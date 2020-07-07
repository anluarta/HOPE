namespace Hope.IFace
{
    public interface IUsuario
    {
        string strMsgResult { get; set; }
        bool Novo(string _usuarionome, string _senha, string _nomecompleto);
    }
}