using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstForm Login = new FirstForm();
            Login.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberLogin FirstForm = new MemberLogin();
            FirstForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrainerLogin FirstForm = new TrainerLogin();
            FirstForm.Show();
        }
    }
}
