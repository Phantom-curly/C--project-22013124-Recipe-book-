using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_book
{
    public partial class registrationPage : Form
    {
        public registrationPage()
        {
            InitializeComponent();

            nameField.Text = "Enter your name";
            nameField.ForeColor = Color.Gray;
            lastNameField.Text = "Enter your last name";
            lastNameField.ForeColor = Color.Gray;
            usernameField.Text = "Create a username";
            usernameField.ForeColor = Color.Gray;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClose_MouseHover(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Red;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Transparent;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMinimize_MouseHover(object sender, EventArgs e)
        {
            buttonMinimize.BackColor = Color.Beige;
        }

        private void buttonMinimize_MouseLeave(object sender, EventArgs e)
        {
            buttonMinimize.BackColor = Color.Transparent;
        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if(nameField.Text == "Enter your name"){
                nameField.Text = "";
                nameField.ForeColor = Color.Black;
            }
        }

        private void lastNameField_Enter(object sender, EventArgs e)
        {
            if(lastNameField.Text == "Enter your last name"){
                lastNameField.Text = "";
                lastNameField.ForeColor = Color.Black;
            }
            
               
        }

        private void usernameField_Enter(object sender, EventArgs e)
        {
            if(usernameField.Text == "Create a username")
            {
                usernameField.Text = "";
                usernameField.ForeColor = Color.Black;
            }   
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if(passwordField.Text == "Create a password")
            {
                passwordField.Text = "";
            }   
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                nameField.Text = "Enter your name";
                nameField.ForeColor = Color.Gray;
            }
        }

        private void lastNameField_Leave(object sender, EventArgs e)
        {
            if (lastNameField.Text == "")
            {
                lastNameField.Text = "Enter your last name";
                lastNameField.ForeColor = Color.Gray;
            }
        }

        private void usernameField_Leave(object sender, EventArgs e)
        {
            if (usernameField.Text == "")
            {
                usernameField.Text = "Create a username";
                usernameField.ForeColor = Color.Gray;
            }
        }

        

        private void activateSignupButton()
        {
            if (nameField.Text == "Enter your name")
            {
                MessageBox.Show("Enter your name!!!");
                return;
            }
            if (lastNameField.Text == "Enter your last name")
            {
                MessageBox.Show("Enter your last name!!!");
                return;
            }

            if (checkUsername())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `users` (`Name`, `Surname`, `login`, `password`) VALUES (@name, @surname, @username, @password);", db.getConnection());
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            cmd.Parameters.Add("@surname", MySqlDbType.VarChar).Value = lastNameField.Text;
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = usernameField.Text;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordField.Text;

            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {   MessageBox.Show("Registration was successful");
                homePage homePage = new homePage();
                homePage.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Registration was unsuccessful");
            db.closeConnection();
            
        }
        //check if username does not already exist
        public Boolean checkUsername()
        {
            DB database = new DB();
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@lU", database.getConnection());
            command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = usernameField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table1);
            if (table1.Rows.Count > 0)
            {
                MessageBox.Show("This username is already taken, create another one");
                return true;
            }
            else
            {
               return false;
            }
        }

        private void passwordField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                activateSignupButton();
            }
        }

        private void loginButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                activateSignupButton();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage login = new mainPage();
            login.Show();
        }

        private void registrationPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - movingPoint.X;
                this.Top += e.Y - movingPoint.Y;
            }
        }

        private void registrationPage_MouseDown(object sender, MouseEventArgs e)
        {
            movingPoint = new Point(e.X, e.Y);
        }
        Point movingPoint;
    }   
}
