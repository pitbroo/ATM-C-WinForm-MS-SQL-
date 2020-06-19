using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekt_Bankomat_Piotr_Brodziak
{
    public partial class Form1 : Form
    {
        
        DataAccesLayer dal = new DataAccesLayer();
        SqlCommand sqlCommand = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            refreshDataReview();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LblID_Click(object sender, EventArgs e)
        {

        }

        private void SearchID_Click(object sender, EventArgs e)
        {
            long pesel = Convert.ToInt64(txtBoxPESEL.Text);
            Customer customer = new Customer();
            lblID.Text = customer.getCustomerID(pesel).ToString();
        }

        private void BtnSearchCustomerInfo_Click(object sender, EventArgs e)
        {
            long pesel = Convert.ToInt64(txtBoxPESEL.Text);
            Customer customer = new Customer();
            customer.getCustoemrInfo(pesel);

            int wynik = customer.getCustoemrInfo(pesel);
            if (wynik==1)
            {
                labCustomerInfo.Text = "Customer \nName = " + customer.Name + "\nSurname = " + customer.Surname + "\nPhone = "
                    + customer.PhoneNumber.ToString() + "\nAddress = " + customer.Address + "\n PESEL = " + customer.PersonalID.ToString();
            }
            else if(wynik==-1)
            {
                labCustomerInfo.Text = "No customer";
            }
            else
            {
                labCustomerInfo.Text = "No connection with Data Base!";
            }
        }

        private void txtBoxPESEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            string[] customerTab = new string[5];
            customerTab[0] = textBoxName.Text;
            customerTab[1] = textBoxSurname.Text;
            customerTab[2] = textBoxPhone.Text;
            customerTab[3] = textBoxAddress.Text;
            customerTab[4] = textBoxPesel.Text;
            Customer customer = new Customer();
            customer.setCustomer(customerTab);
            customer.addCustomer();
            labInsertInfo.Text = customer.addCustomer();
            refreshDataReview();
        }
        private void refreshDataReview()
        {
            sqlCommand.CommandText = "SELECT * FROM Customers ";
            dataGridView1.DataSource = dal.selectData(sqlCommand);
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            textBoxPesel.Text = ""; 
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBoxCustomerId.Text);
            BankAccount account = new BankAccount();
            labelBalance.Text = "Balance = "+account.checkBalance(ID).ToString();

        }

        /*   private void Form1_Load(object sender, EventArgs e)
           {

           }
       */
    }
}
