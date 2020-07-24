using Hope.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Controle
{
    abstract class Comprador_Ent_abs : IComprador_Ent_c
    {
        internal int _Id_Comprador;
        internal string _Numero_Registro;
        internal ListEnum.TipoComprador _Tipo;
        internal string _NomeCompleto_RazaoSocial;
        int IComprador_Ent_c.ID_Comprador => _Id_Comprador;
        string IComprador_Ent_c.NomeCompleto_RazaoSocial => _NomeCompleto_RazaoSocial;
        string IComprador_Ent_c.Numero_Registro
        {
            get
            {
                switch (_Tipo)
                {
                    case ListEnum.TipoComprador.Fisico:
                        //formata no padrao cpf
                        return _Numero_Registro;
                    case ListEnum.TipoComprador.Juridico:
                        //formata no padrao cnpj
                        return _Numero_Registro;
                    default:
                        //devolver sem formata se tievr erro 
                        return _Numero_Registro;
                }
            }
        }
        internal void Clea()
        {
            _Id_Comprador = 0;
            _Numero_Registro = string.Empty;
            _NomeCompleto_RazaoSocial = string.Empty;
        }

        bool IComprador_Ent_c.Set_Numero_Registro(string _Valor)
        {
            _Numero_Registro = _Valor;
            return true;
            throw new NotImplementedException();
        }

        bool IComprador_Ent_c.Set_NomeCompleto_Razao(string _Valor)
        {
            _NomeCompleto_RazaoSocial = _Valor;
            return true;
            throw new NotImplementedException();
        }
    }
}
