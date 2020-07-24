using Hope.Contrato;
using Hope.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    public class Comeco :Hope
    {
        public Comeco()
        {
            colaborador = new Beta.Colaborador_b();
            comprador = new Beta.Comprador_b();
            produto = new Beta.Produto_b();
            caixa = new Beta.Caixa_b();
            vender = new Beta.Vender_b();
            informacao = new Beta.Informacao_b();
            localSet = new HopeDataSet();
            InserRowColaborador();
            InserRowComprador();
            InserRowProduto();
            colaborador.login("anluarta", "127845");
            //Feito fucional ate em cima ^^
            // Teste \\(*;*)//
            caixa.iniciarmeucaixa();
            
            caixa.reforco(50.00m, "troco");
            //caixa._Recebimento._NovoRegistro.Clear();
            //caixa._Recebimento._NovoRegistro._Tipo_Recebimento = ListEnum.TipoRecebimento.Avulso.ToString();
            //caixa._Recebimento._NovoRegistro._Valor_Recebido = "100,00";
            //caixa._Recebimento._NovoRegistro._Forma_Recebimento = ListEnum.FormaRecebimento.Dinheiro.ToString();
            //caixa._Recebimento.gravaregistro();
            //caixa._Recebimento._NovoRegistro.Clear();
            //caixa._Recebimento._NovoRegistro._Tipo_Recebimento = ListEnum.TipoRecebimento.Avulso.ToString();
            //caixa._Recebimento._NovoRegistro._Valor_Recebido = "50,00";
            //caixa._Recebimento._NovoRegistro._Forma_Recebimento = ListEnum.FormaRecebimento.Debito.ToString();
            //caixa._Recebimento.gravaregistro();
            caixa.sangria(20.00m, "almoco");

            vender._novoresgistrocupom();
            vender._Item._NovoRegistro.Clea();
            vender._Item._NovoRegistro._Codigo="1";
            vender._Item._NovoRegistro._Descricao="oculos sol infantil";
            vender._Item._NovoRegistro._Unidade=ListEnum.UnidadeProduto.Peca.ToString();
            vender._Item._NovoRegistro._Quantidade=1;
            vender._Item._NovoRegistro._Preco=14.99m;
            vender._Item.gravarregistro();
            vender._Pagar._NovoRegistro.Clea();
            vender._Pagar._NovoRegistro._Bruto = 20.00m;
            vender._Pagar._NovoRegistro._Dinheiro = 20.00m;
            vender._finalizarregistro();
            vender._novoresgistrocupom();
            vender._Item._NovoRegistro.Clea();
            vender._Item._NovoRegistro._Codigo = "1";
            vender._Item._NovoRegistro._Descricao = "oculos sol infantil";
            vender._Item._NovoRegistro._Unidade = ListEnum.UnidadeProduto.Peca.ToString();
            vender._Item._NovoRegistro._Quantidade = 1;
            vender._Item._NovoRegistro._Preco = 14.99m;
            vender._Item.gravarregistro();
            vender._Pagar._NovoRegistro.Clea();
            vender._Pagar._NovoRegistro._Bruto = 14.99m;
            vender._Pagar._NovoRegistro._Debito = 14.99m;
            vender._finalizarregistro();
            vender._novoresgistrocupom();
            vender._Item._NovoRegistro.Clea();
            vender._Item._NovoRegistro._Codigo = "1";
            vender._Item._NovoRegistro._Descricao = "oculos sol infantil";
            vender._Item._NovoRegistro._Unidade = ListEnum.UnidadeProduto.Peca.ToString();
            vender._Item._NovoRegistro._Quantidade = 1;
            vender._Item._NovoRegistro._Preco = 14.99m;
            vender._Item.gravarregistro();
            vender._Pagar._NovoRegistro.Clea();
            vender._Pagar._NovoRegistro._Bruto = 14.99m;
            vender._Pagar._NovoRegistro._Credito = 14.99m;
            vender._finalizarregistro();
            vender._novoresgistrocupom();
            vender._Item._NovoRegistro.Clea();
            vender._Item._NovoRegistro._Codigo = "1";
            vender._Item._NovoRegistro._Descricao = "oculos sol infantil";
            vender._Item._NovoRegistro._Unidade = ListEnum.UnidadeProduto.Peca.ToString();
            vender._Item._NovoRegistro._Quantidade = 1;
            vender._Item._NovoRegistro._Preco = 14.99m;
            vender._Item.gravarregistro();
            vender._Pagar._NovoRegistro.Clea();
            vender._Pagar._NovoRegistro._Bruto = 14.99m;
            vender._Pagar._NovoRegistro._Cheque = 14.99m;
            vender._finalizarregistro();
            vender._novoresgistrocupom();
            vender._Item._NovoRegistro.Clea();
            vender._Item._NovoRegistro._Codigo = "1";
            vender._Item._NovoRegistro._Descricao = "oculos sol infantil";
            vender._Item._NovoRegistro._Unidade = ListEnum.UnidadeProduto.Peca.ToString();
            vender._Item._NovoRegistro._Quantidade = 1;
            vender._Item._NovoRegistro._Preco = 14.99m;
            vender._Item.gravarregistro();
            vender._Pagar._NovoRegistro.Clea();
            vender._Pagar._NovoRegistro._Bruto = 14.99m;
            vender._Pagar._NovoRegistro._Vale_Alimentacao = 14.99m;
            vender._finalizarregistro();
            vender._novoresgistrocupom();
            vender._Item._NovoRegistro.Clea();
            vender._Item._NovoRegistro._Codigo = "1";
            vender._Item._NovoRegistro._Descricao = "oculos sol infantil";
            vender._Item._NovoRegistro._Unidade = ListEnum.UnidadeProduto.Peca.ToString();
            vender._Item._NovoRegistro._Quantidade = 1;
            vender._Item._NovoRegistro._Preco = 14.99m;
            vender._Item.gravarregistro();
            vender._Pagar._NovoRegistro.Clea();
            vender._Pagar._NovoRegistro._Bruto = 14.99m;
            vender._Pagar._NovoRegistro._Vale_Refeicao = 14.99m;
            vender._finalizarregistro();
            vender._novoresgistrocupom();
            vender._Item._NovoRegistro.Clea();
            vender._Item._NovoRegistro._Codigo = "1";
            vender._Item._NovoRegistro._Descricao = "oculos sol infantil";
            vender._Item._NovoRegistro._Unidade = ListEnum.UnidadeProduto.Peca.ToString();
            vender._Item._NovoRegistro._Quantidade = 1;
            vender._Item._NovoRegistro._Preco = 14.99m;
            vender._Item.gravarregistro();
            vender._Pagar._NovoRegistro.Clea();
            vender._Pagar._NovoRegistro._Bruto = 14.99m;
            vender._Pagar._NovoRegistro._Outro = 14.99m;
            vender._finalizarregistro();
            vender._novoresgistrocupom();
            vender._Item._NovoRegistro.Clea();
            vender._Item._NovoRegistro._Codigo = "1";
            vender._Item._NovoRegistro._Descricao = "oculos sol infantil";
            vender._Item._NovoRegistro._Unidade = ListEnum.UnidadeProduto.Peca.ToString();
            vender._Item._NovoRegistro._Quantidade = 1;
            vender._Item._NovoRegistro._Preco = 14.99m;
            vender._Pagar._NovoRegistro.Clea();
            vender._Pagar._NovoRegistro._Bruto = 20.00m;
            vender._Pagar._NovoRegistro._Desconto = 4.99m;
            vender._Pagar._NovoRegistro._Dinheiro = 10.00m;
            vender._finalizarregistro();
            caixa.fecharmeucaixa();
           colaborador.sair();
        }
        private void InserRowColaborador()
        {
            colaborador._NovoRegistro.Clea();
            colaborador._NovoRegistro._Login_User = "anluarta";
            colaborador._NovoRegistro._Login_PassWord = "127845";
            colaborador._NovoRegistro._Nome_Vendedor = "Andre Luis Araujo";
            colaborador.gravarregistro();
            colaborador._NovoRegistro.Clea();
            colaborador._NovoRegistro._Login_User = "Bacon";
            colaborador._NovoRegistro._Login_PassWord = "102030";
            colaborador._NovoRegistro._Nome_Vendedor = "Alessandro Ferreira Silva";
            colaborador.gravarregistro();
            colaborador._NovoRegistro.Clea();
            colaborador._NovoRegistro._Login_User = "teste";
            colaborador._NovoRegistro._Login_PassWord = "123";
            colaborador._NovoRegistro._Nome_Vendedor = "teste nome completo";
            colaborador.gravarregistro();
        }
        private void InserRowComprador()
        {
            comprador._NovoRegistro.Clea();
            comprador._NovoRegistro._Numero_Registro="0";
            comprador._NovoRegistro._NomeCompleto_RazaoSocial="Balcao";
            comprador._NovoRegistro._Tipo=ListEnum.TipoComprador.Fisico;
            comprador.gravarrestro(); 
            comprador._NovoRegistro.Clea();
            comprador._NovoRegistro._Numero_Registro="38295642871";
            comprador._NovoRegistro._NomeCompleto_RazaoSocial="Andre Luis Araujo Tamboril";
            comprador._NovoRegistro._Tipo=ListEnum.TipoComprador.Fisico;
            comprador.gravarrestro();
            comprador._NovoRegistro.Clea();
            comprador._NovoRegistro._Numero_Registro = "00000000000000";
            comprador._NovoRegistro._NomeCompleto_RazaoSocial = "alessandro ferreira silva";
            comprador._NovoRegistro._Tipo = ListEnum.TipoComprador.Juridico;
            comprador.gravarrestro();
            comprador._NovoRegistro.Clea();
            comprador._NovoRegistro._Numero_Registro = "111111111111111";
            comprador._NovoRegistro._NomeCompleto_RazaoSocial = "Teste Hope";
            comprador._NovoRegistro._Tipo = ListEnum.TipoComprador.Juridico;
            comprador.gravarrestro();
           
        }
        private void InserRowProduto()
        {
            produto._NovoRegistro.Clea();
            produto._NovoRegistro._EAN = "";
            produto._NovoRegistro._Descricao = "Teste";
            produto._NovoRegistro._Unidade = ListEnum.UnidadeProduto.Peca.ToString();
            produto._NovoRegistro._Custo = 1.00m;
            produto._NovoRegistro._Venda = 5.00m;
            produto.gravarregistro();
            produto._NovoRegistro.Clea();
            produto._NovoRegistro._EAN = "";
            produto._NovoRegistro._Descricao = "Teste valor cus ven dif";
            produto._NovoRegistro._Unidade = ListEnum.UnidadeProduto.Peca.ToString();
            produto._NovoRegistro._Custo = 5.00m;
            produto._NovoRegistro._Venda = 9.75m;
            produto.gravarregistro();
            //produto.Set_EAN(""); produto.Set_Descricao("Teste"); produto.Set_Unidade(ListEnum.UnidadeProduto.Peca.ToString()); produto.Set_Custo("0,00"); produto.Set_Venda("1,00");
            //produto.GravarNovo();
            //produto.Set_EAN(""); produto.Set_Descricao("Teste tipo 2"); produto.Set_Unidade(ListEnum.UnidadeProduto.Kilo.ToString()); produto.Set_Custo("0,00"); produto.Set_Venda("5,00");
            //produto.GravarNovo();
        }
        
     
    }
}
