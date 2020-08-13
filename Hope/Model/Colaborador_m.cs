using Hope.Controle;
using Hope.Entidade;
using Hope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Model
{
    class Colaborador_m : Colaborador_c
    {
       internal Colaborador_m()
        {
            Noticia = new List<string>();
            consulta = new Consulta_m._colaborador();
            Entidade.Colaborador_e bs = new Entidade.Colaborador_e();
            bs.Set_Login("Hope");
            bs.Set_Nome_Vendedor("Hope POS");
            bs.Set_Senha("Hope");
            Insert_Data_Value(bs.GetkeyValues());
        }
        protected override IColaborador_e[] find()
        {

            throw new NotImplementedException();
        }

        protected override bool Insert_Data_Value(Dictionary<int, object> keyValuesData)
        {
            if (keyValuesData!= null)
            {
                try
                {
                    HopeDataSet.ColadoradorRow coladoradorRow = Hope.Hope_static.hopeData.Coladorador.NewColadoradorRow();
                    coladoradorRow.Login_Pass = (string)keyValuesData[Colaborador_e.Key_Login_Pass];
                    coladoradorRow.Login_User = (string)keyValuesData[Colaborador_e.Key_Login_User];
                    coladoradorRow.Nome_Vendedor = (string)keyValuesData[Colaborador_e.Key_Nome_Vendedor];
                    Hope_static.hopeData.Coladorador.AddColadoradorRow(coladoradorRow);
                    Hope_static.hopeData.AcceptChanges();
                    Noticia.Add("REgistro salvo");
                    return true;
                }
                catch (Exception e)
                {
                    Noticia.Add(e.Message);
                    return false;
                }
            }
            else
            {
                Noticia.Add("Colaborado Inser_Data_Value KeyValueData nullo ");
                return false;
            }
        }

        internal override bool Busca_Index(object index,out IColaborador_e result)
        {

            throw new NotImplementedException();
        }
    }
}
