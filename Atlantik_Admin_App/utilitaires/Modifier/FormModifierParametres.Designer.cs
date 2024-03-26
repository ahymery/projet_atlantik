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
            this.gbxPayBox.Controls.Add(this.tbxID);
            this.gbxPayBox.Controls.Add(this.tbxCle);
            this.gbxPayBox.Controls.Add(this.tbxSite);
            this.gbxPayBox.Controls.Add(this.lblHMAC);
            this.gbxPayBox.Controls.Add(this.lblIdentifiant);
            this.gbxPayBox.Controls.Add(this.lblRang);
            this.gbxPayBox.Controls.Add(this.lblSite);
            this.gbxPayBox.Location = new System.Drawing.Point(13, 13);
            this.gbxPayBox.Name = "gbxPayBox";
            this.gbxPayBox.Size = new System.Drawing.Size(368, 279);
            this.gbxPayBox.TabIndex = 0;
            this.gbxPayBox.TabStop = false;
            this.gbxPayBox.Text = "Identifiants PayBox";
            // 
            // tbxRang
            // 
            this.tbxRang.Location = new System.Drawing.Point(138, 67);
            this.tbxRang.Name = "tbxRang";
            this.tbxRang.Size = new System.Drawing.Size(35, 20);
            this.tbxRang.TabIndex = 11;
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(138, 105);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(100, 20);
            this.tbxID.TabIndex = 10;
            // 
            // tbxCle
            // 
            this.tbxCle.Location = new System.Drawing.Point(138, 143);
            this.tbxCle.Multiline = true;
            this.tbxCle.Name = "tbxCle";
            this.tbxCle.Size = new System.Drawing.Size(182, 130);
            this.tbxCle.TabIndex = 9;
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(138, 30);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(100, 20);
            this.tbxSite.TabIndex = 8;
            // 
            // lblHMAC
            // 
            this.lblHMAC.AutoSize = true;
            this.lblHMAC.Location = new System.Drawing.Point(16, 143);
            this.lblHMAC.Name = "lblHMAC";
            this.lblHMAC.Size = new System.Drawing.Size(65, 13);
            this.lblHMAC.TabIndex = 7;
            this.lblHMAC.Text = "Clé HMAC : ";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(16, 105);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(62, 13);
            this.lblIdentifiant.TabIndex = 6;
            this.lblIdentifiant.Text = "Identifiant : ";
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(16, 67);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(42, 13);
            this.lblRang.TabIndex = 5;
            this.lblRang.Text = "Rang : ";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(16, 30);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(31, 13);
            this.lblSite.TabIndex = 4;
            this.lblSite.Text = "Site :";
            // 
            // cbxProduction
            // 
            this.cbxProduction.AutoSize = true;
            this.cbxProduction.Location = new System.Drawing.Point(257, 317);
            this.cbxProduction.Name = "cbxProduction";
            this.cbxProduction.Size = new System.Drawing.Size(92, 17);
            this.cbxProduction.TabIndex = 1;
            this.cbxProduction.Text = "En production";
            this.cbxProduction.UseVisualStyleBackColor = true;
            // 
            // tbxMel
            // 
            this.tbxMel.Location = new System.Drawing.Point(257, 340);
            this.tbxMel.Name = "tbxMel";
            this.tbxMel.Size = new System.Drawing.Size(124, 20);
            this.tbxMel.TabIndex = 12;
            // 
            // lblMel
            // 
            this.lblMel.AutoSize = true;
            this.lblMel.Location = new System.Drawing.Point(197, 343);
            this.lblMel.Name = "lblMel";
            this.lblMel.Size = new System.Drawing.Size(54, 13);
            this.lblMel.TabIndex = 12;
            this.lblMel.Text = "Mel Site : ";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(281, 366);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // FormModifierParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 393);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblMel);
            this.Controls.Add(this.tbxMel);
            this.Controls.Add(this.cbxProduction);
            this.Controls.Add(this.gbxPayBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifierParametres";
            this.Text = "Modifier les Paramètres du site";
            this.Load += new System.EventHandler(this.FormModifierParametres_Load);
            this.gbxPayBox.ResumeLayout(false);
            this.gbxPayBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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