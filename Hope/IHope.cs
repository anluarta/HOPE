using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    public interface IHope
    {
        Contrato.IUsuario_c Usuario { get; }
        Contrato.IProduto_c Produto { get; }
        Contrato.ICliente_c Cliente { get; }
        Contrato.ICaixa_c Caixa { get; }
        Contrato.ICupom_c Cupom { get; }
        string[] ArrayTipoCliente{ get; }
        string[] ArrayTipoVecimento { get; }
        string[] ArrayVencimentoSemana{ get; }
        string[] ArrayFormaRecebimento{ get; }
        string[] ArrayTipoRecebimento{ get; }
        string[] ArrayProdutoTipoUnidade{ get; }
        string[] ArrayConsultaComando{ get; }
        string[] ArrayCondicaoConsulta{ get; }
        string[] ArrayConsultaOrden{ get; }
        string[] ArrayUsuarioConsultaColuna { get; }
        string[] ArrayClienteConsultaColuna{ get; }
        string[] ArrayProdutoConsultaColuna{ get; }
        string[] ArrayCaixaConsultaColuna{ get; }
        string[] ArrayCupomConsultaColuna{ get; }

    }
}
