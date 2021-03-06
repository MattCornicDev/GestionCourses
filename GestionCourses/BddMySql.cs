using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionCourses
{
    class BddMySql
    {
        private MySqlConnection Connexion;
        private String AdrServeur, NomBdd, Utilisateur, MotPasse;
        private int NumPort;
        private string ChaineConnexion;
        private String _Erreur;
        private bool EstConnecte;

        public BddMySql(string Serv, int Port, string Bdd, string User, string Pass)
        {
            AdrServeur = Serv;
            NomBdd = Bdd;
            Utilisateur = User;
            MotPasse = Pass;
            NumPort = Port;
            ChaineConnexion = "Server=" + AdrServeur +
                              ";Database=" + NomBdd +
                              ";port=" + NumPort +
                              ";User Id=" + Utilisateur +
                              ";password=" + MotPasse;

            Connexion = new MySqlConnection(ChaineConnexion); // Création de l'object Connexion
            EstConnecte = false; // Connexion fermée par défaut


        }

        public bool OuvrirConnexion()
        {
            try
            {
                Connexion.Open();
                EstConnecte = true;
            }
            catch (Exception Er)
            {
                _Erreur = Er.Message;
            }
            return EstConnecte;
        }

        public bool FermerConnexion()
        {
            try
            {
                Connexion.Close();
                EstConnecte = false;
            }
            catch (Exception Er)
            {
                _Erreur = Er.Message;
            }

            return EstConnecte;
        }

        public string Erreur
        {
            get { return _Erreur; }
        }


        public MySqlDataReader RequeteSql(String Requete)
        {
            MySqlCommand CmdSql = new MySqlCommand(Requete, Connexion);
            MySqlDataReader Reader = null;

            if (EstConnecte == true)
            {
                try
                {
                    Reader = CmdSql.ExecuteReader();
                }
                catch (Exception Er)
                {
                    _Erreur = Er.Message;
                }
                return Reader;
            }
        }

        public int RequeteNoData(String Requete)
        {
            MySqlCommand CmdSqlNoData = new MySqlCommand(Requete, Connexion);
            int NbrLignesModifiees = 0;

            if (EstConnecte == true)
            {
                try
                {
                    NbrLignesModifiees = CmdSqlNoData.ExecuteNonQuery();
                }
                catch (MySqlException Er)
                {
                    _Erreur = Er.Message;
                }
            }
            return NbrLignesModifiees;
        }

    }
}
