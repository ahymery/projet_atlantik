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
            this.gbxTarifs.Location = new System.Drawing.Point(208, 12);
            this.gbxTarifs.Name = "gbxTarifs";
            this.gbxTarifs.Size = new System.Drawing.Size(314, 385);
            this.gbxTarifs.TabIndex = 0;
            this.gbxTarifs.TabStop = false;
            this.gbxTarifs.Text = "Tarifs par Catégorie - Type";
            this.gbxTarifs.Enter += new System.EventHandler(this.gbxTarifs_Enter);
            // 
            // lblTarifs
            // 
            this.lblTarifs.AutoSize = true;
            this.lblTarifs.Location = new System.Drawing.Point(170, 36);
            this.lblTarifs.Name = "lblTarifs";
            this.lblTarifs.Size = new System.Drawing.Size(47, 16);
            this.lblTarifs.TabIndex = 0;
            this.lblTarifs.Text = "Tarifs :";
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.ItemHeight = 16;
            this.lbxSecteurs.Location = new System.Drawing.Point(26, 62);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(143, 196);
            this.lbxSecteurs.TabIndex = 1;
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(23, 29);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(66, 16);
            this.lblSecteurs.TabIndex = 2;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lblLiaisons
            // 
            this.lblLiaisons.AutoSize = true;
            this.lblLiaisons.Location = new System.Drawing.Point(23, 277);
            this.lblLiaisons.Name = "lblLiaisons";
            this.lblLiaisons.Size = new System.Drawing.Size(63, 16);
            this.lblLiaisons.TabIndex = 3;
            this.lblLiaisons.Text = "Liaisons :";
            // 
            // cmbLiaisons
            // 
            this.cmbLiaisons.FormattingEnabled = true;
            this.cmbLiaisons.Location = new System.Drawing.Point(26, 307);
            this.cmbLiaisons.Name = "cmbLiaisons";
            this.cmbLiaisons.Size = new System.Drawing.Size(143, 24);
            this.cmbLiaisons.TabIndex = 4;
            // 
            // lblPeriodes
            // 
            this.lblPeriodes.AutoSize = true;
            this.lblPeriodes.Location = new System.Drawing.Point(23, 434);
            this.lblPeriodes.Name = "lblPeriodes";
            this.lblPeriodes.Size = new System.Drawing.Size(64, 16);
            this.lblPeriodes.TabIndex = 5;
            this.lblPeriodes.Text = "Période : ";
            // 
            // cmbPeriodes
            // 
            this.cmbPeriodes.FormattingEnabled = true;
            this.cmbPeriodes.Location = new System.Drawing.Point(101, 431);
            this.cmbPeriodes.Name = "cmbPeriodes";
            this.cmbPeriodes.Size = new System.Drawing.Size(211, 24);
            this.cmbPeriodes.TabIndex = 6;
            // 
            // btnAjouterTarifs
            // 
            this.btnAjouterTarifs.Location = new System.Drawing.Point(365, 423);
            this.btnAjouterTarifs.Name = "btnAjouterTarifs";
            this.btnAjouterTarifs.Size = new System.Drawing.Size(127, 34);
            this.btnAjouterTarifs.TabIndex = 7;
            this.btnAjouterTarifs.Text = "Ajouter";
            this.btnAjouterTarifs.UseVisualStyleBackColor = true;
            // 
            // FormAjouterTarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 478);
            this.Controls.Add(this.btnAjouterTarifs);
            this.Controls.Add(this.cmbPeriodes);
            this.Controls.Add(this.lblPeriodes);
            this.Controls.Add(this.cmbLiaisons);
            this.Controls.Add(this.lblLiaisons);
            this.Controls.Add(this.lblSecteurs);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.gbxTarifs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjouterTarifs";
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