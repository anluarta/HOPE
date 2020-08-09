using Hope.Controle;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Model
{
    class Colaborador_m : Colaborador_c
    {
       internal Colaborador_m()
        {
            colaborador_DAO = new DAO.Colaborador_d();
            consulta = new Consulta_m._colaborador();
        }
        protected override IColaborador_e[] find()
        {

            throw new NotImplementedException();
        }
    }
}
