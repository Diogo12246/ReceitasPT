using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class FAVORITO
    {
        /////////////////////
        #region atributos
        private int _userID;
        private int _ReceitaID;
        #endregion
        /////////////////////
        #region propriedades
        public int UserID
        {
            get => _userID;
            set => _userID = value;
        }

        public int ReceitaID
        {
            get => _ReceitaID;
            set => _ReceitaID = value;
        }
        #endregion
        /////////////////////
    }
}
