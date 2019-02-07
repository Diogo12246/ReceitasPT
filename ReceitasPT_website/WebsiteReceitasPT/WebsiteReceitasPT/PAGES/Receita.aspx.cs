using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using DAL;

namespace WebsiteReceitasPT.PAGES
{
    public partial class Receita : System.Web.UI.Page
    {
        /////////////////////
        #region declarações
        int userId;
        int ReceitaID;
        int userIdvoto;
        int userdireitovoto;
        int userdireitofavorito;
        string votoNum;
        string IDreceita;
        bool direitodevoto = true;
        bool direitodefavorito = true;
        bool direitodefavoritoremove = true;
        MANAGER M = new MANAGER();
        #endregion
        /////////////////////
        #region pageload
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IDreceita = Request.QueryString["IDreceita"];
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
                ValidateVoto();
                VotoMedia();
                ValidateFAV();
                #endregion
                /////////////////////
                #region ObterReceita_TodoinDALv2.0
                string ligacao = ConfigurationManager.ConnectionStrings["WebsiteReceitasDBcnstr"].ConnectionString;
                ReceitaID = 0;
                #region receberReceita
                using (SqlConnection con = new SqlConnection(ligacao))
                {
                    SqlCommand cmd = new SqlCommand("ObterReceitaEscolhida", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDreceita", IDreceita);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            receitanome.Text = reader["Receita"].ToString();
                            ReceitaDescricao.Text = reader["Descrição"].ToString();
                            receitaAutor.Text = reader["Autor"].ToString();
                            receitaCategoria.Text = reader["Categoria"].ToString();
                            receitaDificuldade.Text = reader["Dificuldade"].ToString();
                            receitaDuracao.Text = reader["Duração"].ToString();
                            ReceitaID = Int32.Parse(reader["ID"].ToString());
                            byte[] byteData = (byte[])reader["Imagem"];
                            imagemreceita.ImageUrl = "data:image;base64," + Convert.ToBase64String(byteData);
                        }
                    }
                }
                /////////////////////
                #region desespero puro
                MANAGER m = new MANAGER();
                DataSet ds = m.GetDataING(ReceitaID);
                DataSet dsCM = m.GetDataCM(ReceitaID);

                GridView1.DataSource = ds;
                GridView1.DataBind();

                Repeater1.DataSource = ds;
                Repeater1.DataBind();

                GridView2.DataSource = dsCM;
                GridView2.DataBind();

                Repeater2.DataSource = dsCM;
                Repeater2.DataBind();
                ////////// O QUE ESTOU EU A FAZER COM A MINHA VIDA? //////////
                #endregion
                /////////////////////
                #endregion
                /////////////////////
                #endregion
                /////////////////////
                #region votodisplay
                
