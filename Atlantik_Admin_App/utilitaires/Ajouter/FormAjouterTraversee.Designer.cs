namespace Atlantik_Admin_App.utilitaires
{
    partial class FormAjouterTraversee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterTraversee));
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblBateau = new System.Windows.Forms.Label();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.lblDHDepart = new System.Windows.Forms.Label();
            this.lblDHArrivee = new System.Windows.Forms.Label();
            this.dateDepart = new System.Windows.Forms.DateTimePicker();
            this.dateArrivee = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(13, 28);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(120, 160);
            this.lbxSecteur.TabIndex = 0;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(13, 9);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(58, 13);
            this.lblSecteur.TabIndex = 1;
            this.lblSecteur.Text = "Secteurs : ";
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(10, 206);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(49, 13);
            this.lblLiaison.TabIndex = 2;
            this.lblLiaison.Text = "Liaison : ";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(13, 236);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 3;
            // 
            // lblBateau
            // 
            this.lblBateau.AutoSize = true;
            this.lblBateau.Location = new System.Drawing.Point(149, 31);
            this.lblBateau.Name = "lblBateau";
            this.lblBateau.Size = new System.Drawing.Size(89, 13);
            this.lblBateau.TabIndex = 4;
            this.lblBateau.Text = "Nom du bateau : ";
            // 
            // cmbBateau
            // 
            this.cmbBateau.FormattingEnabled = true;
            this.cmbBateau.Location = new System.Drawing.Point(244, 28);
            this.cmbBateau.Name = "cmbBateau";
            this.cmbBateau.Size = new System.Drawing.Size(121, 21);
            this.cmbBateau.TabIndex = 5;
            // 
            // lblDHDepart
            // 
            this.lblDHDepart.AutoSize = true;
            this.lblDHDepart.Location = new System.Drawing.Point(141, 130);
            this.lblDHDepart.Name = "lblDHDepart";
            this.lblDHDepart.Size = new System.Drawing.Size(126, 13);
            this.lblDHDepart.TabIndex = 6;
            this.lblDHDepart.Text = "Date et heure de départ :";
            // 
            // lblDHArrivee
            // 
            this.lblDHArrivee.AutoSize = true;
            this.lblDHArrivee.Location = new System.Drawing.Point(141, 170);
            this.lblDHArrivee.Name = "lblDHArrivee";
            this.lblDHArrivee.Size = new System.Drawing.Size(124, 13);
            this.lblDHArrivee.TabIndex = 7;
            this.lblDHArrivee.Text = "Date et heure d\'arrivée : ";
            // 
            // dateDepart
            // 
            this.dateDepart.CustomFormat = "yyyy-MM-dd H\':\'mm";
            this.dateDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDepart.Location = new System.Drawing.Point(273, 130);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(155, 20);
            this.dateDepart.TabIndex = 8;
            this.dateDepart.Value = new System.DateTime(2024, 3, 31, 0, 0, 0, 0);
            // 
            // dateArrivee
            // 
            this.dateArrivee.CustomFormat = "yyyy-MM-dd H\':\'m";
            this.dateArrivee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateArrivee.Location = new System.Drawing.Point(272, 164);
            this.dateArrivee.Name = "dateArrivee";
            this.dateArrivee.Size = new System.Drawing.Size(156, 20);
            this.dateArrivee.TabIndex = 9;
            this.dateArrivee.Value = new System.DateTime(2024, 3, 21, 11, 33, 0, 0);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(353, 230);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 27);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjouterTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 275);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dateArrivee);
            this.Controls.Add(this.dateDepart);
            this.Controls.Add(this.lblDHArrivee);
            this.Controls.Add(this.lblDHDepart);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.lblBateau);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjouterTraversee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une traversée";
            this.Load += new System.EventHandler(this.FormAjouterTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblBateau;
        private System.Windows.Forms.ComboBox cmbBateau;
        private System.Windows.Forms.Label lblDHDepart;
        private System.Windows.Forms.Label lblDHArrivee;
        private System.Windows.Forms.DateTimePicker dateDepart;
        private System.Windows.Forms.DateTimePicker dateArrivee;
        private System.Windows.Forms.Button btnAjouter;
    }
}