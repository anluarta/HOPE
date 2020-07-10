namespace Hope.Contrato
{
    public interface ICaixa
    {

        bool NovoCaixa();
        bool Suprimento(string _Valor);
        bool Sangria(string _Valor, string _Observacao);
        bool TodaLista();
        bool Localizar(string _operacao, string _local, string _orden, int _limit, string _termo);
    }
}