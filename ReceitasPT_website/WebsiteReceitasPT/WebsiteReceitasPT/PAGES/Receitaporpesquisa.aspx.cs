using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using System.Data;

namespace WebsiteReceitasPT.PAGES
{
    public partial class Receitaporpesquisa : System.Web.UI.Page
    {
        /////////////////////
        #region declarações
        int userId;
        #endregion
        /////////////////////
        #region pageload
        protected void Page_Load(object sender, EventArgs e)
        {
            /////////////////////
            #region userId_Verify
            if (Session["User"] == null)
            {
                userId = 0;
            }
            else
            {
                userId = (int)(Session["User"]);
            }
            #endregion
            /////////////////////
            string treceita = Convert.ToString(Session["tipodereceita"]);
            string textsearh = Convert.ToString(Session["textsearch"]);
            MANAGER m = new MANAGER();
            DataSet ds = m.GetDataSBAR(treceita,textsearh);

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
        #endregion
        /////////////////////
        #region redirectReceita_Escolhida
        protected void lkbtnreceita_Click(object sender, EventArgs e)
        {
            // string NomeDeReceita = GridView1.SelectedRow.Cells[cellindex].Text;
            //SESSION["Nome de receita!"]
            LinkButton btn = sender as LinkButton;
            string NomeDeReceita = btn.Text;
            Response.Redirect(String.Format("Receita.aspx?NomeDeReceita={0}", NomeDeReceita));
            // public sealed.
            // public interface .. assinaturas, etc.
        }
        #endregion
        /////////////////////
    }
}