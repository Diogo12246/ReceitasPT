using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class INGREDIENT
    {
        ///////////////////// 
        #region atributos
        int _IngredienteID;
        string _ingredienteNome;
        int _UnidadeID;
        double _IngredienteQtidade;
        #endregion
        ///////////////////// 
        #region propriedades
        public int IngredienteID
        {
            get => _IngredienteID;
            set => _IngredienteID = value;
        }

        public string IngredienteNome
        {
            get => _ingredienteNome;
            set => _ingredienteNome = value;
        }
        public int UnidadeID
        {
            get => _UnidadeID;
            set => _UnidadeID = value;
        }
        public double IngredienteQtidade
        {
            get => _IngredienteQtidade;
            set => _IngredienteQtidade = value;
        }
        public override string ToString()
        {
            return IngredienteNome;
        }
        #endregion
        ///////////////////// 
    }
}
