
using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BDSssionSimple {
    public static class AppliBD {

        private static MySqlConnection conn = null;

        public static MySqlConnection GetConnection() {
            return conn;
        }
       
        public static bool ConnexionBD() {
          //  string sConnexion = @"server=loca
          //  lhost;userid=root;password=;database=bdparticipants";
            conn = new MySqlConnection(Properties.Settings.Default.SConnexion);
           
            conn.Open();
            return (conn.State == System.Data.ConnectionState.Open);
        }
       
        public static char ConnexionUtilisateur(string nom, string pass) {
            char typeU = 'I';
            AppliBD.ConnexionBD();
            MySqlCommand cmd = conn.CreateCommand();
            String chS =  nom + pass;
            // sans requetes préparées
           string req = "Select typeU from utilisateur where nom = '" + nom + "'and passeHash = sha2('" + nom + pass + "', 512)";

            //string req = "Select typeU from utilisateur where nom=@nom and passeHash = sha2(@namepass,512)";
            cmd.CommandText = req;
            //cmd.Prepare();
            //cmd.Parameters.AddWithValue("@nom", nom);
            //cmd.Parameters.AddWithValue("@namepass", chS);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read()) {
                typeU = rdr.GetChar("typeU");
            }
            rdr.Close();
            return typeU;
        }

        public static List<Participant> GetTousLesParticipants() {

            List<Participant> listeP = new List<Participant>();

            string reqQueryEtus = "Select * from participant ";
            MySqlCommand cmd = AppliBD.GetConnection().CreateCommand();
            cmd.CommandText = reqQueryEtus;
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read()) {
                listeP.Add(new Participant(rdr.GetInt32("id"), rdr.GetString("nom"), rdr.GetString("mail"), rdr.GetFloat("balance")));
            }
            rdr.Close();
            return listeP;
        }
        public static List<string> GetTousLesCatégorie()
        {

            List<string> listeP = new List<string>();

            string reqQueryEtus = "Select DISTINCT `categorie` from participant ";
            MySqlCommand cmd = AppliBD.GetConnection().CreateCommand();
            cmd.CommandText = reqQueryEtus;
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listeP.Add(rdr.GetString("categorie"));
            }
            rdr.Close();
            return listeP;
        }
        public static void ModifParticipant(Participant p) {
            MySqlCommand cmd = AppliBD.GetConnection().CreateCommand();
            
            //String reqUPar = "UPDATE participant SET balance = balance -" + d.GetMontant()/pconcernes.Count+ " where id = " + p.GetId();
            String reqUPar = "UPDATE participant SET balance = "+ p.GetBalance()+", mail= '"+ p.GetMail()+
                "', nom = '"+p.GetNom()+"' where id ="+p.GetId();
            cmd.CommandText = reqUPar;
           
            
            int nbI = cmd.ExecuteNonQuery();
           
        }
        public static List<Participant> SearchParticipant(string categorie)
        {
            List<Participant> listeP = new List<Participant>();

            string reqQueryEtus = $"Select * from participant WHERE categorie = '{categorie}'";
            MySqlCommand cmd = AppliBD.GetConnection().CreateCommand();
            cmd.CommandText = reqQueryEtus;
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listeP.Add(new Participant(rdr.GetInt32("id"), rdr.GetString("nom"), rdr.GetString("mail"), rdr.GetFloat("balance")));
            }
            rdr.Close();
            return listeP;

        }

    }
}
