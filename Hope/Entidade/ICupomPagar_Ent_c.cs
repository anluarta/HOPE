namespace Hope.Entidade
{
    public interface ICupomPagar_Ent_c
    {
        string Bruto { get; }
        string Desconto { get; }
        string Cobrado { get; }
        string Recebido { get; }
        string Dinheiro { get; }
        string Debito { get; }
        string Credito { get; }
        string Cheque { get; }
        string Vale_Alimentacao { get; }
        string Vale_Refeicao { get; }
        string Outro { get; }
        string Interno { get; }
        string Conta_Cliente { get; }
        bool Set_Bruto(string Valor);
        bool Set_Desconto(string Valor);
        bool Set_Cobrado(string Valor);
        bool Set_Recebido(string Valor);
        bool Set_Dinheiro(string Valor);
        bool Set_Debito(string Valor);
        bool Set_Credito(string Valor);
        bool Set_Cheque(string Valor);
        bool Set_Vale_Alimentacao(string Valor);
        bool Set_Vale_Refeicao(string Valor);
        bool Set_Outro(string Valor);
        bool Set_Interno(string Valor);
        bool Set_Conta_Cliente(string Valor);
    }
}