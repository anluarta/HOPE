using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface ICliente
    {
        string Id_Cliente { get; set; }
        string Tipo { get; set; }
        bool Fornecedor { get; set; }
        string Cpf_Cnpj { get; set; }
        string NomeCompleto_Razao { get; set; }
        string Email { get; set; }
        string Apelido_Fantasia { get; set; }
        string Telefone_1 { get; set; }
        string Telefone_2 { get; set; }
        string Cep { get; set; }
        string Logradouro { get; set; }
        string Bairro { get; set; }
        string Municipio { get; set; }
        string Estado { get; set; }
        string Observacao { get; set; }
        bool Conta_Cliente { get; set; }
        string Limite_Cupom { get; set; }
        string Limite_Mensal { get; set; }
        string semanaVencimento { get; set; }
        string TipoVemcimento { get; set; }
        string DiaVencimento { get; set; }
    }
}
