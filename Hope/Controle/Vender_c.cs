using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Vender_c : IVender
    {
        internal List<string> Noticia;
        internal Consulta_c Consulta;
        protected abstract bool Insert_New_Row(string Id_caixa, out Dictionary<int, object> keyValuesData);
        protected abstract bool Update_Row(Dictionary<int, object> keyValueData);
        protected abstract bool Deletar_Row(Dictionary<int, object> keyValueData);
        protected abstract bool Select_All_From(out IVender_e[] vender_s);
        IConsulta IVender.Consulta()
        {
            return Consulta;
        }
        bool IVender.Continuar_Registro(object current, out IVender_e vender_)
        {
            if (current != null)
            {
                if (current is IVender_e)
                {
                    vender_ = (IVender_e)current;
                    if (vender_.Get_Finish_Time == Vender_e._ValuaBaseFinishTime)
                    {

                        return true;
                    }
                    else
                    {
                        Noticia.Add("Erro Vender_c Continuar_Registro Finish Time modificado");
                        return false;
                    }
                }
                else
                {
                    Noticia.Add("Erro Vender_c Select valor current nao e IVender_e");
                    vender_ = null;
                    return false;
                }
            }
            else
            {
                Noticia.Add("Erro Valor current nullo");
                vender_ = null;
                return false;
            }
        }
        bool IVender.Select(object current, out IVender_e vender_)
        {
            if (current != null)
            {
                if (current is IVender_e)
                {
                    vender_ = (IVender_e)current;
                    return true;
                }
                else
                {
                    Noticia.Add("Erro Vender_c Select valor current nao e IVender_e");
                    vender_ = null;
                    return false;
                }
            }
            else
            {
                Noticia.Add("Erro Valor current nullo");
                vender_ = null;
                return false;
            }
        }

        bool IVender.Fill(IConsulta consulta, out IVender_e[] vender_s)
        {
            if (consulta != null)
            {
                switch (consulta.Comando)
                {
                    case Enums.Consulta_u.Comando.Select_All_From:
                        if (Select_All_From(out IVender_e[] result))
                        {
                            vender_s = result;
                            return true;
                        }
                        else
                        {
                            vender_s = result;
                            return false;
                        }
                        break;
                    default:
                        Noticia.Add("Erro IConsulta comando nao existe");
                        vender_s = null;
                        return false;
                }
            }
            else
            {
                Noticia.Add("Erro IConsulta Nullo");
                vender_s = null;
                return false;
            }
        }
        bool IVender.Gravar(IVender_e vender)
        {
            if (vender != null)
            {
                Vender_e _E = (Vender_e)vender;
                switch (_E._Posicao)
                {
                    case Vender_e.ListPosicao.Iniciado:
                        _E._Posicao = Vender_e.ListPosicao.Aberto;
                        goto case Vender_e.ListPosicao.Aberto;
                        break;
                    case Vender_e.ListPosicao.Aberto:
                        if (_E.Dispariedade())
                        {
                            if (Update_Row(_E.GetKeyValuesData()))
                            {
                                return true;
                            }
                            else
                            {
                                Noticia.Add("Erro ao atualizar linha do banco de dados");
                                return false;
                            }
                        }
                        else
                        {
                            Noticia.Add("Nao a diferenca a ser salva ");
                            return false;
                        }
                        break;
                    case Vender_e.ListPosicao.Espera:
                        return false;

                        break;
                    case Vender_e.ListPosicao.Pago:
                        return false;

                        break;
                    case Vender_e.ListPosicao.Finalizado:
                        if (Update_Row(_E.GetKeyValuesData()))
                        {
                            return true;
                        }
                        else
                        {
                            Noticia.Add("Erro ao atualizar linha do banco de dados");
                            return false;
                        }

                        break;
                    case Vender_e.ListPosicao.Aborta:
                        if (Deletar_Row(_E.GetKeyValuesData()))
                        {
                            return true;
                        }
                        else
                        {
                            Noticia.Add("Erro ao atualizar linha do banco de dados");
                            return false;
                        }

                        break;
                    case Vender_e.ListPosicao.Devolucao:

                        if (Update_Row(_E.GetKeyValuesData()))
                        {
                            return true;
                        }
                        else
                        {
                            Noticia.Add("Erro ao atualizar linha do banco de dados");
                            return false;
                        }

                        break;
                    default:
                        return false;

                        break;
                }

            }
            else
            {
                Noticia.Add("Erro IVender_e nullo");
                return false;
            }
        }
        string IVender.Notificar()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }
        bool IVender.Novo(ICaixa_e caixaOperacao, out IVender_e vender_)
        {
            if (Hope.Hope_static.Autenticacao.Autenticado)
            {
                if (caixaOperacao != null)
                {
                    if (DateTime.Parse(caixaOperacao.Get_finish_DateTime) == Caixa_e._ValueFinisTime)
                    {
                        if (Insert_New_Row(caixaOperacao.Get_ID, out Dictionary<int, object> result))
                        {
                            vender_ = new Vender_e
                                (
                                index: result[Vender_e.Key_Index],
                                id_caixa: result[Vender_e.Key_ID_Caixa],
                                start_time: result[Vender_e.Key_Start_Time],
                                finish_time: result[Vender_e.Key_Finish_Time],
                                posicao: result[Vender_e.Key_Posicao],
                                colaborador: result[Vender_e.Key_Colaborado],
                                item_s: result[Vender_e.Key_Item_s],
                                troco: result[Vender_e.Key_Troco],
                                recebido: result[Vender_e.Key_Total_Recebido],
                                total_venda: result[Vender_e.Key_Total_Venda],
                                desconto: result[Vender_e.Key_Desconto],
                                pagamento: result[Vender_e.Key_Pagamento]
                                );
                            return true;
                        }
                        else
                        {
                            vender_ = null;
                            return false;
                        }
                    }
                    else
                    {
                        Noticia.Add("Entidade ICaixa_e valor finish_DateTime alterado");
                        vender_ = null;
                        return false;
                    }
                }
                else
                {
                    Noticia.Add("Entidade ICaixa_e valor Nullo");
                    vender_ = null;
                    return false;
                }
            }
            else
            {
                Noticia.Add("Nao esta logado Venda Novo");
                vender_ = null;
                return false;
            }
        }
        bool IVender.Item_Novo(IVender_e entidade, out IItem_e item_)
        {
            if (entidade != null)
            {
                if (entidade.Get_Finish_Time == Vender_e._ValuaBaseFinishTime)
                {
                    item_ = new Item_e(index_item: entidade.Get_Total_Item + 1);
                    return true;
                }
                else
                {
                    Noticia.Add("IVender_e.finish_time ja alterado");
                    item_ = null;
                    return false;
                }
            }
            else
            {
                item_ = null;
                Noticia.Add("IVender_e valor nullo");
                return false;
            }
        }
        bool IVender.Pagar_Novo(IVender_e entidade, out IPagar_e pagar_)
        {
            if (entidade != null)
            {

                if (entidade.Get_Finish_Time == Vender_e._ValuaBaseFinishTime)
                {
                    pagar_ = new Pagar_e(entidade.Get_Valor_Total);
                    return true;
                }
                else
                {
                    Noticia.Add("IVender_e.finish_time ja alterado");
                    pagar_ = null;
                    return false;
                }
            }
            else
            {
                pagar_ = null;
                Noticia.Add("IVender_e valor nullo");
                return false;
            }
        }
        #region PrintDocumento
        public bool VendaComum(/*Entidade.EntEmpresa empresa, Entidade.EntCupom cupom*/)
        {
            //EntCupom = cupom;
            //EntEmpresa = empresa;
            //FontVendaEmpresa = new Font(FontFamily.GenericSerif, 10.0f, FontStyle.Regular);
            //FontVendaCabItem = new Font(FontFamily.GenericSerif, 9.0f, FontStyle.Bold);
            //FontVendaItem = new Font(FontFamily.GenericSerif, 7.0f, FontStyle.Bold);
            //FontEspaco = new Font(FontFamily.GenericSerif, 10.0f, FontStyle.Bold);
            //BrushVendaEmpresa = Brushes.Black;
            //this.Print.BeginPrint += PrintDocument_BeginPrint;
            //this.Print.EndPrint += PrintDocument_EndPrint;
            //this.Print.PrintPage += new PrintPageEventHandler(VendaNaoRegistrada_PrintPage);
            //this.Print.PrinterSettings.PrintFileName = "VendaComun";
            //this.Print.Print();
            //if (InicioImpresao)
            //{
            //    while (!FimImpresao)
            //    {
            //        System.Threading.Thread.Sleep(100);
            //    }
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            throw new Exception();
        }
        private void VendaNaoRegistrada_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Graphics graphics = e.Graphics;
            //graphics.Clear(Color.White);
            //graphics.PageUnit = GraphicsUnit.Pixel;
            //graphics.PageScale = 1.5f;
            //string STRnomeEmpresta = EntEmpresa.Razao;
            //string STRlogradouro = EntEmpresa.Logradouro + " " + EntEmpresa.Numero;

            //string STRtelefone = /*"TEL: " + EntEmpresa.Telefone.Insert(0, "(").Insert(3, ") ") + " FAX: " + EntEmpresa.Fax.Insert(0, "(").Insert(3, ") ")*/"";
            //string STREspaco = "========================================";
            //string STRSubTitulo = "CUPOM NAO FISCAL";
            //// REPETE 2 VEZES O STRespaco
            //// ========================================
            //// ========================================
            //string STRcerquilha = "| #";
            //string STRCod = "| COD";
            //string STRProduto = "| PRODUTO";
            //string STRVlr = "VLR";
            //string STRQtd = "| QTD";
            //string STRTotal = "| TOTAL |";
            //// ========================================
            //// lista de item montado pelo foreach
            //// ========================================
            //string STRTituloTotalPedido = "| VALOR TOTAL DO PEDIDO:";
            //// ========================================
            //string STRObg = "****OBRIGADO E VOLTE SEMPRE****";
            //// paramentros linha X
            //float mgEspacoX = 1.0f;
            //float mgNomeEmpresaX = 290.0f;
            //float logradouroX = 10.0f;
            //float TelefoneX = 10.0f;
            //float mgSubTituloX = 290.0f;
            //float cerquilhaX = 8.0f;
            //float codX = 90.0f;
            //float produtoX = 260.0f;
            //float vlrX = 650.0f;
            //float qtdX = 770.0f;
            //float totalX = 920.0f;
            //float TituloTotaX = 10.0f;
            //float ValorTotalX = 900.0f;
            //float obrigadoX = 200.0f;
            //// paramentros linha Y
            //float nomeempresaY = 5.0f;
            //float logradouroY = 70.0f;
            //float TelefoneY = 130.0f;
            //float espaco1Y = 190.0f;
            //float SubtituloY = 250.0f;
            //float espaco2Y = 290.0f;
            //float espaco3Y = 340.0f;
            //float cerquilhaY = 400.0f;
            //float codY = 400.0f;
            //float produtoY = 400.0f;
            //float vlrY = 400.0f;
            //float qtdY = 400.0f;
            //float totalY = 400.0f;
            //float espaco4Y = 460.0f;
            //float ItemY = 530.0f;
            //PointF nomeempresaF = new PointF(mgNomeEmpresaX, nomeempresaY);
            //PointF logradouroF = new PointF(logradouroX, logradouroY);
            //PointF TelefoneF = new PointF(TelefoneX, TelefoneY);
            //PointF Espaco1F = new PointF(mgEspacoX, espaco1Y);
            //PointF subtituloF = new PointF(mgSubTituloX, SubtituloY);
            //PointF Espaco2F = new PointF(mgEspacoX, espaco2Y);
            //PointF Espaco3F = new PointF(mgEspacoX, espaco3Y);
            //PointF cerquilhaF = new PointF(cerquilhaX, cerquilhaY);
            //PointF codF = new PointF(codX, codY);
            //PointF produtoF = new PointF(produtoX, produtoY);
            //PointF vlrF = new PointF(vlrX, vlrY);
            //PointF qtdF = new PointF(qtdX, qtdY);
            //PointF totalF = new PointF(totalX, totalY);
            //PointF Espaco4F = new PointF(mgEspacoX, espaco4Y);

            //PointF cerItemF;
            //PointF codItemF;
            //PointF prodItemF;
            //PointF vlrItemF;
            //PointF qtdItemF;
            //PointF totalItemF;

            //PointF Espaco5F;
            //PointF TituloTotalF;
            //PointF ValorTotalF;
            //PointF Espaco6F;
            //PointF ObrigadoF;

            //graphics.DrawString(STRnomeEmpresta, FontVendaEmpresa, BrushVendaEmpresa, nomeempresaF);
            //graphics.DrawString(STRlogradouro, FontVendaEmpresa, BrushVendaEmpresa, logradouroF);
            //graphics.DrawString(STRtelefone, FontVendaEmpresa, BrushVendaEmpresa, TelefoneF);
            //graphics.DrawString(STREspaco, FontEspaco, BrushVendaEmpresa, Espaco1F);
            //graphics.DrawString(STRSubTitulo, FontVendaEmpresa, BrushVendaEmpresa, subtituloF);
            //graphics.DrawString(STREspaco, FontEspaco, BrushVendaEmpresa, Espaco2F);
            //graphics.DrawString(STREspaco, FontEspaco, BrushVendaEmpresa, Espaco3F);
            //graphics.DrawString(STRcerquilha, FontVendaCabItem, BrushVendaEmpresa, cerquilhaF);
            //graphics.DrawString(STRCod, FontVendaCabItem, BrushVendaEmpresa, codF);
            //graphics.DrawString(STRProduto, FontVendaCabItem, BrushVendaEmpresa, produtoF);
            //graphics.DrawString(STRVlr, FontVendaCabItem, BrushVendaEmpresa, vlrF);
            //graphics.DrawString(STRQtd, FontVendaCabItem, BrushVendaEmpresa, qtdF);
            //graphics.DrawString(STRTotal, FontVendaCabItem, BrushVendaEmpresa, totalF);
            //graphics.DrawString(STREspaco, FontEspaco, BrushVendaEmpresa, Espaco4F);
            //int NumeroIndexProduto = 0;
            //foreach (Entidade.EntProduto item in EntCupom.Produtos)
            //{
            //    cerItemF = new PointF(cerquilhaX, ItemY);
            //    codItemF = new PointF(codX + 5.0f, ItemY);
            //    prodItemF = new PointF(produtoX, ItemY);
            //    vlrItemF = new PointF(vlrX, ItemY);
            //    qtdItemF = new PointF(qtdX, ItemY);
            //    totalItemF = new PointF(totalX + 30.0f, ItemY);
            //    NumeroIndexProduto++;
            //    string numite = NumeroIndexProduto.ToString();
            //    switch (numite.Length)
            //    {
            //        case 1:
            //            numite = "|00" + numite;
            //            break;
            //        case 2:
            //            numite = "|0" + numite;
            //            break;
            //        case 3:
            //            numite = "|" + numite;
            //            break;
            //        default:
            //            numite = "|" + numite;
            //            break;
            //    }
            //    graphics.DrawString(numite, FontVendaItem, BrushVendaEmpresa, cerItemF);
            //    graphics.DrawString(item.Codigo, FontVendaItem, BrushVendaEmpresa, codItemF);
            //    string descricao = string.Empty;
            //    if (item.Descricao.Length > 10)
            //    {
            //        descricao = item.Descricao.Substring(0, 10);
            //    }
            //    else
            //    {
            //        descricao = item.Descricao;
            //    }
            //    graphics.DrawString(descricao, FontVendaItem, BrushVendaEmpresa, prodItemF);
            //    graphics.DrawString(item.ValorUnidade.ToString("f2"), FontVendaItem, BrushVendaEmpresa, vlrItemF);
            //    graphics.DrawString(item.Quantidade.ToString("f4"), FontVendaItem, BrushVendaEmpresa, qtdItemF);
            //    graphics.DrawString(item.SubValor.ToString("f2"), FontVendaItem, BrushVendaEmpresa, totalItemF);
            //    ItemY += 50.0f;
            //}
            //float espaco5Y = ItemY + 20.0f;
            //Espaco5F = new PointF(mgEspacoX, espaco5Y);
            //graphics.DrawString(STREspaco, FontEspaco, BrushVendaEmpresa, Espaco5F);

            //float TituloTotaValorlY = espaco5Y + 50.0F;
            //TituloTotalF = new PointF(TituloTotaX, TituloTotaValorlY);
            //graphics.DrawString(STRTituloTotalPedido, FontVendaCabItem, BrushVendaEmpresa, TituloTotalF);
            //ValorTotalF = new PointF(ValorTotalX, TituloTotaValorlY);
            //graphics.DrawString(EntCupom.Total, FontVendaCabItem, BrushVendaEmpresa, ValorTotalF);

            //float espaco6Y = TituloTotaValorlY + 50.0F;
            //Espaco6F = new PointF(mgEspacoX, espaco6Y);
            //graphics.DrawString(STREspaco, FontEspaco, BrushVendaEmpresa, Espaco6F);

            //float obrigadoY = espaco6Y + 100.0f;
            //ObrigadoF = new PointF(obrigadoX, obrigadoY);
            //graphics.DrawString(STRObg, FontVendaItem, BrushVendaEmpresa, ObrigadoF);
            //graphics.Flush();

        }
        bool IVender.Print_Document(IVender_e entidade, out PrintDocument document)
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
