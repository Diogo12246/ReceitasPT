using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UNIDADE
    {
        ///////////////////// 
        #region atributos
        int _UnidadeID;
        string _UnidadeNome;
        #endregion
        ///////////////////// 
        #region propriedades
        public int UnidadeID
        {
            get => _UnidadeID;
            set => _UnidadeID = value;
        }
        public string UnidadeNome
        {
            get => _UnidadeNome;
            set => _UnidadeNome = value;
        }
        #endregion
        ///////////////////// 
    }
}
