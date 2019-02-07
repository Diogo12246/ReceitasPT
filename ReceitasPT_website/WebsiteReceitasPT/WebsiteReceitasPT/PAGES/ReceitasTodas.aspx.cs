using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL;

namespace WebsiteReceitasPT.PAGES
{
    public partial class ReceitasTodas : System.Web.UI.Page
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
            MANAGER m = new MANAGER();
            DataSet ds = m.GetData();

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
            //string NomeDeReceita = GridView1.SelectedRow.Cells[cellindex].Text;
            //SESSION["Nome de receita!"]
            LinkButton btn = sender as LinkButton;
            string IDreceita = btn.Text;
            Response.Redirect(String.Format("Receita.aspx?IDreceita={0}", IDreceita));
            // public sealed.
            // public interface .. assinaturas, etc.
        }
        #endregion
        /////////////////////
    }
}