using System.Drawing.Printing;

namespace Hope.Interface
{
    public interface ISangria
    {
        bool Consulta(out IConsulta consulta);
        bool Find(IConsulta consulta,out ISangria_e[] sangria_s);
        bool Select(object current,out ISangria_e sangria_);
        bool Print_Document(ISangria_e sangria_, PrintDocument document);
    }
}