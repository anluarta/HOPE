namespace Hope.Interface
{
    public interface ISangria
    {
        IConsulta Consulta { get; }
        ISangria_e Find(IConsulta consulta);
    }
}