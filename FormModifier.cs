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
    
    public partial class FormModifier : Form
    {
        private int numElab;
        public FormModifier(int numElaboration,string designation,string ville)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            TextBox_Designation.Text = designation;
            TextBox_Ville.Text = ville;
            numElab = numElaboration;
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            BDD bd = new BDD();
            bd.Update_enregistrement(numElab, TextBox_Designation.Text, TextBox_Ville.Text);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Button_Annuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
