namespace Hope.IFace
{
    public interface IEstatdoOperacional
    {
        System.Collections.Generic.List<IListaRegistroExecucao> TempoExecucao { get; set; }
        void ExibirRegistroExecucao();
        bool IsDebug { get; set; }
        frmMeuConsole MeuConsole { get; set; }
        void AddLinhaExecucao(string _acao, string _resultado);
    }
}