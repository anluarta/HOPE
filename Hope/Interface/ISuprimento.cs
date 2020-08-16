using System.Drawing.Printing;

namespace Hope.Interface
{
    public interface ISuprimento
    {
        IConsulta Consulta();
        bool Find(IConsulta consulta,out ISuprimento_e[] suprimento_s);
        bool Select(object current,out ISuprimento_e suprimento_);
        bool Print_Document(ISuprimento_e suprimento_, out PrintDocument document);
    }
}