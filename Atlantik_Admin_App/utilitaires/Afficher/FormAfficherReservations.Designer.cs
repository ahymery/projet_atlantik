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
            this.lblAffichageMontant = new System.Windows.Forms.Label();
            this.lblAffichageVoiture = new System.Windows.Forms.Label();
            this.lblAffichageEnfant = new System.Windows.Forms.Label();
            this.lblAffichageJunior = new System.Windows.Forms.Label();
            this.lblAffichageAdulte = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblJunior = new System.Windows.Forms.Label();
            this.lblEnfants = new System.Windows.Forms.Label();
            this.lblVoiture = new System.Windows.Forms.Label();
            this.lblAdulte = new System.Windows.Forms.Label();
            this.gbxReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(11, 29);
            this.lblNomPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(106, 13);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Selectionnez un nom";
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(121, 26);
            this.cmbClients.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(113, 21);
            this.cmbClients.TabIndex = 1;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // lvReservations
            // 
            this.lvReservations.HideSelection = false;
            this.lvReservations.Location = new System.Drawing.Point(254, 10);
            this.lvReservations.Margin = new System.Windows.Forms.Padding(2);
            this.lvReservations.Name = "lvReservations";
            this.lvReservations.Size = new System.Drawing.Size(468, 149);
            this.lvReservations.TabIndex = 2;
            this.lvReservations.UseCompatibleStateImageBehavior = false;
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
            this.gbxReservation.Location = new System.Drawing.Point(327, 181);
            this.gbxReservation.Margin = new System.Windows.Forms.Padding(2);
            this.gbxReservation.Name = "gbxReservation";
            this.gbxReservation.Padding = new System.Windows.Forms.Padding(2);
            this.gbxReservation.Size = new System.Drawing.Size(338, 175);
            this.gbxReservation.TabIndex = 3;
            this.gbxReservation.TabStop = false;
            this.gbxReservation.Text = "Réservation";
            // 
            // lblAffichageMontant
            // 
            this.lblAffichageMontant.AutoSize = true;
            this.lblAffichageMontant.Location = new System.Drawing.Point(488, 373);
            this.lblAffichageMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAffichageMontant.Name = "lblAffichageMontant";
            this.lblAffichageMontant.Size = new System.Drawing.Size(13, 13);
            this.lblAffichageMontant.TabIndex = 9;
            this.lblAffichageMontant.Tag = "";
            this.lblAffichageMontant.Text = "0";
            // 
            // lblAffichageVoiture
            // 
            this.lblAffichageVoiture.AutoSize = true;
            this.lblAffichageVoiture.Location = new System.Drawing.Point(126, 150);
            this.lblAffichageVoiture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAffichageVoiture.Name = "lblAffichageVoiture";
            this.lblAffichageVoiture.Size = new System.Drawing.Size(13, 13);
            this.lblAffichageVoiture.TabIndex = 8;
            this.lblAffichageVoiture.Tag = "B;2";
            this.lblAffichageVoiture.Text = "0";
            // 
            // lblAffichageEnfant
            // 
            this.lblAffichageEnfant.AutoSize = true;
            this.lblAffichageEnfant.Location = new System.Drawing.Point(126, 111);
            this.lblAffichageEnfant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAffichageEnfant.Name = "lblAffichageEnfant";
            this.lblAffichageEnfant.Size = new System.Drawing.Size(13, 13);
            this.lblAffichageEnfant.TabIndex = 7;
            this.lblAffichageEnfant.Tag = "A;3";
            this.lblAffichageEnfant.Text = "0";
            // 
            // lblAffichageJunior
            // 
            this.lblAffichageJunior.AutoSize = true;
            this.lblAffichageJunior.Location = new System.Drawing.Point(126, 75);
            this.lblAffichageJunior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAffichageJunior.Name = "lblAffichageJunior";
            this.lblAffichageJunior.Size = new System.Drawing.Size(13, 13);
            this.lblAffichageJunior.TabIndex = 6;
            this.lblAffichageJunior.Tag = "A;2";
            this.lblAffichageJunior.Text = "0";
            // 
            // lblAffichageAdulte
            // 
            this.lblAffichageAdulte.AutoSize = true;
            this.lblAffichageAdulte.Location = new System.Drawing.Point(126, 34);
            this.lblAffichageAdulte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAffichageAdulte.Name = "lblAffichageAdulte";
            this.lblAffichageAdulte.Size = new System.Drawing.Size(13, 13);
            this.lblAffichageAdulte.TabIndex = 5;
            this.lblAffichageAdulte.Tag = "A;1";
            this.lblAffichageAdulte.Text = "0";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(324, 373);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(160, 13);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant Total de la réservation :";
            // 
            // lblJunior
            // 
            this.lblJunior.AutoSize = true;
            this.lblJunior.Location = new System.Drawing.Point(21, 75);
            this.lblJunior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJunior.Name = "lblJunior";
            this.lblJunior.Size = new System.Drawing.Size(94, 13);
            this.lblJunior.TabIndex = 3;
            this.lblJunior.Text = "Junior 8 à 18 ans :";
            // 
            // lblEnfants
            // 
            this.lblEnfants.AutoSize = true;
            this.lblEnfants.Location = new System.Drawing.Point(21, 111);
            this.lblEnfants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnfants.Name = "lblEnfants";
            this.lblEnfants.Size = new System.Drawing.Size(91, 13);
            this.lblEnfants.TabIndex = 2;
            this.lblEnfants.Text = "Enfant 0 à 7 ans :";
            // 
            // lblVoiture
            // 
            this.lblVoiture.AutoSize = true;
            this.lblVoiture.Location = new System.Drawing.Point(11, 150);
            this.lblVoiture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVoiture.Name = "lblVoiture";
            this.lblVoiture.Size = new System.Drawing.Size(101, 13);
            this.lblVoiture.TabIndex = 1;
            this.lblVoiture.Text = "Voiture long.Inf 5m :";
            // 
            // lblAdulte
            // 
            this.lblAdulte.AutoSize = true;
            this.lblAdulte.Location = new System.Drawing.Point(66, 34);
            this.lblAdulte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdulte.Name = "lblAdulte";
            this.lblAdulte.Size = new System.Drawing.Size(46, 13);
            this.lblAdulte.TabIndex = 0;
            this.lblAdulte.Text = "Adulte : ";
            // 
            // FormAfficherReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.lblAffichageMontant);
            this.Controls.Add(this.gbxReservation);
            this.Controls.Add(this.lvReservations);
            this.Controls.Add(this.cmbClients);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.lblMontant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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