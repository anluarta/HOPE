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
        protected Suprimento_c _Suprimento;
        protected Sangria_c _Sangria;

        ISuprimento ICaixa.Suprimento => _Suprimento;

        ISangria ICaixa.Sangria => _Sangria;

        protected abstract bool Insert_New_Row(out int Index, out DateTime start);
        protected abstract bool Update_Row(Dictionary<string, string> keyValueData);
        protected abstract bool Select_All_From(out ICaixa_e[] caixa_s);
        

        bool ICaixa.Gravar(ICaixa_e entidade, out ICaixa_e result)
        {
            if (entidade != null)
            {
                Caixa_e _E = entidade as Caixa_e;
                if (_Suprimento.Gravar(_E.suprimento_s))
                {
                    _E.suprimento_s.Clear();
                    Noticia.AddRange(_Suprimento.Noticia);
                    _Suprimento.Noticia.Clear();
                    Noticia.Add("Dado Value Suprimento Gravado");
                }
                else
                {
                    Noticia.AddRange(_Suprimento.Noticia);
                    Noticia.Add("Dado Value Suprimento nao gravado");
                }
                if (_Sangria.Gravar(_E.sangria_s))
                {
                    _E.sangria_s.Clear();
                    Noticia.AddRange(_Sangria.Noticia);
                    _Sangria.Noticia.Clear();
                    Noticia.Add("Dado Value Sangria Gravado");
                }
                else
                {
                    Noticia.AddRange(_Sangria.Noticia);

                    Noticia.Add("Dado Value Sangria nao Gravado");
                }
                if (_E.Disparidade())
                {
                    if (Update_Row(_E.GetToDataValue()))
                    {
                        result = _E;
                        return true;

                    }
                    else
                    {
                        result = _E;
                        return false;
                    }
                }
                else
                {
                    Noticia.Add("a entidade nao sobreu mudanca no seu estado acao nao realizado");
                    result = _E;
                    return false;
                }
            }
            else
            {
                Noticia.Add("Entidade Nula");
                result = null;
                return false;
            }
        }

        string ICaixa.Notifica()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Noticia)
            {
                builder.AppendLine(item);
            }
            Noticia.Clear();
            return builder.ToString();
        }

        ICaixa_e ICaixa.Novo()
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

        ISangria_e ICaixa.Sangria_Novo(ICaixa_e entidade)
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

        ICaixa_e ICaixa.Select(object current)
        {
            throw new NotImplementedException();
        }

        ISuprimento_e ICaixa.Suprimento_Novo(ICaixa_e entidade)
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

        IConsulta ICaixa.Consulta()
        {
            return _Consulta;
        }

        bool ICaixa.Find(IConsulta consulta, out ICaixa_e[] caixa_s)
        {
            switch (consulta.Comando)
            {
                case Enums.Consulta_u.Comando.Select_All_From:
                    if (Select_All_From(out ICaixa_e[] result))
                    {
                        caixa_s = result;
                        return true; ;
                    }
                    else
                    {
                        caixa_s = null;
                        return false;
                    }
                default:
                    caixa_s = null;
                    return false;
            }
        }
    }
}
