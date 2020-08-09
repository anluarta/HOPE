using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Vender_c : IVender
    {
        public IConsulta Consulta => throw new NotImplementedException();

        public IVender_e[] Fill(IConsulta consulta)
        {
            throw new NotImplementedException();
        }

        public bool Gravar(IVender_e vender)
        {
            throw new NotImplementedException();
        }

        public IItem_e Items(IVender_e entidade)
        {
            throw new NotImplementedException();
        }

        public string Notificar()
        {
            throw new NotImplementedException();
        }

        public IVender_e Novo()
        {
            throw new NotImplementedException();
        }

        public IPagar_e Pagar(IVender_e entidade)
        {
            throw new NotImplementedException();
        }

        public IVender_e Select(object current)
        {
            throw new NotImplementedException();
        }
    }
}
