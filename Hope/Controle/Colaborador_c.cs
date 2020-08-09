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

        protected abstract IColaborador_e[] find();
        protected DAO.Colaborador_d colaborador_DAO;
        protected Consulta_c consulta;
        IConsulta IColaborador.Consulta => consulta;

        INotifica IColaborador.Notifica => throw new NotImplementedException();

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
    }
}
