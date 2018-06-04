using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionCollege.DAO
{
    class Connect
    {
        //Déclaration d'un objet de ma classe Connect ( me permet d'accéder à mes méthodes de connexion)
        private Connect instance;
        //Déclaration d'un objet MysqlConnection (pour instancier un objet de connection)
        private MySqlConnection MysqlConnect;

        //Création de mon constructeur
        public Connect()
        {
            //Dans mon constructeur j'instancie mon objet de connexion
            MysqlConnect = new MySqlConnection();
            //Je crée une chaîne de connexion avec la propriété ConnectionString (MySqlConnection)
           //LOCAL      MysqlConnect.ConnectionString = "Server=localhost;Database=gestioncollege;Uid=root;Pwd=";
            MysqlConnect.ConnectionString = "Server=93.113.206.101;Database=college;Uid=Guillaume;Pwd=auskur";


            try
            {
                //j'ouvre ma connexion
                MysqlConnect.Open();
            }
            catch
            {
                //Sinon je ferme ma connexion
                MysqlConnect.Close();
            }
        }

        //Méthode qui permet de se connecter en vérifiant si une instance de connexion est déjà existante avant de se connecter
        public Connect GetInstance()
        {
            if (instance == null)
            {
                //J'instancie l'objet instance de ma classe Connect (dont je crée une connexion par le constructeur)
                instance = new Connect();
            }
            return instance;
        }


        //Méthode qui permet de retourner l'objet MysqlConnection dans mes fichiers DAO
        public MySqlConnection GetSqlConnect()
        {
            return MysqlConnect;
        }

        //Méthode qui ferme la connexion
        public void Close()
        {
            MysqlConnect.Close();
        }
    }
}
