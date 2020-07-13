
namespace Hope
{
    class ListEnum
    {
        public enum ListaTipoRecebimento
        {
            Avulso,Conta_Cliente
        }
        public enum ListaFormaRecebimento
        {
            Dinheiro,Debito,Credito,Cheque/*,Boleto*/
        }
        public enum TipoCliente
        {
            Fisico,Juridico
        }
        public enum DiaSemanaVencimento
        {
            Segunda_Feira,Terca_Feira,Quarta_Feira,Quinta_Feira,Sexta_Feira,Sabado,Domingo
        }
        public enum TipoVencimento
        {
            Mensal,Semanal,Diario
        }
       public enum ListaUnidadeProduto
        {
            Peca,Kilo,Pacote
        }
        public enum ListaOrdena
        {
            Ascedente,Descedente
        }
        public enum ListaOperacaoConsulta
        {
            All,Distinto,Equal
        }
        public enum ListaColunaUsuario
        {
            ID_Usuario,Usuario_Nome,Nome_Completo
        }
        public enum ListaColunaCliente
        {
            ID_CLiente,Cpf_Cnpj,NomeCompleto_Razao
        }
        public enum ListaColunaProduto
        {
            ID_Produto,EAN,Descricao
        }
    }
}
