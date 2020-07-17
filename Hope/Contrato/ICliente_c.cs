namespace Hope.Contrato
{
    public interface ICliente_c
    {
        IInformacao_c Informacao { get; }
        Entidade.ICliente_Ent_c FocusEntidade { get; }
        bool Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out Entidade.ICliente_Ent_c[] ListaResultado);
        bool SelecionaRegistro(object _Selecionado);
        bool GravarRegistro(Entidade.ICliente_Ent_c usuario);
        bool GravaAlteracao(Entidade.ICliente_Ent_c usuario);
        bool NovoRegistro(out Entidade.ICliente_Ent_c usuario);
        void AlteraRegistro(out Entidade.ICliente_Ent_c usuario);

    }
}