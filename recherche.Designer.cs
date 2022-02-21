namespace examen
{
    partial class recherche
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbtest = new System.Windows.Forms.ComboBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.lstprojet = new System.Windows.Forms.ListBox();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.cbtache = new System.Windows.Forms.ComboBox();
            this.lblrecherche = new System.Windows.Forms.Label();
            this.lblservice = new System.Windows.Forms.Label();
            this.dgvemploye = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretache = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemploye)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnfind);
            this.panel1.Controls.Add(this.btnfirst);
            this.panel1.Controls.Add(this.cbtest);
            this.panel1.Controls.Add(this.btnlast);
            this.panel1.Controls.Add(this.btnprevious);
            this.panel1.Controls.Add(this.btnnext);
            this.panel1.Controls.Add(this.lstprojet);
            this.panel1.Controls.Add(this.txtfind);
            this.panel1.Controls.Add(this.cbtache);
            this.panel1.Controls.Add(this.lblrecherche);
            this.panel1.Controls.Add(this.lblservice);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 395);
            this.panel1.TabIndex = 12;
            // 
            // cbtest
            // 
            this.cbtest.FormattingEnabled = true;
            this.cbtest.Location = new System.Drawing.Point(89, 4);
            this.cbtest.Margin = new System.Windows.Forms.Padding(4);
            this.cbtest.Name = "cbtest";
            this.cbtest.Size = new System.Drawing.Size(81, 24);
            this.cbtest.TabIndex = 21;
            this.cbtest.Visible = false;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(259, 49);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(96, 28);
            this.btnfind.TabIndex = 20;
            this.btnfind.Text = "recherche";
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(241, 331);
            this.btnfirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(60, 28);
            this.btnfirst.TabIndex = 19;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(159, 331);
            this.btnlast.Margin = new System.Windows.Forms.Padding(4);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(60, 28);
            this.btnlast.TabIndex = 18;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = true;
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(89, 331);
            this.btnprevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(60, 28);
            this.btnprevious.TabIndex = 17;
            this.btnprevious.Text = "<";
            this.btnprevious.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(4, 331);
            this.btnnext.Margin = new System.Windows.Forms.Padding(4);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(60, 28);
            this.btnnext.TabIndex = 16;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            // 
            // lstprojet
            // 
            this.lstprojet.FormattingEnabled = true;
            this.lstprojet.ItemHeight = 16;
            this.lstprojet.Location = new System.Drawing.Point(4, 84);
            this.lstprojet.Margin = new System.Windows.Forms.Padding(4);
            this.lstprojet.Name = "lstprojet";
            this.lstprojet.Size = new System.Drawing.Size(296, 228);
            this.lstprojet.TabIndex = 15;
            this.lstprojet.SelectedIndexChanged += new System.EventHandler(this.lstprojet_SelectedIndexChanged);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(89, 52);
            this.txtfind.Margin = new System.Windows.Forms.Padding(4);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(160, 22);
            this.txtfind.TabIndex = 14;
            // 
            // cbtache
            // 
            this.cbtache.FormattingEnabled = true;
            this.cbtache.Location = new System.Drawing.Point(89, 7);
            this.cbtache.Margin = new System.Windows.Forms.Padding(4);
            this.cbtache.Name = "cbtache";
            this.cbtache.Size = new System.Drawing.Size(160, 24);
            this.cbtache.TabIndex = 13;
            this.cbtache.SelectedIndexChanged += new System.EventHandler(this.cbtache_SelectedIndexChanged);
            // 
            // lblrecherche
            // 
            this.lblrecherche.AutoSize = true;
            this.lblrecherche.Location = new System.Drawing.Point(9, 54);
            this.lblrecherche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrecherche.Name = "lblrecherche";
            this.lblrecherche.Size = new System.Drawing.Size(77, 17);
            this.lblrecherche.TabIndex = 12;
            this.lblrecherche.Text = "rechercher";
            // 
            // lblservice
            // 
            this.lblservice.AutoSize = true;
            this.lblservice.Location = new System.Drawing.Point(1, 11);
            this.lblservice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblservice.Name = "lblservice";
            this.lblservice.Size = new System.Drawing.Size(90, 17);
            this.lblservice.TabIndex = 11;
            this.lblservice.Text = "NOM TACHE";
            // 
            // dgvemploye
            // 
            this.dgvemploye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvemploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.nombretache});
            this.dgvemploye.Location = new System.Drawing.Point(369, 97);
            this.dgvemploye.Name = "dgvemploye";
            this.dgvemploye.RowTemplate.Height = 24;
            this.dgvemploye.Size = new System.Drawing.Size(386, 311);
            this.dgvemploye.TabIndex = 22;
            this.dgvemploye.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemploye_CellContentClick);
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            // 
            // nombretache
            // 
            this.nombretache.HeaderText = "nombre des heures";
            this.nombretache.Name = "nombretache";
            // 
            // lblsum
            // 
            this.lblsum.AutoSize = true;
            this.lblsum.Location = new System.Drawing.Point(287, 468);
            this.lblsum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(16, 17);
            this.lblsum.TabIndex = 22;
            this.lblsum.Text = "h";
            // 
            // recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.lblsum);
            this.Controls.Add(this.dgvemploye);
            this.Controls.Add(this.panel1);
            this.Name = "recherche";
            this.Text = "recherche";
            this.Load += new System.EventHandler(this.recherche_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbtest;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.ListBox lstprojet;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.ComboBox cbtache;
        private System.Windows.Forms.Label lblrecherche;
        private System.Windows.Forms.Label lblservice;
        private System.Windows.Forms.DataGridView dgvemploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretache;
        private System.Windows.Forms.Label lblsum;
    }
}