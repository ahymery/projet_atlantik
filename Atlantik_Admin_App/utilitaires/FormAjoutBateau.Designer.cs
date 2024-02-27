namespace Atlantik_Admin_App.utilitaires
{
    partial class FormAjoutBateau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutBateau));
            this.gbxCapaMax = new System.Windows.Forms.GroupBox();
            this.tbxCategorieA = new System.Windows.Forms.TextBox();
            this.tbxCategorieB = new System.Windows.Forms.TextBox();
            this.tbxCategorieC = new System.Windows.Forms.TextBox();
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.lblCategorieA = new System.Windows.Forms.Label();
            this.lblCategorieB = new System.Windows.Forms.Label();
            this.lblCategorieC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.gbxCapaMax.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCapaMax
            // 
            this.gbxCapaMax.Controls.Add(this.lblCategorieC);
            this.gbxCapaMax.Controls.Add(this.lblCategorieB);
            this.gbxCapaMax.Controls.Add(this.lblCategorieA);
            this.gbxCapaMax.Controls.Add(this.tbxCategorieC);
            this.gbxCapaMax.Controls.Add(this.tbxCategorieB);
            this.gbxCapaMax.Controls.Add(this.tbxCategorieA);
            this.gbxCapaMax.Location = new System.Drawing.Point(301, 12);
            this.gbxCapaMax.Name = "gbxCapaMax";
            this.gbxCapaMax.Size = new System.Drawing.Size(275, 314);
            this.gbxCapaMax.TabIndex = 0;
            this.gbxCapaMax.TabStop = false;
            this.gbxCapaMax.Text = "Capacités Maximales";
            // 
            // tbxCategorieA
            // 
            this.tbxCategorieA.Location = new System.Drawing.Point(131, 48);
            this.tbxCategorieA.Name = "tbxCategorieA";
            this.tbxCategorieA.Size = new System.Drawing.Size(138, 22);
            this.tbxCategorieA.TabIndex = 0;
            // 
            // tbxCategorieB
            // 
            this.tbxCategorieB.Location = new System.Drawing.Point(131, 141);
            this.tbxCategorieB.Name = "tbxCategorieB";
            this.tbxCategorieB.Size = new System.Drawing.Size(138, 22);
            this.tbxCategorieB.TabIndex = 1;
            // 
            // tbxCategorieC
            // 
            this.tbxCategorieC.Location = new System.Drawing.Point(131, 253);
            this.tbxCategorieC.Name = "tbxCategorieC";
            this.tbxCategorieC.Size = new System.Drawing.Size(138, 22);
            this.tbxCategorieC.TabIndex = 2;
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.Location = new System.Drawing.Point(134, 34);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(138, 22);
            this.tbxNomBateau.TabIndex = 3;
            // 
            // lblCategorieA
            // 
            this.lblCategorieA.AutoSize = true;
            this.lblCategorieA.Location = new System.Drawing.Point(6, 51);
            this.lblCategorieA.Name = "lblCategorieA";
            this.lblCategorieA.Size = new System.Drawing.Size(92, 16);
            this.lblCategorieA.TabIndex = 3;
            this.lblCategorieA.Text = "A (Passager) :";
            // 
            // lblCategorieB
            // 
            this.lblCategorieB.AutoSize = true;
            this.lblCategorieB.Location = new System.Drawing.Point(6, 144);
            this.lblCategorieB.Name = "lblCategorieB";
            this.lblCategorieB.Size = new System.Drawing.Size(106, 16);
            this.lblCategorieB.TabIndex = 4;
            this.lblCategorieB.Text = "B (Véhi. Inf. 2m) : ";
            // 
            // lblCategorieC
            // 
            this.lblCategorieC.AutoSize = true;
            this.lblCategorieC.Location = new System.Drawing.Point(6, 256);
            this.lblCategorieC.Name = "lblCategorieC";
            this.lblCategorieC.Size = new System.Drawing.Size(114, 16);
            this.lblCategorieC.TabIndex = 5;
            this.lblCategorieC.Text = "C (Véhi. Sup. 2m) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom du bateau : ";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(20, 303);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(241, 23);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjoutBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 340);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNomBateau);
            this.Controls.Add(this.gbxCapaMax);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjoutBateau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un bateau";
            this.Load += new System.EventHandler(this.FormAjoutBateau_Load);
            this.gbxCapaMax.ResumeLayout(false);
            this.gbxCapaMax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCapaMax;
        private System.Windows.Forms.TextBox tbxCategorieC;
        private System.Windows.Forms.TextBox tbxCategorieB;
        private System.Windows.Forms.TextBox tbxCategorieA;
        private System.Windows.Forms.TextBox tbxNomBateau;
        private System.Windows.Forms.Label lblCategorieB;
        private System.Windows.Forms.Label lblCategorieA;
        private System.Windows.Forms.Label lblCategorieC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouter;
    }
}