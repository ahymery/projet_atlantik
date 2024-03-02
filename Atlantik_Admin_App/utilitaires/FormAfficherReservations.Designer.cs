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
            this.lblNomPrenom.Location = new System.Drawing.Point(29, 36);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(95, 16);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Nom, Prénom :";
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(142, 33);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(149, 24);
            this.cmbClients.TabIndex = 1;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // lvReservations
            // 
            this.lvReservations.HideSelection = false;
            this.lvReservations.Location = new System.Drawing.Point(338, 12);
            this.lvReservations.Name = "lvReservations";
            this.lvReservations.Size = new System.Drawing.Size(450, 182);
            this.lvReservations.TabIndex = 2;
            this.lvReservations.UseCompatibleStateImageBehavior = false;
            // 
            // gbxReservation
            // 
            this.gbxReservation.Controls.Add(this.lblAffichageMontant);
            this.gbxReservation.Controls.Add(this.lblAffichageVoiture);
            this.gbxReservation.Controls.Add(this.lblAffichageEnfant);
            this.gbxReservation.Controls.Add(this.lblAffichageJunior);
            this.gbxReservation.Controls.Add(this.lblAffichageAdulte);
            this.gbxReservation.Controls.Add(this.lblMontant);
            this.gbxReservation.Controls.Add(this.lblJunior);
            this.gbxReservation.Controls.Add(this.lblEnfants);
            this.gbxReservation.Controls.Add(this.lblVoiture);
            this.gbxReservation.Controls.Add(this.lblAdulte);
            this.gbxReservation.Location = new System.Drawing.Point(338, 200);
            this.gbxReservation.Name = "gbxReservation";
            this.gbxReservation.Size = new System.Drawing.Size(450, 267);
            this.gbxReservation.TabIndex = 3;
            this.gbxReservation.TabStop = false;
            this.gbxReservation.Text = "Réservation";
            // 
            // lblAffichageMontant
            // 
            this.lblAffichageMontant.AutoSize = true;
            this.lblAffichageMontant.Location = new System.Drawing.Point(128, 231);
            this.lblAffichageMontant.Name = "lblAffichageMontant";
            this.lblAffichageMontant.Size = new System.Drawing.Size(14, 16);
            this.lblAffichageMontant.TabIndex = 9;
            this.lblAffichageMontant.Text = "0";
            // 
            // lblAffichageVoiture
            // 
            this.lblAffichageVoiture.AutoSize = true;
            this.lblAffichageVoiture.Location = new System.Drawing.Point(155, 185);
            this.lblAffichageVoiture.Name = "lblAffichageVoiture";
            this.lblAffichageVoiture.Size = new System.Drawing.Size(14, 16);
            this.lblAffichageVoiture.TabIndex = 8;
            this.lblAffichageVoiture.Text = "0";
            // 
            // lblAffichageEnfant
            // 
            this.lblAffichageEnfant.AutoSize = true;
            this.lblAffichageEnfant.Location = new System.Drawing.Point(140, 137);
            this.lblAffichageEnfant.Name = "lblAffichageEnfant";
            this.lblAffichageEnfant.Size = new System.Drawing.Size(14, 16);
            this.lblAffichageEnfant.TabIndex = 7;
            this.lblAffichageEnfant.Text = "0";
            // 
            // lblAffichageJunior
            // 
            this.lblAffichageJunior.AutoSize = true;
            this.lblAffichageJunior.Location = new System.Drawing.Point(146, 92);
            this.lblAffichageJunior.Name = "lblAffichageJunior";
            this.lblAffichageJunior.Size = new System.Drawing.Size(14, 16);
            this.lblAffichageJunior.TabIndex = 6;
            this.lblAffichageJunior.Text = "0";
            // 
            // lblAffichageAdulte
            // 
            this.lblAffichageAdulte.AutoSize = true;
            this.lblAffichageAdulte.Location = new System.Drawing.Point(88, 42);
            this.lblAffichageAdulte.Name = "lblAffichageAdulte";
            this.lblAffichageAdulte.Size = new System.Drawing.Size(14, 16);
            this.lblAffichageAdulte.TabIndex = 5;
            this.lblAffichageAdulte.Text = "0";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(28, 231);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(94, 16);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant Total :";
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
            this.lblVoiture.Location = new System.Drawing.Point(28, 185);
            this.lblVoiture.Name = "lblVoiture";
            this.lblVoiture.Size = new System.Drawing.Size(121, 16);
            this.lblVoiture.TabIndex = 1;
            this.lblVoiture.Text = "Voiture long.Inf 5m :";
            // 
            // lblAdulte
            // 
            this.lblAdulte.AutoSize = true;
            this.lblAdulte.Location = new System.Drawing.Point(28, 42);
            this.lblAdulte.Name = "lblAdulte";
            this.lblAdulte.Size = new System.Drawing.Size(54, 16);
            this.lblAdulte.TabIndex = 0;
            this.lblAdulte.Text = "Adulte : ";
            // 
            // FormAfficherReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.gbxReservation);
            this.Controls.Add(this.lvReservations);
            this.Controls.Add(this.cmbClients);
            this.Controls.Add(this.lblNomPrenom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAfficherReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Réservations";
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