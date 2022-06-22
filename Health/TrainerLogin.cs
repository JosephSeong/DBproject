using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Health
{
    public partial class TrainerLogin : Form
    {
        string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
        public TrainerLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
            if (textBox1.Text == "")
            {
                MySqlConnection conDataBase = new MySqlConnection(Conn);
                MySqlCommand cmdDataBase = new MySqlCommand("select * from 트레이너스케줄;", conDataBase);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
            if (textBox1.Text == "")
            {
                MySqlConnection conDataBase = new MySqlConnection(Conn);
                MySqlCommand cmdDataBase = new MySqlCommand("select * from 스케줄;", conDataBase);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
