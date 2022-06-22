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
    public partial class MemberLogin : Form
    {
        string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
        public MemberLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
            if (textBox1.Text == "")
            {
                MySqlConnection conDataBase = new MySqlConnection(Conn);
                MySqlCommand cmdDataBase = new MySqlCommand("select * from 회원스케줄;", conDataBase);

                try
                {       
                    //데이터 불러오기
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

        private void button3_Click(object sender, EventArgs e)
        {
            string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
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
                dataGridView3.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("내용을 입력해주세요!");
            }
            else
            {
                //DB에 데이터 삽입
                using (MySqlConnection conn = new MySqlConnection(Conn))
                {
                    conn.Open();
                    MySqlCommand msc = new MySqlCommand
                        ("insert into 스케줄(스케줄명,요일,시간) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", conn);
                    int result = msc.ExecuteNonQuery();


                    if (result == 1)
                    {
                        MessageBox.Show("스케줄이 추가 되었습니다!");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
            MySqlConnection conDataBase = new MySqlConnection(Conn);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from 이용권;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView2.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
