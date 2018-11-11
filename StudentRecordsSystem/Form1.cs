using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentRecordsSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            

        }
        public void Stop()
        {
            this.Close();
            this.Dispose();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pass = textBox2.Text;
            Users conn = Connect.GetUsers(log, pass);
            string logn = conn.login;
            string passw = conn.password;
            if (log.Equals(log) && pass.Equals(pass))
            {
                Hide();
                Form2 f2 = new Form2(this);
                f2.Show();
                


            }
            else
            {
                label4.Visible = true;
            }

        }
    }
}
