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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterSecteur));
            this.lblNomSecteur = new System.Windows.Forms.Label();
            this.tbxSecteur = new System.Windows.Forms.TextBox();
            this.btnAjouterUnSecteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomSecteur
            // 
            this.lblNomSecteur.AutoSize = true;
            this.lblNomSecteur.Location = new System.Drawing.Point(16, 47);
            this.lblNomSecteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomSecteur.Name = "lblNomSecteur";
            this.lblNomSecteur.Size = new System.Drawing.Size(110, 16);
            this.lblNomSecteur.TabIndex = 0;
            this.lblNomSecteur.Text = "Nom du secteur : ";
            // 
            // tbxSecteur
            // 
            this.tbxSecteur.Location = new System.Drawing.Point(145, 43);
            this.tbxSecteur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSecteur.Name = "tbxSecteur";
            this.tbxSecteur.Size = new System.Drawing.Size(132, 22);
            this.tbxSecteur.TabIndex = 1;
            // 
            // btnAjouterUnSecteur
            // 
            this.btnAjouterUnSecteur.Location = new System.Drawing.Point(99, 86);
            this.btnAjouterUnSecteur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterUnSecteur.Name = "btnAjouterUnSecteur";
            this.btnAjouterUnSecteur.Size = new System.Drawing.Size(100, 28);
            this.btnAjouterUnSecteur.TabIndex = 2;
            this.btnAjouterUnSecteur.Text = "Ajouter";
            this.btnAjouterUnSecteur.UseVisualStyleBackColor = true;
            this.btnAjouterUnSecteur.Click += new System.EventHandler(this.btnAjouterUnSecteur_Click);
            // 
            // FormAjouterSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 140);
            this.Controls.Add(this.btnAjouterUnSecteur);
            this.Controls.Add(this.tbxSecteur);
            this.Controls.Add(this.lblNomSecteur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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