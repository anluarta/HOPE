using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;

namespace Hope.Controle
{
    internal abstract class Sangria_c : ISangria
    {
        internal List<string> Noticia;
        IConsulta ISangria.Consulta => throw new NotImplementedException();
        protected abstract bool Insert_Data_Value(Dictionary<string, object> keyValuesData);
        internal bool Gravar(List<Sangria_e> sangria_s)
        {
            if (sangria_s !=null)
            {
                if (sangria_s.Count!=0)
                {
                    List<bool> vs = new List<bool>();
                    foreach (Sangria_e item in sangria_s)
                    {
                        vs.Add(Insert_Data_Value(item.GetKeyValuesData()));
                    }
                    if (vs.Find(x => x == true))
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

        ISangria_e[] ISangria.Find(IConsulta consulta)
        {
            throw new NotImplementedException();
        }

        ISangria_e ISangria.Select(object current)
        {
            throw new NotImplementedException();
        }
    }
}