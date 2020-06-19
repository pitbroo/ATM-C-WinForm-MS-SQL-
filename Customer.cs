using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bankomat_Piotr_Brodziak
{
    class Customer
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int CustomerID{ get; private set; }
        public long PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public long PersonalID { get; private set; }


        public int getCustomerID (long pesel)
        {
            string query = "select CustomerID from Customers where PersonalID = @pesel";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@pesel", pesel);
            DataAccesLayer dal = new DataAccesLayer();
            if (dal.connctionOpen())
            {
                SqlDataReader reader = dal.returnReader(sqlCommand);
                if (reader.HasRows)
                {
                    reader.Read(); // wczytuje pierwszy wiersz
                    this.CustomerID = Convert.ToInt32(reader[0].ToString());
                    reader.Close();
                    dal.connctionClosed();
                    return this.CustomerID;
                }
                else
                {
                    dal.connctionClosed();
                    return -1;
                }
            }
            else
            {
                return -2;
            }
        }
        public int getCustoemrInfo(long pesel)
        {
            string query = "SELECT Name, Surname, PhoneNumber, Address, PersonalID from Customers where PersonalID = @pesel";
                //"SELECT name, Surname, PhoneName, Address, PersonalID FROM Customers where PersonalID = @pesel";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@pesel", pesel);
            DataAccesLayer dal = new DataAccesLayer();

            if (dal.connctionOpen())
            {
                SqlDataReader reader = dal.returnReader(sqlCommand);
                if (reader.HasRows)
                {
                    reader.Read();
                    this.Name = reader[0].ToString();
                    this.Surname = reader[1].ToString();
                    this.PhoneNumber = Convert.ToInt64(reader[2].ToString());
                    this.Address = reader[3].ToString();
                    this.PersonalID = Convert.ToInt64(reader[4].ToString());
                    reader.Close();
                    dal.connctionClosed();
                    return 1; //klient został znaleziony
                }
                else
                {
                    dal.connctionClosed();
                    return -1; //brak klienta w bazie danych
                }
            }
            else
            {

                return -2; //brak połaczenia z bazą danych
            }
        }
        
        public void setCustomer(string[] customerTable)
        {
            this.Name = customerTable[0];
            this.Surname = customerTable[1];
            this.PhoneNumber = Convert.ToInt64(customerTable[2]);
            this.Address = customerTable[3];
            this.PersonalID = Convert.ToInt64(customerTable[4]);
        }
        public string addCustomer()
        {
            string query = "insert into Customers values(@name, @surname,@phone,@Addres, @personaLID)";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue ("@name", this.Name);
            sqlCommand.Parameters.AddWithValue("@surname", this.Surname);
            sqlCommand.Parameters.AddWithValue("@phone", this.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@Addres", this.Address);
            sqlCommand.Parameters.AddWithValue("@personaLID", this.PersonalID);
            DataAccesLayer dal = new DataAccesLayer();
            try
            {
                dal.connctionOpen();
                dal.queryExecution(sqlCommand);
                dal.connctionClosed();
            }
            catch (Exception e)
            {
                return e.ToString();
            }


            return "Customer Inserted";
        }
        public string getNameSurname(int cardNumber)
        {
            string query = "SELECT Name, Surname from Customers, CreditCards  where CardNumber = @cardNumber";
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
                    this.Name = reader[0].ToString();
                    this.Surname = reader[1].ToString();
                    reader.Close();
                    dal.connctionClosed();
                    return Name+" "+Surname; //klient został znaleziony
                }
                else
                {
                    dal.connctionClosed();
                    return "Brak w bazie"; //brak klienta w bazie danych
                }
            }
            else
            {

                return "Brak połączenia z bazą"; //brak połaczenia z bazą danych
            }
        }



    }
}
