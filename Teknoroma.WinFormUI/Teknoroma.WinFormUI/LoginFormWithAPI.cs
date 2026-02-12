using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teknoroma.WebApi.Models;

namespace Teknoroma.WinFormUI
{
    public partial class LoginFormWithAPI : Form
    {
        public LoginFormWithAPI()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var request = new
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
            };

            string json = JsonSerializer.Serialize(request);

            using HttpClient client = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("http://localhost:5112/api/auth/login", content);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"API HATASI: {response.StatusCode}" );
            }

            string responseJson = await response.Content.ReadAsStringAsync();

            LoginResponse result = JsonSerializer.Deserialize<LoginResponse>(responseJson);

            if (result.IsSuccess)
            {
                MessageBox.Show("Hoşgeldiniz " + result.UserName);

                CategoryForm cForm = new CategoryForm();
                cForm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
