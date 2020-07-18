using Hope.Entidade;

namespace Hope.Controle
{
    class Recebimento_Ent_abs : Entidade.IRecebimento_Ent_c
    {
        internal string _ID_Cliente;
        internal string _Cliente;
        internal string _Cliente_Conta_Valor;
        internal string _Forma_Recebimento;
        internal string _Tipo_Recebimento;
        internal string _Valor_Recebido;
        internal void Clear()
        {
            _ID_Cliente = string.Empty;
            _Cliente = string.Empty;
            _Cliente_Conta_Valor = string.Empty;
            _Forma_Recebimento = string.Empty;
            _Tipo_Recebimento = string.Empty;
            _Valor_Recebido = string.Empty;
        }
        bool IRecebimento_Ent_c.SetFormaRecebimento(string valor)
        {
            _Forma_Recebimento = valor;
            return true;
        }

        bool IRecebimento_Ent_c.SetTipoRecebimento(string valor)
        {
            _Tipo_Recebimento = valor;
            return true;
        }

        bool IRecebimento_Ent_c.SetValorRecebido(string valor)
        {
            _Valor_Recebido = valor;
            return true;
        }
    }
}