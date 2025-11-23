using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481_Unit2_Assign_Nino
{
    public partial class Form1 : Form
    {
        DB database;

        private string user;
        private string password;
        private string server;
        private string database_name;

        public Form1()
        
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
            button7.Click += new EventHandler(button7_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            user = textBox1.Text;
            password = textBox2.Text;
            server = textBox3.Text;
            database_name = textBox4.Text;

        if (user.Length == 0 || password.Length == 0 || server.Length == 0 || database_name.Length == 0)
            {
                isValid = false;
                MessageBox.Show("All fields are required.", "Input Error");
            }
            if (isValid)
            {
                database = new DB("Server = " + server + "\\SQLEXPRESS;" +
                                  "Trusted_Connection=True;" +
                                    "Database=" + database_name + ";" +
                                    "User ID=" + user + ";" +
                                    "Password=" + password + ";"
                    );
                MessageBox.Show("Connection Successful!", "Success");
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer Count");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String names = database.getCompanyNames();
            MessageBox.Show(names, "Company names");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string count = database.getOrderCount();
            MessageBox.Show(count, "Order count");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string names = database.getCustomerID();
            MessageBox.Show(names, "CustomerID");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string count = database.getEmployeecount();
            MessageBox.Show(count, "Employee count");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string names = database.getEmployeeLastName();
            MessageBox.Show(names, "Employee Last Name");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
