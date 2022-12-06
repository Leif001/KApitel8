namespace KApitel8
{
    partial class sten_sax_påse
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
            this.gbxStenSaxPåse = new System.Windows.Forms.GroupBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblDatornValde = new System.Windows.Forms.Label();
            this.lblDatornsVal = new System.Windows.Forms.Label();
            this.pbxPåse = new System.Windows.Forms.PictureBox();
            this.pbxSax = new System.Windows.Forms.PictureBox();
            this.pbxSten = new System.Windows.Forms.PictureBox();
            this.gbxMinaResultat = new System.Windows.Forms.GroupBox();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.btnSpela = new System.Windows.Forms.Button();
            this.gbxStenSaxPåse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPåse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).BeginInit();
            this.gbxMinaResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStenSaxPåse
            // 
            this.gbxStenSaxPåse.Controls.Add(this.lblResultat);
            this.gbxStenSaxPåse.Controls.Add(this.lblDatornValde);
            this.gbxStenSaxPåse.Controls.Add(this.lblDatornsVal);
            this.gbxStenSaxPåse.Controls.Add(this.pbxPåse);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSax);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSten);
            this.gbxStenSaxPåse.Location = new System.Drawing.Point(80, 64);
            this.gbxStenSaxPåse.Name = "gbxStenSaxPåse";
            this.gbxStenSaxPåse.Size = new System.Drawing.Size(316, 190);
            this.gbxStenSaxPåse.TabIndex = 0;
            this.gbxStenSaxPåse.TabStop = false;
            this.gbxStenSaxPåse.Text = "Sten Sax Påse";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(16, 155);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(233, 23);
            this.lblResultat.TabIndex = 5;
            // 
            // lblDatornValde
            // 
            this.lblDatornValde.AutoSize = true;
            this.lblDatornValde.Location = new System.Drawing.Point(3, 131);
            this.lblDatornValde.Name = "lblDatornValde";
            this.lblDatornValde.Size = new System.Drawing.Size(71, 13);
            this.lblDatornValde.TabIndex = 4;
            this.lblDatornValde.Text = "Datorn valde:";
            // 
            // lblDatornsVal
            // 
            this.lblDatornsVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsVal.Location = new System.Drawing.Point(86, 121);
            this.lblDatornsVal.Name = "lblDatornsVal";
            this.lblDatornsVal.Size = new System.Drawing.Size(100, 23);
            this.lblDatornsVal.TabIndex = 3;
            // 
            // pbxPåse
            // 
            this.pbxPåse.Image = global::KApitel8.Properties.Resources._9183_1_2;
            this.pbxPåse.Location = new System.Drawing.Point(170, 35);
            this.pbxPåse.Name = "pbxPåse";
            this.pbxPåse.Size = new System.Drawing.Size(54, 50);
            this.pbxPåse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPåse.TabIndex = 2;
            this.pbxPåse.TabStop = false;
            this.pbxPåse.Click += new System.EventHandler(this.pbxPåse_Click);
            // 
            // pbxSax
            // 
            this.pbxSax.Image = global::KApitel8.Properties.Resources._2ntwvso1z6elh8cmn3fq7hehjnfza5ri;
            this.pbxSax.Location = new System.Drawing.Point(86, 34);
            this.pbxSax.Name = "pbxSax";
            this.pbxSax.Size = new System.Drawing.Size(56, 50);
            this.pbxSax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSax.TabIndex = 1;
            this.pbxSax.TabStop = false;
            this.pbxSax.Click += new System.EventHandler(this.pbxSax_Click);
            // 
            // pbxSten
            // 
            this.pbxSten.Image = global::KApitel8.Properties.Resources.Sten_Mellan_160x270mm_40158;
            this.pbxSten.Location = new System.Drawing.Point(6, 35);
            this.pbxSten.Name = "pbxSten";
            this.pbxSten.Size = new System.Drawing.Size(50, 50);
            this.pbxSten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSten.TabIndex = 0;
            this.pbxSten.TabStop = false;
            this.pbxSten.Click += new System.EventHandler(this.pbxSten_Click);
            // 
            // gbxMinaResultat
            // 
            this.gbxMinaResultat.Controls.Add(this.tbxMinaResultat);
            this.gbxMinaResultat.Location = new System.Drawing.Point(508, 98);
            this.gbxMinaResultat.Name = "gbxMinaResultat";
            this.gbxMinaResultat.Size = new System.Drawing.Size(200, 100);
            this.gbxMinaResultat.TabIndex = 1;
            this.gbxMinaResultat.TabStop = false;
            this.gbxMinaResultat.Text = "Mina resultat";
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(7, 30);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(151, 64);
            this.tbxMinaResultat.TabIndex = 0;
            // 
            // btnSpela
            // 
            this.btnSpela.Location = new System.Drawing.Point(515, 54);
            this.btnSpela.Name = "btnSpela";
            this.btnSpela.Size = new System.Drawing.Size(75, 23);
            this.btnSpela.TabIndex = 2;
            this.btnSpela.Text = "Spela";
            this.btnSpela.UseVisualStyleBackColor = true;
            this.btnSpela.Click += new System.EventHandler(this.btnSpela_Click);
            // 
            // sten_sax_påse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpela);
            this.Controls.Add(this.gbxMinaResultat);
            this.Controls.Add(this.gbxStenSaxPåse);
            this.Name = "sten_sax_påse";
            this.Text = "sten_sax_påse";
            this.gbxStenSaxPåse.ResumeLayout(false);
            this.gbxStenSaxPåse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPåse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).EndInit();
            this.gbxMinaResultat.ResumeLayout(false);
            this.gbxMinaResultat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStenSaxPåse;
        private System.Windows.Forms.PictureBox pbxSten;
        private System.Windows.Forms.PictureBox pbxSax;
        private System.Windows.Forms.PictureBox pbxPåse;
        private System.Windows.Forms.GroupBox gbxMinaResultat;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.Button btnSpela;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblDatornValde;
        private System.Windows.Forms.Label lblDatornsVal;
    }
}