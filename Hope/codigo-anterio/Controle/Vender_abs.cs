
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
    abstract class Vender_abs : IVender_c
    {
        void teste()
        {
            Caixa_abs caixa = new Caixa_b();
            Caixa_b caixa_ = new Caixa_b();
            caixa.teste3();
            caixa.teste4();
            caixa_.teste3();
            caixa_.teste4();
            Hope_c.caixa.teste3();
            Hope_c.caixa.teste4();
        }
        //internal Vender_Ent_abs _FocusRegistro;
        //internal Vender_Ent_abs _NovoRegistro;
        //internal Vender_Item_abs _Item;
        //internal Vender_Pagar_abs _Pagar;
        //protected abstract bool novo_insert_registro();
        //protected abstract bool gravar_updade_registro();
        //protected abstract bool fechar_updade_registro();
        //protected abstract bool select_all_from(out Entidade.IVender_Ent_c[] listaregistro);
        //internal bool _novoresgistrocupom()
        //{
            
        //    _NovoRegistro.Clea();
        //    _NovoRegistro._ID_Caixa = Hope.caixa._MeuCaixa._ID_Caixa;
        //    _NovoRegistro._ID_Colaborador = Hope.colaborador._Logado._ID_Colaborador;
        //    _NovoRegistro._Status = ListEnum.TipoStatusCupom.Aberto;
        //    _NovoRegistro._Dia_Hora_Abertura = DateTime.Now.ToString();
        //    _NovoRegistro._ID_Comprador = 1;
        //    return novo_insert_registro();
        //}
        //internal bool gravaregistro()
        //{
        //    return gravar_updade_registro();
        //}
        //internal bool _finalizarregistro()
        //{
        //    _FocusRegistro._Dia_Hora_Fechamento = DateTime.Now.ToString();
        //    _FocusRegistro._Status = ListEnum.TipoStatusCupom.Finalizado;
        //    if (fechar_updade_registro())
        //    {
        //        Hope.caixa.pagamento();
        //        return true;

        //    }
        //    else
        //    {

        //        return false;
        //    }
        //}
        //IInformacao_c IVender_c.Informacao => Hope.informacao;

        //IVender_Ent_c IVender_c.FocusEntidade => _FocusRegistro;

        //IVender_Item_c IVender_c.Item => _Item;

        //IVender_Pagar_c IVender_c.Pagar => _Pagar;

        //bool IVender_c.FinalizarRegistro()
        //{
        //    if (Hope.colaborador.Autenticado)
        //    {
        //        if (_FocusRegistro._Status == ListEnum.TipoStatusCupom.Finalizado)
        //        {
        //            Hope.informacao.Add("000", "Cupom em Cache esta finalizado");
        //            return false;
        //        }
        //        else
        //        {
        //            return _finalizarregistro();
        //        }
        //    }
        //    else
        //    {
        //        Hope.informacao.Add("000", "Voce nao esta logado");
        //        return false;
        //    }
        //    throw new NotImplementedException();
        //}

        //bool IVender_c.GravarEstadoRegistro()
        //{
        //    if (Hope.colaborador.Autenticado)
        //    {
        //        return gravaregistro();
        //    }
        //    else
        //    {
        //        Hope.informacao.Add("000", "Voce nao esta logado");
        //        return false;
        //    }
        //}


        //bool IVender_c.NovoRegistro()
        //{
        //    if (Hope.colaborador.Autenticado)
        //    {
        //        return _novoresgistrocupom();
        //    }
        //    else
        //    {
        //        Hope.informacao.Add("000", "Voce nao esta logado");
        //        return false;
        //    }
        //}
        //bool IVender_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out IVender_Ent_c[] ListaRegistro)
        //{
        //    if (Comando.Contains(ListEnum.ComandoConsulta.Selec_All_From.ToString()))
        //    {
        //        return select_all_from(out ListaRegistro);
        //    }
        //    else
        //    {
        //        ListaRegistro = new Vender_Ent_abs[0];
        //        return false;
        //    }
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
