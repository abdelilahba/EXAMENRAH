namespace examen
{
    partial class misajour
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
            this.lstmatricule = new System.Windows.Forms.ListBox();
            this.cbtest = new System.Windows.Forms.ComboBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.lstemploye = new System.Windows.Forms.ListBox();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.cbservice = new System.Windows.Forms.ComboBox();
            this.lblrecherche = new System.Windows.Forms.Label();
            this.lblservice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtnumser = new System.Windows.Forms.TextBox();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.txtsalaire = new System.Windows.Forms.TextBox();
            this.txtdatenaissance = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtmatricule = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.Label();
            this.lblsalaire = new System.Windows.Forms.Label();
            this.ldbdatenai = new System.Windows.Forms.Label();
            this.lbladresse = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblmatricule = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsupprime = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstmatricule);
            this.panel1.Controls.Add(this.cbtest);
            this.panel1.Controls.Add(this.btnfind);
            this.panel1.Controls.Add(this.btnfirst);
            this.panel1.Controls.Add(this.btnlast);
            this.panel1.Controls.Add(this.btnprevious);
            this.panel1.Controls.Add(this.btnnext);
            this.panel1.Controls.Add(this.lstemploye);
            this.panel1.Controls.Add(this.txtfind);
            this.panel1.Controls.Add(this.cbservice);
            this.panel1.Controls.Add(this.lblrecherche);
            this.panel1.Controls.Add(this.lblservice);
            this.panel1.Location = new System.Drawing.Point(33, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 395);
            this.panel1.TabIndex = 11;
            // 
            // lstmatricule
            // 
            this.lstmatricule.FormattingEnabled = true;
            this.lstmatricule.ItemHeight = 16;
            this.lstmatricule.Location = new System.Drawing.Point(4, 178);
            this.lstmatricule.Margin = new System.Windows.Forms.Padding(4);
            this.lstmatricule.Name = "lstmatricule";
            this.lstmatricule.Size = new System.Drawing.Size(219, 132);
            this.lstmatricule.TabIndex = 36;
            this.lstmatricule.Visible = false;
            // 
            // cbtest
            // 
            this.cbtest.FormattingEnabled = true;
            this.cbtest.Location = new System.Drawing.Point(88, 8);
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
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
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
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
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
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
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
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
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
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lstemploye
            // 
            this.lstemploye.FormattingEnabled = true;
            this.lstemploye.ItemHeight = 16;
            this.lstemploye.Location = new System.Drawing.Point(4, 84);
            this.lstemploye.Margin = new System.Windows.Forms.Padding(4);
            this.lstemploye.Name = "lstemploye";
            this.lstemploye.Size = new System.Drawing.Size(296, 228);
            this.lstemploye.TabIndex = 15;
            this.lstemploye.SelectedIndexChanged += new System.EventHandler(this.lstemploye_SelectedIndexChanged);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(89, 52);
            this.txtfind.Margin = new System.Windows.Forms.Padding(4);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(160, 22);
            this.txtfind.TabIndex = 14;
            // 
            // cbservice
            // 
            this.cbservice.FormattingEnabled = true;
            this.cbservice.Location = new System.Drawing.Point(89, 7);
            this.cbservice.Margin = new System.Windows.Forms.Padding(4);
            this.cbservice.Name = "cbservice";
            this.cbservice.Size = new System.Drawing.Size(160, 24);
            this.cbservice.TabIndex = 13;
            this.cbservice.SelectedIndexChanged += new System.EventHandler(this.cbservice_SelectedIndexChanged);
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
            this.lblservice.Location = new System.Drawing.Point(27, 11);
            this.lblservice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblservice.Name = "lblservice";
            this.lblservice.Size = new System.Drawing.Size(53, 17);
            this.lblservice.TabIndex = 11;
            this.lblservice.Text = "service";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtnumser);
            this.panel2.Controls.Add(this.txtgrade);
            this.panel2.Controls.Add(this.txtsalaire);
            this.panel2.Controls.Add(this.txtdatenaissance);
            this.panel2.Controls.Add(this.txtadresse);
            this.panel2.Controls.Add(this.txtprenom);
            this.panel2.Controls.Add(this.txtnom);
            this.panel2.Controls.Add(this.txtmatricule);
            this.panel2.Controls.Add(this.grade);
            this.panel2.Controls.Add(this.lblsalaire);
            this.panel2.Controls.Add(this.ldbdatenai);
            this.panel2.Controls.Add(this.lbladresse);
            this.panel2.Controls.Add(this.lblprenom);
            this.panel2.Controls.Add(this.lblnom);
            this.panel2.Controls.Add(this.lblmatricule);
            this.panel2.Location = new System.Drawing.Point(431, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 395);
            this.panel2.TabIndex = 12;
            // 
            // txtnumser
            // 
            this.txtnumser.Location = new System.Drawing.Point(127, 361);
            this.txtnumser.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumser.Name = "txtnumser";
            this.txtnumser.Size = new System.Drawing.Size(160, 22);
            this.txtnumser.TabIndex = 34;
            this.txtnumser.Visible = false;
            // 
            // txtgrade
            // 
            this.txtgrade.Location = new System.Drawing.Point(127, 331);
            this.txtgrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(160, 22);
            this.txtgrade.TabIndex = 33;
            // 
            // txtsalaire
            // 
            this.txtsalaire.Location = new System.Drawing.Point(127, 288);
            this.txtsalaire.Margin = new System.Windows.Forms.Padding(4);
            this.txtsalaire.Name = "txtsalaire";
            this.txtsalaire.Size = new System.Drawing.Size(160, 22);
            this.txtsalaire.TabIndex = 32;
            // 
            // txtdatenaissance
            // 
            this.txtdatenaissance.Location = new System.Drawing.Point(127, 241);
            this.txtdatenaissance.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatenaissance.Name = "txtdatenaissance";
            this.txtdatenaissance.Size = new System.Drawing.Size(160, 22);
            this.txtdatenaissance.TabIndex = 31;
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(127, 196);
            this.txtadresse.Margin = new System.Windows.Forms.Padding(4);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(160, 22);
            this.txtadresse.TabIndex = 30;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(127, 153);
            this.txtprenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(160, 22);
            this.txtprenom.TabIndex = 29;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(127, 98);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(160, 22);
            this.txtnom.TabIndex = 28;
            // 
            // txtmatricule
            // 
            this.txtmatricule.Location = new System.Drawing.Point(127, 54);
            this.txtmatricule.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatricule.Name = "txtmatricule";
            this.txtmatricule.Size = new System.Drawing.Size(160, 22);
            this.txtmatricule.TabIndex = 21;
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(27, 342);
            this.grade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(45, 17);
            this.grade.TabIndex = 27;
            this.grade.Text = "grade";
            // 
            // lblsalaire
            // 
            this.lblsalaire.AutoSize = true;
            this.lblsalaire.Location = new System.Drawing.Point(27, 302);
            this.lblsalaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsalaire.Name = "lblsalaire";
            this.lblsalaire.Size = new System.Drawing.Size(50, 17);
            this.lblsalaire.TabIndex = 26;
            this.lblsalaire.Text = "salaire";
            // 
            // ldbdatenai
            // 
            this.ldbdatenai.AutoSize = true;
            this.ldbdatenai.Location = new System.Drawing.Point(0, 245);
            this.ldbdatenai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldbdatenai.Name = "ldbdatenai";
            this.ldbdatenai.Size = new System.Drawing.Size(124, 17);
            this.ldbdatenai.TabIndex = 25;
            this.ldbdatenai.Text = "date de naissance";
            // 
            // lbladresse
            // 
            this.lbladresse.AutoSize = true;
            this.lbladresse.Location = new System.Drawing.Point(15, 199);
            this.lbladresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladresse.Name = "lbladresse";
            this.lbladresse.Size = new System.Drawing.Size(59, 17);
            this.lbladresse.TabIndex = 24;
            this.lbladresse.Text = "adresse";
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(27, 153);
            this.lblprenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(56, 17);
            this.lblprenom.TabIndex = 23;
            this.lblprenom.Text = "prenom";
            this.lblprenom.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(27, 98);
            this.lblnom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(35, 17);
            this.lblnom.TabIndex = 22;
            this.lblnom.Text = "nom";
            // 
            // lblmatricule
            // 
            this.lblmatricule.AutoSize = true;
            this.lblmatricule.Location = new System.Drawing.Point(8, 54);
            this.lblmatricule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatricule.Name = "lblmatricule";
            this.lblmatricule.Size = new System.Drawing.Size(65, 17);
            this.lblmatricule.TabIndex = 21;
            this.lblmatricule.Text = "matricule";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnsupprime);
            this.panel3.Controls.Add(this.btnedit);
            this.panel3.Controls.Add(this.btnadd);
            this.panel3.Location = new System.Drawing.Point(409, 418);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 75);
            this.panel3.TabIndex = 34;
            // 
            // btnsupprime
            // 
            this.btnsupprime.Location = new System.Drawing.Point(306, 22);
            this.btnsupprime.Margin = new System.Windows.Forms.Padding(4);
            this.btnsupprime.Name = "btnsupprime";
            this.btnsupprime.Size = new System.Drawing.Size(100, 28);
            this.btnsupprime.TabIndex = 2;
            this.btnsupprime.Text = "suprimme";
            this.btnsupprime.UseVisualStyleBackColor = true;
            this.btnsupprime.Click += new System.EventHandler(this.btnsupprime_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(151, 22);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 28);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "modifier";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(4, 22);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 28);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(20, 18);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 28);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "valider";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(188, 18);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(100, 28);
            this.btnclose.TabIndex = 35;
            this.btnclose.Text = "annuler";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnsave);
            this.panel4.Controls.Add(this.btnclose);
            this.panel4.Location = new System.Drawing.Point(443, 521);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 75);
            this.panel4.TabIndex = 35;
            // 
            // misajour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 641);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "misajour";
            this.Text = "misajour";
            this.Load += new System.EventHandler(this.misajour_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.ListBox lstemploye;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.ComboBox cbservice;
        private System.Windows.Forms.Label lblrecherche;
        private System.Windows.Forms.Label lblservice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblmatricule;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.TextBox txtsalaire;
        private System.Windows.Forms.TextBox txtdatenaissance;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtmatricule;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label lblsalaire;
        private System.Windows.Forms.Label ldbdatenai;
        private System.Windows.Forms.Label lbladresse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsupprime;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lstmatricule;
        private System.Windows.Forms.ComboBox cbtest;
        private System.Windows.Forms.TextBox txtnumser;
    }
}