using Hope.Contrato;
using System;

namespace Hope
{
    public abstract class AbsHope : IHope
    {
        internal static IUsuario usuario;
        internal static IProduto produto;
        internal static ICliente cliente;
        internal static ICaixa caixa;
        internal static ICupom cupom;
        
        internal static HopeLocalDB_DEBUG LocalDB_DEBUG;
        public abstract string valor { get; set; }

        internal string _versao; 
        public object[] Get { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IUsuario IHope.Usuario { get => usuario; set => usuario=value; }
        IProduto IHope.Produto { get => produto; set => produto = value; }
        ICliente IHope.Cliente { get => cliente; set => cliente = value; }
        ICaixa IHope.Caixa { get => caixa; set => caixa = value; }
        ICupom IHope.Cupom { get => cupom; set => cupom = value; }
        string IHope.Versao { get => _versao; set => _versao = value; }

        object[] IHope.GetListaVencimentoSemana()
        {
            object[] vs = new object[7];
            switch (ListEnum.DiaSemanaVencimento.Segunda_Feira)
            {
                case ListEnum.DiaSemanaVencimento.Segunda_Feira:
                    vs[0] = ListEnum.DiaSemanaVencimento.Segunda_Feira.ToString();
                    goto case ListEnum.DiaSemanaVencimento.Terca_Feira;
                case ListEnum.DiaSemanaVencimento.Terca_Feira:
                    vs[1] = ListEnum.DiaSemanaVencimento.Terca_Feira.ToString();
                    goto case ListEnum.DiaSemanaVencimento.Quarta_Feira;
                case ListEnum.DiaSemanaVencimento.Quarta_Feira:
                    vs[2] = ListEnum.DiaSemanaVencimento.Quarta_Feira.ToString();
                    goto case ListEnum.DiaSemanaVencimento.Quinta_Feira;
                case ListEnum.DiaSemanaVencimento.Quinta_Feira:
                    vs[3] = ListEnum.DiaSemanaVencimento.Quinta_Feira.ToString();
                    goto case ListEnum.DiaSemanaVencimento.Sexta_Feira;
                case ListEnum.DiaSemanaVencimento.Sexta_Feira:
                    vs[4] = ListEnum.DiaSemanaVencimento.Sexta_Feira.ToString();
                    goto case ListEnum.DiaSemanaVencimento.Sabado;
                case ListEnum.DiaSemanaVencimento.Sabado:
                    vs[5] = ListEnum.DiaSemanaVencimento.Sabado.ToString();
                    goto case ListEnum.DiaSemanaVencimento.Domingo;
                case ListEnum.DiaSemanaVencimento.Domingo:
                    vs[6] = ListEnum.DiaSemanaVencimento.Domingo.ToString();
                    break;
            }
            return vs;
            throw new NotImplementedException();
        }

        object[] IHope.GetTipoVecimento()
        {
            object[] vs = new object[3];
            switch (ListEnum.TipoVencimento.Mensal)
            {
                case ListEnum.TipoVencimento.Mensal:
                    vs[0] = ListEnum.TipoVencimento.Mensal.ToString();
                    goto case ListEnum.TipoVencimento.Semanal;
                case ListEnum.TipoVencimento.Semanal:
                    vs[1] = ListEnum.TipoVencimento.Semanal.ToString();
                    goto case ListEnum.TipoVencimento.Diario;
                case ListEnum.TipoVencimento.Diario:
                    vs[2] = ListEnum.TipoVencimento.Diario.ToString();
                    break;
            }
            return vs;
        }

        object[] IHope.GetOperacaoConsulta()
        {
            object[] vs = new object[3];
            switch (ListEnum.ListaOperacaoConsulta.Distinto)
            {
                case ListEnum.ListaOperacaoConsulta.Distinto:
                    vs[0] = ListEnum.ListaOperacaoConsulta.Distinto.ToString();
                    goto case ListEnum.ListaOperacaoConsulta.Equal;
                case ListEnum.ListaOperacaoConsulta.Equal:
                    vs[1] = ListEnum.ListaOperacaoConsulta.Equal.ToString();
                    goto case ListEnum.ListaOperacaoConsulta.All;
                case ListEnum.ListaOperacaoConsulta.All:
                    vs[2] = ListEnum.ListaOperacaoConsulta.All.ToString();
                    break;
            }
            return vs;
            throw new NotImplementedException();
        }

