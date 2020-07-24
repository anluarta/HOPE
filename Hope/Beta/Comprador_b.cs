using Hope.Contrato;
using Hope.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Beta
{
    class Comprador_b : Comprador_abs
    {
        public Comprador_b()
        {
            _AlteraRegistro = new Comprador_Ent_b();
            _NovoRegistro = new Comprador_Ent_b();
            _FocusRegistro = new Comprador_Ent_b();
        }

        protected override bool focus_update_registro()
        {
            try
            {
                for (int i = 0; i < Hope.localSet.Comprador.Count; i++)
                {
                    HopeDataSet.CompradorRow comprador = Hope.localSet.Comprador.Rows[i] as HopeDataSet.CompradorRow;
                    if (_FocusRegistro._Id_Comprador == comprador.ID_Comprador)
                    {
                        comprador.Numero_Registro = _AlteraRegistro._Numero_Registro;
                        comprador.NomeCompleto_RazaoSocial = _AlteraRegistro._NomeCompleto_RazaoSocial;
                        comprador.Tipo_Registro = _AlteraRegistro._Tipo.ToString();

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

            throw new NotImplementedException();
        }

        protected override bool novo_insert_registro()
        {
            HopeDataSet.CompradorRow comprador = Hope.localSet.Comprador.NewCompradorRow();
            comprador.Numero_Registro = _NovoRegistro._Numero_Registro;
            comprador.NomeCompleto_RazaoSocial = _NovoRegistro._NomeCompleto_RazaoSocial;
            comprador.Tipo_Registro = _NovoRegistro._Tipo.ToString();
            Hope.localSet.Comprador.Rows.Add(comprador);
            return true;
        }

        protected override bool select_all_from(out Entidade.IComprador_Ent_c[] listaressultado)
        {
            if (Hope.localSet.Comprador.Count != 0)
            {
                List<Entidade.IComprador_Ent_c> comprador_Ents = new List<Entidade.IComprador_Ent_c>();
                for (int i = 0; i < Hope.localSet.Comprador.Count; i++)
                {
                    comprador_Ents.Add(new Beta.Comprador_Ent_b()
                    {
                        _Id_Comprador = (int)Hope.localSet.Comprador.Rows[i]
                        [Hope.localSet.Comprador.ID_CompradorColumn],
                        _Numero_Registro = Hope.localSet.Comprador.Rows[i]
                        [Hope.localSet.Comprador.Numero_RegistroColumn].ToString(),
                        _NomeCompleto_RazaoSocial = Hope.localSet.Comprador.Rows[i]
                        [Hope.localSet.Comprador.NomeCompleto_RazaoSocialColumn].ToString()
                    });
                }
                listaressultado = comprador_Ents.ToArray();
                return true;
            }
            else
            {
                listaressultado = new Comprador_Ent_abs[0];
                return false;
            }
        }
    }
}
