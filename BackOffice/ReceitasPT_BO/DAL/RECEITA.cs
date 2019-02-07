using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class RECEITA
    {
        /////////////////////
        #region atributos
        int _ReceitaID;
        string _ReceitaNome;
        int _UserID;
        string _ReceitaDescricao;
        int _CategoriaID;
        int _DificuldadeID;
        int    _Rating;
        int _ReceitaEstado;
        byte[] _ReceitaImagem;
        int _ReceitaDuracao;
        int _TOP5;
        #endregion
        /////////////////////
        #region propriedades
        public int ReceitaID
        {
            get => _ReceitaID;
            set => _ReceitaID = value;
        }
        public string ReceitaNome
        {
            get => _ReceitaNome;
            set => _ReceitaNome = value;
        }
        public int UserID
        {
            get => _UserID;
            set => _UserID = value;
        }
        public string ReceitaDescricao
        {
            get => _ReceitaDescricao;
            set => _ReceitaDescricao = value;
        }
        public int CategoriaID
        {
            get => _CategoriaID;
            set => _CategoriaID = value;
        }
        public int DificuldadeID
        {
            get => _DificuldadeID;
            set => _DificuldadeID = value;
        }
        public int Rating
        {
            get => _Rating;
            set => _Rating = value;
        }
        public int ReceitaEstado
        {
            get => _ReceitaEstado;
            set => _ReceitaEstado = value;
        }
        public byte[] ReceitaImagem
        {
            get => _ReceitaImagem;
            set => _ReceitaImagem = value;
        }
        public int ReceitaDuracao
        {
            get => _ReceitaDuracao;
            set => _ReceitaDuracao = value;
        }
        public int TOP5
        {
            get => _TOP5;
            set => _TOP5 = value;
        }
        public override string ToString()
        {
            return ReceitaNome;
        }
        #endregion
        /////////////////////
    }
}
