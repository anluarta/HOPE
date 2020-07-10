using System;

namespace Hope
{
    abstract class AbsCliente : Contrato.ICliente
    {
        internal Entidade.ICliente[] _DataResultado;
        internal string MsgResult;
        internal Entidade.Cliente _SetEntidade;
        internal Entidade.Cliente _FocusEntidade;
        public AbsCliente()
        {
            _SetEntidade = new Entidade.Cliente();
        }
        internal abstract bool GravarNovoRegistro_Insert();
        internal abstract bool GravarAlteracaoRegistro_Update();
        internal void Clear()
        {
            _DataResultado = null;
            _SetEntidade = new Entidade.Cliente();
            _FocusEntidade = null;
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
        private bool FormataLocalConsulta(string _recepto, out ListEnum.ListaColunaCliente listaColuna)
        {
            if (_recepto.Contains(ListEnum.ListaColunaCliente.ID_CLiente.ToString()))
            {
                listaColuna = ListEnum.ListaColunaCliente.ID_CLiente;
                return true;
            }
            else if (_recepto.Contains(ListEnum.ListaColunaCliente.Cpf_Cnpj.ToString()))
            {
                listaColuna = ListEnum.ListaColunaCliente.Cpf_Cnpj;
                return true;
            }
            else if (_recepto.Contains(ListEnum.ListaColunaCliente.NomeCompleto_Razao.ToString()))
            {
                listaColuna = ListEnum.ListaColunaCliente.NomeCompleto_Razao;
                return true;
            }
            else
            {
                listaColuna = ListEnum.ListaColunaCliente.ID_CLiente;
                return false;
            }
            throw new Exception();
        }
        internal abstract bool SelectAll();
        Entidade.ICliente[] Contrato.ICliente.DataResultado { get =>_DataResultado ; }
        string Contrato.ICliente.StrMsgResultado { get => MsgResult; set => MsgResult=value; }

        Entidade.ICliente Contrato.ICliente.FocusEntidade => _FocusEntidade;

        bool Contrato.ICliente.FocusRegistro(object _Selecionado)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection rowCollection = _Selecionado as System.Windows.Forms.DataGridViewSelectedRowCollection;
            _FocusEntidade = new Entidade.Cliente()
            {
                Id_Cliente = rowCollection[0].Cells[0].Value.ToString(),
                Cpf_Cnpj = rowCollection[0].Cells[1].Value.ToString(),
                NomeCompleto_Razao = rowCollection[0].Cells[2].Value.ToString(),
                Tipo = rowCollection[0].Cells[3].Value.ToString(),
                Fornecedor = (bool)rowCollection[0].Cells[4].Value
            };
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.GravaAlteracao()
        {
            return GravarAlteracaoRegistro_Update();
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.GravarRegistro()
        {
            return GravarNovoRegistro_Insert();
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Localizar(string _operacao, string _local, string _orden, int _limit, string _termo)
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
            ListEnum.ListaColunaCliente listaColuna;
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
                    case ListEnum.ListaColunaCliente.ID_CLiente:
                        break;
                    case ListEnum.ListaColunaCliente.Cpf_Cnpj:
                        break;
                    case ListEnum.ListaColunaCliente.NomeCompleto_Razao:
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
                MsgResult = "Erro AbsCliente.Localizar";
                return false;
            }

            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Apelido_Fantasia(string _Valor)
        {
            _SetEntidade.Apelido_Fantasia = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Bairro(string _Valor)
        {
            _SetEntidade.Bairro = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Cep(string _Valor)
        {
            _SetEntidade.Cep = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Conta_Cliente(bool _Valor)
        {
            _SetEntidade.Conta_Cliente = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Cpf_Cnpj(string _Valor)
        {
            _SetEntidade.Cpf_Cnpj = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_DiaVencimento(string _Valor)
        {
            _SetEntidade.DiaVencimento = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Email(string _Valor)
        {
            _SetEntidade.Email = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Estado(string _Valor)
        {
            _SetEntidade.Estado = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Fornecedor(bool _Valor)
        {
            _SetEntidade.Fornecedor = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Limite_Cupom(string _Valor)
        {
            _SetEntidade.Limite_Cupom = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Limite_Mensal(string _Valor)
        {
            _SetEntidade.Limite_Mensal = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Logradouro(string _Valor)
        {
            _SetEntidade.Logradouro = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Municipio(string _Valor)
        {
            _SetEntidade.Municipio = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_NomeCompleto_Razao(string _Valor)
        {
            _SetEntidade.NomeCompleto_Razao = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Observacao(string _Valor)
        {
            _SetEntidade.Observacao = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_semanaVencimento(string _Valor)
        {
            _SetEntidade.semanaVencimento = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Telefone_1(string _Valor)
        {
            _SetEntidade.Telefone_1 = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Telefone_2(string _Valor)
        {
            _SetEntidade.Telefone_2 = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_Tipo(string _Valor)
        {
            _SetEntidade.Tipo = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool Contrato.ICliente.Set_TipoVemcimento(string _Valor)
        {
            _SetEntidade.TipoVemcimento = _Valor;
            return true;
            throw new NotImplementedException();
        }

        internal static class ListMsg
        {

            public const string msg001 = "Lista REgistro vazio";
            public const string msg002 = "Registro SAlvo";
        }
    }
}
