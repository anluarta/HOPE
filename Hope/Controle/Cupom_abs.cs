
using Hope.Contrato;
using Hope.Controle;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Cupom_abs : Contrato.ICupom_c
    {
        internal Cupom_Ent_abs _FocusRegistro;
        internal Cupom_Ent_abs _NovoRegistro;
        internal Cupom_Item_abs _Item;
        internal Cupom_Pagar_abs _Pagar;
        protected abstract bool novo_insert_registro();
        protected abstract bool fechar_updade_registro();
        internal bool _novoresgistrocupom()
        {
            _NovoRegistro.Clea();
            _NovoRegistro._ID_Caixa = Hope.caixa._MeuCaixa._ID_Caixa;
            _NovoRegistro._ID_Usuario = Hope.usuario._Logado._ID_Usuario;
            _NovoRegistro._Status = ListEnum.TipoStatusCupom.Aberto;
            _NovoRegistro._Dia_Hora_Abertura = DateTime.Now.ToString();
            return novo_insert_registro();
        }
        internal bool _finalizarregistro()
        {
            _FocusRegistro._Dia_Hora_Fechamento = DateTime.Now.ToString();
            _FocusRegistro._Status = ListEnum.TipoStatusCupom.Finalizado;
            return fechar_updade_registro();
        }
        IInformacao_c ICupom_c.Informacao => Hope.informacao;

        ICupom_Ent_c ICupom_c.FocusEntidade => _FocusRegistro;

        ICupom_Item_c ICupom_c.Item => _Item;

        ICupom_Pagar_c ICupom_c.Pagar => _Pagar;

        bool ICupom_c.FinalizarRegistro()
        {
            if (Hope.usuario._Logado.Autenticado)
            {
                if (_FocusRegistro._Status == ListEnum.TipoStatusCupom.Finalizado)
                {
                    Hope.informacao.Add("000", "Cupom em Cache esta finalizado");
                    return false;
                }
                else
                {
                    return _finalizarregistro();
                }
            }
            else
            {
                Hope.informacao.Add("000", "Voce nao esta logado");
                return false;
            }
            throw new NotImplementedException();
        }

        bool ICupom_c.GravarEstadoRegistro()
        {

            throw new NotImplementedException();
        }


        bool ICupom_c.NovoRegistro()
        {
            if (Hope.usuario._Logado.Autenticado)
            {
                return _novoresgistrocupom();
            }
            else
            {
                Hope.informacao.Add("000", "Voce nao esta logado");
                return false;
            }
        }
        //bool ICupom_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out ICupom_Ent_c[] ListaRegistro)
        //{
        //    throw new NotImplementedException();
        //}

        //bool ICupom_c.SelecionaRegistro(object _Selecionado)
        //{
        //    throw new NotImplementedException();
        //}

        //bool ICupom_c.VerRegistro(object selectIten, out ICupom_Ent_c cupom, out ICupomCliente_Ent_c cliente, out ICupomItem_Ent_c[] item, out ICupomPagar_Ent_c pagar)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
