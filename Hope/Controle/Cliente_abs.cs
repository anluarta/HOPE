using Hope.Contrato;
using Hope.Entidade;
using System;

namespace Hope.Controle
{
    abstract class Cliente_abs:Contrato.ICliente_c
    {
        internal System.Collections.Generic.List<Cliente_Ent_abs> ListRegUsuario;
        internal Cliente_Ent_abs _Logado;
        internal Cliente_Ent_abs _FocusRegistro;
        internal Cliente_Ent_abs _AlteraRegistro;
        internal Cliente_Ent_abs _NovoRegistro;
        internal string _Msg;
        internal abstract bool UpdateRegistro();
        internal abstract bool InsertRegistro();
        internal abstract bool Select_All_From();
        IInformacao_c ICliente_c.Informacao => throw new NotImplementedException();

        ICliente_Ent_c ICliente_c.FocusEntidade => throw new NotImplementedException();

        void ICliente_c.AlteraRegistro(out ICliente_Ent_c usuario)
        {
            throw new NotImplementedException();
        }

        bool ICliente_c.GravaAlteracao(ICliente_Ent_c usuario)
        {
            throw new NotImplementedException();
        }

        bool ICliente_c.GravarRegistro(ICliente_Ent_c usuario)
        {
            throw new NotImplementedException();
        }

        bool ICliente_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out ICliente_Ent_c[] ListaRegistro)
        {
            throw new NotImplementedException();
        }

        bool ICliente_c.NovoRegistro(out ICliente_Ent_c usuario)
        {
            throw new NotImplementedException();
        }

        bool ICliente_c.SelecionaRegistro(object _Selecionado)
        {
            System.Windows.Forms.DataGridViewSelectedRowCollection rowCollection = _Selecionado as System.Windows.Forms.DataGridViewSelectedRowCollection;
            _FocusRegistro = new Beta.Cliente_Ent_b()
            {
                _Id_Cliente = rowCollection[0].Cells[0].Value.ToString(),
                _Cpf_Cnpj = rowCollection[0].Cells[1].Value.ToString(),
                _NomeCompleto_Razao = rowCollection[0].Cells[2].Value.ToString(),
                _Tipo = rowCollection[0].Cells[3].Value.ToString(),
                _Fornecedor = (bool)rowCollection[0].Cells[4].Value
            };
            return true;
        }

        internal static class ListMsg
        {

            public const string msg001 = "Lista REgistro vazio";
            public const string msg002 = "Registro SAlvo";
        }
    }
}
