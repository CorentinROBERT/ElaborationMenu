namespace ElaborationMenu
{
    partial class Form1
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
            this.btn_ajout_donne = new System.Windows.Forms.Button();
            this.btn_modifier_elaboration = new System.Windows.Forms.Button();
            this.btn_supprimer_elaboration = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajout_donne
            // 
            this.btn_ajout_donne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajout_donne.Location = new System.Drawing.Point(647, 12);
            this.btn_ajout_donne.Name = "btn_ajout_donne";
            this.btn_ajout_donne.Size = new System.Drawing.Size(141, 27);
            this.btn_ajout_donne.TabIndex = 1;
            this.btn_ajout_donne.Text = "Ajouter Elaboration";
            this.btn_ajout_donne.UseVisualStyleBackColor = true;
            this.btn_ajout_donne.Click += new System.EventHandler(this.Btn_ajout_donne_Click);
            // 
            // btn_modifier_elaboration
            // 
            this.btn_modifier_elaboration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modifier_elaboration.Location = new System.Drawing.Point(647, 66);
            this.btn_modifier_elaboration.Name = "btn_modifier_elaboration";
            this.btn_modifier_elaboration.Size = new System.Drawing.Size(141, 27);
            this.btn_modifier_elaboration.TabIndex = 2;
            this.btn_modifier_elaboration.Text = "Modifier Elaboration";
            this.btn_modifier_elaboration.UseVisualStyleBackColor = true;
            this.btn_modifier_elaboration.Click += new System.EventHandler(this.Btn_modifier_elaboration_Click);
            // 
            // btn_supprimer_elaboration
            // 
            this.btn_supprimer_elaboration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supprimer_elaboration.Location = new System.Drawing.Point(647, 122);
            this.btn_supprimer_elaboration.Name = "btn_supprimer_elaboration";
            this.btn_supprimer_elaboration.Size = new System.Drawing.Size(141, 27);
            this.btn_supprimer_elaboration.TabIndex = 3;
            this.btn_supprimer_elaboration.Text = "Supprimer Elaboration";
            this.btn_supprimer_elaboration.UseVisualStyleBackColor = true;
            this.btn_supprimer_elaboration.Click += new System.EventHandler(this.Btn_supprimer_elaboration_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(629, 426);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_supprimer_elaboration);
            this.Controls.Add(this.btn_modifier_elaboration);
            this.Controls.Add(this.btn_ajout_donne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ajout_donne;
        private System.Windows.Forms.Button btn_modifier_elaboration;
        private System.Windows.Forms.Button btn_supprimer_elaboration;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

