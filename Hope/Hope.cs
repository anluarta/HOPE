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
            
            //usuario.Set_NomeUsuario("anluarta"); usuario.Set_Senha("127845"); usuario.Set_NomeCompleto("Andre Luis Araujo"); usuario.Set_Email("anluarta@hotmail.com");
            //usuario.GravarRegistro();
            //usuario.Set_NomeUsuario("Bacon"); usuario.Set_Senha("102030"); usuario.Set_NomeCompleto("Alessandro Ferreira Silva"); usuario.Set_Email("giealearetomanda@hotmail.com");
            //usuario.GravarRegistro();
            //cliente.Set_Cpf_Cnpj("38295642871"); cliente.Set_NomeCompleto_Razao("Andre Luis Araujo Tamboril"); cliente.Set_Tipo(ListEnum.TipoCliente.Fisico.ToString()); cliente.Set_Fornecedor(false);
            //cliente.GravarRegistro();
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
