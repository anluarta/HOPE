using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteHope.View;

namespace TesteHope
{
    static class Program
    {
        internal static List<string> Vs;
        internal static Hope.IHope ObjHope;

        internal static Hope.Interface.ICaixa_e CaixaOperacao;
        internal static Hope.Interface.IVender_e Vender;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPOSFull());
        }
        static bool preloadexecutado = false;
        internal static void PreLoadHope()
        {
            if (preloadexecutado)
            {
                return;
            }
            else
            {
                preloadexecutado = true;
                Vs = new List<string>();
                // etapa a ser criadas
                // login,caixa novo,suprimento novo,venda novo,item novo,pagar novo,venda finaliza,caixa add venda,caixa fechamento
                #region Acao_1_Usuario_DEMO
                Vs.Add(">>Acao_1_Usuario_DEMO" + Environment.NewLine);
                // abre o login com o usuario Demo
                if (ObjHope.Autenticacao.Login(User: "Demo", Pass: "Demo"))
                {
                    Vs.Add(ObjHope.Autenticacao.Notifica());
                    // abre o novo registro caixa do usuario demo
                    if (ObjHope.Pos.Caixa.Novo(out CaixaOperacao))
                    {
                        Vs.Add(ObjHope.Pos.Caixa.Notifica());

                        // abre novo resgirto para dar suprimento ao caixa do usuario demo
                        if (ObjHope.Pos.Caixa.Suprimento_Novo(CaixaOperacao, out ISuprimento_e suprimento_))
                        {
                            Vs.Add(ObjHope.Pos.Caixa.Notifica());

                            // coloca os valores do suprimento para ser validado
                            if (suprimento_.Set_Valor("102,50") & suprimento_.Set_Observacao("Abertura caixa"))
                            {
                                Vs.Add(suprimento_.Notifica());

                                // adiciona o registro suprimento ao caixa 
                                if (CaixaOperacao.Add(suprimento_))
                                {
                                    Vs.Add(CaixaOperacao.Notifica());

                                    // grava o registro do caixa apos ter o valor de suprimento adicionado ao caixa 
                                    if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                    {
                                        Vs.Add(ObjHope.Pos.Caixa.Notifica());

                                        // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                        CaixaOperacao = caixa_;
                                    }
                                    else
                                    {
                                        Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(CaixaOperacao.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(suprimento_.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                        }
                        #region VendaPagamentoDinheiro
                        Vs.Add("Venda Pagamento Dinheiro 1 item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento dinheiro
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());

                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Dinheiro("10,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());

                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoDebito
                        Vs.Add("Venda Pagamento Debito 1 item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento debido
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Debito("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoCredito
                        Vs.Add("Venda Pagamento Credito 1 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Credito
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Credito("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoCheque
                        Vs.Add("Venda Pagamento Cheque 1 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Cheque
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em cheque
                                if (pagar_.Set_Cheque("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoValeAlimentacao
                        Vs.Add("Venda Pagamento vale Alimentacao 1 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Vale Alimentacao
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em Vale Alimentacao
                                if (pagar_.Set_Vale_Alimentacao("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoValeREfeicao
                        Vs.Add("Venda Pagamento Vale Refeicao 1 Item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Vale Refeicao
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em Vale Refeicao
                                if (pagar_.Set_Vale_Refeicao("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoOutro
                        Vs.Add("Venda Pagamento Outro 1 Item");
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Outro
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em Outro
                                if (pagar_.Set_Dinheiro("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoInterno
                        Vs.Add("Venda Pagamento Interno 1 Item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Interno
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em interno
                                if (pagar_.Set_Interno("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoParcial
                        Vs.Add("Venda Pagamento Parcial 8 Item"+Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Parcial Dinheiro-Debito-Credito-Cheque-Alimentacao-Refeicao-outro-interno
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_0))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_0.Set_Descricao("teste") & item_0.Set_Quantidade("1") & item_0.Set_Unidade("Peca") & item_0.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_0.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_0))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_0.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_1))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_1.Set_Descricao("teste") & item_1.Set_Quantidade("1") & item_1.Set_Unidade("Peca") & item_1.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_1.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_1))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_1.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_2))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_2.Set_Descricao("teste") & item_2.Set_Quantidade("1") & item_2.Set_Unidade("Peca") & item_2.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_2.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_2))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_2.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_3))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_3.Set_Descricao("teste") & item_3.Set_Quantidade("1") & item_3.Set_Unidade("Peca") & item_3.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_3.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_3))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_3.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_4))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_4.Set_Descricao("teste") & item_4.Set_Quantidade("1") & item_4.Set_Unidade("Peca") & item_4.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_4.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_4))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_4.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_5))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_5.Set_Descricao("teste") & item_5.Set_Quantidade("1") & item_5.Set_Unidade("Peca") & item_5.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_5.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_5))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_5.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_6))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_6.Set_Descricao("teste") & item_6.Set_Quantidade("1") & item_6.Set_Unidade("Peca") & item_6.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_6.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_6))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_6.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_7))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_7.Set_Descricao("teste") & item_7.Set_Quantidade("1") & item_7.Set_Unidade("Peca") & item_7.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_7.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_7))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_7.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }

                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Dinheiro("5,00") & pagar_.Set_Interno("5,00") & pagar_.Set_Cheque("5,00") & pagar_.Set_Credito("5,00") & pagar_.Set_Debito("5,00") & pagar_.Set_Outro("5,00") & pagar_.Set_Vale_Alimentacao("5,00") & pagar_.Set_Vale_Refeicao("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        // fecha o registro caixa 
                        if (CaixaOperacao.Fechamento())
                        {
                            Vs.Add(CaixaOperacao.Notifica());
                            // grava o registro do caixa fechado
                            if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e result))
                            {
                                Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                CaixaOperacao = result;
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Caixa.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(CaixaOperacao.Notifica());
                        }
                    }
                    else
                    {
                        Vs.Add(ObjHope.Pos.Caixa.Notifica());
                    }
                    // fehca o login aberto do usuario demo
                    if (ObjHope.Autenticacao.Logout())
                    {
                        Vs.Add(ObjHope.Autenticacao.Notifica());
                        CaixaOperacao = null;
                        Vender = null;
                    }
                    else
                    {
                        Vs.Add(ObjHope.Autenticacao.Notifica());
                    }
                }
                else
                {
                    Vs.Add(ObjHope.Autenticacao.Notifica());
                }
                #endregion
                #region Acao2UsuarioHope2CaixaRegistrado
                Vs.Add(">>Acao 2 usuario Hope 2 registro caixa finalizado" + Environment.NewLine);

                if (ObjHope.Autenticacao.Login(User: "Hope", Pass: "Hope"))
                {
                    Vs.Add(ObjHope.Autenticacao.Notifica());
                    // abre o novo registro caixa do usuario demo
                    if (ObjHope.Pos.Caixa.Novo(out CaixaOperacao))
                    {
                        Vs.Add(ObjHope.Pos.Caixa.Notifica());

                        // abre novo resgirto para dar suprimento ao caixa do usuario demo
                        if (ObjHope.Pos.Caixa.Suprimento_Novo(CaixaOperacao, out ISuprimento_e suprimento_))
                        {
                            Vs.Add(ObjHope.Pos.Caixa.Notifica());

                            // coloca os valores do suprimento para ser validado
                            if (suprimento_.Set_Valor("102,50") & suprimento_.Set_Observacao("Abertura caixa"))
                            {
                                Vs.Add(suprimento_.Notifica());

                                // adiciona o registro suprimento ao caixa 
                                if (CaixaOperacao.Add(suprimento_))
                                {
                                    Vs.Add(CaixaOperacao.Notifica());

                                    // grava o registro do caixa apos ter o valor de suprimento adicionado ao caixa 
                                    if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                    {
                                        Vs.Add(ObjHope.Pos.Caixa.Notifica());

                                        // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                        CaixaOperacao = caixa_;
                                    }
                                    else
                                    {
                                        Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(CaixaOperacao.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(suprimento_.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                        }
                        #region VendaPagamentoDinheiro
                        Vs.Add("Venda Pagamento Dinheiro 1 item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento dinheiro
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());

                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Dinheiro("10,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());

                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoDebito
                        Vs.Add("Venda Pagamento Debito 1 item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento debido
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Debito("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoCredito
                        Vs.Add("Venda Pagamento Credito 1 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Credito
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Credito("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoCheque
                        Vs.Add("Venda Pagamento Cheque 1 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Cheque
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em cheque
                                if (pagar_.Set_Cheque("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoValeAlimentacao
                        Vs.Add("Venda Pagamento vale Alimentacao 1 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Vale Alimentacao
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em Vale Alimentacao
                                if (pagar_.Set_Vale_Alimentacao("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoValeREfeicao
                        Vs.Add("Venda Pagamento Vale Refeicao 1 Item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Vale Refeicao
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em Vale Refeicao
                                if (pagar_.Set_Vale_Refeicao("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoOutro
                        Vs.Add("Venda Pagamento Outro 1 Item");
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Outro
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em Outro
                                if (pagar_.Set_Dinheiro("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoInterno
                        Vs.Add("Venda Pagamento Interno 1 Item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Interno
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em interno
                                if (pagar_.Set_Interno("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoParcial
                        Vs.Add("Venda Pagamento Parcial 8 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Parcial Dinheiro-Debito-Credito-Cheque-Alimentacao-Refeicao-outro-interno
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_0))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_0.Set_Descricao("teste") & item_0.Set_Quantidade("1") & item_0.Set_Unidade("Peca") & item_0.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_0.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_0))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_0.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_1))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_1.Set_Descricao("teste") & item_1.Set_Quantidade("1") & item_1.Set_Unidade("Peca") & item_1.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_1.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_1))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_1.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_2))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_2.Set_Descricao("teste") & item_2.Set_Quantidade("1") & item_2.Set_Unidade("Peca") & item_2.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_2.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_2))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_2.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_3))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_3.Set_Descricao("teste") & item_3.Set_Quantidade("1") & item_3.Set_Unidade("Peca") & item_3.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_3.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_3))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_3.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_4))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_4.Set_Descricao("teste") & item_4.Set_Quantidade("1") & item_4.Set_Unidade("Peca") & item_4.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_4.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_4))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_4.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_5))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_5.Set_Descricao("teste") & item_5.Set_Quantidade("1") & item_5.Set_Unidade("Peca") & item_5.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_5.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_5))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_5.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_6))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_6.Set_Descricao("teste") & item_6.Set_Quantidade("1") & item_6.Set_Unidade("Peca") & item_6.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_6.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_6))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_6.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_7))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_7.Set_Descricao("teste") & item_7.Set_Quantidade("1") & item_7.Set_Unidade("Peca") & item_7.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_7.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_7))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_7.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }

                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Dinheiro("5,00") & pagar_.Set_Interno("5,00") & pagar_.Set_Cheque("5,00") & pagar_.Set_Credito("5,00") & pagar_.Set_Debito("5,00") & pagar_.Set_Outro("5,00") & pagar_.Set_Vale_Alimentacao("5,00") & pagar_.Set_Vale_Refeicao("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        // fecha o registro caixa 
                        if (CaixaOperacao.Fechamento())
                        {
                            Vs.Add(CaixaOperacao.Notifica());
                            // grava o registro do caixa fechado
                            if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e result))
                            {
                                Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                CaixaOperacao = result;
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Caixa.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(CaixaOperacao.Notifica());
                        }
                    }
                    else
                    {
                        Vs.Add(ObjHope.Pos.Caixa.Notifica());
                    }
                    // fehca o login aberto do usuario demo
                    if (ObjHope.Autenticacao.Logout())
                    {
                        Vs.Add(ObjHope.Autenticacao.Notifica());
                        CaixaOperacao = null;
                        Vender = null;
                    }
                    else
                    {
                        Vs.Add(ObjHope.Autenticacao.Notifica());
                    }
                }
                else
                {
                    Vs.Add(ObjHope.Autenticacao.Notifica());
                }
                #endregion
                #region Acao3UsuarioDemoCaixaNaoFinalizado
                Vs.Add(">>Acao 3 usuario demo caixa nao finalizado" + Environment.NewLine);

                if (ObjHope.Autenticacao.Login(User: "Demo", Pass: "Demo"))
                {
                    Vs.Add(ObjHope.Autenticacao.Notifica());
                    // abre o novo registro caixa do usuario demo
                    if (ObjHope.Pos.Caixa.Novo(out CaixaOperacao))
                    {
                        Vs.Add(ObjHope.Pos.Caixa.Notifica());

                        // abre novo resgirto para dar suprimento ao caixa do usuario demo
                        if (ObjHope.Pos.Caixa.Suprimento_Novo(CaixaOperacao, out ISuprimento_e suprimento_))
                        {
                            Vs.Add(ObjHope.Pos.Caixa.Notifica());

                            // coloca os valores do suprimento para ser validado
                            if (suprimento_.Set_Valor("102,50") & suprimento_.Set_Observacao("Abertura caixa"))
                            {
                                Vs.Add(suprimento_.Notifica());

                                // adiciona o registro suprimento ao caixa 
                                if (CaixaOperacao.Add(suprimento_))
                                {
                                    Vs.Add(CaixaOperacao.Notifica());

                                    // grava o registro do caixa apos ter o valor de suprimento adicionado ao caixa 
                                    if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                    {
                                        Vs.Add(ObjHope.Pos.Caixa.Notifica());

                                        // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                        CaixaOperacao = caixa_;
                                    }
                                    else
                                    {
                                        Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(CaixaOperacao.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(suprimento_.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                        }
                        #region VendaPagamentoDinheiro
                        Vs.Add("Venda Pagamento Dinheiro 1 item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento dinheiro
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());

                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Dinheiro("10,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());

                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoDebito
                        Vs.Add("Venda Pagamento Debito 1 item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento debido
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Debito("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoCredito
                        Vs.Add("Venda Pagamento Credito 1 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Credito
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Credito("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoCheque
                        Vs.Add("Venda Pagamento Cheque 1 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Cheque
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em cheque
                                if (pagar_.Set_Cheque("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoValeAlimentacao
                        Vs.Add("Venda Pagamento vale Alimentacao 1 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Vale Alimentacao
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em Vale Alimentacao
                                if (pagar_.Set_Vale_Alimentacao("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoValeREfeicao
                        Vs.Add("Venda Pagamento Vale Refeicao 1 Item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Vale Refeicao
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em Vale Refeicao
                                if (pagar_.Set_Vale_Refeicao("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoOutro
                        Vs.Add("Venda Pagamento Outro 1 Item");
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Outro
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em Outro
                                if (pagar_.Set_Dinheiro("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoInterno
                        Vs.Add("Venda Pagamento Interno 1 Item " + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Interno
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_.Set_Descricao("teste") & item_.Set_Quantidade("1") & item_.Set_Unidade("Peca") & item_.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em interno
                                if (pagar_.Set_Interno("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        #region VendaPagamentoParcial
                        Vs.Add("Venda Pagamento Parcial 8 Item" + Environment.NewLine);
                        // abre novo registro de venda com os valores do caira pra ser vinculado ao caixa 
                        // pagamento Parcial Dinheiro-Debito-Credito-Cheque-Alimentacao-Refeicao-outro-interno
                        if (ObjHope.Pos.Vender.Novo(CaixaOperacao, out Vender))
                        {
                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                            // abre novo registro item vinculado a venda 
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_0))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_0.Set_Descricao("teste") & item_0.Set_Quantidade("1") & item_0.Set_Unidade("Peca") & item_0.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_0.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_0))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_0.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_1))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_1.Set_Descricao("teste") & item_1.Set_Quantidade("1") & item_1.Set_Unidade("Peca") & item_1.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_1.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_1))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_1.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_2))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_2.Set_Descricao("teste") & item_2.Set_Quantidade("1") & item_2.Set_Unidade("Peca") & item_2.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_2.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_2))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_2.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_3))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_3.Set_Descricao("teste") & item_3.Set_Quantidade("1") & item_3.Set_Unidade("Peca") & item_3.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_3.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_3))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_3.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_4))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_4.Set_Descricao("teste") & item_4.Set_Quantidade("1") & item_4.Set_Unidade("Peca") & item_4.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_4.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_4))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_4.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_5))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_5.Set_Descricao("teste") & item_5.Set_Quantidade("1") & item_5.Set_Unidade("Peca") & item_5.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_5.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_5))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_5.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_6))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_6.Set_Descricao("teste") & item_6.Set_Quantidade("1") & item_6.Set_Unidade("Peca") & item_6.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_6.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_6))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_6.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            if (ObjHope.Pos.Vender.Item_Novo(Vender, out IItem_e item_7))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // coloca os valores do item 
                                if (item_7.Set_Descricao("teste") & item_7.Set_Quantidade("1") & item_7.Set_Unidade("Peca") & item_7.Set_Venda("5,00"))
                                {
                                    Vs.Add(item_7.Notifica());
                                    // adiciona o item a venda aberta
                                    if (Vender.Add(item_7))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o registro da venda aberta 
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(item_7.Notifica());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }

                            // abre novo registro pagamento 
                            if (ObjHope.Pos.Vender.Pagar_Novo(Vender, out IPagar_e pagar_))
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                                // atribui o valor em dinheiro
                                if (pagar_.Set_Dinheiro("5,00") & pagar_.Set_Interno("5,00") & pagar_.Set_Cheque("5,00") & pagar_.Set_Credito("5,00") & pagar_.Set_Debito("5,00") & pagar_.Set_Outro("5,00") & pagar_.Set_Vale_Alimentacao("5,00") & pagar_.Set_Vale_Refeicao("5,00"))
                                {
                                    Vs.Add(pagar_.Noticia());
                                    // adiciona o registro pagar a venda aberta
                                    if (Vender.Add(pagar_))
                                    {
                                        Vs.Add(Vender.Notifica());
                                        // grava o regsitro da venda aberto
                                        if (ObjHope.Pos.Vender.Gravar(Vender))
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(Vender.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(pagar_.Noticia());
                                }
                            }
                            else
                            {
                                Vs.Add(ObjHope.Pos.Vender.Notificar());
                            }
                            // finaliaza o registro venda aberto
                            if (Vender.Finalizar())
                            {
                                Vs.Add(Vender.Notifica());
                                // grava o registro de venda finalizado
                                if (ObjHope.Pos.Vender.Gravar(Vender))
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                    // adiciona o registro de venda ao caixa aberto vinculado com a venda 
                                    if (CaixaOperacao.Add(Vender))
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                        // grava o registro doc aixa aberto 
                                        if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e caixa_))
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                            Vender = null;
                                            // sobre escreve a variavel caixa antes de sido gravado pela saida da variavel caixa contendo o seu novo estado
                                            CaixaOperacao = caixa_;
                                        }
                                        else
                                        {
                                            Vs.Add(ObjHope.Pos.Caixa.Notifica());
                                        }
                                    }
                                    else
                                    {
                                        Vs.Add(CaixaOperacao.Notifica());
                                    }
                                }
                                else
                                {
                                    Vs.Add(ObjHope.Pos.Vender.Notificar());
                                }
                            }
                            else
                            {
                                Vs.Add(Vender.Notifica());
                            }
                        }
                        else
                        {
                            Vs.Add(ObjHope.Pos.Vender.Notificar());
                        }
                        #endregion
                        //// fecha o registro caixa 
                        //if (CaixaOperacao.Fechamento())
                        //{
                        //    Vs.Add(CaixaOperacao.Notifica());
                        //    // grava o registro do caixa fechado
                        //    if (ObjHope.Pos.Caixa.Gravar(CaixaOperacao, out ICaixa_e result))
                        //    {
                        //        Vs.Add(ObjHope.Pos.Caixa.Notifica());
                        //        CaixaOperacao = result;
                        //    }
                        //    else
                        //    {
                        //        Vs.Add(ObjHope.Pos.Caixa.Notifica());
                        //    }
                        //}
                        //else
                        //{
                        //    Vs.Add(CaixaOperacao.Notifica());
                        //}
                    }
                    else
                    {
                        Vs.Add(ObjHope.Pos.Caixa.Notifica());
                    }
                    // fehca o login aberto do usuario demo
                    if (ObjHope.Autenticacao.Logout())
                    {
                        Vs.Add(ObjHope.Autenticacao.Notifica());
                        CaixaOperacao = null;
                        Vender = null;
                    }
                    else
                    {
                        Vs.Add(ObjHope.Autenticacao.Notifica());
                    }
                }
                else
                {
                    Vs.Add(ObjHope.Autenticacao.Notifica());
                }
                #endregion
            }

        }
    }
}
