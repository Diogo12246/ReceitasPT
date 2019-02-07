using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using DAL;


namespace WebsiteReceitasPT.PAGES
{
    public partial class LOGIN_REGISTAR : System.Web.UI.Page
    {   ///////////////////// 
        #region page_load
        int userId; //not assinged default value of 0
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion
        ///////////////////// 
        #region registar_user
        protected void Registar_user(object sender, EventArgs e)
        {
            int userId = 0;
            string constr = ConfigurationManager.ConnectionStrings["WebsiteReceitasDBcnstr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Insert_User"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", usersup.Text.ToString().Trim());
                        cmd.Parameters.AddWithValue("@UserPassword", passsup.Text.ToString().Trim());
                        cmd.Parameters.AddWithValue("@UserEmail", emailsup.Text.ToString().Trim());
                        cmd.Connection = con;
                        con.Open();
                        userId = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }
                }
                string message = string.Empty;
                switch (userId)
                {
                    case -1:
                        message = "O Username já existe, escolha outro!";
                        break;
                    case -2:
                        message = "Este email já existe!";
                        break;
                    default:
                        message = "Registo Concluido! Faça o Login!";
                        break;
                }
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + message + "');", true);
            }
        }
        #endregion
        ///////////////////// 
        #region User_Login
        protected void ValidateUser(object sender, EventArgs e)
        {
            int userId;
            string constr = ConfigurationManager.ConnectionStrings["WebsiteReceitasDBcnstr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Validate_User"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", username.Text);
                    cmd.Parameters.AddWithValue("@UserPassword", userpass.Text);
                    cmd.Connection = con;
                    con.Open();
                    userId = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                string message = string.Empty;
                switch (userId)
                {
                    case -1:
                        message = "Username ou Password incorrectos ou está banido!";
                        break;
                    default:  
                        Session["User"] = userId;
                        message = "Bem Vindo!";
                        Response.Redirect("PaginaInicial.aspx?");
                        break;
                }
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