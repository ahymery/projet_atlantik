namespace Atlantik_Admin_App.utilitaires.Afficher
{
    partial class FormAfficherTraversee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAfficherTraversee));
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.lblSecteurs = new System.Windows.Forms.Label();
            this.lblLiaisons = new System.Windows.Forms.Label();
            this.cmbLiaisons = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTraversee = new System.Windows.Forms.Label();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.lvTraversee = new System.Windows.Forms.ListView();
            this.dateTraversee = new System.Windows.Forms.DateTimePicker();
            this.btnAfficherTraversee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(15, 45);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(101, 186);
            this.lbxSecteurs.TabIndex = 1;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(12, 18);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(58, 13);
            this.lblSecteurs.TabIndex = 0;
            this.lblSecteurs.Text = "Secteurs : ";
            // 
            // lblLiaisons
            // 
            this.lblLiaisons.AutoSize = true;
            this.lblLiaisons.Location = new System.Drawing.Point(12, 250);
            this.lblLiaisons.Name = "lblLiaisons";
            this.lblLiaisons.Size = new System.Drawing.Size(49, 13);
            this.lblLiaisons.TabIndex = 2;
            this.lblLiaisons.Text = "Liaison : ";
            // 
            // cmbLiaisons
            // 
            this.cmbLiaisons.FormattingEnabled = true;
            this.cmbLiaisons.Location = new System.Drawing.Point(15, 276);
            this.cmbLiaisons.Name = "cmbLiaisons";
            this.cmbLiaisons.Size = new System.Drawing.Size(150, 21);
            this.cmbLiaisons.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(302, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(152, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date (par défaut date du jour) :";
            // 
            // lblTraversee
            // 
            this.lblTraversee.AutoSize = true;
            this.lblTraversee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraversee.Location = new System.Drawing.Point(237, 133);
            this.lblTraversee.Name = "lblTraversee";
            this.lblTraversee.Size = new System.Drawing.Size(64, 13);
            this.lblTraversee.TabIndex = 5;
            this.lblTraversee.Text = "Traversée";
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaces.Location = new System.Drawing.Point(454, 133);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(197, 13);
            this.lblPlaces.TabIndex = 6;
            this.lblPlaces.Text = "Places disponibles par catégories";
            // 
            // lvTraversee
            // 
            this.lvTraversee.HideSelection = false;
            this.lvTraversee.Location = new System.Drawing.Point(240, 149);
            this.lvTraversee.Name = "lvTraversee";
            this.lvTraversee.Size = new System.Drawing.Size(447, 227);
            this.lvTraversee.TabIndex = 7;
            this.lvTraversee.UseCompatibleStateImageBehavior = false;
            // 
            // dateTraversee
            // 
            this.dateTraversee.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTraversee.CustomFormat = "dd/MM/yyyy";
            this.dateTraversee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTraversee.Location = new System.Drawing.Point(473, 45);
            this.dateTraversee.Name = "dateTraversee";
            this.dateTraversee.Size = new System.Drawing.Size(100, 20);
            this.dateTraversee.TabIndex = 8;
            // 
            // btnAfficherTraversee
            // 
            this.btnAfficherTraversee.BackColor = System.Drawing.SystemColors.Control;
            this.btnAfficherTraversee.Location = new System.Drawing.Point(305, 96);
            this.btnAfficherTraversee.Name = "btnAfficherTraversee";
            this.btnAfficherTraversee.Size = new System.Drawing.Size(167, 23);
            this.btnAfficherTraversee.TabIndex = 9;
            this.btnAfficherTraversee.Text = "Afficher les traversées";
            this.btnAfficherTraversee.UseVisualStyleBackColor = false;
            this.btnAfficherTraversee.Click += new System.EventHandler(this.btnAfficherTraversee_Click);
            // 
            // FormAfficherTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 385);
            this.Controls.Add(this.btnAfficherTraversee);
            this.Controls.Add(this.dateTraversee);
            this.Controls.Add(this.lvTraversee);
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.lblTraversee);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbLiaisons);
            this.Controls.Add(this.lblLiaisons);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.lblSecteurs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAfficherTraversee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Afficher les traversées pour une liaison et une date donnée";
            this.Load += new System.EventHandler(this.FormAfficherTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.Label lblLiaisons;
        private System.Windows.Forms.ComboBox cmbLiaisons;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTraversee;
        private System.Windows.Forms.Label lblPlaces;
        private System.Windows.Forms.ListView lvTraversee;
        private System.Windows.Forms.DateTimePicker dateTraversee;
        private System.Windows.Forms.Button btnAfficherTraversee;
    }
}