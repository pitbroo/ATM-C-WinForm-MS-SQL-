using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Bankomat_Piotr_Brodziak
{
    class CreditCard
    {
        public int CreditCardID { get; private set; }
        public int CardNumber { get; private set; }
        public int PIN { get; private set; }

        private DateTime expiredDate;

        public DateTime GetExpiredDate()
        {
            return expiredDate;
        }

        private void SetExpiredDate(DateTime value)
        {
            expiredDate = value;
        }
        public int CCV  {get; private set; }
        int t=3;
        public Boolean verifyPIN(int InsertPIN)
        {
            if (t > 0)
            {
                if (InsertPIN == PIN)
                {
                    return true;
                }
                else
                {
                    
                    t++;
                    return false;
                }
            }
            else return false;

        }
        
        public int checkCardNumber(int cardNumber)
        {
            string query = "select PIN from CreditCards where CardNumber = @cardNumber";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@cardNumber", cardNumber);
            DataAccesLayer dal = new DataAccesLayer();
            if (dal.connctionOpen())
            {
                SqlDataReader reader = dal.returnReader(sqlCommand);
                if (reader.HasRows)
                {
                    reader.Read(); // wczytuje pierwszy wiersz
                    this.PIN = Convert.ToInt32(reader[0].ToString());
                    
                    reader.Close();
                    dal.connctionClosed();
                    return this.PIN;
                }
                else
                {
                    dal.connctionClosed();
                    return -1;
                   // MessageBox.Show("Nie ma takiego rekordu w bazie!");
                }
            }
            else
            {
                return -2;
            }
        }
        public int getIDbyCardNumber(int cardNumber)
        {
            string query = "select CustomerId from Cusomers, CreditCards where CardNumber = @cardNumber";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@cardNumber", cardNumber);
            DataAccesLayer dal = new DataAccesLayer();
            if (dal.connctionOpen())
            {
                SqlDataReader reader = dal.returnReader(sqlCommand);
                if (reader.HasRows)
                {
                    reader.Read(); // wczytuje pierwszy wiersz
                    this.CardNumber = Convert.ToInt32(reader[0].ToString());

                    reader.Close();
                    dal.connctionClosed();
                    return this.CardNumber;
                }
                else
                {
                    dal.connctionClosed();
                    return -1;
                    // MessageBox.Show("Nie ma takiego rekordu w bazie!");
                }
            }
            else
            {
                return -2;
            }
        }





    }
}
