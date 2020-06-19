namespace Projekt_Bankomat_Piotr_Brodziak
{
    partial class Bankomat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bankomat));
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEnterPin = new System.Windows.Forms.Button();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.TextBoxAmount = new Projekt_Bankomat_Piotr_Brodziak.PlaceHolderTextBox();
            this.button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.buttonInsertCard = new System.Windows.Forms.Button();
            this.customersTableAdapter1 = new Projekt_Bankomat_Piotr_Brodziak.Database1DataSet1TableAdapters.CustomersTableAdapter();
            this.customersTableAdapter2 = new Projekt_Bankomat_Piotr_Brodziak.Database1DataSet1TableAdapters.CustomersTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button0 = new System.Windows.Forms.Button();
            this.btnPrzecinek = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btm7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.phtxtInsertCard = new Projekt_Bankomat_Piotr_Brodziak.PlaceHolderTextBox();
            this.etykietNrAlbumu = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.panel3);
            this.panel.ForeColor = System.Drawing.Color.Blue;
            this.panel.Location = new System.Drawing.Point(179, 194);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(649, 508);
            this.panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.buttonEnterPin);
            this.panel1.Controls.Add(this.textBoxPIN);
            this.panel1.Location = new System.Drawing.Point(96, 427);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 64);
            this.panel1.TabIndex = 10;
            // 
            // buttonEnterPin
            // 
            this.buttonEnterPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEnterPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEnterPin.ForeColor = System.Drawing.Color.Black;
            this.buttonEnterPin.Location = new System.Drawing.Point(37, 9);
            this.buttonEnterPin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnterPin.Name = "buttonEnterPin";
            this.buttonEnterPin.Size = new System.Drawing.Size(181, 43);
            this.buttonEnterPin.TabIndex = 9;
            this.buttonEnterPin.Text = "Enter PIN";
            this.buttonEnterPin.UseVisualStyleBackColor = false;
            this.buttonEnterPin.Visible = false;
            this.buttonEnterPin.Click += new System.EventHandler(this.buttonEnterPin_Click);
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPIN.HideSelection = false;
            this.textBoxPIN.Location = new System.Drawing.Point(249, 9);
            this.textBoxPIN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.PasswordChar = '*';
            this.textBoxPIN.Size = new System.Drawing.Size(175, 38);
            this.textBoxPIN.TabIndex = 2;
            this.textBoxPIN.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.buttonWithdraw);
            this.panel3.Controls.Add(this.buttonBalance);
            this.panel3.Controls.Add(this.buttonDeposit);
            this.panel3.Controls.Add(this.TextBoxAmount);
            this.panel3.Controls.Add(this.button);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(25, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 395);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.BackColor = System.Drawing.Color.Silver;
            this.buttonWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWithdraw.ForeColor = System.Drawing.Color.Black;
            this.buttonWithdraw.Location = new System.Drawing.Point(192, 175);
            this.buttonWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(128, 110);
            this.buttonWithdraw.TabIndex = 10;
            this.buttonWithdraw.Text = "Wypłać";
            this.buttonWithdraw.UseVisualStyleBackColor = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click_1);
            // 
            // buttonBalance
            // 
            this.buttonBalance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBalance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonBalance.Location = new System.Drawing.Point(389, 175);
            this.buttonBalance.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(160, 111);
            this.buttonBalance.TabIndex = 6;
            this.buttonBalance.Text = "Stan konta";
            this.buttonBalance.UseVisualStyleBackColor = false;
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.Silver;
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeposit.ForeColor = System.Drawing.Color.Black;
            this.buttonDeposit.Location = new System.Drawing.Point(43, 176);
            this.buttonDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(141, 110);
            this.buttonDeposit.TabIndex = 9;
            this.buttonDeposit.Text = "Wpłać";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click_1);
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic);
            this.TextBoxAmount.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxAmount.Location = new System.Drawing.Point(228, 314);
            this.TextBoxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.PlaceHolderText = "Podaj kwote ";
            this.TextBoxAmount.Size = new System.Drawing.Size(320, 34);
            this.TextBoxAmount.TabIndex = 8;
            this.TextBoxAmount.Text = "Podaj kwote ";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button.ForeColor = System.Drawing.Color.Black;
            this.button.Location = new System.Drawing.Point(43, 314);
            this.button.Margin = new System.Windows.Forms.Padding(4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(160, 42);
            this.button.TabIndex = 8;
            this.button.Text = "Zatwierdż";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelInfo);
            this.panel2.Controls.Add(this.labelBalance);
            this.panel2.Location = new System.Drawing.Point(25, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 123);
            this.panel2.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelName.Location = new System.Drawing.Point(4, 6);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(195, 29);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Właścicel konta: ";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.ForeColor = System.Drawing.Color.Black;
            this.labelInfo.Location = new System.Drawing.Point(5, 42);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(54, 24);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "karta:";
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBalance.ForeColor = System.Drawing.Color.Black;
            this.labelBalance.Location = new System.Drawing.Point(4, 80);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(116, 25);
            this.labelBalance.TabIndex = 3;
            this.labelBalance.Text = "Stna Konta:";
            // 
            // buttonInsertCard
            // 
            this.buttonInsertCard.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonInsertCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInsertCard.ForeColor = System.Drawing.Color.White;
            this.buttonInsertCard.Location = new System.Drawing.Point(859, 156);
            this.buttonInsertCard.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsertCard.Name = "buttonInsertCard";
            this.buttonInsertCard.Size = new System.Drawing.Size(259, 44);
            this.buttonInsertCard.TabIndex = 1;
            this.buttonInsertCard.Text = "Włóż kartę";
            this.buttonInsertCard.UseVisualStyleBackColor = false;
            this.buttonInsertCard.Click += new System.EventHandler(this.buttonInsertCard_Click);
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // customersTableAdapter2
            // 
            this.customersTableAdapter2.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Controls.Add(this.button0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPrzecinek, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btm7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(396, 710);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.48544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.51456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 185);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Visible = false;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.ForeColor = System.Drawing.Color.Black;
            this.button0.Location = new System.Drawing.Point(4, 146);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(53, 35);
            this.button0.TabIndex = 12;
            this.button0.Text = ",";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // btnPrzecinek
            // 
            this.btnPrzecinek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzecinek.ForeColor = System.Drawing.Color.Black;
            this.btnPrzecinek.Location = new System.Drawing.Point(71, 146);
            this.btnPrzecinek.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrzecinek.Name = "btnPrzecinek";
            this.btnPrzecinek.Size = new System.Drawing.Size(52, 35);
            this.btnPrzecinek.TabIndex = 11;
            this.btnPrzecinek.Text = "0";
            this.btnPrzecinek.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(135, 146);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "00";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(71, 97);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(52, 41);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(4, 97);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 41);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(135, 51);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(54, 38);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(71, 51);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(52, 38);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(4, 51);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 38);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(135, 4);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(54, 39);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btm7
            // 
            this.btm7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btm7.ForeColor = System.Drawing.Color.Black;
            this.btm7.Location = new System.Drawing.Point(4, 4);
            this.btm7.Margin = new System.Windows.Forms.Padding(4);
            this.btm7.Name = "btm7";
            this.btm7.Size = new System.Drawing.Size(53, 39);
            this.btm7.TabIndex = 0;
            this.btm7.Text = "7";
            this.btm7.UseVisualStyleBackColor = true;
            this.btm7.Click += new System.EventHandler(this.btm7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(71, 4);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 39);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(135, 97);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 41);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // phtxtInsertCard
            // 
            this.phtxtInsertCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.phtxtInsertCard.ForeColor = System.Drawing.Color.Gray;
            this.phtxtInsertCard.Location = new System.Drawing.Point(859, 305);
            this.phtxtInsertCard.Margin = new System.Windows.Forms.Padding(4);
            this.phtxtInsertCard.MaxLength = 20;
            this.phtxtInsertCard.Name = "phtxtInsertCard";
            this.phtxtInsertCard.PlaceHolderText = null;
            this.phtxtInsertCard.Size = new System.Drawing.Size(257, 30);
            this.phtxtInsertCard.TabIndex = 2;
            this.phtxtInsertCard.Text = "Podaj numer karty";
            this.phtxtInsertCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phtxtInsertCard.Visible = false;
            // 
            // etykietNrAlbumu
            // 
            this.etykietNrAlbumu.AutoSize = true;
            this.etykietNrAlbumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.etykietNrAlbumu.Location = new System.Drawing.Point(46, 33);
            this.etykietNrAlbumu.Name = "etykietNrAlbumu";
            this.etykietNrAlbumu.Size = new System.Drawing.Size(192, 25);
            this.etykietNrAlbumu.TabIndex = 4;
            this.etykietNrAlbumu.Text = "Piotr Brodziak 49084";
            // 
            // Bankomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1423, 853);
            this.Controls.Add(this.etykietNrAlbumu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.phtxtInsertCard);
            this.Controls.Add(this.buttonInsertCard);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1441, 900);
            this.MinimumSize = new System.Drawing.Size(1441, 900);
            this.Name = "Bankomat";
            this.Text = "Bankomat";
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonInsertCard;
        private Database1DataSet1TableAdapters.CustomersTableAdapter customersTableAdapter1;
        private Database1DataSet1TableAdapters.CustomersTableAdapter customersTableAdapter2;
        private PlaceHolderTextBox phtxtInsertCard;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btm7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonEnterPin;
        private System.Windows.Forms.Label labelName;
        private PlaceHolderTextBox TextBoxAmount;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button btnPrzecinek;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label etykietNrAlbumu;
    }
}