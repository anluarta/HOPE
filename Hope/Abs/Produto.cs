
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    abstract class AbsProduto : Contrato.IProduto
    {
        internal string MsgResult;
        internal Entidade.IProduto[] _DataResultado;
        internal Entidade.IProduto _SetEntidade;
        internal Entidade.IProduto _FocusEntidade;
        public AbsProduto()
        {
            _SetEntidade = new Entidade.Produto();
            _FocusEntidade = new Entidade.Produto();
            MsgResult = string.Empty;
        }
        internal void Clear()
        {
            _DataResultado = null;
            _SetEntidade = new Entidade.Produto();
            _FocusEntidade = null;
            MsgResult = string.Empty;
        }
        internal abstract bool Update();
        internal abstract bool Insert();
        internal abstract bool SelectAll();
        Entidade.IProduto[] Contrato.IProduto.DadoResultado { get => _DataResultado; }
        string Contrato.IProduto.StrMsgResultado { get => MsgResult; }

        bool Contrato.IProduto.FocusRegistro(object _Selecionado)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection rowCollection = _Selecionado as System.Windows.Forms.DataGridViewSelectedRowCollection;
            _FocusEntidade = new Entidade.Produto()
            {
                ID_Produto = rowCollection[0].Cells[0].Value.ToString(),
                EAN = rowCollection[0].Cells[1].Value.ToString(),
                Descricao = rowCollection[0].Cells[2].Value.ToString(),
                Unidade = rowCollection[0].Cells[3].Value.ToString(),
                Custo = rowCollection[0].Cells[4].Value.ToString(),
                Venda = rowCollection[0].Cells[5].Value.ToString()
            };
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.IProduto.GravarArteracao()
        {
            return Update();
            throw new NotImplementedException();
        }

        bool Contrato.IProduto.GravarNovo()
        {
            return Insert();
            throw new NotImplementedException();
        }
        private bool FormataOrden(string _recptor, out ListEnum.ListaOrdena listaOrdena)
        {
            if (_recptor.Contains(ListEnum.ListaOrdena.Ascedente.ToString()))
            {
                listaOrdena = ListEnum.ListaOrdena.Ascedente;
                return true;
            }
            else
            if (_recptor.Contains(ListEnum.ListaOrdena.Descedente.ToString()))
            {
                listaOrdena = ListEnum.ListaOrdena.Descedente;
                return true;
            }
            else
            {
                listaOrdena = ListEnum.ListaOrdena.Ascedente;
                return false;
            }
            throw new Exception();
        }
        private bool FormataOperacaoConsulta(string _receptor, out ListEnum.ListaOperacaoConsulta listaOperacao)
        {
            if (_receptor.Contains(ListEnum.ListaOperacaoConsulta.All.ToString()))
            {
                listaOperacao = ListEnum.ListaOperacaoConsulta.All;
                return true;
            }
            else if (_receptor.Contains(ListEnum.ListaOperacaoConsulta.Distinto.ToString()))
            {
                listaOperacao = ListEnum.ListaOperacaoConsulta.Distinto;
                return true;

            }
            else if (_receptor.Contains(ListEnum.ListaOperacaoConsulta.Equal.ToString()))
            {
                listaOperacao = ListEnum.ListaOperacaoConsulta.Equal;
                return true;

            }
            else
            {
                listaOperacao = ListEnum.ListaOperacaoConsulta.All;
                return false;
            }
            throw new Exception();
        }
        private bool FormataLocalConsulta(string _recepto, out ListEnum.ListaColunaProduto listaColuna)
        {
            if (_recepto.Contains(ListEnum.ListaColunaProduto.ID_Produto.ToString()))
            {
                listaColuna = ListEnum.ListaColunaProduto.ID_Produto;
                return true;
            }
            else if (_recepto.Contains(ListEnum.ListaColunaProduto.EAN.ToString()))
            {
                listaColuna = ListEnum.ListaColunaProduto.EAN;
                return true;
            }
            else if (_recepto.Contains(ListEnum.ListaColunaProduto.Descricao.ToString()))
            {
                listaColuna = ListEnum.ListaColunaProduto.Descricao;
                return true;
            }
            else
            {
                listaColuna = ListEnum.ListaColunaProduto.ID_Produto;
                return false;
            }
            throw new Exception();
        }

        bool Contrato.IProduto.Localizar(string _operacao, string _local, string _orden, int _limit, string _termo)
        {
            if (_operacao == null)
            {
                _operacao = string.Empty;
            }
            if (_local == null)
            {
                _local = string.Empty;
            }
            if (_orden == null)
            {
                _orden = string.Empty;
            }
            if (_termo == null)
            {
                _termo = string.Empty;
            }
            ListEnum.ListaOrdena listaOrdena;
            ListEnum.ListaOperacaoConsulta operacaoConsulta;
            ListEnum.ListaColunaProduto listaColuna;
            bool orden = FormataOrden(_orden, out listaOrdena);
            bool operacao = FormataOperacaoConsulta(_operacao, out operacaoConsulta);
            bool local = FormataLocalConsulta(_local, out listaColuna);
            if (orden & operacao & local)
            {
                switch (operacaoConsulta)
                {
                    case ListEnum.ListaOperacaoConsulta.All:
                        return SelectAll();
                        break;
                    case ListEnum.ListaOperacaoConsulta.Distinto:
                        break;
                    case ListEnum.ListaOperacaoConsulta.Equal:
                        break;
                    default:
                        break;
                }
                switch (listaColuna)
                {
                    case ListEnum.ListaColunaProduto.ID_Produto:
                        break;
                    case ListEnum.ListaColunaProduto.EAN:
                        break;
                    case ListEnum.ListaColunaProduto.Descricao:
                        break;
                    default:
                        break;
                }
                switch (listaOrdena)
                {
                    case ListEnum.ListaOrdena.Ascedente:
                        break;
                    case ListEnum.ListaOrdena.Descedente:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MsgResult = "Erro AbsUsuario.Localizar";
                return false;
            }

            throw new Exception();
        }

        bool Contrato.IProduto.Set_Custo(string _valor)
        {
            _SetEntidade.Custo = _valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.IProduto.Set_Descricao(string _valor)
        {
            _SetEntidade.Descricao = _valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.IProduto.Set_EAN(string _valor)
        {
            _SetEntidade.EAN = _valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.IProduto.Set_Unidade(string _valor)
        {
            _SetEntidade.Unidade = _valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.IProduto.Set_Venda(string _valor)
        {
            _SetEntidade.Venda = _valor;
            return true;
            throw new NotImplementedException();
        }

        internal static class ListMsg
        {
            public const string msg001 = "Registro salvo";
            public const string msg002 = "Lista registro vazio";
        }
    }


}
