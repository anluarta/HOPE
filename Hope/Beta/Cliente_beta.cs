using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Cliente_beta : AbsCliente
    {
        internal override bool GravarAlteracaoRegistro_Update()
        {
            for (int i = 0; i < AbsHope.LocalDB_DEBUG.Cliente.Count; i++)
            {
                HopeLocalDB_DEBUG.ClienteRow clienteRow = AbsHope.LocalDB_DEBUG.Cliente.Rows[i]as HopeLocalDB_DEBUG.ClienteRow;
                if (int.Parse(_FocusEntidade.Id_Cliente)==clienteRow.ID_Cliente)
                {
                    clienteRow.Cpf_Cnpj = _SetEntidade.Cpf_Cnpj;
                    clienteRow.NomeCompleto_Razao = _SetEntidade.NomeCompleto_Razao;
                    clienteRow.TipoCliente = _SetEntidade.Tipo;
                    clienteRow.Fornecedor = _SetEntidade.Fornecedor;
                    Clear();
                    return true;
                }
            }
            throw new NotImplementedException();
        }

        internal override bool GravarNovoRegistro_Insert()
        {
            HopeLocalDB_DEBUG.ClienteRow clienteRow = AbsHope.LocalDB_DEBUG.Cliente.NewClienteRow();
            clienteRow.Cpf_Cnpj = _SetEntidade.Cpf_Cnpj;
            clienteRow.NomeCompleto_Razao = _SetEntidade.NomeCompleto_Razao;
            clienteRow.TipoCliente = _SetEntidade.Tipo;
            clienteRow.Fornecedor = _SetEntidade.Fornecedor;
            AbsHope.LocalDB_DEBUG.Cliente.Rows.Add(clienteRow);
            return true;
            throw new NotImplementedException();
        }

        internal override bool SelectAll()
        {
            if (AbsHope.LocalDB_DEBUG.Cliente.Count != 0)
            {
                _DataResultado = new Entidade.ICliente[AbsHope.LocalDB_DEBUG.Cliente.Count];
                for (int i = 0; i < AbsHope.LocalDB_DEBUG.Cliente.Count; i++)
                {
                    _DataResultado[i] = new Entidade.Cliente()
                    {
                        Id_Cliente = AbsHope.LocalDB_DEBUG.Cliente.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Cliente.Columns.IndexOf("ID_Cliente")].ToString(),
                        Cpf_Cnpj = AbsHope.LocalDB_DEBUG.Cliente.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Cliente.Columns.IndexOf("Cpf_Cnpj")].ToString(),
                        NomeCompleto_Razao = AbsHope.LocalDB_DEBUG.Cliente.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Cliente.Columns.IndexOf("NomeCompleto_Razao")].ToString(),
                        Tipo = AbsHope.LocalDB_DEBUG.Cliente.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Cliente.Columns.IndexOf("TipoCliente")].ToString(),
                        Fornecedor = (bool)AbsHope.LocalDB_DEBUG.Cliente.Rows[i]
                        [AbsHope.LocalDB_DEBUG.Cliente.Columns.IndexOf("Fornecedor")]
                    };
                }
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
