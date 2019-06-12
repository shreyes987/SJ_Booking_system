using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        customer model = new customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtfname.Text = txtfrom.Text = txtlname.Text = txtnt.Text = txtto.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "" && txtfrom.Text == "" && txtlname.Text == "" && txtto.Text == "" && txtnt.Text == "")
            {
                MessageBox.Show("values cannot be blank");
            }
            else
            {
                model.FirstName = txtfname.Text.Trim();
                model.LastName = txtlname.Text.Trim();
                model.TicketsNo = txtnt.Text.Trim();
                model.From = txtfrom.Text.Trim();
                model.To = txtto.Text.Trim();
                using (Dbmodel db = new Dbmodel())
                {
                    db.customers.Add(model);
                    db.SaveChanges();
                }
                Clear();
                MessageBox.Show("BOOKING DONE");
                PopulateDataGridView();
            }
        }

        void PopulateDataGridView()
        {
            using (Dbmodel db = new Dbmodel())
            {
                dataGridView1.DataSource = db.customers.ToList<customer>();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            date.Text = DateTime.Now.ToLongTimeString();
            time.Text = DateTime.Now.ToLongDateString();

            PopulateDataGridView();
        }

        private void txtnt_TextChanged(object sender, EventArgs e)
        {
            if (txtnt.Text != "")
            { 
                int b = int.Parse(txtnt.Text);
                int c = b * 40;
                string cc = c.ToString();
                txtprice.Text = cc;
            }
            else
            {
                txtnt.Text = "";
                txtprice.Text = "0";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
