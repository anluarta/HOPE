using System;

namespace Hope.Contrato
{
    public interface IUsuario
    {
        bool Localizar( string _operacao, string _local, string _orden, int _limit, string _termo);
        string StrMsgResult { get; set; }
        Entidade.IUsuario[] DadoResultado { get; set; }
        Entidade.IUsuario FocusEntidade { get; }

        bool Set_NomeCompleto(string valor);
        bool Set_Email(string valor);
        bool Set_Senha(string valor);
        bool Set_NomeUsuario(string valor);
        bool FocusRegistro(object _Selecionado);
        bool GravarNovo();
        bool GravaAlteracao();
        bool Login(string _UsuarioNome, string _Senha, out string _MsgResult);
        bool Autenticado(out string msgResult);
        void Sair(out string logof);
        // bool TodaLista();
        // bool NovoUsuario(string _usuarionome, string _senha, string _nomecompleto,string _email);
        // bool AlteraDado(string _usuarionome, string _senha, string _nomecompleto, string _email);
    }
}