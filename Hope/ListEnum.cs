
namespace Hope
{
    class ListEnum
    {
        public enum TipoRecebimento
        {
            Avulso, Conta_Cliente
        }
        public enum FormaRecebimento
        {
            Dinheiro, Debito, Credito, Cheque/*,Boleto*/
        }
        public enum TipoCliente
        {
            Fisico, Juridico
        }
        public enum DiaSemanaVencimento
        {
            Segunda_Feira, Terca_Feira, Quarta_Feira, Quinta_Feira, Sexta_Feira, Sabado, Domingo
        }
        public enum TipoVencimento
        {
            Mensal, Semanal, Diario
        }
        public enum UnidadeProduto
        {
            Peca, Kilo, Pacote
        }
        public enum OrderConsulta
        {
            Ascedente, Descedente
        }
        public enum ComandoConsulta
        {
            Selec_All_From,
            Selec_All_From_Limit,
            Selec_All_From_OrderBy,
            Selec_All_From_OrderBy_Limit,
            Selec_All_From_Where_Cond,
            Selec_All_From_Where_Cond_OrderBy,
            Selec_All_From_Where_Cond_OrderBy_Limit,
        }
        public enum CondicaoConsulta
        {
            //=
            Igual, 
            //>
            Maior,
            //<
            Menor, 
            //>=
            MaiorIgual, 
            //<=
            MenorIgual, 
            //<>
            MenorMaior,
            //LIKE TERMO
            Like_Term,
            //LIKE TERMO%
            Like_Por_Term,
            //LIKE %TERMO
            Like_Term_Por,
            //LIKE %TERMO%
            Like_Por_Term_Por,
            //NOT LIKE %TERMO%
            Not_Like_Por_Term_Por
        }
        public enum ColunaConsultaUsuario
        {
            ID_Usuario, Usuario_Nome, Nome_Completo
        }
        public enum ColunaConsultaCliente
        {
            ID_CLiente, Cpf_Cnpj, NomeCompleto_Razao
        }
        public enum ColunaConsultaProduto
        {
            ID_Produto, EAN, Descricao
        }
        public enum ColunaConsultaCaixa
        {
            ID_Caixa
        }
        public enum ColunaConsultaCupom
        {
            ID_Cupom, ID_Caixa
        }
    }
}
