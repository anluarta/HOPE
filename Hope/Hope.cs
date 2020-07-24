using Hope.Contrato;
using Hope.Entidade;
using Hope.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    public abstract class Hope : IHope
    {
        internal static HopeDataSet localSet;
        internal static Colaborador_abs colaborador;
        internal static Comprador_abs comprador;
        internal static Produto_abs produto;
        internal static Caixa_abs caixa;
        internal static Vender_abs vender;
        internal static Informacao_abs informacao;
        IProduto_c IHope.Produto { get => produto; }
        ICaixa_c IHope.Caixa { get => caixa; }
        IVender_c IHope.Cupom { get => vender; }
        string[] IHope.ArrayTipoCliente
        {
            get
            {
                return new string[]
                {
                   ListEnum.TipoComprador.Fisico.ToString(),
                   ListEnum.TipoComprador.Juridico.ToString()
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

        IColaborador_c IHope.Colaborador => colaborador;

        IComprador_c IHope.Comprador => comprador;
    }
}
