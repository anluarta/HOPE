using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hope.Entidade;
using Hope.Interface;
namespace Hope.Controle
{
    abstract class Caixa_c : ICaixa
    {
       protected List<string> Noticia;
        protected Consulta_c _Consulta;
        public IConsulta Consulta => _Consulta;
        protected abstract bool Insert_New_Row(out int Index, out DateTime start);
        protected abstract bool Update_Row(Dictionary<string, object> keyValueData);
        public ICaixa_e Find(IConsulta consulta)
        {
            throw new NotImplementedException();
        }

        public bool Gravar(ICaixa_e entidade)
        {
            if (entidade != null)
            {
                Caixa_e _E = entidade as Caixa_e;
                if (_E.Disparidade())
                {
                    return Update_Row(_E.GetToDataValue());

                }
                else
                {
                    Noticia.Add("a entidade nao sobreu mudanca no seu estado acao nao realizado");
                    return false;
                }
            }
            else
            {
                Noticia.Add("Entidade Nula");
                return false;
            }
        }

        public string Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }

        public ICaixa_e Novo()
        {
            if (Hope_static.Autenticacao.Autenticado)
            {

                Insert_New_Row(out int id, out DateTime start);
                ICaixa_e _E = new Entidade.Caixa_e(id, Hope_static.Autenticacao.Colaborador, start);
                Noticia.Add("Novo caixa criado");
                return _E;
            }
            else
            {
                throw HException.Caixa_he.Erro_0();
            }
        }

        public ISangria_e Sangria(ICaixa_e entidade)
        {
            throw new NotImplementedException();
        }

        public ICaixa_e Select(object current)
        {
            throw new NotImplementedException();
        }

        public ISuprimento_e Suprimento(ICaixa_e entidade)
        {
            throw new NotImplementedException();
        }
    }
}
