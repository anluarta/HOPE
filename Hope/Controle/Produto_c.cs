using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Produto_c : IProduto
    {
        IConsulta IProduto.Consulta => throw new NotImplementedException();

        ICodigo IProduto.Codigo(IProduto_e Entidade)
        {
            throw new NotImplementedException();
        }

        IProduto_e[] IProduto.Find(IConsulta consulta)
        {
            throw new NotImplementedException();
        }

        bool IProduto.Gravar(ref IProduto_e Entidade)
        {
            throw new NotImplementedException();
        }

        string IProduto.Notifica()
        {
            throw new NotImplementedException();
        }

        IProduto_e IProduto.Novo()
        {
            throw new NotImplementedException();
        }

        IPreco IProduto.Preco(IProduto_e Entidade)
        {
            throw new NotImplementedException();
        }

        IProduto_e IProduto.Select(object current)
        {
            throw new NotImplementedException();
        }
    }
}
