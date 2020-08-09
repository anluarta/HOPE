namespace Hope.Interface
{
    public interface IPagar_e
    {
        bool Set_Dinheiro(string valor);
        bool Set_Debido(string valor);
        bool Set_Credito(string valor);
        bool Set_Cheque(string valor);
        bool Set_Vale_Alimentacao(string valor);
        bool Set_Vale_Refeicao(string valor);
        bool Set_Outro(string valor);
        bool Set_Interno(string valor);
        bool Set_Desconto(string valor);
    }
}