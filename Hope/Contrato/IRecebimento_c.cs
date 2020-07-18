using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Contrato
{
    public interface IRecebimento_c
    {
        IInformacao_c Informacao { get; }
        Entidade.IRecebimento_Ent_c FocusEntidade { get; }
        string Cliente { get; }
        string Cliente_Conta_Valor { get; }

        bool Localizar(string Comando, string Coluna, string Orden, decimal Limit, string Termo, out Entidade.IRecebimento_Ent_c[] ListaRegistro);
        bool SelecionaRegistro(object _Selecionado);
        bool NovoRegistro(out Entidade.IRecebimento_Ent_c usuario);
        bool GravarRegistro(Entidade.IRecebimento_Ent_c usuario);
        bool AdicionarCliente();
    }
}
