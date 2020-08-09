using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope
{
    public class HException_c : ApplicationException
    {
        public HException_c(string message) : base(message)
        {
            // colocar sistema de salva log aqui
        }
    }
}
