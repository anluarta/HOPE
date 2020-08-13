using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;

namespace Hope.Controle
{
    internal abstract class Suprimento_c : ISuprimento
    {
        internal List<string> Noticia;
        IConsulta ISuprimento.Consulta => throw new NotImplementedException();

        protected abstract bool Insert_Data_Value(Dictionary <string,object> keyValuesData );
        internal bool Gravar(List<Suprimento_e> suprimento_s)
        {
            if (suprimento_s!=null)
            {
                if (suprimento_s.Count!=0)
                {
                    List<bool> vs = new List<bool>();
                    foreach (Suprimento_e item in suprimento_s)
                    {
                        vs.Add(Insert_Data_Value(item.GetKeysValueData()));
                    }
                    if (vs.Find(x=>x == true))
                    {

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        ISuprimento_e[] ISuprimento.Find(IConsulta consulta)
        {
            throw new NotImplementedException();
        }

        ISuprimento_e ISuprimento.Select(object current)
        {
            throw new NotImplementedException();
        }
    }
}