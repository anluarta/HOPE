using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    class Cupom_Ent_abs : Entidade.ICupom_Ent_c
    {
        internal string _ID_Cupom { get; set; }
        internal string _ID_Caixa { get; set; }
        internal string _ID_Usuario { get; set; }
        internal string _Dia_Hora_Abertura { get; set; }
        internal string _Dia_Hora_Fechamento { get; set; }
        internal string _Cliente { get; set; }
        internal string _ID_Cliente { get; set; }
        internal ListEnum.TipoStatusCupom _Status { get;  set; }
        string ICupom_Ent_c.ID_Cupom => _ID_Cupom;
        string ICupom_Ent_c.ID_Caixa => _ID_Caixa;
        string ICupom_Ent_c.ID_Usuario => _ID_Usuario;
        string ICupom_Ent_c.Dia_Hora_Abertura => _Dia_Hora_Abertura;
        string ICupom_Ent_c.Dia_Hora_Fechamento => _Dia_Hora_Fechamento;
        string ICupom_Ent_c.Cliente => _Cliente;

        public void Clea()
        {
            _Dia_Hora_Abertura = string.Empty;
            _Dia_Hora_Fechamento = string.Empty;
            _ID_Cupom = string.Empty;
            _ID_Caixa = string.Empty;
            _ID_Usuario = string.Empty;
            _Cliente = string.Empty;
            _ID_Cliente = string.Empty;
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
                Hope.informacao.Add("000", "Erro Set_Status");
                return false;
            }
        }
    }
}
