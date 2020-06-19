using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projekt_Bankomat_Piotr_Brodziak
{
    class BankAccount
    {
        public int AccountID { get;private set;}
        public int CustomerID { get; private set; }
        public string AccountNo { get; private set; }
        public decimal Balance { get; private set; }

        public void withdrawMonay(decimal amount, int cartNumber)
        {
            string query = "update BankAccounts set Balance = Balance - @currnetbalance where CardNumber=@cartNumber";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.AddWithValue("@currnetbalance", amount);
            sqlCommand.Parameters.AddWithValue("@cartNumber", cartNumber);
            DataAccesLayer dal = new DataAccesLayer();

            try
            {
                dal.connctionOpen();
                dal.queryExecution(sqlCommand);
                dal.connctionClosed();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


            MessageBox.Show("WYPŁACONO " + amount.ToString() + " zł z konta!");
        }

        public void depositmoney(decimal amount, int cartNumber)
        {
            string query = "update BankAccounts set Balance = Balance + @currnetbalance where CardNumber=@cartNumber";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
           
            sqlCommand.Parameters.AddWithValue("@currnetbalance", amount);
            sqlCommand.Parameters.AddWithValue("@cartNumber", cartNumber);
            DataAccesLayer dal = new DataAccesLayer();

            try
            {
                dal.connctionOpen();
                dal.queryExecution(sqlCommand);
                dal.connctionClosed();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


            MessageBox.Show("WPŁACONO " + amount.ToString() + " zł na konto");
        }
        public decimal checkBalance(int customerID)
        {
            string query = "select Balance from BankAccounts where CustomerID = @customerID";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.AddWithValue("@customerID", customerID);

            DataAccesLayer dal = new DataAccesLayer();

            if (dal.connctionOpen())
            {
                SqlDataReader reader = dal.returnReader(sqlCommand);
                if (reader.HasRows)
                {
                    reader.Read();
                    this.Balance = Convert.ToDecimal(reader[0].ToString());
                    reader.Close();
                    dal.connctionClosed();
                    return this.Balance;
                }
                dal.connctionClosed();
                return -1;
            }
            else

                return -2;
        }
        public string checkBalanceByCardNumber(int cardNumber)
        {
            string query = "select Balance from BankAccounts where CardNumber = @cardNumber";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.AddWithValue("@cardNumber", cardNumber);

            DataAccesLayer dal = new DataAccesLayer();

            if (dal.connctionOpen())
            {
                SqlDataReader reader = dal.returnReader(sqlCommand);
                if (reader.HasRows)
                {
                    reader.Read();
                    this.Balance = Convert.ToDecimal(reader[0].ToString());
                    reader.Close();
                    dal.connctionClosed();
                    return this.Balance.ToString();
                }
                dal.connctionClosed();
                return "-1";
            }
            else

                return "-2";
        }
        
    

    }
}
