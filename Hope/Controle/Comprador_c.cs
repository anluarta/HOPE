using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
   abstract class Comprador_c : IComprador
    {
        

        IConsulta IComprador.Consulta => throw new NotImplementedException();

        public INotifica Notifica()
        {
            throw new NotImplementedException();
        }

        IComprador_e[] IComprador.Find(IConsulta consulta)
        {
            throw new NotImplementedException();
        }

        bool IComprador.Gravar(IComprador_e Entidade)
        {
            throw new NotImplementedException();
        }

        IComprador_e IComprador.Novo()
        {
            throw new NotImplementedException();
        }

        IComprador_e IComprador.Select(object current)
        {
            throw new NotImplementedException();
        }
    }
}
