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
    public partial class Form4modifystock : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form4modifystock()
        {
            InitializeComponent();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\user\Desktop\data.accdb";
            con.ConnectionString = constring;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "delete from stock where Bar_code=" + textBox4.Text + "";
                // MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("data deleted");
                con.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "Insert into stock(item_name,unit_price,bar_code) values( '" + textBox2.Text + "',' " + textBox3.Text +"',' " + textBox4.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("data saved");
                con.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "Update stock set item_name=' " + textBox2.Text + "' ,unit_price='" + textBox3.Text + "' where Bar_code=" + textBox4.Text + " ";
                MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("data edited");
                con.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            } 
        }
    }
}
