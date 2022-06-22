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
    public partial class Trainer : Form
    {
        public bool test = false;
        TextBox[] txtList;
        const string IdPlaceholder = "5회 이상만 등록 가능";

        string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
        public Trainer()
        {
            InitializeComponent();
            //입상 횟수 TextBox Placeholder 설정
            txtList = new TextBox[] { count };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == count) txt.Text = IdPlaceholder;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                        ("insert into 트레이너(트레이너닉네임,트레이너명,입상횟수,근무중인센터) values('" + textBox1.Text + "','" + textBox2.Text + "','" + count.Text + "','" + textBox4.Text + "')", conn);
                    int result = msc.ExecuteNonQuery();


                    if (result == 1)
                    {
                        MessageBox.Show("트레이너 등록 되었습니다!");
                    }
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
            MySqlConnection conDataBase = new MySqlConnection(Conn);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from 센터;", conDataBase);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
