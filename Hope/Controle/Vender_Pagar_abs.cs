using Hope.Beta;
using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
   abstract class Vender_Pagar_abs : Contrato.IVender_Pagar_c
    {
        internal Controle.Vender_Pagar_Ent_abs _NovoRegistro;
        protected abstract bool novo_insert_resgistro();
        internal string Serial()
        {
            try
            {
               
                var xmlserializer = new System.Xml.Serialization.XmlSerializer(typeof(Vender_Pagar_Ent_b));
                var stringWriter = new System.IO.StringWriter();
                using (var writer = System.Xml.XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, _NovoRegistro);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }
        IInformacao_c IVender_Pagar_c.Informacao => Hope.informacao;
        IVender_Pagar_Ent_c IVender_Pagar_c.FocusEntidade => _NovoRegistro;
        bool IVender_Pagar_c.GravarRegistro(IVender_Pagar_Ent_c pagar)
        {
            if (Hope.colaborador.Autenticado)
            {
                _NovoRegistro = pagar as Controle.Vender_Pagar_Ent_abs;
                // outros tipos de if pra validar na etapa ALFA
                return true;
            }
            else
            {
                Hope.informacao.Add("000", "Nao esta logado pra executa");
                return false;
            }
        }

        bool IVender_Pagar_c.NovoRegistro(out IVender_Pagar_Ent_c pagar)
        {
            if (Hope.colaborador.Autenticado)
            {
                // outros tipos de if pra validar na etapa ALFA
                pagar = _NovoRegistro;
                return true;
            }
            else
            {
                Hope.informacao.Add("000", "Nao esta logado pra executa");
                pagar = null;
                return false;
            }
        }
    }
}
