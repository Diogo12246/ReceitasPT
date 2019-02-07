using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.IO;

namespace ISUDapp
{
    public partial class Form1 : Form
    {
        ///////////////////// 
        #region declaracoes_e_configuracoes_adicionais
        ///////////////////// 
        #region DAL VARIABLES
        //DAL ACCESS//
        USER u;
        INGREDIENT i;
        RECEITA r;
        COMMENT c;
        MANAGER m;
        //DAL ACCESS//
        string UserName;
        #endregion
        /////////////////// 
        #region FORMMOVER
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        #endregion
        ///////////////////// 
        #region formComponents
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        ///////////////////// 
        #endregion
        ///////////////////// 
        #region load_program
        private void Form1_Load(object sender, EventArgs e)
        {
            #region pictureboxesdefaultproperties
            #endregion
            Refreshdata();
        }
        #endregion
        ///////////////////// 
        #region atribuição_Sources
        public void Refreshdata()
        {
            m = new MANAGER();
            m.listadeIngredientes();
            foreach (INGREDIENT Ingrediente in m.listadeIngredientes())
            {
                if (!cboxPIngredienteuban.Items.Contains(Ingrediente.IngredienteNome))
                {
                    cboxPIngredienteuban.Items.Add(Ingrediente.IngredienteNome);
                }
            }

            cboxPCcomment.DataSource = m.listadeCMA();
            cboxCommentUBAN.DataSource = m.listadeCMB();
            cboxcommentUA.DataSource = m.listadeCMUA();
            cboxUserBanPU.DataSource = m.listadeUSERSbanidos();
            cboxUserubanPU.DataSource = m.listadeUSERS();
            cboxnaoaprovadas.DataSource = m.listadeRECEITASUA();
            cboxPRruban.DataSource = m.listadeRECEITASA();
            cboxPRrBAN.DataSource = m.listadeRECEITASB();
        }
        #endregion
        ///////////////////// 
        #region Configuracoes_de_app
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        ///////////////////// 
        #region Troca_de_Paineis
        private void BTNPUSER_Click(object sender, EventArgs e)
        {
            painelReceita.Visible = false;
            PainelIngrediente.Visible = false;
            PainelUser.Visible = true;
            PainelComment.Visible = false;
        }

        private void btnreceitas_Click(object sender, EventArgs e)
        {
            PainelUser.Visible = false;
            PainelIngrediente.Visible = false;
            painelReceita.Visible = true;
            PainelComment.Visible = false;
        }

        private void btnIngredientesP_Click_1(object sender, EventArgs e)
        {
            PainelIngrediente.Visible = true;
            painelReceita.Visible = false;
            PainelUser.Visible = false;
            PainelComment.Visible = false;
        }

        private void btnPCOMENTARIOS_Click(object sender, EventArgs e)
        {
            PainelUser.Visible = false;
            PainelIngrediente.Visible = false;
            painelReceita.Visible = false;
            PainelComment.Visible = true;
        }
        #endregion
        ///////////////////// 
        #region btns + indexchangers
        private void btnIingrediente_Click(object sender, EventArgs e)
        {
            i = new INGREDIENT();
            i.IngredienteNome = txtingredientenome.Text;
            m.InserirIngrediente(i);
            Refreshdata();
            lblstatusING.Text = "O ingrediente foi adicionado com sucesso!";
        }

        private void btnUserBan_Click(object sender, EventArgs e)
        {
            USER User = new USER();
            User = cboxUserubanPU.SelectedItem as USER;
            m.BanirUser(User);
            Refreshdata();
            lblstatususerBAN.Text = "Utilizador banido com sucesso!";
        }

        private void btnUserDesbanir_Click(object sender, EventArgs e)
        {
            USER User = new USER();
            User = cboxUserBanPU.SelectedItem as USER;
            m.DesbanirUser(User);
            Refreshdata();
            lblstatususeruban.Text = "Utilizador desbanido com sucesso!";
        }

        private void cboxUserubanPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserName = cboxUserubanPU.Text;
            lblstatususerBAN.Text = "";
        }

        private void cboxUserBanPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserName = cboxUserBanPU.Text;
            lblstatususeruban.Text = "";
        }

        private void btnAprovarPR_Click(object sender, EventArgs e)
        {
            RECEITA receita = new RECEITA();
            receita = cboxnaoaprovadas.SelectedItem as RECEITA;
            m.aprovarReceita(receita);
            Refreshdata();
            lblBR.Text = "Receita Aprovada!";
        }

        private void btncommentAPR_Click(object sender, EventArgs e)
        {
            COMMENT comment = new COMMENT();
            comment = cboxcommentUA.SelectedItem as COMMENT;
            m.aprovarCOMMENT(comment);
            Refreshdata();
            lblAC.Text = "Comentário Aprovado!";
        }

        private void btncommentban_Click(object sender, EventArgs e)
        {
            COMMENT comment = new COMMENT();
            comment = cboxPCcomment.SelectedItem as COMMENT;
            m.banirCOMMENT(comment);
            Refreshdata();
            lblBC.Text = "Comentário Banido!";
        }

        private void btnCommentUBAN_Click(object sender, EventArgs e)
        {
            COMMENT comment = new COMMENT();
            comment = cboxCommentUBAN.SelectedItem as COMMENT;
            m.unbanCOMMENT(comment);
            Refreshdata();
            lblUC.Text = "Comentário Desbanido!";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboxPCcomment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBC.Text = "";
        }

        private void cboxCommentUBAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUC.Text = "";
        }

        private void cboxcommentUA_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAC.Text = "";
        }

        private void cboxPRruban_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBR.Text = "";
        }

        private void cboxPRrBAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDR.Text = "";
        }

        private void cboxnaoaprovadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAR.Text = "";
        }

        private void btnBR_Click(object sender, EventArgs e)
        {
            RECEITA receita = new RECEITA();
            receita = cboxPRruban.SelectedItem as RECEITA;
            m.banirReceita(receita);
            Refreshdata();
            lblBR.Text = "Receita Banida!";
        }

        private void btnDR_Click(object sender, EventArgs e)
        {
            RECEITA receita = new RECEITA();
            receita = cboxPRrBAN.SelectedItem as RECEITA;
            m.desbanirReceita(receita);
            Refreshdata();
            lblDR.Text = "Receita Desbanida!";
        }

        private void btnT5Y_Click(object sender, EventArgs e)
        {
            RECEITA receita = new RECEITA();
            receita = cboxPRruban.SelectedItem as RECEITA;
            m.top5addR(receita);
            Refreshdata();
            lblBR.Text = "Receita adicionada ao TOP5";
        }

        private void btnT5N_Click(object sender, EventArgs e)
        {
            RECEITA receita = new RECEITA();
            receita = cboxPRruban.SelectedItem as RECEITA;
            m.top5remR(receita);
            Refreshdata();
            lblBR.Text = "Receita removida do TOP5";
        }
        #endregion
        ///////////////////// 
    }
}