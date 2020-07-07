using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.IFace
{
    interface INucleo
    {
        EstadoOperacional _Estado { get; set; }
        IUsuario _Usuario { get; set; }
        ICliente _Cliente { get; set; }
        IProduto _Produto { get; set; }
        ICaixa _Caixa { get; set; }
        ICupom _Cupom { get; set; }
    }
}
