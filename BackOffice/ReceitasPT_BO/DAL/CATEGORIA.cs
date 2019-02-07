using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CATEGORIA
    {   ///////////////////// 
        #region atributos
        int _CategoriaID;
        string _CategoriaNome;
        #endregion
        ///////////////////// 
        #region propriedades
        public int CategoriaID
        {
            get => _CategoriaID;
            set => _CategoriaID = value;
        }

        public string CategoriaNome
        {
            get => _CategoriaNome;
            set => _CategoriaNome = value;
        }
        #endregion
        ///////////////////// 
    }
}
