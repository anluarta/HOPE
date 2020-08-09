using Hope.Entidade;
using Hope.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
   public abstract class Colaborador_c : IColaborado_v
    {
        DAO.Colaborador_d Colaborador_DAO;
        bool IColaborado_v.Cadastra(out IColaborado_Set_v _Set_)
        {
            _Set_ =new Entidade.Colaborador_e();
            return true;
            throw new NotImplementedException();
        }

        bool IColaborado_v.Gravar(Colaborador_e entidade)
        {
            throw new NotImplementedException();
        }
    }
}
