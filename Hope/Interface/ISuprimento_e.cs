using System;

namespace Hope.Interface
{
    public interface ISuprimento_e
    {
        int Index { get; }
        int Id_Caixa { get; }
        DateTime Data_Registro { get; }
        string Observacao { get; }
        decimal Valor { get; }
        bool Set_Valor(string valor);
        bool Set_Observacao(string observacao);
        string Notifica();
        IColaborador_e Colaborador();
    }
}