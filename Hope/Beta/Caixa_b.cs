using Hope.Contrato;
using Hope.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hope.Beta
{
    class Caixa_b : Controle.Caixa_abs
    {
        public Caixa_b()
        {
            _MeuCaixa = new Beta.Caixa_Ent_b();
            _MeuTotalCaixa = new Beta.CaixaTotal_Ent_b();
            _Recebimento = new Beta.Recebimento_b();
        }

        protected override bool MeuCaixa_Insert_Registro()
        {
            HopeDataSet.CaixaRow row = Hope.localSet.Caixa.NewCaixaRow();
            row.ID_Usuario = Hope.usuario._Logado._ID_Usuario;
            row.Abertura = DateTime.Now.ToString();
            Hope.localSet.Caixa.Rows.Add(row);
            _MeuCaixa = new Caixa_Ent_b() { _ID_Caixa = row.ID_Caixa, _Fk_ID_Usuario = row.ID_Usuario, _Abertura = row.Abertura };
            return true;
            throw new NotImplementedException();
        }

        protected override bool meucaixaaberto()
        {
            return false;
        }

        protected override bool MeuCaixa_Update_Registro()
        {
            if (Hope.localSet.Caixa.Count != 0)
            {
                for (int i = 0; i < Hope.localSet.Caixa.Count; i++)
                {
                    if (Hope.localSet.Caixa.Rows[i][Hope.localSet.Caixa.ID_CaixaColumn].ToString().Equals(_MeuCaixa._ID_Caixa))
                    {
                        Hope.localSet.Caixa.Rows[i][Hope.localSet.Caixa.FechamentoColumn] = DateTime.Now.ToString();
                        Hope.informacao.Add("000", "Linha registro alteradok");
                        _MeuCaixa.Clea();
                        return true;

                    }
                }
                Hope.informacao.Add("000", "Nao existe linha para ser alterado");

                return false;
            }
            else
            {
                Hope.informacao.Add("000", "Nao existe Linha registro no CAixa");
                return false;
            }
            throw new NotImplementedException();
        }

        protected override bool Reforco_Insert_Registrp(string valor, string observacao)
        {
            try
            {
                HopeDataSet.Caixa_ReforcoRow row = Hope.localSet.Caixa_Reforco.NewCaixa_ReforcoRow();
                row.ID_Caixa = _MeuCaixa._ID_Caixa;
                row.ID_Usuario = Hope.usuario._Logado._ID_Usuario;
                row.Data = DateTime.Now.ToString();
                row.Valor = valor;
                row.Observacao = observacao;
                Hope.localSet.Caixa_Reforco.Rows.Add(row);
                Hope.informacao.Add("000", "Registro salvo");
                return true;
            }
            catch (Exception e)
            {
                Hope.informacao.Add("000", e.Message);
                return false;
            }
        }

        protected override bool Sangria_Insert_Registrp(string valor, string observacao)
        {
            try
            {
                HopeDataSet.Caixa_SangriaRow row = Hope.localSet.Caixa_Sangria.NewCaixa_SangriaRow();
                row.ID_Caixa = _MeuCaixa._ID_Caixa;
                row.ID_Usuario = Hope.usuario._Logado._ID_Usuario;
                row.Data = DateTime.Now.ToString();
                row.Valor = valor;
                row.Observacao = observacao;
                Hope.localSet.Caixa_Sangria.Rows.Add(row);
                Hope.informacao.Add("000", "Registro salvo");
                return true;
            }
            catch (Exception e)
            {
                Hope.informacao.Add("000", e.Message);
                return false;
            }
        }
    }
}
