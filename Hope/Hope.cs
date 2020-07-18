using Hope.Contrato;
using Hope.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    public class Hope : IHope
    {
        internal static HopeDataSet localSet;
        internal static Usuario_abs usuario;
        internal static Produto_abs produto;
        internal static Cliente_abs cliente;
        internal static Caixa_abs caixa;
        internal static Cupom_abs cupom;
        internal static Informacao_abs informacao;
        internal string _versao;
        public Hope()
        {
            _versao = "BETA 0.0";
            usuario = new Beta.Usuario_b();
            cliente = new Beta.Cliente_b();
            produto = new Beta.Produto_b();
            caixa = new Beta.Caixa_b();
            cupom = new Beta.Cupom_b();
            informacao = new Beta.Informacao_b();
            localSet = new HopeDataSet();
            InserRowUsuario();
            InserRowCliente();
            InserRowProduto();
            usuario.Login("anluarta", "127845");
            //Feito fucional ate em cima ^^

            caixa.iniciarmeucaixa();
            
            caixa.reforco("50,00", "troco");
            caixa._Recebimento._NovoRegistro.Clear();
            caixa._Recebimento._NovoRegistro._Tipo_Recebimento = ListEnum.TipoRecebimento.Avulso.ToString();
            caixa._Recebimento._NovoRegistro._Valor_Recebido = "100,00";
            caixa._Recebimento._NovoRegistro._Forma_Recebimento = ListEnum.FormaRecebimento.Dinheiro.ToString();
            caixa._Recebimento.InsertRegistro();
            caixa._Recebimento._NovoRegistro.Clear();
            caixa._Recebimento._NovoRegistro._Tipo_Recebimento = ListEnum.TipoRecebimento.Avulso.ToString();
            caixa._Recebimento._NovoRegistro._Valor_Recebido = "50,00";
            caixa._Recebimento._NovoRegistro._Forma_Recebimento = ListEnum.FormaRecebimento.Debito.ToString();
            caixa._Recebimento.InsertRegistro();
            caixa.sangria("20,00", "almoco");

            cupom._novoresgistrocupom();
            cupom._Item._NovoRegistro.Clea();
            cupom._Item._NovoRegistro._Codigo="1";
            cupom._Item._NovoRegistro._Descricao="oculos sol infantil";
            cupom._Item._NovoRegistro._Unidade=ListEnum.UnidadeProduto.Peca.ToString();
            cupom._Item._NovoRegistro._Quantidade="1";
            cupom._Item._NovoRegistro._Preco="14,99";
            cupom._Item.gravarregistro();
            cupom._Pagar._NovoRegistro.Clea();
            cupom._Pagar._NovoRegistro._Recebido = "20,00";
            cupom._Pagar._NovoRegistro._Dinheiro = "20,00";

            cupom._finalizarregistro();
            
            caixa.fecharmeucaixa();
            usuario.sair();
        }
        private void InserRowUsuario()
        {
            usuario._NovoRegistro.Clea();
            usuario._NovoRegistro._Usuario_Nome = "anluarta";
            usuario._NovoRegistro._Senha = "127845";
            usuario._NovoRegistro._Nome_Completo = "Andre Luis Araujo";
            usuario._NovoRegistro._Email = "anluarta@hotmail.com";
            usuario.InsertRegistro();
            usuario._NovoRegistro.Clea();
            usuario._NovoRegistro._Usuario_Nome = "Bacon";
            usuario._NovoRegistro._Senha = "102030";
            usuario._NovoRegistro._Nome_Completo = "Alessandro Ferreira Silva";
            usuario._NovoRegistro._Email = "giealearetomanda@hotmail.com";
            usuario.InsertRegistro();
            usuario._NovoRegistro.Clea();
            usuario._NovoRegistro._Usuario_Nome = "teste";
            usuario._NovoRegistro._Senha = "123";
            usuario._NovoRegistro._Nome_Completo = "teste nome completo";
            usuario._NovoRegistro._Email = "teste@hope.hope";
            usuario.InsertRegistro();
        }
        private void InserRowCliente()
        {
            cliente._NovoRegistro.Clea();
            cliente._NovoRegistro._Cpf_Cnpj="38295642871";
            cliente._NovoRegistro._NomeCompleto_Razao="Andre Luis Araujo Tamboril";
            cliente._NovoRegistro._Tipo=ListEnum.TipoCliente.Fisico.ToString();
            cliente._NovoRegistro._Fornecedor=false;
            cliente.InsertRegistro();
            cliente._NovoRegistro.Clea();
            cliente._NovoRegistro._Cpf_Cnpj = "00000000000000";
            cliente._NovoRegistro._NomeCompleto_Razao = "alessandro ferreira silva";
            cliente._NovoRegistro._Tipo = ListEnum.TipoCliente.Juridico.ToString();
            cliente._NovoRegistro._Fornecedor = false;
            cliente.InsertRegistro();
            cliente._NovoRegistro.Clea();
            cliente._NovoRegistro._Cpf_Cnpj = "111111111111111";
            cliente._NovoRegistro._NomeCompleto_Razao = "Teste Hope";
            cliente._NovoRegistro._Tipo = ListEnum.TipoCliente.Juridico.ToString();
            cliente._NovoRegistro._Fornecedor = true;
            cliente.InsertRegistro();
           
        }
        private void InserRowProduto()
        {
            produto._NovoRegistro.Clea();

            //produto.Set_EAN(""); produto.Set_Descricao("Teste"); produto.Set_Unidade(ListEnum.UnidadeProduto.Peca.ToString()); produto.Set_Custo("0,00"); produto.Set_Venda("1,00");
            //produto.GravarNovo();
            //produto.Set_EAN(""); produto.Set_Descricao("Teste tipo 2"); produto.Set_Unidade(ListEnum.UnidadeProduto.Kilo.ToString()); produto.Set_Custo("0,00"); produto.Set_Venda("5,00");
            //produto.GravarNovo();
        }
        IUsuario_c IHope.Usuario { get => usuario; }
        IProduto_c IHope.Produto { get => produto; }
        ICliente_c IHope.Cliente { get => cliente; }
        ICaixa_c IHope.Caixa { get => caixa; }
        ICupom_c IHope.Cupom { get => cupom; }
        string[] IHope.ArrayTipoCliente
        {
            get
            {
                return new string[]
                {
                   ListEnum.TipoCliente.Fisico.ToString(),
                   ListEnum.TipoCliente.Juridico.ToString()
                };
            }
        }
        string[] IHope.ArrayTipoVecimento
        {
            get
            {
                return new string[]
                {
                    ListEnum.TipoVencimento.Mensal.ToString(),
                ListEnum.TipoVencimento.Semanal.ToString(),
                    ListEnum.TipoVencimento.Diario.ToString()
               };
            }
        }
        string[] IHope.ArrayVencimentoSemana
        {
            get
            {
                return new string[]
                {
                    ListEnum.DiaSemanaVencimento.Segunda_Feira.ToString(),
                    ListEnum.DiaSemanaVencimento.Terca_Feira.ToString(),
                    ListEnum.DiaSemanaVencimento.Quarta_Feira.ToString(),
                    ListEnum.DiaSemanaVencimento.Quinta_Feira.ToString(),
                    ListEnum.DiaSemanaVencimento.Sexta_Feira.ToString(),
                    ListEnum.DiaSemanaVencimento.Sabado.ToString(),
                    ListEnum.DiaSemanaVencimento.Domingo.ToString()
                };
            }
        }
        string[] IHope.ArrayFormaRecebimento
        {
            get
            {
                return new string[]
                {
                        ListEnum.FormaRecebimento.Dinheiro.ToString(),
                        ListEnum.FormaRecebimento.Debito.ToString(),
                        ListEnum.FormaRecebimento.Credito.ToString(),
                        ListEnum.FormaRecebimento.Cheque.ToString()
                };
            }
        }
        string[] IHope.ArrayTipoRecebimento
        {
            get
            {
                return new string[]
                {
                        ListEnum.TipoRecebimento.Avulso.ToString(),
                        ListEnum.TipoRecebimento.Conta_Cliente.ToString()
                };
            }
        }
        string[] IHope.ArrayProdutoTipoUnidade
        {
            get
            {
                return new string[]
                {
                        ListEnum.UnidadeProduto.Peca.ToString(),
                        ListEnum.UnidadeProduto.Kilo.ToString(),
                        ListEnum.UnidadeProduto.Pacote.ToString()
                };
            }
        }
        string[] IHope.ArrayConsultaComando
        {
            get
            {
                return new string[]
                {
                    ListEnum.ComandoConsulta.Selec_All_From.ToString(),
                    ListEnum.ComandoConsulta.Selec_All_From_Limit.ToString(),
                    ListEnum.ComandoConsulta.Selec_All_From_OrderBy.ToString(),
                    ListEnum.ComandoConsulta.Selec_All_From_OrderBy_Limit.ToString(),
                    ListEnum.ComandoConsulta.Selec_All_From_Where_Cond.ToString(),
                    ListEnum.ComandoConsulta.Selec_All_From_Where_Cond_OrderBy.ToString(),
                    ListEnum.ComandoConsulta.Selec_All_From_Where_Cond_OrderBy_Limit.ToString()
                };
            }
        }
        string[] IHope.ArrayConsultaOrden
        {
            get
            {
                return new string[]
                {
                        ListEnum.OrderConsulta.Ascedente.ToString(),
                        ListEnum.OrderConsulta.Descedente.ToString()
                };
            }
        }
        string[] IHope.ArrayUsuarioConsultaColuna
        {
            get
            {
                return new string[]
                {
                        ListEnum.ColunaConsultaUsuario.ID_Usuario.ToString(),
                        ListEnum.ColunaConsultaUsuario.Usuario_Nome.ToString(),
                        ListEnum.ColunaConsultaUsuario.Nome_Completo.ToString()
                };
            }
        }
        string[] IHope.ArrayClienteConsultaColuna
        {
            get
            {
                return new string[]
                {
                        ListEnum.ColunaConsultaCliente.ID_CLiente.ToString(),
                        ListEnum.ColunaConsultaCliente.Cpf_Cnpj.ToString(),
                        ListEnum.ColunaConsultaCliente.NomeCompleto_Razao.ToString()
                };
            }
        }
        string[] IHope.ArrayProdutoConsultaColuna
        {
            get
            {
                return new string[]
                {
                        ListEnum.ColunaConsultaProduto.ID_Produto.ToString(),
                        ListEnum.ColunaConsultaProduto.EAN.ToString(),
                        ListEnum.ColunaConsultaProduto.Descricao.ToString()
                };
            }
        }
        string[] IHope.ArrayCaixaConsultaColuna
        {
            get
            {
                return new string[]
                {
                        ListEnum.ColunaConsultaCaixa.ID_Caixa.ToString()
                };
            }
        }
        string[] IHope.ArrayCupomConsultaColuna
        {
            get
            {
                return new string[]
                {
                        ListEnum.ColunaConsultaCupom.ID_Caixa.ToString()
                };
            }
        }
        string[] IHope.ArrayCondicaoConsulta
        {
            get
            {
                return new string[]
                {
                    ListEnum.CondicaoConsulta.Igual.ToString(),
                    ListEnum.CondicaoConsulta.Maior.ToString(),
                    ListEnum.CondicaoConsulta.MaiorIgual.ToString(),
                    ListEnum.CondicaoConsulta.Menor.ToString(),
                    ListEnum.CondicaoConsulta.MenorIgual.ToString(),
                    ListEnum.CondicaoConsulta.MenorMaior.ToString(),
                    ListEnum.CondicaoConsulta.Like_Term.ToString(),
                    ListEnum.CondicaoConsulta.Like_Por_Term.ToString(),
                    ListEnum.CondicaoConsulta.Like_Por_Term_Por.ToString(),
                    ListEnum.CondicaoConsulta.Like_Term_Por.ToString(),
                    ListEnum.CondicaoConsulta.Not_Like_Por_Term_Por.ToString()
                };
            }
        }
    }
}
