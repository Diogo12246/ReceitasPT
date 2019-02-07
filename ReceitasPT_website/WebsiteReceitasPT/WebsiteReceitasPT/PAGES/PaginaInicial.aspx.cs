using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace WebsiteReceitasPT.PAGES
{
    public partial class PaginaInicial : System.Web.UI.Page
    {
        ///////////////////// 
        #region declarações
        int userId;
        #endregion
        ///////////////////// 
        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                userId = 0;
            }
            else
            {
                userId = (int)(Session["User"]);
                //todo_User_VerifyName;
            }
            dropdownhome.Items.Insert(0, "Nome");
            dropdownhome.Items.Insert(1, "Categoria");
            dropdownhome.Items.Insert(2, "Ingrediente");
        }
        #endregion
        ///////////////////// 
        #region SubmeterReceita_navigateTo
        protected void Submeterbtn_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("LOGIN_REGISTAR.aspx");
            }
            else
            {
                Response.Redirect("SubmeterReceita.aspx?");
            }

        }
        #endregion
        ///////////////////// 
        #region TodasAsReceitas_navigateTo
        protected void TodasAsReceitasbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReceitasTodas.aspx?");
        }
        #endregion
        ///////////////////// 
        #region painel_user_navigateTo
        protected void paineldeuserbtn_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("LOGIN_REGISTAR.aspx");
            }
            else
            {
                Response.Redirect("PaineldeUser.aspx?");
            }
        }
        /////////////////////
        #endregion
        /////////////////////
        #region homepage_navigateTo
        protected void Homebutton_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                userId = 0;
            }
            else
            {
                Response.Redirect("PaginaInicial.aspx?");
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
        #region pesquisar_receitas
        protected void btnhomesearch_Click(object sender, EventArgs e)
        {
            Session["tipodereceita"] = dropdownhome.SelectedItem.Text;
            Session["textsearch"] = searchhome.Text;
            if (Session["User"] == null)
            {
                Response.Redirect("Receitaporpesquisa.aspx");
            }
            else
            {
                if ((string)Session["tipodereceita"]=="Nome")
                {
                int userS = (int)Session["User"];
                string userST = searchhome.Text;
                string userSTT = dropdownhome.SelectedItem.Text;
                MANAGER m = new MANAGER();
                m.InserirLastSearch(userS, userST, userSTT);
                Response.Redirect("Receitaporpesquisa.aspx");
                }
                else
                {
                    Response.Redirect("Receitaporpesquisa.aspx");
                }
            }

        }

        protected void top5btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("TOP5.aspx");
        }
        #endregion
        /////////////////////
    }
}