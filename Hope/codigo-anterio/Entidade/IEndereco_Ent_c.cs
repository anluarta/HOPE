namespace Hope.Entidade
{
    public interface IEndereco_Ent_c
    {
        string Logradouro { get; }
        string Cep { get; }
        string Bairro { get; }
        string Municipio { get; }
        string Estado { get; }
        bool Set_Logradouro(string valor);
        bool Set_Cep(string valor);
        bool Set_Bairro(string valor);
        bool Set_Municipio(string valor);
        bool Set_Estado(string valor);
    }
}