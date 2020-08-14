using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hope.Entidade;
using Hope.Interface;
namespace Hope.Controle
{
    abstract class Caixa_c : ICaixa
    {
        protected List<string> Noticia;
        protected Consulta_c _Consulta;
        protected Suprimento_c _Suprimento;
        protected Sangria_c _Sangria;

        ISuprimento ICaixa.Suprimento => _Suprimento;

        ISangria ICaixa.Sangria => _Sangria;

        protected abstract bool Insert_New_Row(out int Index, out DateTime start);
        protected abstract bool Update_Row(Dictionary<string, string> keyValueData);
        protected abstract bool Select_All_From(out ICaixa_e[] caixa_s);


        bool ICaixa.Gravar(ICaixa_e entidade, out ICaixa_e result)
        {
            if (entidade != null)
            {
                Caixa_e _E = entidade as Caixa_e;
                if (_Suprimento.Gravar(_E.suprimento_s))
                {
                    _E.suprimento_s.Clear();
                    Noticia.AddRange(_Suprimento.Noticia);
                    _Suprimento.Noticia.Clear();
                    Noticia.Add("Dado Value Suprimento Gravado");
                }
                else
                {
                    Noticia.AddRange(_Suprimento.Noticia);
                    Noticia.Add("Dado Value Suprimento nao gravado");
                }
                if (_Sangria.Gravar(_E.sangria_s))
                {
                    _E.sangria_s.Clear();
                    Noticia.AddRange(_Sangria.Noticia);
                    _Sangria.Noticia.Clear();
                    Noticia.Add("Dado Value Sangria Gravado");
                }
                else
                {
                    Noticia.AddRange(_Sangria.Noticia);

                    Noticia.Add("Dado Value Sangria nao Gravado");
                }
                if (_E.Disparidade())
                {
                    if (Update_Row(_E.GetToDataValue()))
                    {
                        result = _E;
                        return true;

                    }
                    else
                    {
                        result = _E;
                        return false;
                    }
                }
                else
                {
                    Noticia.Add("a entidade nao sobreu mudanca no seu estado acao nao realizado");
                    result = _E;
                    return false;
                }
            }
            else
            {
                Noticia.Add("Entidade Nula");
                result = null;
                return false;
            }
        }

        string ICaixa.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }

        ICaixa_e ICaixa.Novo()
        {
            if (Hope_static.Autenticacao.Autenticado)
            {

                Insert_New_Row(out int id, out DateTime start);
                ICaixa_e _E = new Entidade.Caixa_e(id, Hope_static.Autenticacao.Colaborador, start);
                Noticia.Add("Novo caixa criado");
                return _E;
            }
            else
            {
                throw HException.Caixa_he.Erro_0();
            }
        }

        ISangria_e ICaixa.Sangria_Novo(ICaixa_e entidade)
        {
            if (entidade != null)
            {
                if (Hope_static.Autenticacao.Autenticado)
                {
                    Caixa_e caixa_E = entidade as Caixa_e;

                    ISangria_e _E = new Sangria_e(caixaID: caixa_E.ID, colaboraID: caixa_E.Colaborador.Get_ID);

                    return _E;
                }
                else
                {
                    Noticia.Add("Nao esta autenticado para essa acao ");
                    return null;
                }

            }
            else
            {
                Noticia.Add("Sangria entidade nullo");
                return null;
            }
        }

        ICaixa_e ICaixa.Select(object current)
        {
            throw new NotImplementedException();
        }

        ISuprimento_e ICaixa.Suprimento_Novo(ICaixa_e entidade)
        {
            if (entidade != null)
            {
                if (Hope_static.Autenticacao.Autenticado)
                {
                    Caixa_e caixa_E = entidade as Caixa_e;
                    ISuprimento_e suprimento_E = new Suprimento_e(caixaID: caixa_E.ID, colaboraID: caixa_E.Colaborador.Get_ID);

                    return suprimento_E;
                }
                else
                {
                    Noticia.Add("Nao esta autenticado para essa acao ");
                    return null;
                }

            }
            else
            {
                Noticia.Add("Suprimento entidade nullo");
                return null;
            }
        }

        IConsulta ICaixa.Consulta()
        {
            return _Consulta;
        }

