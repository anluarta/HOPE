namespace Hope.Entidade
{
    public interface IColaborador_Ent_c : IEndereco_Ent_c
    {
        int ID_Colaborador { get; }
        string Nome_Vendedor { get; }
        string Login_User { get; }
        string Login_PassWord { get; }
        // trabalhar nisso na fase ALFA
        //string Tipo_Colaborador { get; }
        //string Nivel_Permisao{ get; }
        bool Set_Login_User(string valor);
        bool Set_Login_PassWord(string valor);
        bool Set_Nome_Vendedor(string valor);
        // trabalhar nisso na fase ALFA
        // bool Set_Funcao(string valor);
        // bool Set_Nivel_Permisao(string valor);
    }
}