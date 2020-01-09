using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Oracle.DataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;

namespace ElaborationMenu
{
    public partial class Form1 : Form
    {
        private BDD bd = new BDD();
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            dataGridView1.DataSource = bd.get_table_elaboration();
          
            /*
            //Connection db
            Console.WriteLine("Start Connection DB");
            //---------------------------------------

            //data connection
            string host = "192.168.1.24";
            int port = 1521;
            string sid = "elaborationMenu";
            string user = "SYSTEM";
            string password = "A25663345e*";

            //---------------------------------------
            // Connexion de la chaine (String) pour se connecter directement à Oracle.
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                    + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                    + sid + ")));Password=" + password + ";User ID=" + user;


            OracleConnection conn = new OracleConnection();

            conn.ConnectionString = connString;

            // Create a Command from Connection.
            OracleCommand cmd = conn.CreateCommand();

            
            // Affiche la table elaboration
            //--------------------------------------------------------------------------------
            // Set Command Text
            cmd.CommandText = "select * from elaboration";

            //ouverture de la connexion
            conn.Open();

            //utilsiation d'un reader pour executer la requete et afficher dans la console les resultats
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1)+" "+reader.GetString(2));
                }
            }
            //fermeture de la connexion
            conn.Close();
            //--------------------------------------------------------------------------------
            */

            /*
            //--------------------------------------------------------------------------------
            //insertion 
            string sql = "Insert into elaboration (numelaboration, designation) "
                                             + " values (:numelaboration, :designation) ";

            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue(":numelaboration",4);
            cmd.Parameters.AddWithValue(":designation","Menu 4");

            conn.Open();
            // Exécutez Command (pour delete, insert, update).
            int rowCount = cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Row Count affected = " + rowCount);
            //--------------------------------------------------------------------------------
            */

            /*
            //--------------------------------------------------------------------------------
            //mettre une ligne a jour.
            //insertion 
            string sql = "Update elaboration set designation = :designation where numelaboration = :numelaboration";

            cmd.Connection = conn;
            cmd.CommandText = sql;


            cmd.Parameters.AddWithValue(":designation", "Menu X");
            cmd.Parameters.AddWithValue(":numelaboration", 3);

            // Exécutez Command (utilisé pour delete, insert, update).
            conn.Open();
            int rowCount = cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Row Count affected = " + rowCount);
            //--------------------------------------------------------------------------------
            */

            /*
            //--------------------------------------------------------------------------------
            //Supprimmer une ligne de la base de donnée
            string sql = "Delete from elaboration where numelaboration = :numelaboration ";

            // Définissez Connection pour Command
            cmd.Connection = conn;

            // Command Text.
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue(":numelaboration", 3);

            // Exécutez Command (utilisé pour delete,insert, update).
            conn.Open();
            int rowCount = cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Row Count affected = " + rowCount);
            //--------------------------------------------------------------------------------
            */


            /*
            //--------------------------------------------------------------------------------
            //Execution de procedure stocké

            //Change la ville d'une elaboration par une nouvelle ville
            cmd = new OracleCommand("SP_MENUS_PAR_VILLE", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //ajout des parametres ville a changé et nouvelle ville
            cmd.Parameters.Add("PN$VILLE", "ST JEAN");
            cmd.Parameters.Add("PN$NEW_VILLE", "NICE");

            //ouverture bdd
            conn.Open();
            //execution de la procedure stocke
            int rowCount = cmd.ExecuteNonQuery();
            //fermeture de la connexion
            conn.Close();

            //indique le nombre de ligne affecté
            Console.WriteLine("Row Count affected = " + rowCount);
            //--------------------------------------------------------------------------------
            */

            /*
            //--------------------------------------------------------------------------------
            //Execution d'une fonction

            //ouverture de la connexion
            conn.Open();
            try
            {
                // Créez un objet Command pour appeler la fonction Get_Emp_No.
                cmd = new OracleCommand("Get_Menu_From_Ville", conn);

                // Le type de Command est StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;

                // ** Remarque: Avec Oracle, le paramètre de retour doit être ajouté d'abord.
                // Créez un paramètre dont le résultat de retour de la fonction est (Varchar2(50)).
                OracleParameter resultParam = new OracleParameter(":Result", OracleDbType.Varchar2, 50);

                // ReturnValue
                resultParam.Direction = ParameterDirection.ReturnValue;

                // Ajoutez aux paramètres.
                cmd.Parameters.Add(resultParam);

                // Ajoutez le paramètre @p_Emp_Id et définissez sa valeur = 100.
                cmd.Parameters.Add(":pVille", OracleDbType.Varchar2).Value = "NICE";

                // Appelez la fonction.
                cmd.ExecuteNonQuery();

                string menu = null;
                if (resultParam.Value != DBNull.Value)
                {
                    OracleString returnValue = (OracleString)resultParam.Value;
                    menu = returnValue.ToString();
                }
                Console.WriteLine("Valeur de retour : " + menu);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //--------------------------------------------------------------------------------
            */
        }

        //se produit lors de l'ouverture de la form principale.
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = false;
        }

        //ajouter un enregistrement
        private void Btn_ajout_donne_Click(object sender, EventArgs e)
        {

        }

        //modifier un enregistrement selectionner
        private void Btn_modifier_elaboration_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                int numElaboration = (int)dataGridView1.CurrentRow.Cells[0].Value;
                string Designation = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Ville = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FormModifier frmModifier = new FormModifier(numElaboration, Designation, Ville);
                frmModifier.ShowDialog();
                if(frmModifier.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = bd.get_table_elaboration();
                }
            }
            else
            {
                MessageBox.Show("Aucune ligne selectionné", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //supprimer un enregistrement selectionner
        private void Btn_supprimer_elaboration_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                int NumeroElaboration = (int)dataGridView1.CurrentRow.Cells[0].Value;
                bd.Supprimer_enregistrement_numElaboration(NumeroElaboration);
                dataGridView1.DataSource = bd.get_table_elaboration();
            }
            else
            {
                MessageBox.Show("Aucune ligne selectionné","ERREUR",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            bd.Fermer_Bdd();
        }
    }
}
