﻿using Hope.Contrato;
using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hope.Controle
{
    abstract class Caixa_abs : Contrato.ICaixa_c
    {
        internal Recebimento_abs _Recebimento;
        internal Caixa_Ent_abs _MeuCaixa;
        internal CaixaTotal_Ent_abs _MeuTotalCaixa;
        protected abstract bool MeuCaixa_Insert_Registro();
        protected abstract bool MeuCaixa_Update_Registro();
        protected abstract bool meucaixaaberto();
        protected abstract bool Reforco_Insert_Registrp(string valor, string observacao);
        protected abstract bool Sangria_Insert_Registrp(string valor, string observacao);
        internal bool reforco(string valor,string observacao) 
        {
            return Reforco_Insert_Registrp(valor, observacao);
        } 
        internal bool sangria(string valor,string observacao) 
        {
            return Sangria_Insert_Registrp(valor, observacao);
        }
        internal bool iniciarmeucaixa()
        {
            if (meucaixaaberto())
            {
                Hope.informacao.Add("000", "Caixa ja aberto");
                return true;
            }
            else if (MeuCaixa_Insert_Registro())
            {
                Hope.informacao.Add("000", "CAixa iniciado");
                return true;
            }
            else
            {
                Hope.informacao.Add("000", "Erro inicarmeucaixa inserRegistro");
                return false;
            }
        }
        internal bool fecharmeucaixa()
        {
            return MeuCaixa_Update_Registro();
            throw new Exception();
        }
        IRecebimento_c Contrato.ICaixa_c.Recebimento { get => _Recebimento; }

        string Contrato.ICaixa_c.ReforcoTotal => _MeuTotalCaixa._Reforco;

        string Contrato.ICaixa_c.SangriaTotal => _MeuTotalCaixa._Sangria;

        string Contrato.ICaixa_c.DinheiroTotal => _MeuTotalCaixa._Dinheiro;

        string Contrato.ICaixa_c.DebidoTotal => _MeuTotalCaixa._Debito;

        string Contrato.ICaixa_c.CreditoTotal => _MeuTotalCaixa._Credito;

        string Contrato.ICaixa_c.ChequeTotal => _MeuTotalCaixa._Cheque;

        string Contrato.ICaixa_c.ValeAlimentacaoTotal => _MeuTotalCaixa._Vale_Alimentacao;

        string Contrato.ICaixa_c.ValeRefeicaoTotal => _MeuTotalCaixa._Vale_Refeicao;

        string Contrato.ICaixa_c.OutroTotal => _MeuTotalCaixa._Outro;

        string Contrato.ICaixa_c.ContaClienteTotal => _MeuTotalCaixa._ContaCliente;

        string Contrato.ICaixa_c.InternoTotal => _MeuTotalCaixa._Interno;

        string Contrato.ICaixa_c.RecebimentoTotal => _MeuTotalCaixa._Recebimento;

        IInformacao_c ICaixa_c.Informacao => throw new NotImplementedException();

        public bool DetalheValorTotalRegistro(DataGridViewRow dataGridViewRow, out ICaixaTotal_Ent_c totais)
        {
            //ICaixaTotal_Ent_c v = new CaixaTotal();
            //v.Cheque = "0,00";
            //v.ContaCliente = "0,00";
            //v.Credito = "0,00";
            //v.CupomCancelado = "0,00";
            //v.CupomVendido = "0,00";
            //v.Debito = "0,00";
            //v.Dinheiro = "0,00";
            //v.Interno = "0,00";
            //v.Outro = "0,00";
            //v.Recebimento = "0,00";
            //v.Reforco = "0,00";
            //v.Sangria = "0,00";
            //v.ValeAlimentacao = "0,00";
            //v.ValeRefeicao = "0,00";
            //totais = v;
            //return true;
            throw new NotImplementedException();
        }

        bool ICaixa_c.EncerrarMeuCaixa()
        {
            if (Hope.usuario._Logado.Autenticado)
            {
                return fecharmeucaixa();
            }
            else
            {
                Hope.informacao.Add("000", "Voce nao esta logado");
                return false;
            }
            throw new NotImplementedException();
        }

        bool ICaixa_c.IniciarMeuCaixa()
        {
            if (Hope.usuario._Logado.Autenticado)
            {
                return iniciarmeucaixa();
            }
            else
            {
                Hope.informacao.Add("000", "Voce nao esta logado");
                return false;
            }
        }

        bool ICaixa_c.Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out ICaixa_Ent_c[] ListaResultado)
        {
            throw new NotImplementedException();
        }

        bool ICaixa_c.Reforco(string _Valor, string _Observacao)
        {
            if (Hope.usuario._Logado.Autenticado)
            {
                return reforco(_Valor,_Observacao);
            }
            else
            {
                Hope.informacao.Add("000", "Voce nao esta logado");
                return false;
            }
            throw new NotImplementedException();
        }

        bool ICaixa_c.Sangria(string _Valor, string _Observacao)
        {
            if (Hope.usuario._Logado.Autenticado)
            {
                return sangria(_Valor, _Observacao);
            }
            else
            {
                Hope.informacao.Add("000", "Voce nao esta logado");
                return false;
            }
            throw new NotImplementedException();
        }

        bool ICaixa_c.Situacao()
        {
            throw new NotImplementedException();
        }
    }
}