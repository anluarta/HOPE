
using Hope.Contrato;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    abstract class AbsUsuario : IUsuario
    {
        internal Entidade.Usuario _SetEntidade;
        internal Entidade.Usuario _FocusEntidade;
        internal string MsgResult { get; set; }
        internal string StrfilterExpression;
        public AbsUsuario()
        {
            _SetEntidade = new Entidade.Usuario();
            _FocusEntidade = new Entidade.Usuario();
        }
        virtual internal bool Nome_Usuario(string _usuarionome)
        {
            bool v = false;
            try
            {
                v = decimal.TryParse(_usuarionome, out decimal n);
            }
            finally
            {

            }
            if (v)
            {
                MsgResult = ListMsg.msg001;
                v = false;
            }
            else if (string.IsNullOrEmpty(_usuarionome))
            {
                MsgResult = ListMsg.msg002;
                v = false;
            }
            else if (string.IsNullOrWhiteSpace(_usuarionome))
            {
                MsgResult = ListMsg.msg003;
                v = false;
            }
            else if (_usuarionome.Length <= 3)
            {
                MsgResult = ListMsg.msg004;
                v = false;
            }
            else if (_usuarionome.Length >= 20)
            {
                MsgResult = ListMsg.msg005;
                v = false;
            }
            else
            {

                v = true;
            }
            return v;

        }
        virtual internal bool Email(string valor)
        {
            return true;
            throw new Exception();
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
        private bool FormataLocalConsulta(string _recepto, out ListEnum.ListaColunaUsuario listaColuna)
        {
            if (_recepto.Contains(ListEnum.ListaColunaUsuario.ID_Usuario.ToString()))
            {
                listaColuna = ListEnum.ListaColunaUsuario.ID_Usuario;
                return true;
            }
            else if (_recepto.Contains(ListEnum.ListaColunaUsuario.Nome_Completo.ToString()))
            {
                listaColuna = ListEnum.ListaColunaUsuario.Nome_Completo;
                return true;
            }
            else if (_recepto.Contains(ListEnum.ListaColunaUsuario.Usuario_Nome.ToString()))
            {
                listaColuna = ListEnum.ListaColunaUsuario.Usuario_Nome;
                return true;
            }
            else
            {
                listaColuna = ListEnum.ListaColunaUsuario.ID_Usuario;
                return false;
            }
            throw new Exception();
        }

        public  bool GravarNovo()
        {
            if (_SetEntidade.V_Senha & _SetEntidade.V_Email & _SetEntidade.V_NomeCompleto & _SetEntidade.V_UsuarioNome)
            {

                return GravarNovoRegistro_Insert();
            }
            else
            {
                MsgResult = "Erro gravar registro";
                return false;
            }
            throw new NotImplementedException();
        }
        internal void Clear()
        {
            _SetEntidade = null;
            _FocusEntidade = null;
            _SetEntidade = new Entidade.Usuario();
            _FocusEntidade = new Entidade.Usuario();
        }
        internal abstract bool SelectAll();
        internal abstract bool GravarNovoRegistro_Insert();
        internal abstract bool GravaAlteracaoRegistro_Update();


        #region Contrato
        internal Entidade.IUsuario[] _DadoResultado { get; set; }
        string IUsuario.StrMsgResult { get => MsgResult; set => MsgResult = value; }
        Entidade.IUsuario[] IUsuario.DadoResultado { get => _DadoResultado; set => _DadoResultado = value; }
        Entidade.IUsuario IUsuario.FocusEntidade { get => _FocusEntidade; }
        bool IUsuario.Localizar(string _operacao, string _local, string _orden, int _limit, string _termo)
        {
            if (_operacao==null)
            {
                _operacao = string.Empty;
            } if (_local == null)
            {
                _local = string.Empty;
            } if (_orden == null)
            {
                _orden = string.Empty;
            } if (_termo == null)
            {
                _termo = string.Empty;
            }
            ListEnum.ListaOrdena listaOrdena;
            ListEnum.ListaOperacaoConsulta operacaoConsulta;
            ListEnum.ListaColunaUsuario listaColuna;
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
                    case ListEnum.ListaColunaUsuario.ID_Usuario:
                        break;
                    case ListEnum.ListaColunaUsuario.Usuario_Nome:
                        break;
                    case ListEnum.ListaColunaUsuario.Nome_Completo:
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
        bool IUsuario.Set_NomeCompleto(string _nomecompleto)
        {
            if (string.IsNullOrEmpty(_nomecompleto))
            {
                MsgResult = ListMsg.msg011;
                return false;
            }
            else if (string.IsNullOrWhiteSpace(_nomecompleto))
            {
                MsgResult = ListMsg.msg012;
                return false;

            }
            else if (_nomecompleto.Length <= 10)
            {
                MsgResult = ListMsg.msg013;
                return false;

            }
            else if (_nomecompleto.Length >= 100)
            {
                MsgResult = ListMsg.msg014;
                return false;

            }
            else
            {
                _SetEntidade.Nome_Completo = _nomecompleto;
                _SetEntidade.V_NomeCompleto = true;
                return true;
            }
            throw new NotImplementedException();
        }
        bool IUsuario.Set_Email(string valor)
        {
            return Email(valor);
            throw new NotImplementedException();
        }
        bool IUsuario.Set_Senha(string _senha)
        {
            if (string.IsNullOrEmpty(_senha))
            {
                MsgResult = ListMsg.msg007;
                return false;

            }
            else if (string.IsNullOrWhiteSpace(_senha))
            {
                MsgResult = ListMsg.msg008;
                return false;

            }
            else if (_senha.Length <= 5)
            {
                MsgResult = ListMsg.msg009;
                return false;

            }
            else if (_senha.Length >= 30)
            {
                MsgResult = ListMsg.msg010;
                return false;

            }
            else
            {
                _SetEntidade.Senha = _senha;
                _SetEntidade.V_Senha = true;
                return true;
            }
            throw new NotImplementedException();
        }
        bool IUsuario.Set_NomeUsuario(string valor)
        {
            return Nome_Usuario(valor);
            throw new NotImplementedException();
        }
        bool IUsuario.FocusRegistro(object _Selecionado)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection rowCollection = _Selecionado as System.Windows.Forms.DataGridViewSelectedRowCollection;
            _FocusEntidade = new Entidade.Usuario()
            {
                ID_Usuario = rowCollection[0].Cells[0].Value.ToString(),
                Usuario_Nome = rowCollection[0].Cells[1].Value.ToString(),
                Senha = rowCollection[0].Cells[2].Value.ToString(),
                Nome_Completo = rowCollection[0].Cells[3].Value.ToString(),
                Email = rowCollection[0].Cells[4].Value.ToString()
            };
            return true;
            throw new NotImplementedException();
        }

        public bool GravaAlteracao()
        {
            if (_SetEntidade.V_Senha & _SetEntidade.V_Email & _SetEntidade.V_NomeCompleto & _SetEntidade.V_UsuarioNome)
            {
                return GravaAlteracaoRegistro_Update();
            }
            else
            {
                MsgResult = "Erro gravar alteracao registro";
                return false;
            }
            throw new NotImplementedException();
        }
        #endregion

        internal static class ListMsg
        {
            public const string msg001 = "Usuario Nome dever ter letra.";
            public const string msg002 = "Usuario Nome Nullo";
            public const string msg003 = "Usuario Nome Vazio";
            public const string msg004 = "Usuario Nome e muito curto <=3";
            public const string msg005 = "Usuario Nome muito longo >=20";
            public const string msg006 = "Usuario Nome Ja Registrado";
            public const string msg007 = "Usuario Senha Nullo";
            public const string msg008 = "Usuario Senha Vazio";
            public const string msg009 = "Usuario Senha muito curto <=5";
            public const string msg010 = "Usuario Senha muito longo >=30";
            public const string msg011 = "Usuario Nome Completo nullo";
            public const string msg012 = "Usuario Nome Completo Vazio";
            public const string msg013 = "Usuario Nome Completo muito curto <=30";
            public const string msg014 = "Ususario Nome Completo muito longo >=100";
            public const string msg015 = "Registro salvo \n valor \n ID_USUario={0} Usuario_Nome={1} Senha={2} Nome_Completo={3}";
            public const string msg016 = "Lista usuario vazio";
        }
    }

}
