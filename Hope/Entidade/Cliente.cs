namespace Hope.Entidade
{
    class Cliente : ICliente
    {
        public string Id_Cliente { get; set; }
        public string Tipo { get; set; }
        public bool Fornecedor { get; set; }
        public string Cpf_Cnpj { get; set; }
        public string NomeCompleto_Razao { get; set; }
        public string Email { get; set; }
        public string Apelido_Fantasia { get; set; }
        public string Telefone_1 { get; set; }
        public string Telefone_2 { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Observacao { get; set; }
        public bool Conta_Cliente { get; set; }
        public string Limite_Cupom { get; set; }
        public string Limite_Mensal { get; set; }
        public string semanaVencimento { get; set; }
        public string TipoVemcimento { get; set; }
        public string DiaVencimento { get; set; }
    }
}
