using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PESQUISA
    {
        /////////////////
        #region atributos
        int _UserID;
        string _UserPesquisa;
        string _UserPesquisaType;
        #endregion
        /////////////////
        #region propriedades
        public int UserID
        {
            get => _UserID;
            set => _UserID = value;
        }
        public string UserPesquisa
        {
            get => _UserPesquisa;
            set => _UserPesquisa = value;
        }
        public string UserPesquisaType
        {
            get => _UserPesquisaType;
            set => _UserPesquisaType = value;
        }
        #endregion
        /////////////////
    }
}
