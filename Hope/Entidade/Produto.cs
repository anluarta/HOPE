using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Entidade
{
    class Produto : IProduto
    {
        public string ID_Produto { get; set; }
        public string EAN {get;set;}
        public string Descricao {get;set;}
        public string Unidade {get;set;}
        public string Custo {get;set;}
        public string Venda {get;set;}
    }
}
