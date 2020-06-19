using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Projekt_Bankomat_Piotr_Brodziak
{
    class DataAccesLayer
    {
        SqlConnection sqlConnection =
            new SqlConnection(ConfigurationManager.ConnectionStrings
                ["Projekt_Bankomat_Piotr_Brodziak.Properties.Settings.Database1ConnectionString"].ConnectionString);

        public DataTable selectData(SqlCommand sqlCommand)
        {
            //Obsługa SELECT, nie jest wymagane otwarte połączenie z bazą danych
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public SqlDataReader returnReader(SqlCommand sqlCommand)
        {
            //Obsługa zapytań typu select
            //Metoda wymaga otwartego połączenia z bazą
            sqlCommand.Connection = sqlConnection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            return reader;
        }

        public void queryExecution(SqlCommand sqlCommand)
        {
            //Wymagane jest połączenie z baządanych
            //Obsługuje zapytań  typu inster, update i delete
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }

        public bool connctionOpen()
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool connctionClosed()
        {
            try
            {
                sqlConnection.Close();
                return false;
            }
            catch
            {
                return true;
            }
        }

    }
}
