namespace Hope.Interface
{
    public interface ISuprimento
    {
        IConsulta Consulta { get; }
        ISuprimento_e[] Find(IConsulta consulta);
        ISuprimento_e Select(object current);
    }
}