using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{ 
    public partial class SignIn : Form
    {
        private UsersDataBase _users = new UsersDataBase();
        public SignIn()
        {
            InitializeComponent();
        }

        private void signInLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            var loginText = loginTextBox.Text;
            var password = pswTextBox.Text;
            var adapter = new SqlDataAdapter();
            var table = new DataTable();
            var query = $"select userId, userLog, userPswrd from RegistrationTable where userLog = '{loginText}' and userPswrd = '{password}'";
            var command = new SqlCommand(query, _users.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
