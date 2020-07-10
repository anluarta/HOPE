using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
   public interface IHope
    {
        Contrato.IUsuario Usuario { get; set; }
        Contrato.IProduto Produto { get; set; }
        Contrato.ICliente Cliente { get; set; }
        Contrato.ICaixa Caixa { get; set; }
        Contrato.ICupom Cupom { get; set; }
        object[] GetTipoVecimento();
        object[] GetListaVencimentoSemana();
        object[] GetTipoCliente();
        object[] GetUsuarioLocalConsulta();
        object[] GetOperacaoConsulta();
        object[] GetOrden();
        object[] GetTipoUnidadeProduto();
        object[] GetClienteLocalConsulta();
        object[] GetProdutoLocalConsulta();
        string Versao { get; set; }
        
    }
}
