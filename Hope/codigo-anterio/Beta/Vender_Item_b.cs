using Hope.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Vender_Item_b : Controle.Vender_Item_abs
    {
        //public Vender_Item_b()
        //{
        //    _NovoRegistro = new Vender_Item_Ent_b();
        //    _FocusRegistro = new Vender_Item_Ent_b();

        //}
        //protected override bool listaregistro(out Entidade.IVender_Item_Ent_c[] data)
        //{
        //    if (Hope.localSet.Item.Count != 0)
        //    {
        //        List<Vender_Item_Ent_b> aItem = new List<Vender_Item_Ent_b>();
        //        foreach (HopeDataSet.ItemRow item in Hope.localSet.Item.Rows)
        //        {
        //            aItem.Add(new Vender_Item_Ent_b()
        //            {
        //                _ID_Item = item.ID_Item,
        //                _Codigo = item.Codigo,
        //                _Descricao = item.Descricao,
        //                _Unidade = item.Unidade,
        //                _Quantidade = item.Quantidade,
        //                _Preco = item.Preco,

        //            });
        //        }
        //        data = aItem.ToArray();
        //        return true;
        //    }
        //    else
        //    {
        //        Hope.informacao.Add("000", "Nao existe linha de registro no CupomItem");
        //        data = new Vender_Item_Ent_abs[0];
        //        return false;
        //    }
        //}

        //protected override bool novo_insert_registro()
        //{
        //    try
        //    {
        //        HopeDataSet.ItemRow row = Hope.localSet.Item.NewItemRow();
        //        row.Codigo = _NovoRegistro._Codigo;
        //        row.Descricao = _NovoRegistro._Descricao;
        //        row.Unidade = _NovoRegistro._Unidade;
        //        row.Quantidade = _NovoRegistro._Quantidade;
        //        row.Preco = _NovoRegistro._Preco;
        //        Hope.localSet.Item.Rows.Add(row);
        //        _NovoRegistro.Clea();
        //        Hope.informacao.Add("000", "Gravar REgistro item cupom");
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Hope.informacao.Add("000", e.Message);
        //        Hope.informacao.Add("000", "Erro na gravacao do registro de item");
        //        return false;

        //    }

        //}
    }
}
