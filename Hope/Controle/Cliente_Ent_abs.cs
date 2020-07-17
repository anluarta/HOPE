using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Cliente_Ent_abs : ICliente_Ent_c
    {
        
        public string _Id_Cliente { get; set; }
        public string _Tipo { get; set; }
        public bool _Fornecedor { get; set; }
        public string _Cpf_Cnpj { get; set; }
        public string _NomeCompleto_Razao { get; set; }
        public string _Email { get; set; }
        public string _Apelido_Fantasia { get; set; }
        public string _Telefone_1 { get; set; }
        public string _Telefone_2 { get; set; }
        public string _Cep { get; set; }
        public string _Logradouro { get; set; }
        public string _Bairro { get; set; }
        public string _Municipio { get; set; }
        public string _Estado { get; set; }
        public string _Observacao { get; set; }
        public bool _Conta_Cliente { get; set; }
        public string _Limite_Cupom { get; set; }
        public string _Limite_Mensal { get; set; }
        public string _Semana_Vencimento { get; set; }
        public string _Tipo_Vemcimento { get; set; }
        public string _Dia_Vencimento { get; set; }
        string ICliente_Ent_c.Id_Cliente => _Id_Cliente;

        string ICliente_Ent_c.Tipo => _Tipo;

        bool ICliente_Ent_c.Fornecedor => _Fornecedor;

        string ICliente_Ent_c.Cpf_Cnpj => _Cpf_Cnpj;

        string ICliente_Ent_c.NomeCompleto_Razao => _NomeCompleto_Razao;

        string ICliente_Ent_c.Email => _Email;

        string ICliente_Ent_c.Apelido_Fantasia => _Apelido_Fantasia;

        string ICliente_Ent_c.Telefone_1 => _Telefone_1;

        string ICliente_Ent_c.Telefone_2 => _Telefone_2;

        string ICliente_Ent_c.Cep => _Cep;

        string ICliente_Ent_c.Logradouro => _Logradouro;

        string ICliente_Ent_c.Bairro => _Bairro;

        string ICliente_Ent_c.Municipio => _Municipio;

        string ICliente_Ent_c.Estado => _Estado;

        string ICliente_Ent_c.Observacao => _Observacao;

        bool ICliente_Ent_c.Conta_Cliente => _Conta_Cliente;

        string ICliente_Ent_c.Limite_Cupom => _Limite_Cupom;

        string ICliente_Ent_c.Limite_Mensal => _Limite_Mensal;

        string ICliente_Ent_c.semanaVencimento => _Semana_Vencimento;

        string ICliente_Ent_c.TipoVemcimento => _Tipo_Vemcimento;

        string ICliente_Ent_c.DiaVencimento => _Dia_Vencimento;

        bool ICliente_Ent_c.Set_Apelido_Fantasia(string _Valor)
        {
            _Apelido_Fantasia = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Bairro(string _Valor)
        {
            _Bairro = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Cep(string _Valor)
        {
            _Cep = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Conta_Cliente(bool _Valor)
        {
            _Conta_Cliente = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Cpf_Cnpj(string _Valor)
        {
            _Cpf_Cnpj = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_DiaVencimento(string _Valor)
        {
            _Dia_Vencimento = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Email(string _Valor)
        {
            _Email = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Estado(string _Valor)
        {
            _Estado = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Fornecedor(bool _Valor)
        {
            _Fornecedor = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Limite_Cupom(string _Valor)
        {
            _Limite_Cupom = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Limite_Mensal(string _Valor)
        {
            _Limite_Mensal = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Logradouro(string _Valor)
        {
            _Logradouro = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Municipio(string _Valor)
        {
            _Municipio = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_NomeCompleto_Razao(string _Valor)
        {
            _NomeCompleto_Razao = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Observacao(string _Valor)
        {
            _Observacao = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_semanaVencimento(string _Valor)
        {
            _Semana_Vencimento = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Telefone_1(string _Valor)
        {
            _Telefone_1 = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Telefone_2(string _Valor)
        {
            _Telefone_2 = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_Tipo(string _Valor)
        {
            _Tipo = _Valor;
            return true;
        }

        bool ICliente_Ent_c.Set_TipoVemcimento(string _Valor)
        {
            _Tipo_Vemcimento = _Valor;
            return true;
        }
    }
}
