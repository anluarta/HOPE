namespace Hope.Contrato
{
    public interface ICupom
    {
        bool NovoCupom(string _ID_Caixa, string _ID_Usuario);
        bool TodaLista();
        bool Localizar(string _operacao, string _local, string _orden, int _limit, string _termo);
    }
}