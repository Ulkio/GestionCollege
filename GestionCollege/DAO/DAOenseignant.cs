using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionCollege
{
    class DAOenseignant
    {
        //ATTRIBUTS
        private DAO.Connect DAOconnect;
        private MySqlDataAdapter adapter;
        private MySqlDataReader reader;
        public MySqlCommand sqlCommand { get; set; }


        //CONSTRUCTEUR
        public DAOenseignant()
        {
            DAOconnect = new DAO.Connect();
            DAOconnect.GetSqlConnect();

            sqlCommand = new MySqlCommand();
            sqlCommand.Connection = DAOconnect.GetSqlConnect();
        }


        //CRUD
        public DataTable DisplayData()
        {
            DAOconnect = new DAO.Connect();
            DataTable dt = new DataTable();
            adapter = new MySqlDataAdapter("SELECT idEnseignant AS ID, DATE_FORMAT(dateFonctionEnseignant, '%d/%m/%Y') AS \"Date d'entree\", nomEnseignant AS Nom, prenomEnseignant AS Prenom, telEnseignant AS Telephone, mailEnseignant AS Mail, isResponsableEnseignant AS Responsable, idDepartement, idMatiere FROM enseignant", DAOconnect.GetSqlConnect());
            adapter.Fill(dt);
            //DAOconnect.Close();
            return dt;
        }
        public void Save()
        {
            sqlCommand = new MySqlCommand("INSERT INTO enseignant(nomEnseignant, prenomEnseignant, telEnseignant, mailEnseignant, isResponsableEnseignant, dateFonctionEnseignant, idDepartement, idMatiere) VALUES (@nom, @prenom, @tel, @mail, @resp, @date, @idDpt, @idMat)", DAOconnect.GetSqlConnect());
        }
        public void Update()
        {
            sqlCommand = new MySqlCommand("UPDATE enseignant SET nomEnseignant = @nom, prenomEnseignant = @prenom, telEnseignant = @tel, mailEnseignant = @mail, isResponsableEnseignant = @resp, dateFonctionEnseignant= @date WHERE idEnseignant = @id", DAOconnect.GetSqlConnect());
        }
        public void Delete()
        {
            sqlCommand = new MySqlCommand("DELETE FROM enseignant WHERE idEnseignant = @id", DAOconnect.GetSqlConnect());
        }
        public DataTable Search()
        {
            DAOconnect = new DAO.Connect();
            DataTable dtSearch = new DataTable();
            adapter = new MySqlDataAdapter("SELECT * FROM enseignant WHERE nomEnseignant LIKE '@nom')", DAOconnect.GetSqlConnect());
            adapter.Fill(dtSearch);
            return dtSearch;
        }
    }
}
