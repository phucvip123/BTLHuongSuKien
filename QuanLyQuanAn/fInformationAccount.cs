using QuanLyQuanAn.DAO;
using QuanLyQuanAn.DTO;
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
    public partial class fInformationAccount : Form
    {

        Account accountLogin = null;
        public fInformationAccount(string username)
        {
            InitializeComponent();
            accountLogin = AccountDAO.Instance.GetAccountByUserName(username);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fInformationAccount_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = accountLogin.Username;
            textBoxDisplayname.Text = accountLogin.Displayname;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text.ToString() == accountLogin.Password && textBoxNewPassword.Text.ToString() == textBoxConfirm.Text.ToString()) {
                AccountDAO.Instance.UpdateAccount(accountLogin,textBoxNewPassword.Text.ToString());
                if (MessageBox.Show("Thay đổi thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("Mật khẩu không chính xác hoặc mật khẩu mới và mật khẩu xác nhận không trùng khớp nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
