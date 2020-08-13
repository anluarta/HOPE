using Hope.Interface;
using Hope.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Colaborador_c : IColaborador
    {
        protected List<string> Noticia;
        protected abstract IColaborador_e[] find();
        protected Consulta_c consulta;
        IConsulta IColaborador.Consulta => consulta;
        protected abstract bool Insert_Data_Value(Dictionary<int, object> keyValuesData);
        internal abstract bool Busca_Index(object index,out IColaborador_e result);

        IColaborador_e[] IColaborador.Find(IConsulta consulta)
        {
            return find();
            throw new NotImplementedException();
        }

        bool IColaborador.Gravar(IColaborador_e _E)
        {

            throw new NotImplementedException();
        }

        IColaborador_e IColaborador.Novo()
        {
           // throw  new Colaborador_m.Colaborador_Exception();
            return new Entidade.Colaborador_e();
            throw new NotImplementedException();
        }

        IColaborador_e IColaborador.Select(object current)
        {
            return new Entidade.Colaborador_e();

            throw new NotImplementedException();
        }

        string IColaborador.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }
    }
}
