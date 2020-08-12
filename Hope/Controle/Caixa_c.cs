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
        Suprimento _Suprimento;
        Sangria _Sangria;
        public IConsulta Consulta => _Consulta;

        public ISuprimento Suprimento => _Suprimento;

        public ISangria Sangria => _Sangria;

        protected abstract bool Insert_New_Row(out int Index, out DateTime start);
        protected abstract bool Update_Row(Dictionary<string, string> keyValueData);

        public ICaixa_e[] Find(IConsulta consulta)
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
                    if (_Suprimento.Gravar(_E.suprimento_s))
                    {
                        Noticia.Add("Dado Value Suprimento Gravado");
                    }
                    else
                    {
                        Noticia.Add("Dado Value Suprimento nao gravado");
                    }
                    if (_Sangria.Gravar(_E.sangria_s))
                    {
                        Noticia.Add("Dado Value Sangria Gravado");
                    }
                    else
                    {
                        Noticia.Add("Dado Value Sangria nao Gravado");
                    } 
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

        public ISangria_e Sangria_Novo(ICaixa_e entidade)
        {
            if (entidade != null)
            {
                if (Hope_static.Autenticacao.Autenticado)
                {
                    Caixa_e caixa_E = entidade as Caixa_e;

                    ISangria_e _E = new Sangria_e(caixaID: caixa_E.ID, colaboraID: caixa_E.Colaborador.Get_ID);

                    return _E;
                }
                else
                {
                    Noticia.Add("Nao esta autenticado para essa acao ");
                    return null;
                }

            }
            else
            {
                Noticia.Add("Sangria entidade nullo");
                return null;
            }
        }

        public ICaixa_e Select(object current)
        {
            throw new NotImplementedException();
        }

        public ISuprimento_e Suprimento_Novo(ICaixa_e entidade)
        {
            if (entidade != null)
            {
                if (Hope_static.Autenticacao.Autenticado)
                {
                    Caixa_e caixa_E = entidade as Caixa_e;
                    ISuprimento_e suprimento_E = new Suprimento_e(caixaID: caixa_E.ID, colaboraID: caixa_E.Colaborador.Get_ID);

                    return suprimento_E;
                }
                else
                {
                    Noticia.Add("Nao esta autenticado para essa acao ");
                    return null;
                }

            }
            else
            {
                Noticia.Add("Suprimento entidade nullo");
                return null;
            }
        }
    }
}
