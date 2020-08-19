using System.Collections.Generic;

namespace Hope.Interface
{
    public interface ICaixa_e
    {
        string Get_ID { get; }
        string Get_Colaborador{get;}
        string Get_Start_DateTime{get;}
        string Get_finish_DateTime{get;}
        internal List<ISuprimento_e> GetSuprimento_s();
        internal List<ISangria_e> GetSangria_s();
        internal void Suprimento_Clear();
        internal void Sangria_Clear();
        internal bool Disparidade();
        internal Dictionary<string, string> GetToDataValue();
        string Notifica();
        bool Fechamento();
        string Dinheiro();
        string Debito();
        string Credito();
        string Cheque();
        string Vale_Alemintacao();
        string Vale_Refeicao();
        string Outro();
        string Interno();
        string Sangria();
        string Suprimento();
        bool Add(ISangria_e entidade);
        bool Add(ISuprimento_e entidade);
        bool Add(IVender_e entidade);
        bool Remover(IVender_e vender_);

    }
}