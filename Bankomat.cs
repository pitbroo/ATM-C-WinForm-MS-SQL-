using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Bankomat_Piotr_Brodziak
{
    public partial class Bankomat : Form
    {
        bool depositIsClick=false;
        bool WithdrawClick = false;
        int tryLogin = 3;
        DataAccesLayer dal = new DataAccesLayer();
        SqlCommand sqlCommand = new SqlCommand();
        string CardNo;
        public Bankomat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CardNo = phtxtInsertCard.Text;
            labelInfo.Text = CardNo;
        }

        private void buttonInsertCard_Click(object sender, EventArgs e)
        {
            if (buttonInsertCard.Text == "Włóż kartę")
            {
                phtxtInsertCard.Visible = true;
                buttonEnterPin.Visible = true;
                tableLayoutPanel1.Visible = true;
            }
            else if (buttonInsertCard.Text == "Zatwierdź numer")
            {
                phtxtInsertCard.Visible = false;
            }

            textBoxPIN.Visible = true;
            CardNo = phtxtInsertCard.Text;
            labelInfo.Text = CardNo;

        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnterPin_Click(object sender, EventArgs e)
        {
            
            int cardNumber = Convert.ToInt32(phtxtInsertCard.Text);
            CreditCard card = new CreditCard();
            Customer customer = new Customer();
            int checkPass  = card.checkCardNumber(cardNumber);
            int Pass = Convert.ToInt32(textBoxPIN.Text);
            if (checkPass == Pass)
            {
               MessageBox.Show("PIN POPRAWNY, zalogowałeś się do bankomatu!");
               panel3.Visible = true;
                panel1.Visible = false;
                tableLayoutPanel1.Visible = false;
                
               BankAccount account = new BankAccount();
               
               int a = Convert.ToInt32(phtxtInsertCard.Text);
               labelInfo.Text = "Numer karty: "+(phtxtInsertCard.Text);
               labelName.Text = customer.getNameSurname(a);

            }
            else
            {
                   
                if (tryLogin == 0)
                {
                    MessageBox.Show(" Nieprawidłowy PIN lub numer karty! KARTA ZABLKOWANA!");

                    panel.Visible = false;
                    panel1.Visible = false;
                    tryLogin--;

                }
               
                else
                {
                    MessageBox.Show("Nieprawidłowy PIN lub numer karty! zostało "+tryLogin+" prób");
                    tryLogin--;
                    textBoxPIN.Text = "";
                    first = "";
                }
                
            }
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            BankAccount account = new BankAccount();
            int a = Convert.ToInt32(phtxtInsertCard.Text);
            labelBalance.Text = "Stan konta: " + account.checkBalanceByCardNumber(a);
        }


        private void button_Click(object sender, EventArgs e)
        {
            int check = Convert.ToInt32(TextBoxAmount.Text);
            if (TextBoxAmount.Text == "")
            {
                MessageBox.Show("Nie podałeś kwoty!");
            }
            else if (check % 10 != 0)
            {
                MessageBox.Show("Nie mamy biolonu, podaj tylko dziesiętne kwoty!");
            }
            else
            {
                if (depositIsClick == true)
                {
                    BankAccount bankAccount = new BankAccount();
                    int cardNumer = Convert.ToInt32(phtxtInsertCard.Text);
                    bankAccount.depositmoney(Convert.ToInt32(TextBoxAmount.Text), cardNumer);
                    labelBalance.Text = "Stan konta: ";
                }
                else if (WithdrawClick == true)
                {
                    
                    BankAccount bankAccount = new BankAccount();
                    int a = Convert.ToInt32(phtxtInsertCard.Text);
                    int currentBalance = Convert.ToInt32(bankAccount.checkBalanceByCardNumber(a));
                    
                    if (currentBalance > Convert.ToInt32(TextBoxAmount.Text))
                    {
                        int cardNumer = Convert.ToInt32(phtxtInsertCard.Text);
                        bankAccount.withdrawMonay(Convert.ToInt32(TextBoxAmount.Text), cardNumer);
                        labelBalance.Text = "Stan konta: ";
                    }
                    else
                    {
                        MessageBox.Show("Za mało środków na koncie!");
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrałeś funkcji!");
                }
            }
        }

        private void buttonDeposit_Click_1(object sender, EventArgs e)
        {
            buttonDeposit.BackColor = Color.Green;
            depositIsClick = true;
            WithdrawClick = false;
            buttonWithdraw.BackColor = Color.Gray;
        }

        private void buttonWithdraw_Click_1(object sender, EventArgs e)
        {
            buttonWithdraw.BackColor = Color.Green;
            WithdrawClick = true;
            depositIsClick = false;
            buttonDeposit.BackColor = Color.Gray; ;
        }

        string first = "";
        string Next(char next)
        {
            return first = first + next;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
                Next('1');
            textBoxPIN.Text = first;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Next('2');
            textBoxPIN.Text = first;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Next('3');
            textBoxPIN.Text = first;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Next('4');
            textBoxPIN.Text = first;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Next('5');
            textBoxPIN.Text = first;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Next('6');
            textBoxPIN.Text = first;
        }

        private void btm7_Click(object sender, EventArgs e)
        {
            Next('7');
            textBoxPIN.Text = first;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Next('8');
            textBoxPIN.Text = first;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Next('9');
            textBoxPIN.Text = first;
        }

    }
}
