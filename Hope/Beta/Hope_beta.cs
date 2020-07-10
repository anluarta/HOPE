using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Hope_beta : AbsHope
    {
        public Hope_beta()
        {
            _versao = "BETA 0.0";
            usuario = new Usuario_beta();

            cliente = new Cliente_beta();
            produto = new Produto_beta();
            caixa = new Caixa_beta();
            cupom = new Cupom_beta();
            LocalDB_DEBUG = new HopeLocalDB_DEBUG();
            usuario.Set_NomeUsuario("anluarta"); usuario.Set_Senha("127845"); usuario.Set_NomeCompleto("Andre Luis Araujo"); usuario.Set_Email("anluarta@hotmail.com");
            usuario.GravarNovo();
            usuario.Set_NomeUsuario("Bacon"); usuario.Set_Senha("102030"); usuario.Set_NomeCompleto("Alessandro Ferreira Silva"); usuario.Set_Email("giealearetomanda@hotmail.com");
            usuario.GravarNovo();
            cliente.Set_Cpf_Cnpj("38295642871"); cliente.Set_NomeCompleto_Razao("Andre Luis Araujo Tamboril"); cliente.Set_Tipo(ListEnum.TipoCliente.Fisico.ToString()); cliente.Set_Fornecedor(false);
            cliente.GravarRegistro();
            produto.Set_EAN(""); produto.Set_Descricao("Teste"); produto.Set_Unidade(ListEnum.ListaUnidadeProduto.Peca.ToString()); produto.Set_Custo("0,00"); produto.Set_Venda( "1,00");
            produto.GravarNovo();
            produto.Set_EAN(""); produto.Set_Descricao("Teste tipo 2"); produto.Set_Unidade(ListEnum.ListaUnidadeProduto.Kilo.ToString()); produto.Set_Custo("0,00"); produto.Set_Venda( "5,00");
            produto.GravarNovo();
        }

        public override string valor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
