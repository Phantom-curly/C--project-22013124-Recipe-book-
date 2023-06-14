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
    public partial class mainPage : Form
    {

        public mainPage()
        {
            InitializeComponent();
            //regulating the size of password Field
            this.passwordField.Size = new Size(this.passwordField.Size.Width, 36);
            this.passwordField.AutoSize = false;
            this.usernameField.AutoSize = false;

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseClick(object sender, MouseEventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Transparent;
        }

        private void minimizeButton_MouseHover(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.Beige;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.Transparent;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point movingPoint;
        //method to move the window
        private void mainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - movingPoint.X;
                this.Top += e.Y - movingPoint.Y;
            }
        }

        private void mainPage_MouseDown(object sender, MouseEventArgs e)
        {
            movingPoint = new Point(e.X, e.Y);
        }
        //database connection
        private void activateButton()
        {
            string loginUser = usernameField.Text;
            string loginPass = passwordField.Text;
            DB database = new DB();
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@lU AND `password`=@lP", database.getConnection());
            command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@lP", MySqlDbType.VarChar).Value = loginPass;
            adapter.SelectCommand = command;
            adapter.Fill(table1);
            if (table1.Rows.Count > 0)
            {
                MessageBox.Show("Login successful!");
                homePage homePage = new homePage();
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
            
        }

        private void loginButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                activateButton();
                
            }
        }

        private void mainPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                activateButton();
            }
        }

        private void mainPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                activateButton();
            }
        }

        private void passwordField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                activateButton();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationPage register = new registrationPage();
            register.Show();
        }
    }
}
