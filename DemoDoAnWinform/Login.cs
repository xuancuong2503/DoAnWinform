using DemoDoAnWinform.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoDoAnWinform.DAO;

namespace DemoDoAnWinform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTaiKhoan.Text;
            string passWord = txtMatKhau.Text;
            if (login(userName,passWord))
            { 
            Manager f = new Manager();
            this.Hide();
            f.ShowDialog();
            this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }
        bool login(string userName,string passWord)
        {
            return AccountDAO.Instance.Login(userName,passWord);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có Thật Sự Muốn Thoát", "Thông Báo" , MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
