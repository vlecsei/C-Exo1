namespace Appli1
{
    partial class FRM_Appli1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gbx_Vitesse = new System.Windows.Forms.GroupBox();
            this.Rbt_Vitesse_500 = new System.Windows.Forms.RadioButton();
            this.Rbt_Vitesse_300 = new System.Windows.Forms.RadioButton();
            this.Rbt_Vitesse_200 = new System.Windows.Forms.RadioButton();
            this.Rbt_Vitesse_100 = new System.Windows.Forms.RadioButton();
            this.Gbx_Temperateur = new System.Windows.Forms.GroupBox();
            this.Rbt_Temp_100 = new System.Windows.Forms.RadioButton();
            this.Rbt_Temp_80 = new System.Windows.Forms.RadioButton();
            this.Rbt_Temp_50 = new System.Windows.Forms.RadioButton();
            this.Gbx_Parametres = new System.Windows.Forms.GroupBox();
            this.Txt_Temp_retenue = new System.Windows.Forms.TextBox();
            this.Txt_Vitesse_retenue = new System.Windows.Forms.TextBox();
            this.Lbl_Temp_retenue = new System.Windows.Forms.Label();
            this.Lbl_Vitesse_retenue = new System.Windows.Forms.Label();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Retablir = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.Gbx_Vitesse.SuspendLayout();
            this.Gbx_Temperateur.SuspendLayout();
            this.Gbx_Parametres.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx_Vitesse
            // 
            this.Gbx_Vitesse.Controls.Add(this.Rbt_Vitesse_500);
            this.Gbx_Vitesse.Controls.Add(this.Rbt_Vitesse_300);
            this.Gbx_Vitesse.Controls.Add(this.Rbt_Vitesse_200);
            this.Gbx_Vitesse.Controls.Add(this.Rbt_Vitesse_100);
            this.Gbx_Vitesse.Location = new System.Drawing.Point(22, 24);
            this.Gbx_Vitesse.Name = "Gbx_Vitesse";
            this.Gbx_Vitesse.Size = new System.Drawing.Size(394, 64);
            this.Gbx_Vitesse.TabIndex = 0;
            this.Gbx_Vitesse.TabStop = false;
            this.Gbx_Vitesse.Text = "Vitesse du mélangeur en tours par minutes";
            // 
            // Rbt_Vitesse_500
            // 
            this.Rbt_Vitesse_500.AutoSize = true;
            this.Rbt_Vitesse_500.Location = new System.Drawing.Point(312, 28);
            this.Rbt_Vitesse_500.Name = "Rbt_Vitesse_500";
            this.Rbt_Vitesse_500.Size = new System.Drawing.Size(43, 17);
            this.Rbt_Vitesse_500.TabIndex = 3;
            this.Rbt_Vitesse_500.TabStop = true;
            this.Rbt_Vitesse_500.Text = "500";
            this.Rbt_Vitesse_500.UseVisualStyleBackColor = true;
            // 
            // Rbt_Vitesse_300
            // 
            this.Rbt_Vitesse_300.AutoSize = true;
            this.Rbt_Vitesse_300.Location = new System.Drawing.Point(211, 28);
            this.Rbt_Vitesse_300.Name = "Rbt_Vitesse_300";
            this.Rbt_Vitesse_300.Size = new System.Drawing.Size(43, 17);
            this.Rbt_Vitesse_300.TabIndex = 2;
            this.Rbt_Vitesse_300.TabStop = true;
            this.Rbt_Vitesse_300.Text = "300";
            this.Rbt_Vitesse_300.UseVisualStyleBackColor = true;
            // 
            // Rbt_Vitesse_200
            // 
            this.Rbt_Vitesse_200.AutoSize = true;
            this.Rbt_Vitesse_200.Location = new System.Drawing.Point(106, 28);
            this.Rbt_Vitesse_200.Name = "Rbt_Vitesse_200";
            this.Rbt_Vitesse_200.Size = new System.Drawing.Size(43, 17);
            this.Rbt_Vitesse_200.TabIndex = 1;
            this.Rbt_Vitesse_200.TabStop = true;
            this.Rbt_Vitesse_200.Text = "200";
            this.Rbt_Vitesse_200.UseVisualStyleBackColor = true;
            // 
            // Rbt_Vitesse_100
            // 
            this.Rbt_Vitesse_100.AutoSize = true;
            this.Rbt_Vitesse_100.Location = new System.Drawing.Point(6, 28);
            this.Rbt_Vitesse_100.Name = "Rbt_Vitesse_100";
            this.Rbt_Vitesse_100.Size = new System.Drawing.Size(43, 17);
            this.Rbt_Vitesse_100.TabIndex = 0;
            this.Rbt_Vitesse_100.TabStop = true;
            this.Rbt_Vitesse_100.Text = "100";
            this.Rbt_Vitesse_100.UseVisualStyleBackColor = true;
            // 
            // Gbx_Temperateur
            // 
            this.Gbx_Temperateur.Controls.Add(this.Rbt_Temp_100);
            this.Gbx_Temperateur.Controls.Add(this.Rbt_Temp_80);
            this.Gbx_Temperateur.Controls.Add(this.Rbt_Temp_50);
            this.Gbx_Temperateur.Location = new System.Drawing.Point(22, 94);
            this.Gbx_Temperateur.Name = "Gbx_Temperateur";
            this.Gbx_Temperateur.Size = new System.Drawing.Size(254, 62);
            this.Gbx_Temperateur.TabIndex = 1;
            this.Gbx_Temperateur.TabStop = false;
            this.Gbx_Temperateur.Text = "Température du mélangeur";
            // 
            // Rbt_Temp_100
            // 
            this.Rbt_Temp_100.AutoSize = true;
            this.Rbt_Temp_100.Location = new System.Drawing.Point(198, 31);
            this.Rbt_Temp_100.Name = "Rbt_Temp_100";
            this.Rbt_Temp_100.Size = new System.Drawing.Size(43, 17);
            this.Rbt_Temp_100.TabIndex = 2;
            this.Rbt_Temp_100.TabStop = true;
            this.Rbt_Temp_100.Text = "100";
            this.Rbt_Temp_100.UseVisualStyleBackColor = true;
            // 
            // Rbt_Temp_80
            // 
            this.Rbt_Temp_80.AutoSize = true;
            this.Rbt_Temp_80.Location = new System.Drawing.Point(106, 31);
            this.Rbt_Temp_80.Name = "Rbt_Temp_80";
            this.Rbt_Temp_80.Size = new System.Drawing.Size(37, 17);
            this.Rbt_Temp_80.TabIndex = 1;
            this.Rbt_Temp_80.TabStop = true;
            this.Rbt_Temp_80.Text = "80";
            this.Rbt_Temp_80.UseVisualStyleBackColor = true;
            // 
            // Rbt_Temp_50
            // 
            this.Rbt_Temp_50.AutoSize = true;
            this.Rbt_Temp_50.Location = new System.Drawing.Point(6, 31);
            this.Rbt_Temp_50.Name = "Rbt_Temp_50";
            this.Rbt_Temp_50.Size = new System.Drawing.Size(37, 17);
            this.Rbt_Temp_50.TabIndex = 0;
            this.Rbt_Temp_50.TabStop = true;
            this.Rbt_Temp_50.Text = "50";
            this.Rbt_Temp_50.UseVisualStyleBackColor = true;
            // 
            // Gbx_Parametres
            // 
            this.Gbx_Parametres.Controls.Add(this.Txt_Temp_retenue);
            this.Gbx_Parametres.Controls.Add(this.Txt_Vitesse_retenue);
            this.Gbx_Parametres.Controls.Add(this.Lbl_Temp_retenue);
            this.Gbx_Parametres.Controls.Add(this.Lbl_Vitesse_retenue);
            this.Gbx_Parametres.Location = new System.Drawing.Point(22, 162);
            this.Gbx_Parametres.Name = "Gbx_Parametres";
            this.Gbx_Parametres.Size = new System.Drawing.Size(254, 114);
            this.Gbx_Parametres.TabIndex = 2;
            this.Gbx_Parametres.TabStop = false;
            this.Gbx_Parametres.Text = "Paramètres retenus";
            // 
            // Txt_Temp_retenue
            // 
            this.Txt_Temp_retenue.Enabled = false;
            this.Txt_Temp_retenue.Location = new System.Drawing.Point(85, 83);
            this.Txt_Temp_retenue.Name = "Txt_Temp_retenue";
            this.Txt_Temp_retenue.Size = new System.Drawing.Size(156, 20);
            this.Txt_Temp_retenue.TabIndex = 3;
            // 
            // Txt_Vitesse_retenue
            // 
            this.Txt_Vitesse_retenue.Enabled = false;
            this.Txt_Vitesse_retenue.Location = new System.Drawing.Point(85, 33);
            this.Txt_Vitesse_retenue.Name = "Txt_Vitesse_retenue";
            this.Txt_Vitesse_retenue.Size = new System.Drawing.Size(156, 20);
            this.Txt_Vitesse_retenue.TabIndex = 2;
            // 
            // Lbl_Temp_retenue
            // 
            this.Lbl_Temp_retenue.AutoSize = true;
            this.Lbl_Temp_retenue.Location = new System.Drawing.Point(6, 86);
            this.Lbl_Temp_retenue.Name = "Lbl_Temp_retenue";
            this.Lbl_Temp_retenue.Size = new System.Drawing.Size(73, 13);
            this.Lbl_Temp_retenue.TabIndex = 1;
            this.Lbl_Temp_retenue.Text = "Température :";
            // 
            // Lbl_Vitesse_retenue
            // 
            this.Lbl_Vitesse_retenue.AutoSize = true;
            this.Lbl_Vitesse_retenue.Location = new System.Drawing.Point(6, 36);
            this.Lbl_Vitesse_retenue.Name = "Lbl_Vitesse_retenue";
            this.Lbl_Vitesse_retenue.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Vitesse_retenue.TabIndex = 0;
            this.Lbl_Vitesse_retenue.Text = "Vitesse :";
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(282, 168);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(134, 32);
            this.Btn_OK.TabIndex = 3;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Retablir
            // 
            this.Btn_Retablir.Location = new System.Drawing.Point(282, 206);
            this.Btn_Retablir.Name = "Btn_Retablir";
            this.Btn_Retablir.Size = new System.Drawing.Size(134, 32);
            this.Btn_Retablir.TabIndex = 4;
            this.Btn_Retablir.Text = "Rétablir";
            this.Btn_Retablir.UseVisualStyleBackColor = true;
            this.Btn_Retablir.Click += new System.EventHandler(this.Btn_Retablir_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.Location = new System.Drawing.Point(282, 244);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(134, 32);
            this.Btn_Quitter.TabIndex = 5;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // FRM_Appli1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 294);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.Btn_Retablir);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Gbx_Parametres);
            this.Controls.Add(this.Gbx_Temperateur);
            this.Controls.Add(this.Gbx_Vitesse);
            this.Name = "FRM_Appli1";
            this.Text = "Paramètres de l\'analyseur";
            this.Gbx_Vitesse.ResumeLayout(false);
            this.Gbx_Vitesse.PerformLayout();
            this.Gbx_Temperateur.ResumeLayout(false);
            this.Gbx_Temperateur.PerformLayout();
            this.Gbx_Parametres.ResumeLayout(false);
            this.Gbx_Parametres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx_Vitesse;
        private System.Windows.Forms.GroupBox Gbx_Temperateur;
        private System.Windows.Forms.GroupBox Gbx_Parametres;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Retablir;
        private System.Windows.Forms.Button Btn_Quitter;
        private System.Windows.Forms.RadioButton Rbt_Vitesse_500;
        private System.Windows.Forms.RadioButton Rbt_Vitesse_300;
        private System.Windows.Forms.RadioButton Rbt_Vitesse_200;
        private System.Windows.Forms.RadioButton Rbt_Vitesse_100;
        private System.Windows.Forms.RadioButton Rbt_Temp_100;
        private System.Windows.Forms.RadioButton Rbt_Temp_80;
        private System.Windows.Forms.RadioButton Rbt_Temp_50;
        private System.Windows.Forms.TextBox Txt_Temp_retenue;
        private System.Windows.Forms.TextBox Txt_Vitesse_retenue;
        private System.Windows.Forms.Label Lbl_Temp_retenue;
        private System.Windows.Forms.Label Lbl_Vitesse_retenue;
    }
}

