using System.Data;
using System.Data.SqlClient;

namespace Authorization
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            var login = loginTxt.Text.Trim();
            var password = paswordTxt.Text.Trim();
            if (IsExists(login))
            {
                MessageBox.Show("Такой логин уже существует!");
                return;
            }
            var query = $"insert into RegistrationTable values ('{login}', '{password}')";
            var command = new SqlCommand(query, UsersDataBase.GetConnection());
            UsersDataBase.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан");
                this.Hide();
                new SignIn().Show();
            }
            else
                MessageBox.Show("Ошибка!");
            UsersDataBase.CloseConnection();
        }

        private bool IsExists(string login)
        {
            var adapter = new SqlDataAdapter();
            var table = new DataTable();
            var query = $"select userId, userLog, userPswrd from RegistrationTable where userLog = '{login}'";
            var command = new SqlCommand(query, UsersDataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }
    }
}