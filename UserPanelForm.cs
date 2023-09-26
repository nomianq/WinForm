using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class UserPanelForm : Form
    {       
        public bool isBtnClick = false; // переменная для отслеживания кнопки
        public UserPanelForm()
        {
            InitializeComponent();
            UserEmailField.Text = "Введите новый email";
            UserPasswordField.Text = "Введите новый пароль";
        }
        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "Введите новый email")
            {
                UserEmailField.Text = "";
            }
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Введите новый пароль")
            {
                UserPasswordField.Text = "";
                UserPasswordField.UseSystemPasswordChar = true;
            }
        }
        public void TextBox_Leave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "")
            {
                UserEmailField.Text = "Введите новый email";
            }
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите новый пароль";
                UserPasswordField.UseSystemPasswordChar = false;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(isBtnClick) // если кнопка нажата во второй раз
            {
                this.Hide();
                AuthForm authForm = new AuthForm();
                authForm.ShowDialog();
                this.Close();
            }
            else // если кнопка нажата первый раз
            {
                if (UserEmailField.Text.Trim() == "" || UserEmailField.Text.Trim() == "Введите новый email")
                {
                    MessageBox.Show("Вы не ввели email");
                    return;
                }
                if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Введите новый пароль")
                {
                    MessageBox.Show("Вы не ввели пароль");
                    return;
                }
                DB db = new DB();
                MySqlCommand command = new MySqlCommand(
                    "UPDATE users SET email = @email, password = @password WHERE login = 'admin'",
                    db.GetConnection()
                );
                command.Parameters.AddWithValue("email", UserEmailField.Text);
                command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));

                db.OpenConnection();
                try
                {
                    command.ExecuteScalar();
                    UserEmailField.Text = "";
                    UserEmailField.Enabled = false;
                    UserPasswordField.Text = "";
                    UserPasswordField.Enabled = false;
                    EditButton.Text = "Готово";
                    MessageBox.Show("Данные изменены");                   
                    isBtnClick = true;
                } catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
                db.CloseConnection();
            }
        }

        private string Hash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = PanelLabel;
        }
    }
}
