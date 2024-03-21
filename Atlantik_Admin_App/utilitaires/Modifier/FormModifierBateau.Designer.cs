namespace Atlantik_Admin_App.utilitaires
{
    partial class FormModifierBateau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifierBateau));
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.gbxCapacitésMax = new System.Windows.Forms.GroupBox();
            this.tbxCategorieC = new System.Windows.Forms.TextBox();
            this.tbxCategorieB = new System.Windows.Forms.TextBox();
            this.tbxCategorieA = new System.Windows.Forms.TextBox();
            this.lblCategorieC = new System.Windows.Forms.Label();
            this.lblCategorieB = new System.Windows.Forms.Label();
            this.lblCategorieA = new System.Windows.Forms.Label();
            this.cmbNomBateau = new System.Windows.Forms.ComboBox();
            this.btnModifierBateau = new System.Windows.Forms.Button();
            this.gbxCapacitésMax.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(13, 22);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(74, 13);
            this.lblNomBateau.TabIndex = 0;
            this.lblNomBateau.Text = "Nom bateau : ";
            // 
            // gbxCapacitésMax
            // 
            this.gbxCapacitésMax.Controls.Add(this.tbxCategorieC);
            this.gbxCapacitésMax.Controls.Add(this.tbxCategorieB);
            this.gbxCapacitésMax.Controls.Add(this.tbxCategorieA);
            this.gbxCapacitésMax.Controls.Add(this.lblCategorieC);
            this.gbxCapacitésMax.Controls.Add(this.lblCategorieB);
            this.gbxCapacitésMax.Controls.Add(this.lblCategorieA);
            this.gbxCapacitésMax.Location = new System.Drawing.Point(244, 3);
            this.gbxCapacitésMax.Name = "gbxCapacitésMax";
            this.gbxCapacitésMax.Size = new System.Drawing.Size(233, 255);
            this.gbxCapacitésMax.TabIndex = 1;
            this.gbxCapacitésMax.TabStop = false;
            this.gbxCapacitésMax.Text = "Capacités Maximales";
            // 
            // tbxCategorieC
            // 
            this.tbxCategorieC.Location = new System.Drawing.Point(108, 221);
            this.tbxCategorieC.Name = "tbxCategorieC";
            this.tbxCategorieC.Size = new System.Drawing.Size(113, 20);
            this.tbxCategorieC.TabIndex = 5;
            // 
            // tbxCategorieB
            // 
            this.tbxCategorieB.Location = new System.Drawing.Point(108, 117);
            this.tbxCategorieB.Name = "tbxCategorieB";
            this.tbxCategorieB.Size = new System.Drawing.Size(113, 20);
            this.tbxCategorieB.TabIndex = 4;
            // 
            // tbxCategorieA
            // 
            this.tbxCategorieA.Location = new System.Drawing.Point(108, 31);
            this.tbxCategorieA.Name = "tbxCategorieA";
            this.tbxCategorieA.Size = new System.Drawing.Size(113, 20);
            this.tbxCategorieA.TabIndex = 3;
            // 
            // lblCategorieC
            // 
            this.lblCategorieC.AutoSize = true;
            this.lblCategorieC.Location = new System.Drawing.Point(12, 224);
            this.lblCategorieC.Name = "lblCategorieC";
            this.lblCategorieC.Size = new System.Drawing.Size(90, 13);
            this.lblCategorieC.TabIndex = 2;
            this.lblCategorieC.Tag = "C";
            this.lblCategorieC.Text = "C (Véhi.sup.2m) : ";
            // 
            // lblCategorieB
            // 
            this.lblCategorieB.AutoSize = true;
            this.lblCategorieB.Location = new System.Drawing.Point(12, 120);
            this.lblCategorieB.Name = "lblCategorieB";
            this.lblCategorieB.Size = new System.Drawing.Size(84, 13);
            this.lblCategorieB.TabIndex = 1;
            this.lblCategorieB.Tag = "B";
            this.lblCategorieB.Text = "B (Véhi.inf.2m) : ";
            // 
            // lblCategorieA
            // 
            this.lblCategorieA.AutoSize = true;
            this.lblCategorieA.Location = new System.Drawing.Point(12, 34);
            this.lblCategorieA.Name = "lblCategorieA";
            this.lblCategorieA.Size = new System.Drawing.Size(76, 13);
            this.lblCategorieA.TabIndex = 0;
            this.lblCategorieA.Tag = "A";
            this.lblCategorieA.Text = "A (Passager) : ";
            // 
            // cmbNomBateau
            // 
            this.cmbNomBateau.FormattingEnabled = true;
            this.cmbNomBateau.Location = new System.Drawing.Point(93, 22);
            this.cmbNomBateau.Name = "cmbNomBateau";
            this.cmbNomBateau.Size = new System.Drawing.Size(145, 21);
            this.cmbNomBateau.TabIndex = 2;
            this.cmbNomBateau.SelectedIndexChanged += new System.EventHandler(this.cmbNomBateau_SelectedIndexChanged);
            // 
            // btnModifierBateau
            // 
            this.btnModifierBateau.Location = new System.Drawing.Point(16, 230);
            this.btnModifierBateau.Name = "btnModifierBateau";
            this.btnModifierBateau.Size = new System.Drawing.Size(222, 28);
            this.btnModifierBateau.TabIndex = 3;
            this.btnModifierBateau.Text = "Modifier";
            this.btnModifierBateau.UseVisualStyleBackColor = true;
            this.btnModifierBateau.Click += new System.EventHandler(this.btnModifierBateau_Click);
            // 
            // FormModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 270);
            this.Controls.Add(this.btnModifierBateau);
            this.Controls.Add(this.cmbNomBateau);
            this.Controls.Add(this.gbxCapacitésMax);
            this.Controls.Add(this.lblNomBateau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifierBateau";
            this.Text = "Modifier un bateau";
            this.Load += new System.EventHandler(this.FormModifierBateau_Load);
            this.gbxCapacitésMax.ResumeLayout(false);
            this.gbxCapacitésMax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.GroupBox gbxCapacitésMax;
        private System.Windows.Forms.ComboBox cmbNomBateau;
        private System.Windows.Forms.Button btnModifierBateau;
        private System.Windows.Forms.Label lblCategorieC;
        private System.Windows.Forms.Label lblCategorieB;
        private System.Windows.Forms.Label lblCategorieA;
        private System.Windows.Forms.TextBox tbxCategorieC;
        private System.Windows.Forms.TextBox tbxCategorieB;
        private System.Windows.Forms.TextBox tbxCategorieA;
    }
}