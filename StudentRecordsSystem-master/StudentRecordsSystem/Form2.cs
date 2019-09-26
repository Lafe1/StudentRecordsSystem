using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentRecordsSystem
{
    public partial class Form2 : Form
    {
        private Form1 m_parent;
        public Form2(Form1 Form1)
        {
            InitializeComponent();
            m_parent = Form1;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void LoadData()
        {

        }
        static void Conn(DataGridView dataGridView1, DataGridView dataGridView2)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.ColumnHeadersVisible = true;
            LoadData();
            void LoadData()
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
         Integrated Security=True";
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[6].Width = 150;

                dataGridView1.Columns[0].HeaderText = "Студенческий";
                dataGridView1.Columns[1].HeaderText = "Группа";
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Имя";
                dataGridView1.Columns[4].HeaderText = "Отчество";
                dataGridView1.Columns[5].HeaderText = "Адрес";
                dataGridView1.Columns[6].HeaderText = "Номер";

                string query = "SELECT Students.Id_Student, Students.Surname, Students.Name, Students.Patronymic, Students.Class, Students.Address, Students.Number FROM Students";
                SqlCommand command = new SqlCommand(query, myConnection);

                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();


                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
            dataGridView2.ColumnCount = 8;
            dataGridView2.ColumnHeadersVisible = true;
            LoadData2();
            void LoadData2()
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
         Integrated Security=True";
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                dataGridView2.RowHeadersVisible = false;
                dataGridView2.Columns[7].Width = 150;

                dataGridView2.Columns[0].HeaderText = "Id";
                dataGridView2.Columns[1].HeaderText = "Id студента";
                dataGridView2.Columns[2].HeaderText = "Родственная связь";
                dataGridView2.Columns[3].HeaderText = "Фамилия";
                dataGridView2.Columns[4].HeaderText = "Имя";
                dataGridView2.Columns[5].HeaderText = "Отчество";
                dataGridView2.Columns[6].HeaderText = "Адрес";
                dataGridView2.Columns[7].HeaderText = "Номер";

                string query = "SELECT Parents.Id_Parent, Parents.Id_Student, Parents.Family_Relationship, Parents.Surname, Parents.Name, Parents.Patronymic, Parents.Address, Parents.Number FROM Parents";
                SqlCommand command = new SqlCommand(query, myConnection);

                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                myConnection.Close();
                myConnection.Dispose();

                foreach (string[] s in data)
                    dataGridView2.Rows.Add(s);
            }

        }

        private void базаЛичныхДелСтудентовBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void база_личных_дел_студентовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        public void Form2_Load(object sender, EventArgs e)
        {
            Conn(dataGridView1,dataGridView2);

        }

        private void база_личных_дел_студентовBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void база_личных_дел_студентовBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void база_личных_дел_студентовBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void база_личных_дел_студентовBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void база_личных_дел_студентовBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void база_личных_дел_студентовBindingNavigatorSaveItem_Click_5(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void база_личных_дел_студентовBindingNavigatorSaveItem_Click_6(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void база_личных_дел_студентовBindingNavigatorSaveItem_Click_7(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void база_личных_дел_студентовBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void база_личных_дел_студентовBindingNavigatorSaveItem_Click_8(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_parent.Stop();

        }

        private void база_личных_дел_студентовDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void база_личных_дел_студентовBindingNavigatorSaveItem_Click_9(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void база_дел_студентовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void база_дел_студентовBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void база_дел_студентовBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void база_дел_студентовBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
         Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand("INSERT INTO [Students] (Id_Student, Surname, Name, Patronymic, Class, Address, Number) VALUES (@Id_Student, @Surname, @Name, @Patronymic, @Class, @Address, @Number)", myConnection);


            command1.Parameters.AddWithValue("Id_Student", textBox2.Text);
            command1.Parameters.AddWithValue("Surname", textBox3.Text);
            command1.Parameters.AddWithValue("Name", textBox4.Text);
            command1.Parameters.AddWithValue("Patronymic", textBox7.Text);
            command1.Parameters.AddWithValue("Class", textBox6.Text);
            command1.Parameters.AddWithValue("Address", textBox5.Text);
            command1.Parameters.AddWithValue("Number", textBox8.Text);
            myConnection.Open();

            try
            {
                command1.ExecuteNonQuery();
                MessageBox.Show("Данные внесены!");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox8.Text = "";

            }
            catch
            {
                MessageBox.Show("Ошибка, проверьте данные!");
            }
            finally
            {
                myConnection.Close();
                myConnection.Dispose();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
         Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            if (radioButton1.Checked)
            {
                SqlCommand command1 = new SqlCommand("DELETE FROM [Students] WHERE Id_Student=@Id_Student", myConnection);

                command1.Parameters.AddWithValue("Id_Student",textBox1.Text);
                try
                {
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    textBox1.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ошибка, проверьте данные!");
                }
                finally
                {
                    myConnection.Close();
                    myConnection.Dispose();
                }
            }
            if (radioButton2.Checked)
            {
                SqlCommand command1 = new SqlCommand("DELETE FROM [Parents] WHERE Id_Parent=@Id_Parent", myConnection);

                command1.Parameters.AddWithValue("Id_Parent", textBox1.Text);
                try
                {
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    textBox1.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ошибка, проверьте данные!");
                }
                finally
                {
                    myConnection.Close();
                    myConnection.Dispose();
                }
            }



        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].HeaderText = "";
            dataGridView1.Columns[1].HeaderText = "";
            dataGridView1.Columns[2].HeaderText = "";
            dataGridView1.Columns[3].HeaderText = "";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns[0].HeaderText = "";
            dataGridView2.Columns[1].HeaderText = "";
            dataGridView2.Columns[2].HeaderText = "";
            dataGridView2.Columns[3].HeaderText = "";
            dataGridView2.Columns[4].HeaderText = "";
            dataGridView2.Columns[5].HeaderText = "";
            dataGridView2.Columns[6].HeaderText = "";
            dataGridView2.Columns[7].HeaderText = "";
            Conn(dataGridView1, dataGridView2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
         Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand("INSERT INTO [Parents] (Id_Parent, Id_Student, Family_Relationship, Surname, Name, Patronymic, Address, Number) VALUES (@Id_Parent, @Id_Student, @Family_Relationship, @Surname, @Name, @Patronymic, @Address, @Number)", myConnection);

            command1.Parameters.AddWithValue("Id_Parent", textBox15.Text);
            command1.Parameters.AddWithValue("Id_Student", textBox11.Text);
            command1.Parameters.AddWithValue("Family_Relationship", textBox18.Text);
            command1.Parameters.AddWithValue("Surname", textBox14.Text);
            command1.Parameters.AddWithValue("Name", textBox13.Text);
            command1.Parameters.AddWithValue("Patronymic", textBox12.Text);
            command1.Parameters.AddWithValue("Address", textBox10.Text);
            command1.Parameters.AddWithValue("Number", textBox9.Text);
            myConnection.Open();

            try
            {
                command1.ExecuteNonQuery();
                MessageBox.Show("Данные внесены!");
                textBox15.Text = "";
                textBox11.Text = "";
                textBox18.Text = "";
                textBox14.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";
                textBox10.Text = "";
                textBox9.Text = "";
            }
            catch
            {
                MessageBox.Show("Ошибка, прверьте данные!");
            }
            finally
            {
                myConnection.Close();
                myConnection.Dispose();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
