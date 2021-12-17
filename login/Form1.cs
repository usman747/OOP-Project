using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace login
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\user\Desktop\data.accdb";
            con.ConnectionString = constring;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2adminmenu f2;
            f2 = new Form2adminmenu();
            string user_name;
            string password;
            user_name="usman";
            password="123";
            
            if (this.textBox3.Text == user_name && this.textBox2.Text == password)
            {
                f2.Show();
            }
            else
            {
                MessageBox.Show("WRONG PASSWORD");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3usermenu f3;
            f3 = new Form3usermenu();
            f3.Show();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
