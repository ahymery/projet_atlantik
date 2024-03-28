namespace Atlantik_Admin_App.utilitaires.Modifier
{
    partial class FormModifierParametres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifierParametres));
            this.gbxPayBox = new System.Windows.Forms.GroupBox();
            this.tbxRang = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxCle = new System.Windows.Forms.TextBox();
            this.tbxSite = new System.Windows.Forms.TextBox();
            this.lblHMAC = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblRang = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.cbxProduction = new System.Windows.Forms.CheckBox();
            this.tbxMel = new System.Windows.Forms.TextBox();
            this.lblMel = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gbxPayBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPayBox
            // 
            this.gbxPayBox.Controls.Add(this.tbxRang);
            this.gbxPayBox.Controls.Add(this.lblMel);
            this.gbxPayBox.Controls.Add(this.tbxID);
            this.gbxPayBox.Controls.Add(this.tbxMel);
            this.gbxPayBox.Controls.Add(this.tbxCle);
            this.gbxPayBox.Controls.Add(this.cbxProduction);
            this.gbxPayBox.Controls.Add(this.tbxSite);
            this.gbxPayBox.Controls.Add(this.lblHMAC);
            this.gbxPayBox.Controls.Add(this.lblIdentifiant);
            this.gbxPayBox.Controls.Add(this.lblRang);
            this.gbxPayBox.Controls.Add(this.lblSite);
            this.gbxPayBox.Location = new System.Drawing.Point(17, 16);
            this.gbxPayBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxPayBox.Name = "gbxPayBox";
            this.gbxPayBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxPayBox.Size = new System.Drawing.Size(491, 426);
            this.gbxPayBox.TabIndex = 0;
            this.gbxPayBox.TabStop = false;
            this.gbxPayBox.Text = "Identifiants PayBox";
            // 
            // tbxRang
            // 
            this.tbxRang.Location = new System.Drawing.Point(184, 82);
            this.tbxRang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxRang.Name = "tbxRang";
            this.tbxRang.Size = new System.Drawing.Size(45, 22);
            this.tbxRang.TabIndex = 11;
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(184, 129);
            this.tbxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(132, 22);
            this.tbxID.TabIndex = 10;
            // 
            // tbxCle
            // 
            this.tbxCle.Location = new System.Drawing.Point(184, 176);
            this.tbxCle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCle.Multiline = true;
            this.tbxCle.Name = "tbxCle";
            this.tbxCle.Size = new System.Drawing.Size(241, 159);
            this.tbxCle.TabIndex = 9;
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(184, 37);
            this.tbxSite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(132, 22);
            this.tbxSite.TabIndex = 8;
            // 
            // lblHMAC
            // 
            this.lblHMAC.AutoSize = true;
            this.lblHMAC.Location = new System.Drawing.Point(21, 176);
            this.lblHMAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHMAC.Name = "lblHMAC";
            this.lblHMAC.Size = new System.Drawing.Size(78, 16);
            this.lblHMAC.TabIndex = 7;
            this.lblHMAC.Text = "Clé HMAC : ";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(21, 129);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(72, 16);
            this.lblIdentifiant.TabIndex = 6;
            this.lblIdentifiant.Text = "Identifiant : ";
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(21, 82);
            this.lblRang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(49, 16);
            this.lblRang.TabIndex = 5;
            this.lblRang.Text = "Rang : ";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(21, 37);
            this.lblSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(36, 16);
            this.lblSite.TabIndex = 4;
            this.lblSite.Text = "Site :";
            // 
            // cbxProduction
            // 
            this.cbxProduction.AutoSize = true;
            this.cbxProduction.Location = new System.Drawing.Point(318, 360);
            this.cbxProduction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxProduction.Name = "cbxProduction";
            this.cbxProduction.Size = new System.Drawing.Size(111, 20);
            this.cbxProduction.TabIndex = 1;
            this.cbxProduction.Text = "En production";
            this.cbxProduction.UseVisualStyleBackColor = true;
            this.cbxProduction.CheckedChanged += new System.EventHandler(this.cbxProduction_CheckedChanged);
            // 
            // tbxMel
            // 
            this.tbxMel.Location = new System.Drawing.Point(318, 388);
            this.tbxMel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMel.Name = "tbxMel";
            this.tbxMel.Size = new System.Drawing.Size(164, 22);
            this.tbxMel.TabIndex = 12;
            // 
            // lblMel
            // 
            this.lblMel.AutoSize = true;
            this.lblMel.Location = new System.Drawing.Point(246, 391);
            this.lblMel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMel.Name = "lblMel";
            this.lblMel.Size = new System.Drawing.Size(64, 16);
            this.lblMel.TabIndex = 12;
            this.lblMel.Text = "Mel Site : ";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(375, 450);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 28);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // FormModifierParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 484);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.gbxPayBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormModifierParametres";
            this.Text = "Modifier les Paramètres du site";
            this.Load += new System.EventHandler(this.FormModifierParametres_Load);
            this.gbxPayBox.ResumeLayout(false);
            this.gbxPayBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPayBox;
        private System.Windows.Forms.TextBox tbxRang;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxCle;
        private System.Windows.Forms.TextBox tbxSite;
        private System.Windows.Forms.Label lblHMAC;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblRang;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.CheckBox cbxProduction;
        private System.Windows.Forms.TextBox tbxMel;
        private System.Windows.Forms.Label lblMel;
        private System.Windows.Forms.Button btnModifier;
    }
}