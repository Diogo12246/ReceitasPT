using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PAGES_Erro : System.Web.UI.Page
{
    int userId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        userId = (int)(Session["User"]);
    }
}