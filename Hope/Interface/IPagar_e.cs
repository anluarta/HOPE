namespace Hope.Interface
{
    public interface IPagar_e
    {
        decimal Bruto { get; }
        decimal Desconto { get; }
        decimal Cobrado { get; }
        decimal Recebido { get; }
        decimal Dinheiro { get; }
        decimal Troco { get; }
        decimal Debito { get; }
        decimal Credito { get; }
        decimal Cheque { get; }
        decimal Vale_Alimentacao { get; }
        decimal Vale_Refeicao { get; }
        decimal Outro { get; }
        decimal Interno { get; }
        bool Set_Desconto(string Valor);
        bool Set_Dinheiro(string Valor);
        bool Set_Debito(string Valor);
        bool Set_Credito(string Valor);
        bool Set_Cheque(string Valor);
        bool Set_Vale_Alimentacao(string Valor);
        bool Set_Vale_Refeicao(string Valor);
        bool Set_Outro(string Valor);
        bool Set_Interno(string Valor);
      
    }
}