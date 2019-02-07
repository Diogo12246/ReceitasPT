using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class USER
    {   ///////////////////// 
        #region propriedades
        int _UserID;
        string _UserAutorname;
        string _UserPassword;
        string _UserEmail;
        byte[] _UserImage;
        int _UserRole;
        int _UserState;
        #endregion
        ///////////////////// 
        #region propriedades
        public string UserAutorname
        {
            get => _UserAutorname;
            set => _UserAutorname = value;
        }

        public string UserEmail
        {
            get => _UserEmail;
            set => _UserEmail = value;
        }

        public int UserState
        {
            get => _UserState;
            set => _UserState = value;
        }

        public string UserPassword
        {
            get => _UserPassword;
            set => _UserPassword = value;
        }

        public int UserRole
        {
            get => _UserRole;
            set => _UserRole = value;
        }

        public byte[] UserImage
        {
            get => _UserImage;
            set => _UserImage = value;
        }
        public int UserID
        {
            get => _UserID;
            set => _UserID = value;
        }

        public override string ToString()
        {
            return UserAutorname; 
        }
        #endregion
        ///////////////////// 
    }
}
