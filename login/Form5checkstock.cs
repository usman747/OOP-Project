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
    public partial class Form5checkstock : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form5checkstock()
        {
            InitializeComponent();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\user\Desktop\data.accdb";
            con.ConnectionString = constring;
        }

        private void Form5checkstock_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from stock";
                command.CommandText = query;
                OleDbDataAdapter awais = new OleDbDataAdapter(command);
                DataTable usman = new DataTable();
                awais.Fill(usman);
                dataGridView1.DataSource = usman;
                con.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            } 

        }
    }
}
