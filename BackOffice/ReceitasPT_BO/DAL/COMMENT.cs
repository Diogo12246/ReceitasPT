using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class COMMENT
    {
        int _ComentarioID;
        int _ReceitaID;
        int _UserID;
        string _ComentarioTXT;
        int _ComentarioState;

        public int ComentarioID
        {
            get => _ComentarioID;
            set => _ComentarioID = value;
        }
        public int ReceitaID
        {
            get => _ReceitaID;
            set => _ReceitaID = value;
        }
        public int UserID
        {
            get => _UserID;
            set => _UserID = value;
        }
        public string ComentarioTXT
        {
            get => _ComentarioTXT;
            set => _ComentarioTXT = value;
        }
        public int ComentarioState
        {
            get => _ComentarioState;
            set => _ComentarioState = value;
        }
        public override string ToString()
        {
            return "UserID="+UserID + " " + ComentarioTXT;
        }
    }
}
