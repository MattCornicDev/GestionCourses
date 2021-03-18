using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCourses;
using static GestionCourses.BddMySql;
using MySql.Data.MySqlClient;


namespace GestionCourses
{
    public partial class IhmGestionCourses : Form
    {
        public object BddGestCourses { get; private set; }
        public bool FermetureOk { get; private set; }

        public IhmGestionCourses()
        {
            InitializeComponent();
        }

        public bool OuvrirConnexion { get; private set; }



        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            bool OuvertureOk = BddGestCourses.OuvrirConnexion();
            if (OuvertureOk == true)
            {
                textBoxEtat.Text = "Connexion à la base de données réussi";
            }
            else
                textBoxEtat.Text = "Echec de connexion à la base de données : Exception retournée = " + BddGestCourses.Erreur;
                    
        }

        private void buttonDeconnexion_click(object sender, EventArgs e)
        {
            bool FermetureOk = BddGestCourses.Ouvrirconnexion();

            if (FermetureOk == true) 
            { 
            
                textBoxEtat.Text = "Déconnexion de la base de données réussi";
            }
            else
                textBoxEtat.Text = "Echec de déconnexion de la base de données: Exception retournée =" +
                    BddGestCourses.Erreur;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExecuter_Click(object sender, EventArgs e)
        {
            textBoxResultat.Clear();

            MySqlDataReader Reader = BddGestCourses.RequeteSql(textBoxSql.Text);

            if(Reader != null) // on test si la requete a bien retourné un résultat
            {
                // vérifie si des données sont présentes dans le reader.
                if(Reader.HasRows) // HasRows Renvoie 0 si aucune ligne 1 dans le cas contraire.
                {
                    while (Reader.Read()) // Récupère la ligne courante et passe ensuite à la suivante
                                          // Retourne 0 s'il ne reste pas de ligne.
                    {
                        int NbrColonnes = Reader.FieldCount;
                        string Valeur = "";
                        for (int i=0; i<NbrColonnes; i++)
                        {
                            // On récupère la valeur de la colonne d'indice i de la ligne qu'on vient de récuper et on l'ajoute dans la chaine avec une tabulation
                            Valeur += Reader.GetString(i) + "\t";
                        }
                        Valeur += "\n"; // Ajoute un saut de ligne.
                        textBoxResultat.AppendText(Valeur); // Ajoute la ligne au textBoxResultat
                    }
                }
            }
            Reader.Dispose(); // Appelle la méthode pour détruire l'objet (nécessaire entre deux requêtes).
        }
    }
}
