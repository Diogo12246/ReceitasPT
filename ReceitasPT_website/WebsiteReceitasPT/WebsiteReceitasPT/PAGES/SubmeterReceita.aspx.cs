using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace WebsiteReceitasPT.PAGES
{
    
    public partial class SubmeterReceita : System.Web.UI.Page
    {
        ///////////////////// 
        #region declarações
        int userId;
        MANAGER M = new MANAGER();
        public static List<INGREDIENT> lista_de_Ingredientes = new List<INGREDIENT>();
        #endregion
        /////////////////////
        #region page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            /////////////////////
            #region UserId_Verify
            userId = (int)(Session["User"]);
            if (userId == 0)
            {
                Response.Redirect("LOGIN_REGISTAR.aspx");
            }
            #endregion
            /////////////////////
            #region Verificação_de_sessão
            if (Session["User"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
            #endregion
            /////////////////////
            #region Dal_Manager
            /////////////////DAL MANAGER/////////////////////
            MANAGER M = new MANAGER();
            ////////////////////////////////////////////////
            #endregion
            //////////////////////////////////////////
            #region Popular_Dropdown_Lista_Ingredientes

            if (ingredientelista.Items.Count == 0)
            {
                foreach (INGREDIENT Ingrediente in M.listadeIngredientes())
                {
                    ingredientelista.Items.Add(Ingrediente.IngredienteNome);
                }
            }

            #endregion
            //////////////////////////////////////////
            #region Popular_Dropdown_Lista_Categorias
            if (receitaCategoria.Items.Count == 0)
            {
                foreach (CATEGORIA Categoria in M.listadecategorias())
                {
                    receitaCategoria.Items.Add(Categoria.CategoriaNome);
                }
            }
            #endregion
            //////////////////////////////////////////
            #region Popular_Dropdown_Lista_Dificuldade
            if (receitaDificuldade.Items.Count == 0)
            {
                foreach (DIFICULDADE dificuldade in M.listadedificuldades())
                {
                    receitaDificuldade.Items.Add(dificuldade.DificuldadeNome);
                }
            }
            #endregion
            //////////////////////////////////////////
            #region Popular_Dropdown_Lista_Unidade
            if (ingredienteunidade.Items.Count == 0)
            {
                foreach (UNIDADE Unidade in M.listadeUnidades())
                {
                    ingredienteunidade.Items.Add(Unidade.UnidadeNome);
                }
            }
            #endregion
            //////////////////////////////////////////
        }
        #endregion
        /////////////////////
        #region Submeter_Receita
        protected void SubmitRecipe_Click1(object sender, EventArgs e)
        {
            #region INSTANCIAR_Receita_Manager
            RECEITA r = new RECEITA();
            #endregion
            r.ReceitaNome = receitanome.Text;
            r.ReceitaDescricao = receitadescricao.Text;
            r.UserID = userId;
            r.ReceitaEstado = 0;
            r.DificuldadeID = receitaDificuldade.SelectedIndex + 1;
            r.CategoriaID = receitaCategoria.SelectedIndex + 1;
            r.Rating = 0;
            int duracao = Int32.Parse(receitaduracao.Text);
            r.ReceitaDuracao = duracao;
            r.ReceitaEstado = 0;
            byte[] receitaimagembytearray = imagemupload.FileBytes;
            r.ReceitaImagem = receitaimagembytearray;
            r.TOP5 = 0;
            M.InserirReceita(r);

            foreach (INGREDIENT ingrediente in lista_de_Ingredientes)
            {
                M.InserirReceitaStep2(ingrediente.IngredienteID, ingrediente.IngredienteQtidade, ingrediente.UnidadeID);
            }
            Response.Write("<script>alert('Submissão de receita completa! Mas primeiro terá de ser aprovada por um admin!')</script>");
            Response.Redirect("PaginaInicial.aspx");
        }
        #endregion
        /////////////////////
        #region Inserir_Ingrediente_nalista
        protected void inserirIngredientesnalista_Click(object sender, EventArgs e)
        {
            INGREDIENT I = new INGREDIENT();
            I.IngredienteID = ingredientelista.SelectedIndex + 1;
            I.IngredienteQtidade = double.Parse(ingredientequantidade.Text);
            I.UnidadeID = ingredienteunidade.SelectedIndex + 1;

            lista_de_Ingredientes.Add(I);

            string mensagem = "Preencha o título da receita para poder adicionar ingredientes";

            if (string.IsNullOrWhiteSpace(this.receitanome.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensagem + "');", true);
            }
            else
            {
                INGREDIENTESELECIONADOLISTA.Items.Add(ingredientelista.SelectedIndex + " - " + ingredientequantidade.Text + " " + ingredienteunidade.SelectedItem);
            }
        }
        #endregion
        /////////////////////
        #region redirectback
        protected void redirectsubmeterhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaInicial.aspx?");
        }
        #endregion
        /////////////////////
    }
}