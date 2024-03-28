namespace Atlantik_Admin_App.utilitaires
{
    partial class FormAfficherReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAfficherReservations));
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.lvReservations = new System.Windows.Forms.ListView();
            this.gbxReservation = new System.Windows.Forms.GroupBox();
            this.lblAffichageVoiture = new System.Windows.Forms.Label();
            this.lblAffichageEnfant = new System.Windows.Forms.Label();
            this.lblAffichageJunior = new System.Windows.Forms.Label();
            this.lblAffichageAdulte = new System.Windows.Forms.Label();
            this.lblJunior = new System.Windows.Forms.Label();
            this.lblEnfants = new System.Windows.Forms.Label();
            this.lblVoiture = new System.Windows.Forms.Label();
            this.lblAdulte = new System.Windows.Forms.Label();
            this.lblAffichageMontant = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.gbxReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(15, 36);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(130, 16);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Selectionnez un nom";
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(161, 32);
            this.cmbClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(149, 24);
            this.cmbClients.TabIndex = 1;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // lvReservations
            // 
            this.lvReservations.HideSelection = false;
            this.lvReservations.Location = new System.Drawing.Point(339, 12);
            this.lvReservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvReservations.Name = "lvReservations";
            this.lvReservations.Size = new System.Drawing.Size(623, 182);
            this.lvReservations.TabIndex = 2;
            this.lvReservations.UseCompatibleStateImageBehavior = false;
            this.lvReservations.SelectedIndexChanged += new System.EventHandler(this.lvReservations_SelectedIndexChanged);
            // 
            // gbxReservation
            // 
            this.gbxReservation.Controls.Add(this.lblAffichageVoiture);
            this.gbxReservation.Controls.Add(this.lblAffichageEnfant);
            this.gbxReservation.Controls.Add(this.lblAffichageJunior);
            this.gbxReservation.Controls.Add(this.lblAffichageAdulte);
            this.gbxReservation.Controls.Add(this.lblJunior);
            this.gbxReservation.Controls.Add(this.lblEnfants);
            this.gbxReservation.Controls.Add(this.lblVoiture);
            this.gbxReservation.Controls.Add(this.lblAdulte);
            this.gbxReservation.Location = new System.Drawing.Point(436, 223);
            this.gbxReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxReservation.Name = "gbxReservation";
            this.gbxReservation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxReservation.Size = new System.Drawing.Size(451, 215);
            this.gbxReservation.TabIndex = 3;
            this.gbxReservation.TabStop = false;
            this.gbxReservation.Text = "Réservation";
            // 
            // lblAffichageVoiture
            // 
            this.lblAffichageVoiture.AccessibleName = "lblAffichage";
            this.lblAffichageVoiture.AutoSize = true;
            this.lblAffichageVoiture.Location = new System.Drawing.Point(168, 185);
            this.lblAffichageVoiture.Name = "lblAffichageVoiture";
            this.lblAffichageVoiture.Size = new System.Drawing.Size(14, 16);
            this.lblAffichageVoiture.TabIndex = 8;
            this.lblAffichageVoiture.Tag = "B;2";
            this.lblAffichageVoiture.Text = "0";
            // 
            // lblAffichageEnfant
            // 
            this.lblAffichageEnfant.AccessibleName = "lblAffichage";
            this.lblAffichageEnfant.AutoSize = true;
            this.lblAffichageEnfant.Location = new System.Drawing.Point(168, 137);
            this.lblAffichageEnfant.Name = "lblAffichageEnfant";
            this.lblAffichageEnfant.Size = new System.Drawing.Size(14, 16);
            this.lblAffichageEnfant.TabIndex = 7;
            this.lblAffichageEnfant.Tag = "A;3";
            this.lblAffichageEnfant.Text = "0";
            // 
            // lblAffichageJunior
            // 
            this.lblAffichageJunior.AccessibleName = "lblAffichage";
            this.lblAffichageJunior.AutoSize = true;
            this.lblAffichageJunior.Location = new System.Drawing.Point(168, 92);
            this.lblAffichageJunior.Name = "lblAffichageJunior";
            this.lblAffichageJunior.Size = new System.Drawing.Size(14, 16);
            this.lblAffichageJunior.TabIndex = 6;
            this.lblAffichageJunior.Tag = "A;2";
            this.lblAffichageJunior.Text = "0";
            // 
            // lblAffichageAdulte
            // 
            this.lblAffichageAdulte.AccessibleName = "lblAffichage";
            this.lblAffichageAdulte.AutoSize = true;
            this.lblAffichageAdulte.Location = new System.Drawing.Point(168, 42);
            this.lblAffichageAdulte.Name = "lblAffichageAdulte";
            this.lblAffichageAdulte.Size = new System.Drawing.Size(14, 16);
            this.lblAffichageAdulte.TabIndex = 5;
            this.lblAffichageAdulte.Tag = "A;1";
            this.lblAffichageAdulte.Text = "0";
            // 
            // lblJunior
            // 
            this.lblJunior.AutoSize = true;
            this.lblJunior.Location = new System.Drawing.Point(28, 92);
            this.lblJunior.Name = "lblJunior";
            this.lblJunior.Size = new System.Drawing.Size(112, 16);
            this.lblJunior.TabIndex = 3;
            this.lblJunior.Text = "Junior 8 à 18 ans :";
            // 
            // lblEnfants
            // 
            this.lblEnfants.AutoSize = true;
            this.lblEnfants.Location = new System.Drawing.Point(28, 137);
            this.lblEnfants.Name = "lblEnfants";
            this.lblEnfants.Size = new System.Drawing.Size(106, 16);
            this.lblEnfants.TabIndex = 2;
            this.lblEnfants.Text = "Enfant 0 à 7 ans :";
            // 
            // lblVoiture
            // 
            this.lblVoiture.AutoSize = true;
            this.lblVoiture.Location = new System.Drawing.Point(15, 185);
            this.lblVoiture.Name = "lblVoiture";
            this.lblVoiture.Size = new System.Drawing.Size(121, 16);
            this.lblVoiture.TabIndex = 1;
            this.lblVoiture.Text = "Voiture long.Inf 5m :";
            // 
            // lblAdulte
            // 
            this.lblAdulte.AutoSize = true;
            this.lblAdulte.Location = new System.Drawing.Point(88, 42);
            this.lblAdulte.Name = "lblAdulte";
            this.lblAdulte.Size = new System.Drawing.Size(54, 16);
            this.lblAdulte.TabIndex = 0;
            this.lblAdulte.Text = "Adulte : ";
            // 
            // lblAffichageMontant
            // 
            this.lblAffichageMontant.AutoSize = true;
            this.lblAffichageMontant.Location = new System.Drawing.Point(651, 459);
            this.lblAffichageMontant.Name = "lblAffichageMontant";
            this.lblAffichageMontant.Size = new System.Drawing.Size(14, 16);
            this.lblAffichageMontant.TabIndex = 9;
            this.lblAffichageMontant.Tag = "";
            this.lblAffichageMontant.Text = "0";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(432, 459);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(197, 16);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant Total de la réservation :";
            // 
            // FormAfficherReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 524);
            this.Controls.Add(this.lblAffichageMontant);
            this.Controls.Add(this.gbxReservation);
            this.Controls.Add(this.lvReservations);
            this.Controls.Add(this.cmbClients);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.lblMontant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAfficherReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Détails d\'une réservations pour un client";
            this.Load += new System.EventHandler(this.FormAfficherReservations_Load);
            this.gbxReservation.ResumeLayout(false);
            this.gbxReservation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.ListView lvReservations;
        private System.Windows.Forms.GroupBox gbxReservation;
        private System.Windows.Forms.Label lblAffichageAdulte;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblJunior;
        private System.Windows.Forms.Label lblEnfants;
        private System.Windows.Forms.Label lblVoiture;
        private System.Windows.Forms.Label lblAdulte;
        private System.Windows.Forms.Label lblAffichageMontant;
        private System.Windows.Forms.Label lblAffichageVoiture;
        private System.Windows.Forms.Label lblAffichageEnfant;
        private System.Windows.Forms.Label lblAffichageJunior;
    }
}