using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Interface
{
    public interface IVender
    {
        string Notificar();
        Interface.IVender_e Novo();
        bool Gravar(Interface.IVender_e vender);
        IVender_e Select(object current);
        IConsulta Consulta { get; }
        IVender_e[] Fill(IConsulta consulta);
        IItem_e Items(IVender_e entidade);
        IPagar_e Pagar(IVender_e entidade);
    }
}
