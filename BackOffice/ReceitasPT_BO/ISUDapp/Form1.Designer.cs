namespace ISUDapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPCOMENTARIOS = new System.Windows.Forms.Button();
            this.btnIngredientesP = new System.Windows.Forms.Button();
            this.btnreceitas = new System.Windows.Forms.Button();
            this.BTNPUSER = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmini = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ingredientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.websiteReceitasDataSet = new ISUDapp.WebsiteReceitasDataSet();
            this.ingredientesTableAdapter = new ISUDapp.WebsiteReceitasDataSetTableAdapters.IngredientesTableAdapter();
            this.btnUserDesbanir = new System.Windows.Forms.Button();
            this.cboxUserBanPU = new System.Windows.Forms.ComboBox();
            this.btnUserBan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxUserubanPU = new System.Windows.Forms.ComboBox();
            this.painelReceita = new System.Windows.Forms.Panel();
            this.btnDR = new System.Windows.Forms.Button();
            this.btnBR = new System.Windows.Forms.Button();
            this.lblAR = new System.Windows.Forms.Label();
            this.lblDR = new System.Windows.Forms.Label();
            this.lblBR = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAprovarPR = new System.Windows.Forms.Button();
            this.cboxnaoaprovadas = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxPRrBAN = new System.Windows.Forms.ComboBox();
            this.cboxPRruban = new System.Windows.Forms.ComboBox();
            this.PainelUser = new System.Windows.Forms.Panel();
            this.lblstatususeruban = new System.Windows.Forms.Label();
            this.lblstatususerBAN = new System.Windows.Forms.Label();
            this.PainelIngrediente = new System.Windows.Forms.Panel();
            this.lblstatusING = new System.Windows.Forms.Label();
            this.btnIingrediente = new System.Windows.Forms.Button();
            this.txtingredientenome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxPIngredienteuban = new System.Windows.Forms.ComboBox();
            this.PainelComment = new System.Windows.Forms.Panel();
            this.lblAC = new System.Windows.Forms.Label();
            this.lblUC = new System.Windows.Forms.Label();
            this.lblBC = new System.Windows.Forms.Label();
            this.btncommentAPR = new System.Windows.Forms.Button();
            this.cboxcommentUA = new System.Windows.Forms.ComboBox();
            this.btnCommentUBAN = new System.Windows.Forms.Button();
            this.cboxCommentUBAN = new System.Windows.Forms.ComboBox();
            this.btncommentban = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboxPCcomment = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnT5Y = new System.Windows.Forms.Button();
            this.btnT5N = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteReceitasDataSet)).BeginInit();
            this.painelReceita.SuspendLayout();
            this.PainelUser.SuspendLayout();
            this.PainelIngrediente.SuspendLayout();
            this.PainelComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPCOMENTARIOS);
            this.panel1.Controls.Add(this.btnIngredientesP);
            this.panel1.Controls.Add(this.btnreceitas);
            this.panel1.Controls.Add(this.BTNPUSER);
            this.panel1.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnPCOMENTARIOS
            // 
            this.btnPCOMENTARIOS.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPCOMENTARIOS, "btnPCOMENTARIOS");
            this.btnPCOMENTARIOS.Name = "btnPCOMENTARIOS";
            this.btnPCOMENTARIOS.UseVisualStyleBackColor = true;
            this.btnPCOMENTARIOS.Click += new System.EventHandler(this.btnPCOMENTARIOS_Click);
            // 
            // btnIngredientesP
            // 
            resources.ApplyResources(this.btnIngredientesP, "btnIngredientesP");
            this.btnIngredientesP.FlatAppearance.BorderSize = 0;
            this.btnIngredientesP.Name = "btnIngredientesP";
            this.btnIngredientesP.UseVisualStyleBackColor = true;
            this.btnIngredientesP.Click += new System.EventHandler(this.btnIngredientesP_Click_1);
            // 
            // btnreceitas
            // 
            this.btnreceitas.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnreceitas, "btnreceitas");
            this.btnreceitas.Name = "btnreceitas";
            this.btnreceitas.UseVisualStyleBackColor = true;
            this.btnreceitas.Click += new System.EventHandler(this.btnreceitas_Click);
            // 
            // BTNPUSER
            // 
            this.BTNPUSER.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BTNPUSER, "BTNPUSER");
            this.BTNPUSER.Name = "BTNPUSER";
            this.BTNPUSER.UseVisualStyleBackColor = true;
            this.BTNPUSER.Click += new System.EventHandler(this.BTNPUSER_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(72)))), ((int)(((byte)(150)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.label1);
            this.panel3.Name = "panel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label1.Name = "label1";
            // 
            // btnmini
            // 
            resources.ApplyResources(this.btnmini, "btnmini");
            this.btnmini.FlatAppearance.BorderSize = 0;
            this.btnmini.Name = "btnmini";
            this.btnmini.UseVisualStyleBackColor = true;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            // 
            // btnclose
            // 
            resources.ApplyResources(this.btnclose, "btnclose");
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.Name = "btnclose";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // ingredientesBindingSource
            // 
            this.ingredientesBindingSource.DataMember = "Ingredientes";
            this.ingredientesBindingSource.DataSource = this.websiteReceitasDataSet;
            // 
            // websiteReceitasDataSet
            // 
            this.websiteReceitasDataSet.DataSetName = "WebsiteReceitasDataSet";
            this.websiteReceitasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientesTableAdapter
            // 
            this.ingredientesTableAdapter.ClearBeforeFill = true;
            // 
            // btnUserDesbanir
            // 
            resources.ApplyResources(this.btnUserDesbanir, "btnUserDesbanir");
            this.btnUserDesbanir.Name = "btnUserDesbanir";
            this.btnUserDesbanir.UseVisualStyleBackColor = true;
            this.btnUserDesbanir.Click += new System.EventHandler(this.btnUserDesbanir_Click);
            // 
            // cboxUserBanPU
            // 
            this.cboxUserBanPU.FormattingEnabled = true;
            resources.ApplyResources(this.cboxUserBanPU, "cboxUserBanPU");
            this.cboxUserBanPU.Name = "cboxUserBanPU";
            this.cboxUserBanPU.SelectedIndexChanged += new System.EventHandler(this.cboxUserBanPU_SelectedIndexChanged);
            // 
            // btnUserBan
            // 
            resources.ApplyResources(this.btnUserBan, "btnUserBan");
            this.btnUserBan.Name = "btnUserBan";
            this.btnUserBan.UseVisualStyleBackColor = true;
            this.btnUserBan.Click += new System.EventHandler(this.btnUserBan_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // cboxUserubanPU
            // 
            this.cboxUserubanPU.FormattingEnabled = true;
            resources.ApplyResources(this.cboxUserubanPU, "cboxUserubanPU");
            this.cboxUserubanPU.Name = "cboxUserubanPU";
            this.cboxUserubanPU.SelectedIndexChanged += new System.EventHandler(this.cboxUserubanPU_SelectedIndexChanged);
            // 
            // painelReceita
            // 
            this.painelReceita.Controls.Add(this.btnT5N);
            this.painelReceita.Controls.Add(this.btnT5Y);
            this.painelReceita.Controls.Add(this.btnDR);
            this.painelReceita.Controls.Add(this.btnBR);
            this.painelReceita.Controls.Add(this.lblAR);
            this.painelReceita.Controls.Add(this.lblDR);
            this.painelReceita.Controls.Add(this.lblBR);
            this.painelReceita.Controls.Add(this.label11);
            this.painelReceita.Controls.Add(this.label7);
            this.painelReceita.Controls.Add(this.label6);
            this.painelReceita.Controls.Add(this.btnAprovarPR);
            this.painelReceita.Controls.Add(this.cboxnaoaprovadas);
            this.painelReceita.Controls.Add(this.label13);
            this.painelReceita.Controls.Add(this.cboxPRrBAN);
            this.painelReceita.Controls.Add(this.cboxPRruban);
            resources.ApplyResources(this.painelReceita, "painelReceita");
            this.painelReceita.Name = "painelReceita";
            // 
            // btnDR
            // 
            resources.ApplyResources(this.btnDR, "btnDR");
            this.btnDR.Name = "btnDR";
            this.btnDR.UseVisualStyleBackColor = true;
            this.btnDR.Click += new System.EventHandler(this.btnDR_Click);
            // 
            // btnBR
            // 
            resources.ApplyResources(this.btnBR, "btnBR");
            this.btnBR.Name = "btnBR";
            this.btnBR.UseVisualStyleBackColor = true;
            this.btnBR.Click += new System.EventHandler(this.btnBR_Click);
            // 
            // lblAR
            // 
            resources.ApplyResources(this.lblAR, "lblAR");
            this.lblAR.Name = "lblAR";
            // 
            // lblDR
            // 
            resources.ApplyResources(this.lblDR, "lblDR");
            this.lblDR.Name = "lblDR";
            // 
            // lblBR
            // 
            resources.ApplyResources(this.lblBR, "lblBR");
            this.lblBR.Name = "lblBR";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnAprovarPR
            // 
            resources.ApplyResources(this.btnAprovarPR, "btnAprovarPR");
            this.btnAprovarPR.Name = "btnAprovarPR";
            this.btnAprovarPR.UseVisualStyleBackColor = true;
            this.btnAprovarPR.Click += new System.EventHandler(this.btnAprovarPR_Click);
            // 
            // cboxnaoaprovadas
            // 
            this.cboxnaoaprovadas.FormattingEnabled = true;
            resources.ApplyResources(this.cboxnaoaprovadas, "cboxnaoaprovadas");
            this.cboxnaoaprovadas.Name = "cboxnaoaprovadas";
            this.cboxnaoaprovadas.SelectedIndexChanged += new System.EventHandler(this.cboxnaoaprovadas_SelectedIndexChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // cboxPRrBAN
            // 
            this.cboxPRrBAN.FormattingEnabled = true;
            resources.ApplyResources(this.cboxPRrBAN, "cboxPRrBAN");
            this.cboxPRrBAN.Name = "cboxPRrBAN";
            this.cboxPRrBAN.SelectedIndexChanged += new System.EventHandler(this.cboxPRrBAN_SelectedIndexChanged);
            // 
            // cboxPRruban
            // 
            this.cboxPRruban.FormattingEnabled = true;
            resources.ApplyResources(this.cboxPRruban, "cboxPRruban");
            this.cboxPRruban.Name = "cboxPRruban";
            this.cboxPRruban.SelectedIndexChanged += new System.EventHandler(this.cboxPRruban_SelectedIndexChanged);
            // 
            // PainelUser
            // 
            this.PainelUser.Controls.Add(this.lblstatususeruban);
            this.PainelUser.Controls.Add(this.lblstatususerBAN);
            this.PainelUser.Controls.Add(this.label9);
            this.PainelUser.Controls.Add(this.btnUserBan);
            this.PainelUser.Controls.Add(this.label8);
            this.PainelUser.Controls.Add(this.cboxUserBanPU);
            this.PainelUser.Controls.Add(this.btnUserDesbanir);
            this.PainelUser.Controls.Add(this.cboxUserubanPU);
            resources.ApplyResources(this.PainelUser, "PainelUser");
            this.PainelUser.Name = "PainelUser";
            // 
            // lblstatususeruban
            // 
            resources.ApplyResources(this.lblstatususeruban, "lblstatususeruban");
            this.lblstatususeruban.Name = "lblstatususeruban";
            // 
            // lblstatususerBAN
            // 
            resources.ApplyResources(this.lblstatususerBAN, "lblstatususerBAN");
            this.lblstatususerBAN.Name = "lblstatususerBAN";
            // 
            // PainelIngrediente
            // 
            this.PainelIngrediente.Controls.Add(this.lblstatusING);
            this.PainelIngrediente.Controls.Add(this.btnIingrediente);
            this.PainelIngrediente.Controls.Add(this.txtingredientenome);
            this.PainelIngrediente.Controls.Add(this.label4);
            this.PainelIngrediente.Controls.Add(this.label10);
            this.PainelIngrediente.Controls.Add(this.cboxPIngredienteuban);
            resources.ApplyResources(this.PainelIngrediente, "PainelIngrediente");
            this.PainelIngrediente.Name = "PainelIngrediente";
            // 
            // lblstatusING
            // 
            resources.ApplyResources(this.lblstatusING, "lblstatusING");
            this.lblstatusING.Name = "lblstatusING";
            // 
            // btnIingrediente
            // 
            resources.ApplyResources(this.btnIingrediente, "btnIingrediente");
            this.btnIingrediente.Name = "btnIingrediente";
            this.btnIingrediente.UseVisualStyleBackColor = true;
            this.btnIingrediente.Click += new System.EventHandler(this.btnIingrediente_Click);
            // 
            // txtingredientenome
            // 
            resources.ApplyResources(this.txtingredientenome, "txtingredientenome");
            this.txtingredientenome.Name = "txtingredientenome";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // cboxPIngredienteuban
            // 
            this.cboxPIngredienteuban.FormattingEnabled = true;
            resources.ApplyResources(this.cboxPIngredienteuban, "cboxPIngredienteuban");
            this.cboxPIngredienteuban.Name = "cboxPIngredienteuban";
            // 
            // PainelComment
            // 
            this.PainelComment.Controls.Add(this.lblAC);
            this.PainelComment.Controls.Add(this.lblUC);
            this.PainelComment.Controls.Add(this.lblBC);
            this.PainelComment.Controls.Add(this.btncommentAPR);
            this.PainelComment.Controls.Add(this.cboxcommentUA);
            this.PainelComment.Controls.Add(this.btnCommentUBAN);
            this.PainelComment.Controls.Add(this.cboxCommentUBAN);
            this.PainelComment.Controls.Add(this.btncommentban);
            this.PainelComment.Controls.Add(this.label5);
            this.PainelComment.Controls.Add(this.label2);
            this.PainelComment.Controls.Add(this.label12);
            this.PainelComment.Controls.Add(this.cboxPCcomment);
            resources.ApplyResources(this.PainelComment, "PainelComment");
            this.PainelComment.Name = "PainelComment";
            // 
            // lblAC
            // 
            resources.ApplyResources(this.lblAC, "lblAC");
            this.lblAC.Name = "lblAC";
            // 
            // lblUC
            // 
            resources.ApplyResources(this.lblUC, "lblUC");
            this.lblUC.Name = "lblUC";
            // 
            // lblBC
            // 
            resources.ApplyResources(this.lblBC, "lblBC");
            this.lblBC.Name = "lblBC";
            // 
            // btncommentAPR
            // 
            resources.ApplyResources(this.btncommentAPR, "btncommentAPR");
            this.btncommentAPR.Name = "btncommentAPR";
            this.btncommentAPR.UseVisualStyleBackColor = true;
            this.btncommentAPR.Click += new System.EventHandler(this.btncommentAPR_Click);
            // 
            // cboxcommentUA
            // 
            this.cboxcommentUA.FormattingEnabled = true;
            resources.ApplyResources(this.cboxcommentUA, "cboxcommentUA");
            this.cboxcommentUA.Name = "cboxcommentUA";
            this.cboxcommentUA.SelectedIndexChanged += new System.EventHandler(this.cboxcommentUA_SelectedIndexChanged);
            // 
            // btnCommentUBAN
            // 
            resources.ApplyResources(this.btnCommentUBAN, "btnCommentUBAN");
            this.btnCommentUBAN.Name = "btnCommentUBAN";
            this.btnCommentUBAN.UseVisualStyleBackColor = true;
            this.btnCommentUBAN.Click += new System.EventHandler(this.btnCommentUBAN_Click);
            // 
            // cboxCommentUBAN
            // 
            this.cboxCommentUBAN.FormattingEnabled = true;
            resources.ApplyResources(this.cboxCommentUBAN, "cboxCommentUBAN");
            this.cboxCommentUBAN.Name = "cboxCommentUBAN";
            this.cboxCommentUBAN.SelectedIndexChanged += new System.EventHandler(this.cboxCommentUBAN_SelectedIndexChanged);
            // 
            // btncommentban
            // 
            resources.ApplyResources(this.btncommentban, "btncommentban");
            this.btncommentban.Name = "btncommentban";
            this.btncommentban.UseVisualStyleBackColor = true;
            this.btncommentban.Click += new System.EventHandler(this.btncommentban_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // cboxPCcomment
            // 
            this.cboxPCcomment.FormattingEnabled = true;
            resources.ApplyResources(this.cboxPCcomment, "cboxPCcomment");
            this.cboxPCcomment.Name = "cboxPCcomment";
            this.cboxPCcomment.SelectedIndexChanged += new System.EventHandler(this.cboxPCcomment_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btnT5Y
            // 
            resources.ApplyResources(this.btnT5Y, "btnT5Y");
            this.btnT5Y.Name = "btnT5Y";
            this.btnT5Y.UseVisualStyleBackColor = true;
            this.btnT5Y.Click += new System.EventHandler(this.btnT5Y_Click);
            // 
            // btnT5N
            // 
            resources.ApplyResources(this.btnT5N, "btnT5N");
            this.btnT5N.Name = "btnT5N";
            this.btnT5N.UseVisualStyleBackColor = true;
            this.btnT5N.Click += new System.EventHandler(this.btnT5N_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnmini);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.PainelComment);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.PainelIngrediente);
            this.Controls.Add(this.PainelUser);
            this.Controls.Add(this.painelReceita);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteReceitasDataSet)).EndInit();
            this.painelReceita.ResumeLayout(false);
            this.painelReceita.PerformLayout();
            this.PainelUser.ResumeLayout(false);
            this.PainelUser.PerformLayout();
            this.PainelIngrediente.ResumeLayout(false);
            this.PainelIngrediente.PerformLayout();
            this.PainelComment.ResumeLayout(false);
            this.PainelComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNPUSER;
        private System.Windows.Forms.Button btnreceitas;
        private System.Windows.Forms.Button btnIngredientesP;
        private System.Windows.Forms.Button btnPCOMENTARIOS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnmini;
        private System.Windows.Forms.Button btnclose;
        private WebsiteReceitasDataSet websiteReceitasDataSet;
        private System.Windows.Forms.BindingSource ingredientesBindingSource;
        private WebsiteReceitasDataSetTableAdapters.IngredientesTableAdapter ingredientesTableAdapter;
        private System.Windows.Forms.Button btnUserBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxUserubanPU;
        private System.Windows.Forms.Button btnUserDesbanir;
        private System.Windows.Forms.ComboBox cboxUserBanPU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel painelReceita;
        private System.Windows.Forms.Panel PainelUser;
        private System.Windows.Forms.Panel PainelIngrediente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxPIngredienteuban;
        private System.Windows.Forms.Panel PainelComment;
        private System.Windows.Forms.Button btnCommentUBAN;
        private System.Windows.Forms.ComboBox cboxCommentUBAN;
        private System.Windows.Forms.Button btncommentban;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboxPCcomment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboxPRrBAN;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboxPRruban;
        private System.Windows.Forms.Button btnAprovarPR;
        private System.Windows.Forms.ComboBox cboxnaoaprovadas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIingrediente;
        private System.Windows.Forms.TextBox txtingredientenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblstatusING;
        private System.Windows.Forms.Label lblstatususeruban;
        private System.Windows.Forms.Label lblstatususerBAN;
        private System.Windows.Forms.Button btncommentAPR;
        private System.Windows.Forms.ComboBox cboxcommentUA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.Label lblUC;
        private System.Windows.Forms.Label lblBC;
        private System.Windows.Forms.Label lblAR;
        private System.Windows.Forms.Label lblDR;
        private System.Windows.Forms.Label lblBR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBR;
        private System.Windows.Forms.Button btnDR;
        private System.Windows.Forms.Button btnT5N;
        private System.Windows.Forms.Button btnT5Y;
    }
}

