using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DAL;

namespace WebsiteReceitasPT.PAGES
{
    public partial class PaineldeUser : System.Web.UI.Page
    {
        /////////////////////

        #region Page_Load
        int userId;
        MANAGER m = new MANAGER();
        protected void Page_Load(object sender, EventArgs e)
        {
            userId = (int)(Session["User"]);
            if (Session["User"]==null || userId == 0)
            {
                Response.Redirect("LOGIN_REGISTAR.aspx");
            }

            if (userultimapesquisa.Items.Count == 0)
            {
                foreach (PESQUISA pesquisa in m.Ultimaspesquisas(userId))
                {
                    userultimapesquisa.Items.Add(pesquisa.UserPesquisa);
                }
            }

            DataSet ds = m.GetDataFAV(userId);

            GridView1.DataSource = ds;
            GridView1.DataBind();

            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
        #endregion
        ///////////////////// 
        #region redirectback
        protected void redirectsubmeterhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaInicial.aspx?");
        }

        protected void ultimapesquisabtn_Click(object sender, EventArgs e)
        {
            Session["tipodereceita"] = "Nome";
            Session["textsearch"] = userultimapesquisa.SelectedItem.Text;
            Response.Redirect("Receitaporpesquisa.aspx");
        }
        #endregion
        ///////////////////// 
        #region redirectReceita_Escolhida
        protected void lkbtnreceita_Click(object sender, EventArgs e)
        {
            LinkButton btn = sender as LinkButton;
            string IDreceita = btn.Text;
            Response.Redirect(String.Format("Receita.aspx?IDreceita={0}", IDreceita));
        }
        #endregion
        /////////////////////
    }
}