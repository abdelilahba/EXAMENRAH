namespace examen
{
    partial class menu
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
            this.bntmisajour = new System.Windows.Forms.Button();
            this.btnrecheche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntmisajour
            // 
            this.bntmisajour.Location = new System.Drawing.Point(261, 66);
            this.bntmisajour.Margin = new System.Windows.Forms.Padding(4);
            this.bntmisajour.Name = "bntmisajour";
            this.bntmisajour.Size = new System.Drawing.Size(368, 66);
            this.bntmisajour.TabIndex = 0;
            this.bntmisajour.Text = "misajour";
            this.bntmisajour.UseVisualStyleBackColor = true;
            this.bntmisajour.Click += new System.EventHandler(this.bntmisajour_Click);
            // 
            // btnrecheche
            // 
            this.btnrecheche.Location = new System.Drawing.Point(261, 171);
            this.btnrecheche.Margin = new System.Windows.Forms.Padding(4);
            this.btnrecheche.Name = "btnrecheche";
            this.btnrecheche.Size = new System.Drawing.Size(364, 66);
            this.btnrecheche.TabIndex = 1;
            this.btnrecheche.Text = "recheche";
            this.btnrecheche.UseVisualStyleBackColor = true;
            this.btnrecheche.Click += new System.EventHandler(this.btnrecheche_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 441);
            this.Controls.Add(this.btnrecheche);
            this.Controls.Add(this.bntmisajour);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu";
            this.Text = "form2";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntmisajour;
        private System.Windows.Forms.Button btnrecheche;
    }
}