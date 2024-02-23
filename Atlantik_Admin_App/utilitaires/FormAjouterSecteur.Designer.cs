namespace Atlantik_Admin_App.utilitaires
{
    partial class FormAjouterSecteur
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
            this.lblNomSecteur = new System.Windows.Forms.Label();
            this.tbxSecteur = new System.Windows.Forms.TextBox();
            this.btnAjouterUnSecteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomSecteur
            // 
            this.lblNomSecteur.AutoSize = true;
            this.lblNomSecteur.Location = new System.Drawing.Point(12, 38);
            this.lblNomSecteur.Name = "lblNomSecteur";
            this.lblNomSecteur.Size = new System.Drawing.Size(91, 13);
            this.lblNomSecteur.TabIndex = 0;
            this.lblNomSecteur.Text = "Nom du secteur : ";
            // 
            // tbxSecteur
            // 
            this.tbxSecteur.Location = new System.Drawing.Point(109, 35);
            this.tbxSecteur.Name = "tbxSecteur";
            this.tbxSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbxSecteur.TabIndex = 1;
            // 
            // btnAjouterUnSecteur
            // 
            this.btnAjouterUnSecteur.Location = new System.Drawing.Point(74, 70);
            this.btnAjouterUnSecteur.Name = "btnAjouterUnSecteur";
            this.btnAjouterUnSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterUnSecteur.TabIndex = 2;
            this.btnAjouterUnSecteur.Text = "Ajouter";
            this.btnAjouterUnSecteur.UseVisualStyleBackColor = true;
            this.btnAjouterUnSecteur.Click += new System.EventHandler(this.btnAjouterUnSecteur_Click);
            // 
            // FormAjouterSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 114);
            this.Controls.Add(this.btnAjouterUnSecteur);
            this.Controls.Add(this.tbxSecteur);
            this.Controls.Add(this.lblNomSecteur);
            this.Name = "FormAjouterSecteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un Secteur";
            this.Load += new System.EventHandler(this.AjouterSecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomSecteur;
        private System.Windows.Forms.TextBox tbxSecteur;
        private System.Windows.Forms.Button btnAjouterUnSecteur;
    }
}