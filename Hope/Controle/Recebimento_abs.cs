using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Recebimento_abs : Contrato.IRecebimento_c
    {
        //internal Recebimento_Ent_abs _NovoRegistro;
        //internal Recebimento_Ent_abs _FocusRegistro;
        //protected abstract bool novo_insert_regsitro();
        //internal void gravaregistro()
        //{
        //    novo_insert_regsitro();
        //}
        //IInformacao_c IRecebimento_c.Informacao => Hope.informacao;

        //Entidade.IRecebimento_Ent_c IRecebimento_c.FocusEntidade => _FocusRegistro;

        //string IRecebimento_c.Cliente => _NovoRegistro._Cliente;

        //string IRecebimento_c.Cliente_Conta_Valor => _NovoRegistro._Cliente_Conta_Valor;

        //bool IRecebimento_c.AdicionarCliente()
        //{
        //    if (Hope.cliente._FocusRegistro._Conta_Cliente)
        //    {
        //        _NovoRegistro._ID_Cliente = Hope.cliente._FocusRegistro._Id_Cliente;
        //        _NovoRegistro._Cliente = Hope.cliente._FocusRegistro._NomeCompleto_Razao;
        //        _NovoRegistro._Cliente_Conta_Valor = "0,00";
        //        return true;
        //    }
        //    else
        //    {
        //        Hope.informacao.Add("000", "Conta Cliente nao ativa");
        //        return false; 
        //    }
        //}

        //bool IRecebimento_c.GravarRegistro(Entidade.IRecebimento_Ent_c usuario)
        //{
        //    throw new NotImplementedException();
        //}

        //bool IRecebimento_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out Entidade.IRecebimento_Ent_c[] ListaRegistro)
        //{
        //    throw new NotImplementedException();
        //}

        //bool IRecebimento_c.NovoRegistro(out Entidade.IRecebimento_Ent_c usuario)
        //{
        //    throw new NotImplementedException();
        //}

        //bool IRecebimento_c.SelecionaRegistro(object _Selecionado)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
