using System.Data;
using System.Data.SqlClient;

namespace Authorization
{ 
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignInLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pswTextBox.MaxLength = 10;
            this.Hide();
            new SignUp().Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            var loginText = loginTextBox.Text;
            var password = pswTextBox.Text;
            var adapter = new SqlDataAdapter();
            var table = new DataTable();
            var query = $"select userId, userLog, userPswrd from RegistrationTable where userLog = '{loginText}' and userPswrd = '{password}'";
            var command = new SqlCommand(query, UsersDataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Неправильный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
