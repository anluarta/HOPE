using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Interface
{
    /// <summary>
    /// interface de acesso as funcoes 
    /// </summary>
   public interface IColaborador
    {
        string Notifica();
        /// <summary>
        /// funcao de inicia nova Entidade
        /// </summary>
        /// <returns>internface entidade colaborador</returns>
        IColaborador_e Novo();
        /// <summary>
        /// grava nova entidade colaborador
        /// </summary>
        /// <param name="Entidade">recebe a entidade colaborador</param>
        /// <returns>true pra gravacao feita false checar o erro </returns>
        bool Gravar(IColaborador_e Entidade);
        /// <summary>
        /// seleciona um registro e obtem a entidade dele com os valores
        /// </summary>
        /// <param name="current">recebe do binding o resgitro selecionado</param>
        /// <returns>entidade colaborador</returns>
        IColaborador_e Select(object current);
        /// <summary>
        /// cria procedimento pra consulta 
        /// </summary>
        IConsulta Consulta { get; }
        /// <summary>
        /// procura no banco de dados os paramento de consulta e retorna matriz entidade
        /// </summary>
        /// <param name="consulta">paramentro de consulta</param>
        /// <returns>matriz de entidade </returns>
        IColaborador_e[] Find(IConsulta consulta);
    }
}
