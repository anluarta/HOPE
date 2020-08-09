using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.View
{
   public interface IColaborado_v
    {
        bool Cadastra(out IColaborado_Set_v _Set_);
        bool Gravar(Colaborador_e entidade);
    }
}
