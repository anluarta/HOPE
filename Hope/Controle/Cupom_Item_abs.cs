using Hope.Contrato;
using Hope.Entidade;
using System;

namespace Hope.Controle
{
   abstract class Cupom_Item_abs : Contrato.ICupom_Item_c
    {
        internal Controle.Cupom_Item_Ent_abs _FocusRegistro;
        internal Controle.Cupom_Item_Ent_abs _NovoRegistro;
        protected abstract Cupom_Item_Ent_abs[] listaregistro();
        protected abstract bool novo_insert_registro();
        internal bool gravarregistro()
        {
            Hope.informacao.Add("000", "Gravar REgistro item cupom");
            return novo_insert_registro();
            throw new Exception();
        }
        IInformacao_c ICupom_Item_c.Informacao => Hope.informacao;

        ICupom_Item_Ent_c ICupom_Item_c.FocusRegistro => _FocusRegistro;

        ICupom_Item_Ent_c[] ICupom_Item_c.ListaRegistro => listaregistro();

        void ICupom_Item_c.AlteraRegistro(out ICupom_Item_Ent_c cupomItem)
        {
            throw new System.NotImplementedException();
        }

        bool ICupom_Item_c.GravaAlteracao(ICupom_Item_Ent_c cupomItem)
        {
            throw new System.NotImplementedException();
        }

        bool ICupom_Item_c.GravarRegistro(ICupom_Item_Ent_c cupomItem)
        {
            throw new System.NotImplementedException();
        }

        bool ICupom_Item_c.NovoRegistro(out ICupom_Item_Ent_c cupomItem)
        {
            throw new System.NotImplementedException();
        }

        bool ICupom_Item_c.RemoverRegistroSelecionado(object _Selecionado)
        {
            throw new System.NotImplementedException();
        }

        bool ICupom_Item_c.SelecionaRegistro(object _Selecionado)
        {
            throw new System.NotImplementedException();
        }
    }
}