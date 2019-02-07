using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DIFICULDADE
    {
        ///////////////////// 
        #region atributos
        int _DificuldadeID;
        string _DificuldadeNome;
        #endregion
        ///////////////////// 
        #region propriedades

        public int DificuldadeID
        {
            get => _DificuldadeID;
            set => _DificuldadeID = value;
        }

        public string DificuldadeNome
        {
            get => _DificuldadeNome;
            set => _DificuldadeNome = value;
        }
        #endregion
        ///////////////////// 
    }
}
