using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Interface
{
    public interface IVender
    {
        string Notificar();
        bool Novo(ICaixa_e caixaOperacao,out IVender_e vender_);
        bool Gravar(Interface.IVender_e vender);
        IVender_e Select(object current);
        IConsulta Consulta();
        IVender_e[] Fill(IConsulta consulta);
        bool Item_Novo(IVender_e entidade,out IItem_e item_);
        bool Pagar_Novo(IVender_e entidade,out IPagar_e pagar_);
        bool Print_Document(IVender_e entidade, out PrintDocument document);
    }
}
