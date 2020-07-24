using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    class Vender_Ent_abs : IVender_Ent_c
    {
        internal int _ID_Vender;
        internal int _ID_Caixa ;
        internal int _ID_Colaborador ;
        internal int _ID_Comprador ;
        internal string _Dia_Hora_Abertura ;
        internal string _Dia_Hora_Fechamento ;
        internal ListEnum.TipoStatusCupom _Status ;
        int IVender_Ent_c.ID_Vender => _ID_Vender;
        int IVender_Ent_c.ID_Caixa => _ID_Caixa;
        int IVender_Ent_c.ID_Comprador => _ID_Comprador;
        string IVender_Ent_c.Dia_Hora_Abertura => _Dia_Hora_Abertura;
        string IVender_Ent_c.Dia_Hora_Fechamento => _Dia_Hora_Fechamento;
        int IVender_Ent_c.ID_Colaborador => _ID_Colaborador;

        public void Clea()
        {
            _Dia_Hora_Abertura = string.Empty;
            _Dia_Hora_Fechamento = string.Empty;
            _ID_Vender = 0;
            _ID_Caixa = 0;
            _ID_Colaborador = 0;
            _ID_Comprador = 0;
        }
        internal bool Set_Status(string valor)
        {
            try
            {
                if (valor.Equals(ListEnum.TipoStatusCupom.Aberto.ToString()))
                {
                    _Status = ListEnum.TipoStatusCupom.Aberto;
                    return true;
                }
                else if (valor.Equals(ListEnum.TipoStatusCupom.Espera.ToString()))
                {
                    _Status = ListEnum.TipoStatusCupom.Espera;
                    return true;
                }
                else if (valor.Equals(ListEnum.TipoStatusCupom.Finalizado.ToString()))
                {
                    _Status = ListEnum.TipoStatusCupom.Finalizado;
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception e)
            {
                Hope.informacao.Add("000", e.Message);
                Hope.informacao.Add("000", "Erro Set_Status");
                return false;
            }
        }
    }
}
