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
    public partial class Form3usermenu : Form
    {
        double total = 0;
        int row = 0;
        private OleDbConnection con = new OleDbConnection();
        public Form3usermenu()
        {
            InitializeComponent();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\user\Desktop\data.accdb";
            con.ConnectionString = constring;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkstock_button_Click(object sender, EventArgs e)
        {
            Form5checkstock f;
            f = new Form5checkstock();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "SELECT * FROM stock where item_name = '" + textBox1.Text + "'";
                // string que = "Insert into stock(serial_no,items,unit_price,bar_code) values('" + textBox1.Text + " ', '" + textBox2.Text + "',' " + textBox3.Text + "',' " + textBox4.Text + "')"; 
                command.CommandText = query;
                //MessageBox.Show(sql);

                OleDbCommand cmd = new OleDbCommand(query, con);

                OleDbDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //this.textBox4.Text = reader["item_name"].ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1[0, 0].Value = reader["bar_code"].ToString();
                    dataGridView1[1, 0].Value = reader["item_name"].ToString();
                    dataGridView1[2, 0].Value = reader["unit_price"].ToString();
                }

                reader.Close();
                con.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            OleDbCommand co = new OleDbCommand();
            co.Connection = con;
            co.CommandText = "SELECT * FROM stock";
            con.Open();
            OleDbDataReader reader;
            reader = co.ExecuteReader();

            while (reader.Read())
            {
                if (reader["item_name"].ToString().Contains(dataGridView1[1, 0].Value.ToString()))
                {
                    dataGridView2.Rows.Add();
                    dataGridView2[0, row].Value = dataGridView1[0, 0].Value.ToString();
                    dataGridView2[1, row].Value = dataGridView1[1, 0].Value.ToString();
                    dataGridView2[2, row].Value = dataGridView1[2, 0].Value.ToString();
                    dataGridView2[3, row].Value = textBox2.Text;
                    double cost = (Convert.ToDouble(textBox2.Text)) * (Convert.ToDouble(reader["unit_price"].ToString()));
                    dataGridView2[4, row].Value = Convert.ToString(cost);
                    total = total + cost;
                    row++;
                }
                textBox4.Text = Convert.ToString(total);
            }
            
            con.Close();
        }

        private void invoice_button_Click(object sender, EventArgs e)
        {
            PdfPTable ali = new PdfPTable(5);
           
            Document awais = new Document(iTextSharp.text.PageSize.A4);
            PdfWriter wri = PdfWriter.GetInstance(awais, new FileStream("lis.pdf", FileMode.Create));

            awais.Open();
            iTextSharp.text.Image abbasi = iTextSharp.text.Image.GetInstance("robot.PNG");
            abbasi.ScalePercent(75f);
          
            awais.Add(abbasi);
            Paragraph co_name;
            co_name = new Paragraph("COMPANY NAME:ROBOT PARTS CORPORATION \n ADDRESS:PLOT NO:2,BLUE AREA,ISLAMABAD \n CONTACT NO:051-12345 \n");
            Paragraph invoice = new Paragraph("                                                                            INVOICE");
            DateTime dt;
            string dts;
            dt = DateTime.Now;
            dts = dt.ToString();
            Paragraph date = new Paragraph(dts);
            Paragraph cost= new Paragraph(Convert.ToString(total));
            Paragraph to = new Paragraph("TOTAL COST: "+total+" \n SIGNATURE: \n\n\n\n                                    THANK YOU FOR BUYING FROM US");
            ali.AddCell("BAR CODE");
            ali.AddCell("ITEM NAME");
            ali.AddCell("UNIT PRICE");
            ali.AddCell("QUANTITY");
            ali.AddCell("COST");
            int d = dataGridView2.RowCount;
            int a = 1;
            while (a != d)
            {
                ali.AddCell(dataGridView2[0, a - 1].Value.ToString());
                ali.AddCell(dataGridView2[1, a - 1].Value.ToString());
                ali.AddCell(dataGridView2[2, a - 1].Value.ToString());
                ali.AddCell(dataGridView2[3, a - 1].Value.ToString());
                ali.AddCell(dataGridView2[4, a - 1].Value.ToString());      
                a++;
            }
      
            awais.Add(invoice);
            awais.Add(date);
            awais.Add(co_name);
            awais.Add(ali);
            awais.Add(to);
            awais.Dispose();
            awais.Close();
            System.Diagnostics.Process.Start(System.IO.Path.Combine(Application.StartupPath, "lis.pdf"));
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}