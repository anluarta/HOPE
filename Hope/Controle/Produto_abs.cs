
using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Produto_abs : Contrato.IProduto_c
    {
        internal List<Produto_Ent_abs> ListaResultado;
       internal Controle.Produto_Ent_abs _FocusRegistro;
       internal Controle.Produto_Ent_abs _NovoRegistro;
        internal abstract bool UpdateRegistro();
        internal abstract bool InsertRegistro();
        internal abstract bool Select_All_From();
        IInformacao_c IProduto_c.Informacao => Hope.informacao;

        IProduto_Ent_c IProduto_c.FocusEntidade => _FocusRegistro;
        bool IProduto_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out IProduto_Ent_c[] ListaRegistro)
        {
            throw new NotImplementedException();
        }

        bool IProduto_c.SelecionaRegistro(object _Selecionado)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection rowCollection = _Selecionado as System.Windows.Forms.DataGridViewSelectedRowCollection;
            _FocusRegistro = new Beta.Produto_Ent_b()
            {
                _ID_Produto = rowCollection[0].Cells[0].Value.ToString(),
                _EAN = rowCollection[0].Cells[1].Value.ToString(),
                _Descricao = rowCollection[0].Cells[2].Value.ToString(),
                _Unidade = rowCollection[0].Cells[3].Value.ToString(),
                _Custo = rowCollection[0].Cells[4].Value.ToString(),
                _Venda = rowCollection[0].Cells[5].Value.ToString()
            };
            return true;
        }

        bool IProduto_c.NovoRegistro(out IProduto_Ent_c _produto)
        {
            _NovoRegistro.Clea();
            _produto = _NovoRegistro;
            return true;
            throw new NotImplementedException();
        }

        bool IProduto_c.GravarRegistro(IProduto_Ent_c _produto)
        {
            _NovoRegistro = _produto as Produto_Ent_abs;
            return InsertRegistro();
            throw new NotImplementedException();
        }

        void IProduto_c.AlteraRegistro(out IProduto_Ent_c _produto)
        {
            throw new NotImplementedException();
        }

        bool IProduto_c.GravaAlteracao(IProduto_Ent_c _produto)
        {
            throw new NotImplementedException();
        }
        //bool Contrato.IProduto_c.FocusRegistro(object _Selecionado)
        //{
        //   
        //    throw new NotImplementedException();
        //}

        //private bool FormataOrden(string _recptor, out ListEnum.OrderConsulta listaOrdena)
        //{
        //    if (_recptor.Contains(ListEnum.OrderConsulta.Ascedente.ToString()))
        //    {
        //        listaOrdena = ListEnum.OrderConsulta.Ascedente;
        //        return true;
        //    }
        //    else
        //    if (_recptor.Contains(ListEnum.OrderConsulta.Descedente.ToString()))
        //    {
        //        listaOrdena = ListEnum.OrderConsulta.Descedente;
        //        return true;
        //    }
        //    else
        //    {
        //        listaOrdena = ListEnum.OrderConsulta.Ascedente;
        //        return false;
        //    }
        //    throw new Exception();
        //}
        //private bool FormataOperacaoConsulta(string _receptor, out ListEnum.ComandoConsulta listaOperacao)
        //{
        //    if (_receptor.Contains(ListEnum.ComandoConsulta.Selec_All_From.ToString()))
        //    {
        //        listaOperacao = ListEnum.ComandoConsulta.Selec_All_From;
        //        return true;
        //    }

        //    else
        //    {
        //        listaOperacao = ListEnum.ComandoConsulta.Selec_All_From;
        //        return false;
        //    }
        //    throw new Exception();
        //}
        //private bool FormataLocalConsulta(string _recepto, out ListEnum.ColunaConsultaProduto listaColuna)
        //{
        //    if (_recepto.Contains(ListEnum.ColunaConsultaProduto.ID_Produto.ToString()))
        //    {
        //        listaColuna = ListEnum.ColunaConsultaProduto.ID_Produto;
        //        return true;
        //    }
        //    else if (_recepto.Contains(ListEnum.ColunaConsultaProduto.EAN.ToString()))
        //    {
        //        listaColuna = ListEnum.ColunaConsultaProduto.EAN;
        //        return true;
        //    }
        //    else if (_recepto.Contains(ListEnum.ColunaConsultaProduto.Descricao.ToString()))
        //    {
        //        listaColuna = ListEnum.ColunaConsultaProduto.Descricao;
        //        return true;
        //    }
        //    else
        //    {
        //        listaColuna = ListEnum.ColunaConsultaProduto.ID_Produto;
        //        return false;
        //    }
        //    throw new Exception();
        //}
        //bool Contrato.IProduto_c.Localizar(string _operacao, string _local, string _orden, int _limit, string _termo)
        //{
        //    if (_operacao == null)
        //    {
        //        _operacao = string.Empty;
        //    }
        //    if (_local == null)
        //    {
        //        _local = string.Empty;
        //    }
        //    if (_orden == null)
        //    {
        //        _orden = string.Empty;
        //    }
        //    if (_termo == null)
        //    {
        //        _termo = string.Empty;
        //    }
        //    ListEnum.OrderConsulta listaOrdena;
        //    ListEnum.ComandoConsulta operacaoConsulta;
        //    ListEnum.ColunaConsultaProduto listaColuna;
        //    bool orden = FormataOrden(_orden, out listaOrdena);
        //    bool operacao = FormataOperacaoConsulta(_operacao, out operacaoConsulta);
        //    bool local = FormataLocalConsulta(_local, out listaColuna);
        //    if (orden & operacao & local)
        //    {
        //        switch (operacaoConsulta)
        //        {
        //            case ListEnum.ComandoConsulta.Selec_All_From:
        //                return SelectAll();
        //                break;
        //            case ListEnum.ComandoConsulta.Distinto:
        //                break;
        //            case ListEnum.ComandoConsulta.Equal:
        //                break;
        //            default:
        //                break;
        //        }
        //        switch (listaColuna)
        //        {
        //            case ListEnum.ColunaConsultaProduto.ID_Produto:
        //                break;
        //            case ListEnum.ColunaConsultaProduto.EAN:
        //                break;
        //            case ListEnum.ColunaConsultaProduto.Descricao:
        //                break;
        //            default:
        //                break;
        //        }
        //        switch (listaOrdena)
        //        {
        //            case ListEnum.OrderConsulta.Ascedente:
        //                break;
        //            case ListEnum.OrderConsulta.Descedente:
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        MsgResult = "Erro AbsUsuario.Localizar";
        //        return false;
        //    }

        //    throw new Exception();
        //}



        internal static class ListMsg
        {
            public const string msg001 = "Registro salvo";
            public const string msg002 = "Lista registro vazio";
        }
    }


}
