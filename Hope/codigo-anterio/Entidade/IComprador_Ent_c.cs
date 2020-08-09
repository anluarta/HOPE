using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
   public interface IComprador_Ent_c//:IEndereco_Ent_c
    {
        int ID_Comprador { get; }
        string Numero_Registro { get; }
        string NomeCompleto_RazaoSocial { get; }
        bool Set_Numero_Registro(string _Valor);
        bool Set_NomeCompleto_Razao(string _Valor);

        //string Tipo { get; }
        //bool Fornecedor { get; }
        //string Cpf_Cnpj { get; }
        //string Email { get; }
        //string Apelido_Fantasia { get; }
        //string Telefone_1 { get; }
        //string Telefone_2 { get; }
        //string Cep { get; }
        //string Logradouro { get; }
        //string Bairro { get; }
        //string Municipio { get; }
        //string Estado { get; }
        //string Observacao { get; }
        //bool Conta_Cliente { get; }
        //string Limite_Cupom { get; }
        //string Limite_Mensal { get; }
        //string semanaVencimento { get; }
        //string TipoVemcimento { get; }
        //string DiaVencimento { get; }
        //bool Set_Tipo(string _Valor);
        //bool Set_Fornecedor(bool _Valor);
        //bool Set_Email(string _Valor);
        //bool Set_Apelido_Fantasia(string _Valor);
        //bool Set_Telefone_1(string _Valor);
        //bool Set_Telefone_2(string _Valor);
        //bool Set_Cep(string _Valor);
        //bool Set_Logradouro(string _Valor);
        //bool Set_Bairro(string _Valor);
        //bool Set_Municipio(string _Valor);
        //bool Set_Estado(string _Valor);
        //bool Set_Observacao(string _Valor);
        //bool Set_Conta_Cliente(bool _Valor);
        //bool Set_Limite_Cupom(string _Valor);
        //bool Set_Limite_Mensal(string _Valor);
        //bool Set_semanaVencimento(string _Valor);
        //bool Set_TipoVemcimento(string _Valor);
        //bool Set_DiaVencimento(string _Valor);
    }
}
