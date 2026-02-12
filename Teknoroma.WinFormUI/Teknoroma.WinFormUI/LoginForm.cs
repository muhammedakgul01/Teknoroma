using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teknoroma.BLL.DesignPatterns.GenericRepository.ConcRep;
using Teknoroma.Entities;

namespace Teknoroma.WinFormUI
{
    public partial class LoginForm : Form
    {
        UserRepository _userRepo;
        public LoginForm()
        {
            InitializeComponent();
            _userRepo = new UserRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre zorunludur!!!");
                return;
            }

            try
            {
                User user = _userRepo.Login(userName, password);

                if (user == null)
                {
                    MessageBox.Show("Kullanıcı adı ve şifre hatalı!!!");
                    return;
                }

                MessageBox.Show($"Hoş geldin {user.UserName}");

                CategoryForm categoryForm = new CategoryForm();
                this.Hide();
                categoryForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
