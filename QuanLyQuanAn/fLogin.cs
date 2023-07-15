using QuanLyQuanAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{

    public partial class fLogin : Form
    {
        public string username = "";
        public fLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (login(username,password))
            {
                fTableManager f = new fTableManager(username);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!","Fail",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool login(string userName,string passWord)
            {
                return AccountDAO.Instance.Login(userName,passWord);
            }
        }
    }
}
