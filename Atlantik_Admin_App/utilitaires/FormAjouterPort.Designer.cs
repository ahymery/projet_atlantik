namespace Atlantik_Admin_App.utilitaires
{
    partial class FormAjouterPort
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
            this.btnAjouterUnPort = new System.Windows.Forms.Button();
            this.tbxAjouterPort = new System.Windows.Forms.TextBox();
            this.lblNomPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjouterUnPort
            // 
            this.btnAjouterUnPort.Location = new System.Drawing.Point(105, 85);
            this.btnAjouterUnPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterUnPort.Name = "btnAjouterUnPort";
            this.btnAjouterUnPort.Size = new System.Drawing.Size(92, 27);
            this.btnAjouterUnPort.TabIndex = 0;
            this.btnAjouterUnPort.Text = "Ajouter";
            this.btnAjouterUnPort.UseVisualStyleBackColor = true;
            this.btnAjouterUnPort.Click += new System.EventHandler(this.btnAjouterUnPort_Click);
            // 
            // tbxAjouterPort
            // 
            this.tbxAjouterPort.Location = new System.Drawing.Point(140, 41);
            this.tbxAjouterPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxAjouterPort.Name = "tbxAjouterPort";
            this.tbxAjouterPort.Size = new System.Drawing.Size(132, 22);
            this.tbxAjouterPort.TabIndex = 1;
            // 
            // lblNomPort
            // 
            this.lblNomPort.AutoSize = true;
            this.lblNomPort.Location = new System.Drawing.Point(33, 44);
            this.lblNomPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomPort.Name = "lblNomPort";
            this.lblNomPort.Size = new System.Drawing.Size(89, 16);
            this.lblNomPort.TabIndex = 2;
            this.lblNomPort.Text = "Nom du port : ";
            // 
            // FormAjouterPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 143);
            this.Controls.Add(this.lblNomPort);
            this.Controls.Add(this.tbxAjouterPort);
            this.Controls.Add(this.btnAjouterUnPort);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAjouterPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un port";
            this.Load += new System.EventHandler(this.FormAjouterPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterUnPort;
        private System.Windows.Forms.TextBox tbxAjouterPort;
        private System.Windows.Forms.Label lblNomPort;
    }
}