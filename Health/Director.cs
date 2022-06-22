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
    public partial class Director : Form
    {
        public bool test = false;
        TextBox[] txtList;
        const string IdPlaceholder = "20회 이상만 등록 가능";

        string Conn = "Server=localhost;Database=Health;Uid=root;Pwd=1234;";
        public Director()
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
            if (textBox1.Text == "" || count.Text == "")
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
                        ("insert into 관장(관장명,입상횟수,전화번호) values('" + textBox1.Text + "','" + count.Text + "','" + textBox3.Text + "')", conn);
                    int result = msc.ExecuteNonQuery();


                    if (result == 1)
                    {
                        MessageBox.Show("관장 등록 되었습니다!");
                    }
                }
            }
        }
    }
}
