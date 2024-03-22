namespace Atlantik_Admin_App.utilitaires
{
    partial class FormAjouterTarifs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterTarifs));
            this.gbxTarifs = new System.Windows.Forms.GroupBox();
            this.lblTarifs = new System.Windows.Forms.Label();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.lblSecteurs = new System.Windows.Forms.Label();
            this.lblLiaisons = new System.Windows.Forms.Label();
            this.cmbLiaisons = new System.Windows.Forms.ComboBox();
            this.lblPeriodes = new System.Windows.Forms.Label();
            this.cmbPeriodes = new System.Windows.Forms.ComboBox();
            this.btnAjouterTarifs = new System.Windows.Forms.Button();
            this.gbxTarifs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTarifs
            // 
            this.gbxTarifs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxTarifs.Controls.Add(this.lblTarifs);
            this.gbxTarifs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxTarifs.Location = new System.Drawing.Point(156, 6);
            this.gbxTarifs.Margin = new System.Windows.Forms.Padding(2);
            this.gbxTarifs.Name = "gbxTarifs";
            this.gbxTarifs.Padding = new System.Windows.Forms.Padding(2);
            this.gbxTarifs.Size = new System.Drawing.Size(236, 317);
            this.gbxTarifs.TabIndex = 0;
            this.gbxTarifs.TabStop = false;
            this.gbxTarifs.Text = "Tarifs par Catégorie - Type";
            // 
            // lblTarifs
            // 
            this.lblTarifs.AutoSize = true;
            this.lblTarifs.Location = new System.Drawing.Point(115, 18);
            this.lblTarifs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarifs.Name = "lblTarifs";
            this.lblTarifs.Size = new System.Drawing.Size(39, 13);
            this.lblTarifs.TabIndex = 0;
            this.lblTarifs.Text = "Tarifs :";
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(20, 50);
            this.lbxSecteurs.Margin = new System.Windows.Forms.Padding(2);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(108, 160);
            this.lbxSecteurs.TabIndex = 1;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(17, 24);
            this.lblSecteurs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 2;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lblLiaisons
            // 
            this.lblLiaisons.AutoSize = true;
            this.lblLiaisons.Location = new System.Drawing.Point(17, 225);
            this.lblLiaisons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLiaisons.Name = "lblLiaisons";
            this.lblLiaisons.Size = new System.Drawing.Size(51, 13);
            this.lblLiaisons.TabIndex = 3;
            this.lblLiaisons.Text = "Liaisons :";
            // 
            // cmbLiaisons
            // 
            this.cmbLiaisons.FormattingEnabled = true;
            this.cmbLiaisons.Location = new System.Drawing.Point(20, 249);
            this.cmbLiaisons.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLiaisons.Name = "cmbLiaisons";
            this.cmbLiaisons.Size = new System.Drawing.Size(132, 21);
            this.cmbLiaisons.TabIndex = 4;
            // 
            // lblPeriodes
            // 
            this.lblPeriodes.AutoSize = true;
            this.lblPeriodes.Location = new System.Drawing.Point(17, 353);
            this.lblPeriodes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodes.Name = "lblPeriodes";
            this.lblPeriodes.Size = new System.Drawing.Size(52, 13);
            this.lblPeriodes.TabIndex = 5;
            this.lblPeriodes.Text = "Période : ";
            // 
            // cmbPeriodes
            // 
            this.cmbPeriodes.FormattingEnabled = true;
            this.cmbPeriodes.Location = new System.Drawing.Point(76, 350);
            this.cmbPeriodes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPeriodes.Name = "cmbPeriodes";
            this.cmbPeriodes.Size = new System.Drawing.Size(234, 21);
            this.cmbPeriodes.TabIndex = 6;
            // 
            // btnAjouterTarifs
            // 
            this.btnAjouterTarifs.Location = new System.Drawing.Point(324, 344);
            this.btnAjouterTarifs.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterTarifs.Name = "btnAjouterTarifs";
            this.btnAjouterTarifs.Size = new System.Drawing.Size(65, 27);
            this.btnAjouterTarifs.TabIndex = 7;
            this.btnAjouterTarifs.Text = "Ajouter";
            this.btnAjouterTarifs.UseVisualStyleBackColor = true;
            this.btnAjouterTarifs.Click += new System.EventHandler(this.btnAjouterTarifs_Click);
            // 
            // FormAjouterTarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 388);
            this.Controls.Add(this.btnAjouterTarifs);
            this.Controls.Add(this.cmbPeriodes);
            this.Controls.Add(this.lblPeriodes);
            this.Controls.Add(this.cmbLiaisons);
            this.Controls.Add(this.lblLiaisons);
            this.Controls.Add(this.lblSecteurs);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.gbxTarifs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAjouterTarifs";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter les tarifs pour une liaison et une période";
            this.Load += new System.EventHandler(this.FormAjouterTarifs_Load);
            this.gbxTarifs.ResumeLayout(false);
            this.gbxTarifs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTarifs;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.Label lblLiaisons;
        private System.Windows.Forms.ComboBox cmbLiaisons;
        private System.Windows.Forms.Label lblPeriodes;
        private System.Windows.Forms.ComboBox cmbPeriodes;
        private System.Windows.Forms.Button btnAjouterTarifs;
        private System.Windows.Forms.Label lblTarifs;
    }
}