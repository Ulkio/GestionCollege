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

        //Méthode qui récupère toutes les données de la table Etudiant et qui retourne une liste
        /* public List<MODEL.Etudiant> GetAll()
         {
             //La requête (toujours de type chaîne de caractères (string))
             string strSql = "Select * from etudiant";
             sqlCde.CommandText = strSql;

             //Execution de ma commande grâce au DataReader (sqlReader) 
             sqlReader = sqlCde.ExecuteReader();
             //Je récupère les données dans un while (tant qu'il y a des données à lire)
             while (sqlReader.Read())
             {
                 etu = new MODEL.Etudiant();

                 //Definition Mappage : faire correspondre ta base de données avec ton MODEL.Etudiant (il récupère les infos non
                 //objet (Données SQL) de la base de donnée et les transforme en language objet (language c#))

                 //Mappage objet relationnel
                 etu.idEtudiant = sqlReader.GetInt32(0);
                 etu.nomEtudiant = sqlReader.GetString(1);
                 etu.prenomEtudiant = sqlReader.GetString(2);
                 letu.Add(etu);
             }
             //Une fois que les données sont récupérées, je ferme la connexion
             sqlReader.Close();
             //Je retourne la liste des donées récupérées par le datareader
             return letu;
         }/*/

        //Méthode DisplayData, qui retourne une DataTable
        public DataTable DisplayData() //Méthode qui retourne une datatable
        {
            daoConnect = new Connect();//On instancie une connexion

            dt = new DataTable();//:On instancie une DataTable
            adapt = new MySqlDataAdapter("select * from etudiant", daoConnect.GetSqlConnect());//On instancie un adapter avec en paramètres la requête et la connexion)
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
            sqlCde = new MySqlCommand("update etudiant set nomEtudiant = @nom, prenomEtudiant = @prenom where idEtudiant = @id", daoConnect.GetSqlConnect());
        }

    }
}
