using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teknoroma.BLL.DesignPatterns.GenericRepository.ConcRep;

namespace Teknoroma.WinFormUI
{
    public partial class UserCreateForm : Form
    {
        EmployeeRepository _employeeRepo;
        UserRepository _userRepo;
        public UserCreateForm()
        {
            InitializeComponent();

            _employeeRepo = new EmployeeRepository();
            _userRepo = new UserRepository();
        }

        private void UserCreateForm_Load(object sender, EventArgs e)
        {
            LoadEmployeesWithoutUser();
            LoadUsers();
        }

        void LoadEmployeesWithoutUser()
        {
            var employees = _employeeRepo.GetAll();
            var users = _userRepo.GetAll();

            var result = employees
                .Where(e => !users.Any(u => u.EmployeeID == e.ID))
                .Select(e => new
                {
                    e.ID,
                    FullName = e.FirstName + " " + e.LastName
                })
                .ToList();

            cmbEmployees.DataSource = result;
            cmbEmployees.DisplayMember = "FullName";
            cmbEmployees.ValueMember = "ID";
        }

        void LoadUsers()
        {
            lstUsers.DataSource = _userRepo.GetAll();
            lstUsers.DisplayMember = "UserName";
            lstUsers.ValueMember = "ID";
        }

        void ClearInputs() 
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir çalışan seçiniz");
                return;
            }

            else if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılmaz");
                return;
            }

            int employeeId = (int)cmbEmployees.SelectedValue;

            try
            {
                _userRepo.CreatedUser(employeeId, txtUserName.Text, txtPassword.Text);

                MessageBox.Show("Kullanıcı Oluşturuldu");

                LoadEmployeesWithoutUser();
                LoadUsers();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