        bool ICaixa.Find(IConsulta consulta, out ICaixa_e[] caixa_s)
        {
            switch (consulta.Comando)
            {
                case Enums.Consulta_u.Comando.Select_All_From:
                    if (Select_All_From(out ICaixa_e[] result))
                    {
                        caixa_s = result;
                        return true; ;
                    }
                    else
                    {
                        caixa_s = null;
                        return false;
                    }
                default:
                    caixa_s = null;
                    return false;
            }
        }

        Rectangle marginBounds;
        Rectangle pageBounds;
        PageSettings settings;
        Font FonLeituraxItem;
        Font FonLeituraxCabeca;
        Graphics graphics;
        Font Bold;
        Caixa_e _E;
        bool ICaixa.Print_Document(object current, out PrintDocument document)
        {
            if (current != null)
            {
                _E = current as Caixa_e;
                if (_E.FinishTime== Caixa_e._ValueFinisTime)
                {
                    // leitura X
                    Bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    document = new PrintDocument();
                    settings = new PageSettings();
                    FonLeituraxCabeca = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
                    FonLeituraxItem = new Font(FontFamily.GenericSerif, 11, FontStyle.Regular);
                    graphics = document.PrinterSettings.CreateMeasurementGraphics();

                    settings.PaperSize = CalcArePrint(graphics: ref graphics);
                    document.DefaultPageSettings = settings;

                    document.PrintPage += new PrintPageEventHandler(Leitura_X);
                    return true;

                }
                else
                {
                    // Resumo Caixa Fechado
                    Bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    document = new PrintDocument();
                    settings = new PageSettings();
                    FonLeituraxCabeca = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
                    FonLeituraxItem = new Font(FontFamily.GenericSerif, 11, FontStyle.Regular);
                    graphics = document.PrinterSettings.CreateMeasurementGraphics();

                    settings.PaperSize = CalcArePrint(graphics: ref graphics);
                    document.PrintPage += new PrintPageEventHandler(Remumo_Caixa);
                    return true;

                }
            }
            else
            {
                document = null;
                Noticia.Add("Entidade nula Print_Document");
                return false;
            }
            throw new NotImplementedException();
        }
        private void Leitura_X(object sender, PrintPageEventArgs e)
        {
            graphics = e.Graphics;
            CalcArePrint(ref graphics);
           // graphics.DrawString("Suprimento", Bold, Brushes.Black, 1, 1);

        }
        private void Remumo_Caixa(object sender, PrintPageEventArgs e)
        {
            graphics = e.Graphics;
            CalcArePrint(ref graphics);
           // graphics.DrawString("Suprimento", Bold, Brushes.Black, 1, 1);

        }
        private PaperSize CalcArePrint(ref Graphics graphics)
        {
            graphics.Clear(Color.White);
            graphics.PageUnit = GraphicsUnit.Point;
            graphics.PageScale = 0.17f;

            float margem = 10.0f;
            float MargemValor = 750.0f;
            float linOperador = 100.0f;
            float linData = 200.0f;
            float linHora = 500.0f;
            float lin1 = 600.0f;
            float linAber = 700.0f;
            float linSuprimen = 800.0f;
            float linDinheiro = 900.0f;
            float linCredito = 1000.0f;
            float linDebito = 1100.0f;
            float linAlimenta = 1200.0f;
            float linRefeica = 1300.0f;
            float linLoja = 1400.0f;
            float linChque = 1500.0f;
            float linCarne = 1600.0f;
            float linOutro = 1700.0f;
            float linSangria = 1800.0f;
            float linSangriaDinh = 1900.0f;
            float linSangriaCheque = 2000.0f;
            float linSangriaCratao = 2100.0f;
            float lin2 = 2200.0f;
            float linEntrada = 2300.0f;
            float linSaida = 2400.0f;
            float linFechame = 2500.0f;
            float lincancelad = 2600.0f;
            float interno = 2700.0f;
            PointF cabecalhoF = new PointF(65.0f, 0.0f);
            PointF OperadorF = new PointF(margem, linOperador);
            PointF DataF = new PointF(margem, linData);
            PointF HoraF = new PointF(margem, linHora);
            PointF Linha1F = new PointF(margem, lin1);
            PointF AberF = new PointF(margem, linAber);
            PointF suprimentoF = new PointF(margem, linSuprimen);
            PointF dinheiroF = new PointF(margem, linDinheiro);
            PointF creditoF = new PointF(margem, linCredito);
            PointF debitoF = new PointF(margem, linDebito);
            PointF AlimentacaoF = new PointF(margem, linAlimenta);
            PointF refeicaoF = new PointF(margem, linRefeica);
            PointF LojaF = new PointF(margem, linLoja);
            PointF ChequeavistaF = new PointF(margem, linChque);
            PointF carneF = new PointF(margem, linCarne);
            PointF outrosF = new PointF(margem, linOutro);
            PointF sangriaF = new PointF(margem, linSangria);
            PointF sangriadinheiroF = new PointF(margem, linSangriaDinh);
            PointF sangriachequesF = new PointF(margem, linSangriaCheque);
            PointF sangriacartaoF = new PointF(margem, linSangriaCratao);
            PointF Linha2F = new PointF(margem, lin2);
            PointF entradasF = new PointF(margem, linEntrada);
            PointF saidasF = new PointF(margem, linSaida);
            PointF fechamentoF = new PointF(margem, linFechame);
            PointF canceladosF = new PointF(margem, lincancelad);
            PointF internoF = new PointF(margem, interno);

            PointF OperadorValorF = new PointF(MargemValor, linOperador);
            PointF DataValorF = new PointF(MargemValor, linData);
            PointF HoraValorF = new PointF(MargemValor, linHora);
            PointF AberValorF = new PointF(MargemValor, linAber);
            PointF suprimentoValorF = new PointF(MargemValor, linSuprimen);
            PointF dinheiroValorF = new PointF(MargemValor, linDinheiro);
            PointF creditoValorF = new PointF(MargemValor, linCredito);
            PointF debitoValorF = new PointF(MargemValor, linDebito);
            PointF AlimentacaoValorF = new PointF(MargemValor, linAlimenta);
            PointF refeicaoValorF = new PointF(MargemValor, linRefeica);
            PointF LojaValorF = new PointF(MargemValor, linLoja);
            PointF ChequeavistaValorF = new PointF(MargemValor, linChque);
            PointF carneValorF = new PointF(MargemValor, linCarne);
            PointF outrosValorF = new PointF(MargemValor, linOutro);
            PointF sangriaValorF = new PointF(MargemValor, linSangria);
            PointF sangriadinheiroValorF = new PointF(MargemValor, linSangriaDinh);
            PointF sangriachequesValorF = new PointF(MargemValor, linSangriaCheque);
            PointF sangriacartaoValorF = new PointF(MargemValor, linSangriaCratao);
            PointF entradasValorF = new PointF(MargemValor, linEntrada);
            PointF saidasValorF = new PointF(MargemValor, linSaida);
            PointF fechamentoValorF = new PointF(MargemValor, linFechame);
            PointF canceladosValorF = new PointF(MargemValor, lincancelad);
            PointF internoValorF = new PointF(MargemValor, interno);

            graphics.DrawString("MOVIMENTO LEITURA X", FonLeituraxCabeca, Brushes.Black, cabecalhoF);

            graphics.DrawString("OPERADOR:", FonLeituraxItem, Brushes.Black, OperadorF);
            graphics.DrawString(_E.Colaborador.Get_Nome_Vendedo, FonLeituraxItem, Brushes.Black, OperadorValorF);
            graphics.DrawString("DATA:", FonLeituraxItem, Brushes.Black, DataF);
            graphics.DrawString(_E.StartTime.ToString("dd/MM/yyyy"), FonLeituraxItem, Brushes.Black, DataValorF);
            graphics.DrawString("HORA:", FonLeituraxItem, Brushes.Black, HoraF);
            graphics.DrawString(_E.StartTime.ToString("HH:mm:ss"), FonLeituraxItem, Brushes.Black, HoraValorF);
            graphics.DrawString("--------------------------------------------------", FonLeituraxItem, Brushes.Black, Linha1F);
            //graphics.DrawString("ABER. DE.CAIXA...", FonLeituraxItem, Brushes.Black, AberF);
            //graphics.DrawString(EntLeituraX.Abertura.ToString("f2"), FonLeituraxItem, Brushes.Black, AberValorF);
            graphics.DrawString("SUPRIMENTO...", FonLeituraxItem, Brushes.Black, suprimentoF);
            graphics.DrawString(_E.vSuprimento.ToString("f2"), FonLeituraxItem, Brushes.Black, suprimentoValorF);
            graphics.DrawString("DINHEIRO...", FonLeituraxItem, Brushes.Black, dinheiroF);
            graphics.DrawString(_E.vDinheiro.ToString("f2"), FonLeituraxItem, Brushes.Black, dinheiroValorF);
            graphics.DrawString("CARTAO DE CREDITO...", FonLeituraxItem, Brushes.Black, creditoF);
            graphics.DrawString(_E.vCredito.ToString("f2"), FonLeituraxItem, Brushes.Black, creditoValorF);
            graphics.DrawString("CARTAO DE DEBITO...", FonLeituraxItem, Brushes.Black, debitoF);
            graphics.DrawString(_E.vDebito.ToString("f2"), FonLeituraxItem, Brushes.Black, debitoValorF);
            graphics.DrawString("VALE ALIMENTACAO...", FonLeituraxItem, Brushes.Black, AlimentacaoF);
            graphics.DrawString(_E.vValeAlimentacao.ToString("f2"), FonLeituraxItem, Brushes.Black, AlimentacaoValorF);
            graphics.DrawString("VALE REFEICAO...", FonLeituraxItem, Brushes.Black, refeicaoF);
            graphics.DrawString(_E.vValeRefeicao.ToString("f2"), FonLeituraxItem, Brushes.Black, refeicaoValorF);
            //graphics.DrawString("CREDITO DE LOJA...", FonLeituraxItem, Brushes.Black, LojaF);
            //graphics.DrawString("0,00", FonLeituraxItem, Brushes.Black, LojaValorF);
            graphics.DrawString("CHEQUE A VISTA...", FonLeituraxItem, Brushes.Black, ChequeavistaF);
            graphics.DrawString(_E.vCheque.ToString("f2"), FonLeituraxItem, Brushes.Black, ChequeavistaValorF);
            //graphics.DrawString("CARNE PAGTO...", FonLeituraxItem, Brushes.Black, carneF);
            //graphics.DrawString("0,00", FonLeituraxItem, Brushes.Black, carneValorF);
            graphics.DrawString("OUTROS...", FonLeituraxItem, Brushes.Black, outrosF);
            graphics.DrawString(_E.vOutro.ToString("f2"), FonLeituraxItem, Brushes.Black, outrosValorF);
            graphics.DrawString("SANGRIA...", FonLeituraxItem, Brushes.Black, sangriaF);
            graphics.DrawString(_E.vSangria.ToString("f2"), FonLeituraxItem, Brushes.Black, sangriaValorF);
            //graphics.DrawString("SANGRIA DINHEIRO...", FonLeituraxItem, Brushes.Black, sangriadinheiroF);
            //graphics.DrawString("0,00", FonLeituraxItem, Brushes.Black, sangriadinheiroValorF);
            //graphics.DrawString("SANGRIA CHEQUES...", FonLeituraxItem, Brushes.Black, sangriachequesF);
            //graphics.DrawString("0,00", FonLeituraxItem, Brushes.Black, sangriachequesValorF);
            //graphics.DrawString("SANGRIA CARTAO...", FonLeituraxItem, Brushes.Black, sangriacartaoF);
            //graphics.DrawString("0,00", FonLeituraxItem, Brushes.Black, sangriacartaoValorF);
            graphics.DrawString("--------------------------------------------------", FonLeituraxItem, Brushes.Black, Linha2F);
            graphics.DrawString("TOTAL DE ENTRADA...", FonLeituraxItem, Brushes.Black, entradasF);
            graphics.DrawString(_E.vRecebido.ToString("f2"), FonLeituraxItem, Brushes.Black, entradasValorF);
            graphics.DrawString("TOTAL DE  SAIDAS...", FonLeituraxItem, Brushes.Black, saidasF);
            graphics.DrawString(_E.vSangria.ToString("f2"), FonLeituraxItem, Brushes.Black, saidasValorF);
            //graphics.DrawString("VALOR FECHAMENTO...", FonLeituraxItem, Brushes.Black, fechamentoF);
            //graphics.DrawString(fechamento.ToString("f2"), FonLeituraxItem, Brushes.Black, fechamentoValorF);
            graphics.DrawString("PEDIDOS CANCELADO...", FonLeituraxItem, Brushes.Black, canceladosF);
            graphics.DrawString(_E.vCancelado.ToString("f2"), FonLeituraxItem, Brushes.Black, canceladosValorF);
            graphics.DrawString("Controle Interno...", FonLeituraxItem, Brushes.Black, internoF);
            graphics.DrawString(_E.vInterno.ToString("f2"), FonLeituraxItem, Brushes.Black, internoValorF);
            graphics.Flush();
            return new PaperSize("Custom", (int)graphics.VisibleClipBounds.Width/5, (int)graphics.VisibleClipBounds.Height/5);
        }
    }
}
