namespace Hope.Contrato
{
    public interface ICliente
    {
        Entidade.ICliente[] DataResultado { get; }
        string StrMsgResultado { get; set; }
        bool Localizar(string _operacao, string _local, string _orden, int _limit, string _termo, out string msg, out Entidade.ICliente[] ListaResultado);
        Entidade.ICliente FocusEntidade { get; }
        bool FocusRegistro(object _Selecionado);
        bool GravarRegistro();
        bool GravaAlteracao();
        bool Set_Tipo(string _Valor);
        bool Set_Fornecedor(bool _Valor);
        bool Set_Cpf_Cnpj(string _Valor);
        bool Set_NomeCompleto_Razao(string _Valor);
        bool Set_Email(string _Valor);
        bool Set_Apelido_Fantasia(string _Valor);
        bool Set_Telefone_1(string _Valor);
        bool Set_Telefone_2(string _Valor);
        bool Set_Cep(string _Valor);
        bool Set_Logradouro(string _Valor);
        bool Set_Bairro(string _Valor);
        bool Set_Municipio(string _Valor);
        bool Set_Estado(string _Valor);
        bool Set_Observacao(string _Valor);
        bool Set_Conta_Cliente(bool _Valor);
        bool Set_Limite_Cupom(string _Valor);
        bool Set_Limite_Mensal(string _Valor);
        bool Set_semanaVencimento(string _Valor);
        bool Set_TipoVemcimento(string _Valor);
        bool Set_DiaVencimento(string _Valor);
    }
}