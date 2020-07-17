using Hope.Contrato;
using Hope.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Cliente_b : Controle.Cliente_abs
    {
        public Cliente_b()
        {
            _AlteraRegistro = new Cliente_Ent_b();
            _NovoRegistro = new Cliente_Ent_b();
            _FocusRegistro = new Cliente_Ent_b();
        }
        internal override bool InsertRegistro()
        {
            HopeDataSet.ClienteRow clienteRow = Hope.localSet.Cliente.NewClienteRow();
            clienteRow.Cpf_Cnpj = _NovoRegistro._Cpf_Cnpj;
            clienteRow.NomeCompleto_Razao = _NovoRegistro._NomeCompleto_Razao;
            clienteRow.TipoCliente = _NovoRegistro._Tipo;
            clienteRow.Fornecedor = _NovoRegistro._Fornecedor;
            Hope.localSet.Cliente.Rows.Add(clienteRow);
            return true;
        }

        internal override bool Select_All_From()
        {
            if (Hope.localSet.Cliente.Count != 0)
            {
                for (int i = 0; i < Hope.localSet.Cliente.Count; i++)
                {
                    ListRegUsuario.Add(new Beta.Cliente_Ent_b()
                    {
                        _Id_Cliente = Hope.localSet.Cliente.Rows[i]
                        [Hope.localSet.Cliente.Columns.IndexOf("ID_Cliente")].ToString(),
                        _Cpf_Cnpj = Hope.localSet.Cliente.Rows[i]
                        [Hope.localSet.Cliente.Columns.IndexOf("Cpf_Cnpj")].ToString(),
                        _NomeCompleto_Razao = Hope.localSet.Cliente.Rows[i]
                        [Hope.localSet.Cliente.Columns.IndexOf("NomeCompleto_Razao")].ToString(),
                        _Tipo = Hope.localSet.Cliente.Rows[i]
                        [Hope.localSet.Cliente.Columns.IndexOf("TipoCliente")].ToString(),
                        _Fornecedor = (bool)Hope.localSet.Cliente.Rows[i]
                        [Hope.localSet.Cliente.Columns.IndexOf("Fornecedor")]
                    });
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        internal override bool UpdateRegistro()
        {
            try
            {
                for (int i = 0; i < Hope.localSet.Cliente.Count; i++)
                {
                    HopeDataSet.ClienteRow clienteRow = Hope.localSet.Cliente.Rows[i] as HopeDataSet.ClienteRow;
                    if (int.Parse(_FocusRegistro._Id_Cliente) == clienteRow.ID_Cliente)
                    {
                        clienteRow.Cpf_Cnpj = _AlteraRegistro._Cpf_Cnpj;
                        clienteRow.NomeCompleto_Razao = _AlteraRegistro._NomeCompleto_Razao;
                        clienteRow.TipoCliente = _AlteraRegistro._Tipo;
                        clienteRow.Fornecedor = _AlteraRegistro._Fornecedor;

                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Hope.informacao.Add("000", e.Message);
                return false;
            }

        }
    }
}