        object[] IHope.GetOrden()
        {
            object[] vs = new object[2];
            switch (ListEnum.ListaOrdena.Ascedente)
            {
                case ListEnum.ListaOrdena.Ascedente:
                    vs[0] = ListEnum.ListaOrdena.Ascedente.ToString();
                    goto case ListEnum.ListaOrdena.Descedente;
                case ListEnum.ListaOrdena.Descedente:
                    vs[1] = ListEnum.ListaOrdena.Descedente.ToString();
                    break;
            }
            return vs;
            throw new NotImplementedException();
        }

        object[] IHope.GetTipoCliente()
        {
            object[] vs = new object[2];
            switch (ListEnum.TipoCliente.Fisico)
            {
                case ListEnum.TipoCliente.Fisico:
                    vs[0] = ListEnum.TipoCliente.Fisico.ToString();
                    goto case ListEnum.TipoCliente.Juridico;
                case ListEnum.TipoCliente.Juridico:
                    vs[1] = ListEnum.TipoCliente.Juridico.ToString();
                    break;
            }
            return vs;
            throw new NotImplementedException();
        }

        object[] IHope.GetTipoUnidadeProduto()
        {
            object[] vs = new object[3];
            switch (ListEnum.ListaUnidadeProduto.Peca)
            {
                case ListEnum.ListaUnidadeProduto.Peca:
                    vs[0] = ListEnum.ListaUnidadeProduto.Peca.ToString();
                    goto case ListEnum.ListaUnidadeProduto.Kilo;
                case ListEnum.ListaUnidadeProduto.Kilo:
                    vs[1] = ListEnum.ListaUnidadeProduto.Kilo.ToString();
                    goto case ListEnum.ListaUnidadeProduto.Pacote;
                case ListEnum.ListaUnidadeProduto.Pacote:
                    vs[2] = ListEnum.ListaUnidadeProduto.Pacote.ToString();
                    break;
                default:
            }
            return vs;
            throw new NotImplementedException();
        }

        object[] IHope.GetUsuarioLocalConsulta()
        {
            object[] vs = new object[3];
            switch (ListEnum.ListaColunaUsuario.ID_Usuario)
            {
                case ListEnum.ListaColunaUsuario.ID_Usuario:
                    vs[0] = ListEnum.ListaColunaUsuario.ID_Usuario.ToString();
                    goto case ListEnum.ListaColunaUsuario.Usuario_Nome;
                case ListEnum.ListaColunaUsuario.Usuario_Nome:
                    vs[1] = ListEnum.ListaColunaUsuario.Usuario_Nome.ToString();
                    goto case ListEnum.ListaColunaUsuario.Nome_Completo;
                case ListEnum.ListaColunaUsuario.Nome_Completo:
                    vs[2] = ListEnum.ListaColunaUsuario.Nome_Completo.ToString();
                    break;
            }
            return vs;
            throw new NotImplementedException();
        }
        public static IHope Beta()
        {
            return new Beta.Hope_beta();
        }
        public static IHope Alfa()
        {
            return new Alfa.HopeAlfa();
        }
        public static IHope Prod()
        {
            return new Prod.HopeProd();
        }

        object[] IHope.GetClienteLocalConsulta()
        {
            object[] vs = new object[3];
            switch (ListEnum.ListaColunaCliente.ID_CLiente)
            {
                case ListEnum.ListaColunaCliente.ID_CLiente:
                    vs[0] = ListEnum.ListaColunaCliente.ID_CLiente.ToString();
                    goto case ListEnum.ListaColunaCliente.Cpf_Cnpj;
                case ListEnum.ListaColunaCliente.Cpf_Cnpj:
                    vs[1] = ListEnum.ListaColunaCliente.Cpf_Cnpj.ToString();
                    goto case ListEnum.ListaColunaCliente.NomeCompleto_Razao;
                case ListEnum.ListaColunaCliente.NomeCompleto_Razao:
                    vs[2] = ListEnum.ListaColunaCliente.NomeCompleto_Razao.ToString();
                    break;
            }
            return vs;
            throw new NotImplementedException();
        }

        object[] IHope.GetProdutoLocalConsulta()
        {
            object[] vs = new object[3];
            switch (ListEnum.ListaColunaProduto.ID_Produto)
            {
                case ListEnum.ListaColunaProduto.ID_Produto:
                    vs[0] = ListEnum.ListaColunaProduto.ID_Produto.ToString();
                    goto case ListEnum.ListaColunaProduto.EAN;
                case ListEnum.ListaColunaProduto.EAN:
                    vs[1] = ListEnum.ListaColunaProduto.EAN.ToString();
                    goto case ListEnum.ListaColunaProduto.Descricao; 
                case ListEnum.ListaColunaProduto.Descricao:
                    vs[2] = ListEnum.ListaColunaProduto.Descricao.ToString();
                    break;
            }
            return vs;
            throw new NotImplementedException();
        }
    }
}
