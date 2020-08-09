using Hope.Contrato;
using Hope.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Vender_b : Vender_abs
    {
        public Vender_b()
        {
            _NovoRegistro = new Vender_Ent_b();
            _FocusRegistro = new Vender_Ent_b();
            _Item = new Vender_Item_b();
            _Pagar = new Vender_Pagar_b();
        }
        protected override bool fechar_updade_registro()
        {
            if (Hope.localSet.Vender.Count != 0)
            {
                foreach (HopeDataSet.VenderRow item in Hope.localSet.Vender.Select("ID_Vender =" + _FocusRegistro._ID_Vender + " "))
                {
                    item.Dia_Hora_Fechamento = _FocusRegistro._Dia_Hora_Fechamento;
                    item.Condicao = _FocusRegistro._Status;
                    item.Item=this._Item.Serial();
                    item.Pagar = this._Pagar.Serial();
                    Hope.informacao.Add("000", " Registro Salvo");
                    return true;
                }
                Hope.informacao.Add("000", " erro registro nao localizado");
                return false;
            }
            else
            {
                Hope.informacao.Add("000", " erro Cupom Count 0");
                return false;
            }
        }
        /// local que vai pegar o dados em focus e salva 
        /// tipo cupom dados focus
        ///     item dados lista hopedataset
        ///     pagar dados focus
        protected override bool gravar_updade_registro()
        {
            if (Hope.localSet.Vender.Count != 0)
            {
                foreach (HopeDataSet.VenderRow item in Hope.localSet.Vender.Select("ID_Cupom =" + _FocusRegistro._ID_Vender + " "))
                {
                    item.ID_Caixa = _FocusRegistro._ID_Caixa;
                    item.ID_Colaborado = _FocusRegistro._ID_Colaborador;
                    item.ID_Comprador = _FocusRegistro._ID_Comprador;
                    item.Dia_Hora_Abertura = _FocusRegistro._Dia_Hora_Abertura;
                    item.Condicao = _FocusRegistro._Status;
                    item.Item = this._Item.Serial();
                    item.Pagar = this._Pagar.Serial();
                    item.Total = _FocusRegistro._Total;
                    Hope.informacao.Add("000", " Registro Salvo");
                    return true;
                }
                Hope.informacao.Add("000", " erro registro nao localizado");
                return false;
            }
            else
            {
                Hope.informacao.Add("000", " erro Cupom Count 0");
                return false;
            }
        }

        protected override bool novo_insert_registro()
        {
            try
            {
                HopeDataSet.VenderRow row = Hope.localSet.Vender.NewVenderRow();
                row.ID_Caixa = _NovoRegistro._ID_Caixa;
                row.ID_Colaborado = _NovoRegistro._ID_Colaborador;
                row.ID_Comprador = _NovoRegistro._ID_Comprador;
                row.Dia_Hora_Abertura = _NovoRegistro._Dia_Hora_Abertura;
                row.Condicao = _NovoRegistro._Status;
                Hope.localSet.Vender.Rows.Add(row);
                row = Hope.localSet.Vender.Rows[Hope.localSet.Vender.Count - 1] as HopeDataSet.VenderRow;
                _FocusRegistro._ID_Vender = row.ID_Vender;
                _FocusRegistro._ID_Caixa = row.ID_Caixa;
                _FocusRegistro._ID_Colaborador = row.ID_Colaborado;
                _FocusRegistro._ID_Comprador = row.ID_Comprador;
                _FocusRegistro._Dia_Hora_Abertura = row.Dia_Hora_Abertura;
                _FocusRegistro._Status = (ListEnum.TipoStatusCupom)row.Condicao;
                _NovoRegistro.Clea();
                Hope.informacao.Add("000", "Registro Salvo");
                return true;
            }
            catch (Exception e)
            {

                Hope.informacao.Add("000", e.Message);
                Hope.informacao.Add("000", "erro cria novo registro Cupom");
                return false;
            }
        }

        protected override bool select_all_from( out Entidade.IVender_Ent_c[] listaregistro)
        {
            if (Hope.localSet.Vender.Count!=0)
            {
                List<Entidade.IVender_Ent_c> vender_s = new List<Entidade.IVender_Ent_c>();
                foreach (HopeDataSet.VenderRow item in Hope.localSet.Vender.Rows)
                {
                    vender_s.Add(
                        new Vender_Ent_b(
                            item.ID_Vender,
                            item.ID_Caixa,
                            item.ID_Colaborado,
                            item.ID_Comprador,
                            item.Total,
                            item.Dia_Hora_Abertura,
                            item.Dia_Hora_Fechamento,
                            item.Condicao
                            ));
                }
                listaregistro = vender_s.ToArray();
                return true;
            }
            else
            {
                listaregistro = new Vender_Ent_b[0];
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
