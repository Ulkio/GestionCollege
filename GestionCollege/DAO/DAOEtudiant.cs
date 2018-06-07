using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionCollege.DAO
{
    class DAOetudiant
    {
        //ATTRIBUTS
        //Déclaration d'un objet de ma classe Connect (instanciation de la classe Connect, qui permet de me connecter à la base de données)
        private Connect daoConnect;
        //Déclaration d'un objet adapter pour adapter les données récupérées en base de données avec la classe objet Etudiant.cs
        private MySqlDataAdapter adapt;
        //Déclaration d'un objet Command pour les requêtes
        public MySqlCommand sqlCde { get; set; }
        //Permet de lire les données en base de données
        private MySqlDataReader sqlReader;
        //Déclaration de l'objet Etudiant
        private MODEL.Etudiant etu;
        //Déclaration d'un objet liste (pour l'ensemble des lignes récupérées en base de données)
        //private List<MODEL.Etudiant> letu = new List<MODEL.Etudiant>();
        //Déclaration d'une DataTable
        private DataTable dt;

        //Mon constructeur de la classe DAOEtudiant (qui me permettra d'établir la connexion avec la BDD) (le rôle du constructeur est d'initialiser
        //tous ce qu'on a dedans)
        public DAOetudiant()
        {
            daoConnect = new Connect();
            daoConnect.GetSqlConnect();
            sqlCde = new MySqlCommand();
            sqlCde.Connection = daoConnect.GetSqlConnect();
        }


        //Méthode DisplayData, qui retourne une DataTable
        public DataTable DisplayData() //Méthode qui retourne une datatable
        {
            daoConnect = new Connect();//On instancie une connexion

            dt = new DataTable();//:On instancie une DataTable
            adapt = new MySqlDataAdapter("select idEtudiant AS ID, DATE_FORMAT(dateEntreeEtudiant, '%d/%m/%Y') AS \"Date d'entree\", nomEtudiant AS Nom, prenomEtudiant AS Prenom, telEtudiant AS Telephone, mailEtudiant AS Mail from etudiant", daoConnect.GetSqlConnect());//On instancie un adapter avec en paramètres la requête et la connexion)
            adapt.Fill(dt);//On remplit avec la method fill() de l’adapter, la datatable dt
            return dt;//On retourne le table pour la faire correspondre au datagridview du formulaire
        }


        //Méthode pour sauvegarder une nouvelle entrée de mon objet Etudiant
        public void save()
        {
            sqlCde = new MySqlCommand("insert into etudiant(nomEtudiant, prenomEtudiant, dateEntreeEtudiant, telEtudiant, mailEtudiant) values(@nom, @prenom, @date, @tel, @mail)", daoConnect.GetSqlConnect());
        }

        //Méthode pour supprimer une entrée (Etudiant) en base de données
        public void delete()
        {
            sqlCde = new MySqlCommand("delete from etudiant where idEtudiant=@id", daoConnect.GetSqlConnect());
        }

        //Méthode pour modifier un étudiant en base de données
        public void update()
        {
            sqlCde = new MySqlCommand("update etudiant set nomEtudiant = @nom, prenomEtudiant = @prenom, dateEntreeEtudiant = @date , telEtudiant = @tel, mailEtudiant = @mail where idEtudiant = @id", daoConnect.GetSqlConnect());
        }

    }
}
