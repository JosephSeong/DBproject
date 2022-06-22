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
    public partial class Center : Form
    {
        string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
        public Center()
        {
            InitializeComponent();
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
                        ("insert into 센터(센터명,위치,전화번호) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +  "')", conn);
                    int result = msc.ExecuteNonQuery();


                    if (result == 1)
                    {
                        MessageBox.Show("센터 등록 되었습니다!");
                    }
                }
            }
        }
    }
}
