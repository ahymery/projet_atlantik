namespace Atlantik_Admin_App
{
    partial class FormAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.logoAtlantik = new System.Windows.Forms.PictureBox();
            this.lblAtlantik = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterSecteur = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterPort = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterTarifs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModifierBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.btnParametres = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAfficherTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAfficherDetails = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.logoAtlantik)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoAtlantik
            // 
            this.logoAtlantik.Image = ((System.Drawing.Image)(resources.GetObject("logoAtlantik.Image")));
            this.logoAtlantik.Location = new System.Drawing.Point(59, 60);
            this.logoAtlantik.Name = "logoAtlantik";
            this.logoAtlantik.Size = new System.Drawing.Size(357, 251);
            this.logoAtlantik.TabIndex = 0;
            this.logoAtlantik.TabStop = false;
            // 
            // lblAtlantik
            // 
            this.lblAtlantik.BackColor = System.Drawing.SystemColors.Control;
            this.lblAtlantik.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtlantik.ForeColor = System.Drawing.Color.Red;
            this.lblAtlantik.Location = new System.Drawing.Point(71, 39);
            this.lblAtlantik.Name = "lblAtlantik";
            this.lblAtlantik.Size = new System.Drawing.Size(261, 61);
            this.lblAtlantik.TabIndex = 1;
            this.lblAtlantik.Text = "Atlantik";
            this.lblAtlantik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouter,
            this.btnModifier,
            this.btnAfficher,
            this.btnAPropos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAjouter
            // 
            this.btnAjouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouterSecteur,
            this.btnAjouterPort,
            this.btnAjouterLiaison,
            this.btnAjouterTarifs,
            this.btnAjouterBateau,
            this.btnAjouterTraversee});
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(58, 20);
            this.btnAjouter.Text = "Ajouter";
            // 
            // btnModifier
            // 
            this.btnModifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModifierBateau,
            this.btnParametres});
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(64, 20);
            this.btnModifier.Text = "Modifier";
            // 
            // btnAfficher
            // 
            this.btnAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAfficherTraversee,
            this.btnAfficherDetails});
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(61, 20);
            this.btnAfficher.Text = "Afficher";
            // 
            // btnAPropos
            // 
            this.btnAPropos.Name = "btnAPropos";
            this.btnAPropos.Size = new System.Drawing.Size(67, 20);
            this.btnAPropos.Text = "A propos";
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(287, 22);
            this.btnAjouterSecteur.Text = "Un secteur";
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouterSecteur_Click);
            // 
            // btnAjouterPort
            // 
            this.btnAjouterPort.Name = "btnAjouterPort";
            this.btnAjouterPort.Size = new System.Drawing.Size(287, 22);
            this.btnAjouterPort.Text = "Un port";
            this.btnAjouterPort.Click += new System.EventHandler(this.btnAjouterPort_Click);
            // 
            // btnAjouterLiaison
            // 
            this.btnAjouterLiaison.Name = "btnAjouterLiaison";
            this.btnAjouterLiaison.Size = new System.Drawing.Size(287, 22);
            this.btnAjouterLiaison.Text = "Une liaison";
            // 
            // btnAjouterTarifs
            // 
            this.btnAjouterTarifs.Name = "btnAjouterTarifs";
            this.btnAjouterTarifs.Size = new System.Drawing.Size(287, 22);
            this.btnAjouterTarifs.Text = "Les tarifs pour une liaison et une période";
            // 
            // btnAjouterBateau
            // 
            this.btnAjouterBateau.Name = "btnAjouterBateau";
            this.btnAjouterBateau.Size = new System.Drawing.Size(287, 22);
            this.btnAjouterBateau.Text = "Un bateau";
            // 
            // btnAjouterTraversee
            // 
            this.btnAjouterTraversee.Name = "btnAjouterTraversee";
            this.btnAjouterTraversee.Size = new System.Drawing.Size(287, 22);
            this.btnAjouterTraversee.Text = "Une traversée";
            // 
            // btnModifierBateau
            // 
            this.btnModifierBateau.Name = "btnModifierBateau";
            this.btnModifierBateau.Size = new System.Drawing.Size(180, 22);
            this.btnModifierBateau.Text = "Un bateau";
            // 
            // btnParametres
            // 
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Size = new System.Drawing.Size(180, 22);
            this.btnParametres.Text = "Les paramètres";
            // 
            // btnAfficherTraversee
            // 
            this.btnAfficherTraversee.Name = "btnAfficherTraversee";
            this.btnAfficherTraversee.Size = new System.Drawing.Size(586, 22);
            this.btnAfficherTraversee.Text = "Les traversées pour une liaison et une date et une date donnée avec places restan" +
    "tes par catégorie";
            // 
            // btnAfficherDetails
            // 
            this.btnAfficherDetails.Name = "btnAfficherDetails";
            this.btnAfficherDetails.Size = new System.Drawing.Size(586, 22);
            this.btnAfficherDetails.Text = "Les détails d\'une réservation pour un client";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 323);
            this.Controls.Add(this.lblAtlantik);
            this.Controls.Add(this.logoAtlantik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAccueil";
            this.Text = "Atlantik - Accueil";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoAtlantik)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoAtlantik;
        private System.Windows.Forms.Label lblAtlantik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAjouter;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterSecteur;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterPort;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterLiaison;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterTarifs;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterBateau;
        private System.Windows.Forms.ToolStripMenuItem btnAjouterTraversee;
        private System.Windows.Forms.ToolStripMenuItem btnModifier;
        private System.Windows.Forms.ToolStripMenuItem btnModifierBateau;
        private System.Windows.Forms.ToolStripMenuItem btnParametres;
        private System.Windows.Forms.ToolStripMenuItem btnAfficher;
        private System.Windows.Forms.ToolStripMenuItem btnAfficherTraversee;
        private System.Windows.Forms.ToolStripMenuItem btnAfficherDetails;
        private System.Windows.Forms.ToolStripMenuItem btnAPropos;
    }
}