                if (Convert.ToDouble(votoNum) > 0 && Convert.ToDouble(votoNum) <= 1)
                {
                    ratingimagem.ImageUrl = "~/RESOURCES/IMAGES/RATING/1.png";
                }
                else if (Convert.ToDouble(votoNum) > 1 && Convert.ToDouble(votoNum) <= 2)
                {
                    ratingimagem.ImageUrl = "~/RESOURCES/IMAGES/RATING/2.png";
                }
                else if (Convert.ToDouble(votoNum) > 2 && Convert.ToDouble(votoNum) <= 3)
                {
                    ratingimagem.ImageUrl = "~/RESOURCES/IMAGES/RATING/3.png";
                }
                else if (Convert.ToDouble(votoNum) > 3 && Convert.ToDouble(votoNum) <= 4)
                {
                    ratingimagem.ImageUrl = "~/RESOURCES/IMAGES/RATING/4.png";
                }
                else if (Convert.ToDouble(votoNum) > 4 && Convert.ToDouble(votoNum) <= 5)
                {
                    ratingimagem.ImageUrl = "~/RESOURCES/IMAGES/RATING/5.png";
                }
                #endregion
                /////////////////////
            }
            else
            {
                IDreceita = Request.QueryString["IDreceita"];
                ReceitaID = Convert.ToInt32(IDreceita);
                if (Session["User"] == null)
                {
                    userId = 0;
                }
                else
                {
                    userId = (int)(Session["User"]);
                }
                ValidateVoto();
                ValidateFAV();
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
        #region inserir_Comment_Voto
        protected void btninserircomment_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("LOGIN_REGISTAR.aspx");
            }
            else
            {
                string ComentarioTXT = txtcomment.Text;
                M.inserirComentario(ReceitaID, userId, ComentarioTXT);
            }
        }

        protected void votarreceita_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("LOGIN_REGISTAR.aspx");
            }
            else
            {
                if (direitodevoto == true)
                {
                    int Rating = Convert.ToInt32(vototxt.Text);
                    M.inserirVoto(ReceitaID, userId, Rating);
                }
                else
                {
                    votostatus.Text = "Você já votou";
                }
            }
        }
        #endregion
        /////////////////////
        #region User_Voto 
            //TODO IN DAL v2.0
        protected void ValidateVoto()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebsiteReceitasDBcnstr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Validate_Vote"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userID",userId);
                    cmd.Parameters.AddWithValue("@ReceitaID", Convert.ToInt32(IDreceita));
                    cmd.Connection = con;
                    con.Open();
                    userIdvoto = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                switch (userIdvoto)
                {
                    case 0:
                        votarreceita.Enabled = true;
                        direitodevoto = true;
                        break;
                    default:
                        votarreceita.Enabled = false;
                        direitodevoto = false;
                        votostatus.Text = "Você já votou";
                        votarreceita.Text = "Disabled";
                        break;
                }
            }
        }
        #endregion
        /////////////////////
        #region VotoMedia
        //TODO IN DAL v2.0
        protected void VotoMedia()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebsiteReceitasDBcnstr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("RatingMedia"))
                {
                    int intReceitaID = Convert.ToInt32(IDreceita);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReceitaID", intReceitaID);
                    cmd.Connection = con;
                    con.Open();
                    votoNum = cmd.ExecuteScalar().ToString();
                    if (votoNum == "")
                    {
                        votoNum = "1";
                    }
                    else
                    {
                        votoNum = votoNum.ToString();
                    }
                    con.Close();
                }
            }
        }
        #endregion
        /////////////////////
        #region User_FAV
        //TODO IN DAL v2.0
        protected void ValidateFAV()
        {
            string constr = ConfigurationManager.ConnectionStrings["WebsiteReceitasDBcnstr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Validate_FAV"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userID", userId);
                    cmd.Parameters.AddWithValue("@ReceitaID", Convert.ToInt32(IDreceita));
                    cmd.Connection = con;
                    con.Open();
                    userdireitofavorito = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                switch (userdireitofavorito)
                {
                    case 0:
                        addaosfav.Enabled = true;
                        direitodefavorito = true;
                        direitodefavoritoremove = false;
                        break;
                    default:
                        addaosfav.Enabled = false;
                        direitodefavorito = false;
                        direitodefavoritoremove = true;                  
                        break;
                }
            }
        }
        #endregion
        /////////////////////
        #region favoritos_add
        protected void addaosfav_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("LOGIN_REGISTAR.aspx");
            }
            else
            {
                if (direitodefavorito == true)
                {
                    int state = 1;
                    M.inserirnosFav(ReceitaID, userId, state);
                }
                else
                {
                    lblfavstatus.Text = "Você já tem esta receita nos favoritos";
                }
            }
        }
        #endregion
        /////////////////////
        #region favoritos_rem
        protected void remvdosfav_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("LOGIN_REGISTAR.aspx");
            }
            else
            {
                if (direitodefavoritoremove == true)
                {
                    M.removerdosFav(ReceitaID, userId);
                }
                else
                {
                    lblfavstatus.Text = "Você já não tem esta receita nos favoritos";
                }
            }
        }
        #endregion
        /////////////////////
    }
}