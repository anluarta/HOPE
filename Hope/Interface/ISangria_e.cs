using System;

namespace Hope.Interface
{
    public interface ISangria_e
    {
        int Id_Sangria { get; }
        int Id_Caixa { get; }
        DateTime Data_Registro { get; }
        decimal Valor { get; }
        string Observacao { get; }
        bool Set_Valor(string valor);
        bool Set_Observacao(string obsevacao);
        string Notifica();
        IColaborador_e Get_Colaborador();
    }
}