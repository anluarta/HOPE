using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    public interface IHope
    {
        Contrato.IProduto_c Produto { get; }
        Contrato.ICaixa_c Caixa { get; }
        Contrato.IVender_c Cupom { get; }
        Contrato.IColaborador_c Colaborador { get; }
        Contrato.IComprador_c Comprador { get; }
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
