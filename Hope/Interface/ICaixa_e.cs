namespace Hope.Interface
{
    public interface ICaixa_e
    {
        string Get_ID { get; }
        string Get_Colaborador{get;}
        string Get_Start_DateTime{get;}
        string Get_finish_DateTime{get;}
        string Notifica();
        void Fechamento();
        string Dinheiro();
        string Debito();
        string Credito();
        string Cheque();
        string Vale_Alemintacao();
        string Vale_Refeicao();
        string Outro();
        string Interno();
        string Sangria();
        string Suprimento();
        bool Add(ISangria_e entidade);
        bool Add(ISuprimento_e entidade);
    }
}