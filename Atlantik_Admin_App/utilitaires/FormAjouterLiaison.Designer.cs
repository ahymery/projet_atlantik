namespace Atlantik_Admin_App.utilitaires
{
    partial class FormAjouterLiaison
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
            this.gbxSecteur = new System.Windows.Forms.GroupBox();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.btnAjoutLiaison = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.cmbArrivee = new System.Windows.Forms.ComboBox();
            this.gbxSecteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSecteur
            // 
            this.gbxSecteur.Controls.Add(this.lbxSecteur);
            this.gbxSecteur.Location = new System.Drawing.Point(12, 12);
            this.gbxSecteur.Name = "gbxSecteur";
            this.gbxSecteur.Size = new System.Drawing.Size(210, 250);
            this.gbxSecteur.TabIndex = 0;
            this.gbxSecteur.TabStop = false;
            this.gbxSecteur.Text = "Secteurs :";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.ItemHeight = 16;
            this.lbxSecteur.Location = new System.Drawing.Point(6, 34);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(188, 196);
            this.lbxSecteur.TabIndex = 0;
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(312, 157);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(119, 22);
            this.tbxDistance.TabIndex = 5;
            // 
            // btnAjoutLiaison
            // 
            this.btnAjoutLiaison.Location = new System.Drawing.Point(291, 210);
            this.btnAjoutLiaison.Name = "btnAjoutLiaison";
            this.btnAjoutLiaison.Size = new System.Drawing.Size(87, 24);
            this.btnAjoutLiaison.TabIndex = 8;
            this.btnAjoutLiaison.Text = "Ajouter";
            this.btnAjoutLiaison.UseVisualStyleBackColor = true;
            this.btnAjoutLiaison.Click += new System.EventHandler(this.btnAjoutLiaison_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(237, 160);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(69, 16);
            this.lblDistance.TabIndex = 4;
            this.lblDistance.Text = "Distance : ";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(237, 32);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(57, 16);
            this.lblDepart.TabIndex = 0;
            this.lblDepart.Text = "Départ  :";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Location = new System.Drawing.Point(237, 91);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(62, 16);
            this.lblArrivee.TabIndex = 1;
            this.lblArrivee.Text = "Arrivée  : ";
            // 
            // cmbDepart
            // 
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(305, 29);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(162, 24);
            this.cmbDepart.TabIndex = 6;
            // 
            // cmbArrivee
            // 
            this.cmbArrivee.FormattingEnabled = true;
            this.cmbArrivee.Location = new System.Drawing.Point(305, 88);
            this.cmbArrivee.Name = "cmbArrivee";
            this.cmbArrivee.Size = new System.Drawing.Size(162, 24);
            this.cmbArrivee.TabIndex = 7;
            // 
            // FormAjouterLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 283);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.cmbArrivee);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.btnAjoutLiaison);
            this.Controls.Add(this.lblArrivee);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.gbxSecteur);
            this.Controls.Add(this.tbxDistance);
            this.Name = "FormAjouterLiaison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une liaison";
            this.Load += new System.EventHandler(this.FormAjouterLiaison_Load);
            this.gbxSecteur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Button btnAjoutLiaison;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ComboBox cmbArrivee;
    }
}