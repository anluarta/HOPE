using Hope.Contrato;
using Hope.Entidade;
using System;

namespace Hope.Controle
{
    abstract class Vender_Item_abs : Contrato.IVender_Item_c
    {
        internal Controle.Vender_Item_Ent_abs _FocusRegistro;
        internal Controle.Vender_Item_Ent_abs _NovoRegistro;
        protected abstract bool listaregistro(out IVender_Item_Ent_c[] data);
        protected abstract bool novo_insert_registro();
        internal bool gravarregistro()
        {
            return novo_insert_registro();
            throw new Exception();
        }
        internal string Serial()
        {
            try
            {
                var stringWriter = new System.IO.StringWriter();
                Hope.localSet.Item.WriteXml(stringWriter);
                return stringWriter.ToString();
            }
            catch (Exception ex)
            {
                Hope.informacao.Add("000", ex.Message);
                return "";
            }
        }
        IInformacao_c IVender_Item_c.Informacao => Hope.informacao;

        IVender_Item_Ent_c IVender_Item_c.FocusRegistro => _FocusRegistro;

        IVender_Item_Ent_c[] IVender_Item_c.ListaRegistro
        {
            get
            {
                if (listaregistro(out IVender_Item_Ent_c[] data))
                {
                    return data;
                }
                else
                {
                    data = new Vender_Item_Ent_abs[0];
                    return data;
                }
            }
        }

        void IVender_Item_c.AlteraRegistro(out IVender_Item_Ent_c cupomItem)
        {
            throw new System.NotImplementedException();
        }

        bool IVender_Item_c.GravaAlteracao(IVender_Item_Ent_c cupomItem)
        {
            throw new System.NotImplementedException();
        }

        bool IVender_Item_c.GravarRegistro(IVender_Item_Ent_c cupomItem)
        {
            throw new System.NotImplementedException();
        }

        bool IVender_Item_c.NovoRegistro(out IVender_Item_Ent_c cupomItem)
        {
            throw new System.NotImplementedException();
        }

        bool IVender_Item_c.RemoverRegistroSelecionado(object _Selecionado)
        {
            throw new System.NotImplementedException();
        }

        bool IVender_Item_c.SelecionaRegistro(object _Selecionado)
        {
            throw new System.NotImplementedException();
        }
    }
}