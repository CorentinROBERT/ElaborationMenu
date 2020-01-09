namespace ElaborationMenu
{
    partial class FormModifier
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
            this.TextBox_Designation = new System.Windows.Forms.TextBox();
            this.TextBox_Ville = new System.Windows.Forms.TextBox();
            this.Label_Designation = new System.Windows.Forms.Label();
            this.Label_Ville = new System.Windows.Forms.Label();
            this.button_valider = new System.Windows.Forms.Button();
            this.Button_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Designation
            // 
            this.TextBox_Designation.Location = new System.Drawing.Point(55, 34);
            this.TextBox_Designation.Name = "TextBox_Designation";
            this.TextBox_Designation.Size = new System.Drawing.Size(260, 20);
            this.TextBox_Designation.TabIndex = 0;
            // 
            // TextBox_Ville
            // 
            this.TextBox_Ville.Location = new System.Drawing.Point(55, 105);
            this.TextBox_Ville.Name = "TextBox_Ville";
            this.TextBox_Ville.Size = new System.Drawing.Size(257, 20);
            this.TextBox_Ville.TabIndex = 1;
            // 
            // Label_Designation
            // 
            this.Label_Designation.AutoSize = true;
            this.Label_Designation.Location = new System.Drawing.Point(55, 9);
            this.Label_Designation.Name = "Label_Designation";
            this.Label_Designation.Size = new System.Drawing.Size(63, 13);
            this.Label_Designation.TabIndex = 2;
            this.Label_Designation.Text = "Designation";
            // 
            // Label_Ville
            // 
            this.Label_Ville.AutoSize = true;
            this.Label_Ville.Location = new System.Drawing.Point(55, 74);
            this.Label_Ville.Name = "Label_Ville";
            this.Label_Ville.Size = new System.Drawing.Size(26, 13);
            this.Label_Ville.TabIndex = 3;
            this.Label_Ville.Text = "Ville";
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(58, 147);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(83, 45);
            this.button_valider.TabIndex = 3;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // Button_Annuler
            // 
            this.Button_Annuler.Location = new System.Drawing.Point(232, 147);
            this.Button_Annuler.Name = "Button_Annuler";
            this.Button_Annuler.Size = new System.Drawing.Size(83, 45);
            this.Button_Annuler.TabIndex = 4;
            this.Button_Annuler.Text = "Annuler";
            this.Button_Annuler.UseVisualStyleBackColor = true;
            this.Button_Annuler.Click += new System.EventHandler(this.Button_Annuler_Click);
            // 
            // FormModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 212);
            this.Controls.Add(this.Button_Annuler);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.Label_Ville);
            this.Controls.Add(this.Label_Designation);
            this.Controls.Add(this.TextBox_Ville);
            this.Controls.Add(this.TextBox_Designation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModifier";
            this.Text = "Modifier Elaboration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Designation;
        private System.Windows.Forms.TextBox TextBox_Ville;
        private System.Windows.Forms.Label Label_Designation;
        private System.Windows.Forms.Label Label_Ville;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button Button_Annuler;
    }
}