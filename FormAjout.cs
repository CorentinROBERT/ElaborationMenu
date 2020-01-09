using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElaborationMenu
{
    public partial class FormAjout : Form
    {
        public FormAjout()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            if(TextBox_Designation.Text != "" && TextBox_Ville.Text != "")
            {
                Bd.Ajouter_enregistrement(TextBox_Designation.Text, TextBox_Ville.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez renseigner l'élaboration ET a ville","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
        private void Button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
