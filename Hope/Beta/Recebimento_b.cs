﻿using Hope.Controle;

namespace Hope.Beta
{
     class Recebimento_b : Recebimento_abs
    {
        //public Recebimento_b()
        //{
        //    _FocusRegistro = new Recebimento_Ent_abs();
        //    _NovoRegistro = new Recebimento_Ent_abs();
        //}

        //protected override bool novo_insert_regsitro()
        //{
        //    try
        //    {
        //        HopeDataSet.RecebimentoRow row = Hope.localSet.Recebimento.NewRecebimentoRow();
        //        row.FormaRecebida = _NovoRegistro._Forma_Recebimento;
        //        row.TipoRecebimento = _NovoRegistro._Tipo_Recebimento;
        //        row.ValorRecebido = _NovoRegistro._Valor_Recebido;
        //        Hope.localSet.Recebimento.Rows.Add(row);
        //        _NovoRegistro.Clear();
        //        Hope.informacao.Add("000", "recebimento insertregistro sucesso");
        //        return true;
        //    }
        //    catch (System.Exception e)
        //    {
        //        Hope.informacao.Add("000", e.Message);
        //        return false;
        //    }
        //}

    }
}