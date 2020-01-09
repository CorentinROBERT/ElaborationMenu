using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElaborationMenu
{
    //Definit la classe d'acces à la BDD Oracle
    class BDD
    {
        private OracleConnection conn = new OracleConnection();
        private OracleCommand cmd = null;
        public BDD()
        {
            string host = "192.168.1.24";
            int port = 1521;
            string sid = "elaborationMenu";
            string user = "SYSTEM";
            string password = "A25663345e*";

            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                    + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                    + sid + ")));Password=" + password + ";User ID=" + user;


            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
        }

        public void Fermer_Bdd()
        {
            if(conn.State == ConnectionState.Open)
                conn.Close();
        }

        //retourne la liste des colonnes de la table elaboration
        public DataTable get_table_elaboration()
        {
        
            string sql = "select * from elaboration ";
            cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            DataTable ds = new DataTable();

            da.Fill(ds);

            return ds;
        }

        //supprime une elaboration avec son numero
        public void Supprimer_enregistrement_numElaboration(int numElaboration)
        {
            //Supprimmer une ligne de la base de donnée
            string sql = "Delete from elaboration where numelaboration = :numelaboration ";

            // Définissez Connection pour Command
            cmd.Connection = conn;

            // Command Text.
            cmd.CommandText = sql;

            cmd.Parameters.Add(":numelaboration", numElaboration);

            
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            // Exécutez Command (utilisé pour delete,insert, update).
            //int RowCount = cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
        }

        //update designation et ville d'une elaboration
        public void Update_enregistrement(int numElaboration, string designation,string ville)
        {
            //Supprimmer une ligne de la base de donnée
            string sql = "Update elaboration set designation = :designation , ville = :ville where numelaboration = :numelaboration";

            // Définissez Connection pour Command
            cmd.Connection = conn;

            // Command Text.
            cmd.CommandText = sql;

            cmd.Parameters.Add(":designation", designation);
            cmd.Parameters.Add(":ville", ville);
            cmd.Parameters.Add(":numelaboration", numElaboration);


            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            // Exécutez Command (utilisé pour delete,insert, update).
            //int RowCount = cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
        }

        public void Ajouter_enregistrement(string elaboration,string ville)
        {
            string sql = "Insert into elaboration (designation,ville) "
                                            + " values (:designation,:ville) ";

            cmd.CommandText = sql;

            cmd.Parameters.Add(":designation", elaboration);
            cmd.Parameters.Add(":ville", ville);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            int rowCount = cmd.ExecuteNonQuery();
        }
    }
}
