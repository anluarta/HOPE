
using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Usuario_abs : Contrato.IUsuario_c
    {
        internal List<Controle.Usuario_Ent_abs> ListRegUsuario;
        internal Controle.Usuario_Ent_abs _Logado;
        internal Controle.Usuario_Ent_abs _FocusRegistro;
        internal Controle.Usuario_Ent_abs _AlteraRegistro;
        internal Controle.Usuario_Ent_abs _NovoRegistro;
        internal string _Msg;
        internal abstract bool UpdateRegistro();
        internal abstract bool InsertRegistro();
        internal abstract bool Select_All_From();
        internal abstract bool Login(string user, string senha);
        IUsuario_Ent_c IUsuario_c.FocusEntidade => _FocusRegistro;

        IInformacao_c IUsuario_c.Informacao => Hope.informacao;

        void IUsuario_c.AlteraRegistro(out IUsuario_Ent_c usuario)
        {
            Hope.informacao.Clear();
            _AlteraRegistro.Clea();
            usuario = _AlteraRegistro;
        }

        bool IUsuario_c.Autenticado()
        {
            Hope.informacao.Clear();
            if (_Logado.Autenticado)
            {
                Hope.informacao.Add("000", "esta logado");
                return true;
            }
            else
            {
                Hope.informacao.Add("000", "Nao esta logado");
                return false;
            }
        }

        bool IUsuario_c.GravaAlteracao(IUsuario_Ent_c usuario)
        {
            Hope.informacao.Clear();
            _AlteraRegistro = usuario as Usuario_Ent_abs;
            bool bupdate = UpdateRegistro();
            return bupdate;
        }

        bool IUsuario_c.GravarRegistro(IUsuario_Ent_c usuario)
        {
            Hope.informacao.Clear();
            _NovoRegistro = usuario as Usuario_Ent_abs;
            bool binsert = InsertRegistro();
            return binsert;
        }
        bool IUsuario_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo,  out IUsuario_Ent_c[] ListaRegistro)
        {
            Hope.informacao.Clear();
            bool bFormat = FormataComandoLocalizacao(Comando, Coluna, Orden, out ListEnum.OrderConsulta listaOrdena, out ListEnum.ComandoConsulta operacaoConsulta, out ListEnum.ColunaConsultaUsuario listaColuna);
            if (bFormat)
            {
                switch (operacaoConsulta)
                {
                    case ListEnum.ComandoConsulta.Selec_All_From:
                        bool vselectall = Select_All_From();
                        ListaRegistro = ListRegUsuario.ToArray<Controle.Usuario_Ent_abs>();
                        return vselectall;
                    default:
                        Hope.informacao.Add("000", "Erro Comando Consulta Nao implementado.");

                        ListaRegistro = new IUsuario_Ent_c[0];
                        return false;
                }

            }
            else
            {
                Hope.informacao.Add("000", "Erro AbsUsuario.FormataConsulta");
                ListaRegistro = new IUsuario_Ent_c[0];
                return false;
            }
        }

        bool IUsuario_c.Login(string _UsuarioNome, string _Senha)
        {
            Hope.informacao.Clear();
            return Login(_UsuarioNome, _Senha);
        }

        bool IUsuario_c.NovoRegistro( out IUsuario_Ent_c usuario)
        {
            Hope.informacao.Clear();
            _NovoRegistro.Clea();
            usuario = _NovoRegistro;
            return true;
        }

        void IUsuario_c.Sair()
        {
            Hope.informacao.Clear();
            Hope.informacao.Add("000", "Limpo memoria cache");
            _Logado.Clea();
        }

        bool IUsuario_c.SelecionaRegistro(object _Selecionado)
        {
            Hope.informacao.Clear();
            try
            {
                System.Windows.Forms.DataGridViewRow rowCollection = _Selecionado as System.Windows.Forms.DataGridViewRow;
                _FocusRegistro = new Beta.Usuario_Ent_b()
                {
                    _ID_Usuario = rowCollection.Cells[0].Value.ToString(),
                    _Usuario_Nome = rowCollection.Cells[1].Value.ToString(),
                    _Senha = rowCollection.Cells[2].Value.ToString(),
                    _Nome_Completo = rowCollection.Cells[3].Value.ToString(),
                    _Email = rowCollection.Cells[4].Value.ToString()
                };
                return true;
            }
            catch (Exception e)
            {
                Hope.informacao.Add("000", e.Message);
                return false;
            }
        }
        bool FormataComandoLocalizacao(string _operacao, string _local, string _orden, out ListEnum.OrderConsulta listaOrdena, out ListEnum.ComandoConsulta listaOperacao, out ListEnum.ColunaConsultaUsuario listaColuna)
        {
            listaOrdena = ListEnum.OrderConsulta.Ascedente;
            listaOperacao = ListEnum.ComandoConsulta.Selec_All_From;
            listaColuna = ListEnum.ColunaConsultaUsuario.ID_Usuario;
            if (_operacao == null)
            {
                Hope.informacao.Add("000", "Operacao null");
                return false;
            }
            if (_local == null)
            {
                Hope.informacao.Add("000","Local Null");
                return false;
            }
            if (_orden == null)
            {
                Hope.informacao.Add("000","Orden null");
                return false;
            }
            else
            {

                try
                {
                    if (_operacao.Contains(ListEnum.ComandoConsulta.Selec_All_From.ToString()))
                    {
                        listaOperacao = ListEnum.ComandoConsulta.Selec_All_From;
                    }

                    else if (_local.Contains(ListEnum.ColunaConsultaUsuario.ID_Usuario.ToString()))
                    {
                        listaColuna = ListEnum.ColunaConsultaUsuario.ID_Usuario;
                    }
                    else if (_local.Contains(ListEnum.ColunaConsultaUsuario.Nome_Completo.ToString()))
                    {
                        listaColuna = ListEnum.ColunaConsultaUsuario.Nome_Completo;
                    }
                    else if (_local.Contains(ListEnum.ColunaConsultaUsuario.Usuario_Nome.ToString()))
                    {
                        listaColuna = ListEnum.ColunaConsultaUsuario.Usuario_Nome;
                    }
                    else
                    if (_orden.Contains(ListEnum.OrderConsulta.Ascedente.ToString()))
                    {
                        listaOrdena = ListEnum.OrderConsulta.Ascedente;
                    }
                    else if (_orden.Contains(ListEnum.OrderConsulta.Descedente.ToString()))
                    {
                        listaOrdena = ListEnum.OrderConsulta.Descedente;
                    }

                    return true;
                }
                catch
                {
                    Hope.informacao.Add("000", "Erro no FormataComandoLocalizacao");
                    return false;
                }
            }

        }
        //virtual internal bool Nome_Usuario(string _usuarionome)
        //{
        //    bool v = false;
        //    try
        //    {
        //        v = decimal.TryParse(_usuarionome, out decimal n);
        //    }
        //    finally
        //    {

        //    }
        //    if (v)
        //    {
        //        MsgResult = ListMsg.msg001;
        //        v = false;
        //    }
        //    else if (string.IsNullOrEmpty(_usuarionome))
        //    {
        //        MsgResult = ListMsg.msg002;
        //        v = false;
        //    }
        //    else if (string.IsNullOrWhiteSpace(_usuarionome))
        //    {
        //        MsgResult = ListMsg.msg003;
        //        v = false;
        //    }
        //    else if (_usuarionome.Length <= 3)
        //    {
        //        MsgResult = ListMsg.msg004;
        //        v = false;
        //    }
        //    else if (_usuarionome.Length >= 20)
        //    {
        //        MsgResult = ListMsg.msg005;
        //        v = false;
        //    }
        //    else
        //    {

        //        v = true;
        //    }
        //    return v;

        //}

        //bool IUsuario_c.SelecionaRegistro(object _Selecionado)
        //{
        //    
        //    throw new NotImplementedException();
        //}

        //public bool GravaAlteracao()
        //{
        //    if (_SetEntidade.V_Senha & _SetEntidade.V_Email & _SetEntidade.V_NomeCompleto & _SetEntidade.V_UsuarioNome)
        //    {
        //        return GravaAlteracaoRegistro_Update();
        //    }
        //    else
        //    {
        //        MsgResult = "Erro gravar alteracao registro";
        //        return false;
        //    }
        //    throw new NotImplementedException();
        //}

        //public bool Login(string _UsuarioNome, string _Senha, out string _MsgResult)
        //{
        //    _MsgResult = MsgResult;
        //    return Autenticador(_UsuarioNome, _Senha);
        //    throw new NotImplementedException();
        //}

        //bool IUsuario_c.Autenticado(out string msgResult)
        //{
        //    //msgResult = "ja ta logado voce vai sair";
        //    if(_AutenticEntidade!=null){ msgResult ="Sair da conta";return true;}else{msgResult="Nao a usuario autenticado";return false;}
        //    throw new NotImplementedException();
        //}

        //void IUsuario_c.Sair(out string logof)
        //{
        //    logof = "Usuario saio ";
        //    _AutenticEntidade = null;
        //    return;
        //    throw new NotImplementedException();
        //}
        //#endregion

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
