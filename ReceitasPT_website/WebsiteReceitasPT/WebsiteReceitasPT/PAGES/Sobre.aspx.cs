using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PAGES_Sobre : System.Web.UI.Page
{
    int userId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"]==null)
        {
            userId = 0;
        }
        else
        {
            userId = (int)(Session["User"]);
        }
        
    }
    #region redirectback
    protected void redirectsubmeterhome_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaginaInicial.aspx?");
    }
    #endregion
}