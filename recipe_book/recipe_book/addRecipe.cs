using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_book
{
    public partial class addRecipe : Form
    {
        public addRecipe()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void addButton_MouseHover(object sender, EventArgs e)
        {
            addButton.BackColor = Color.Green;
        }
        public string Tags;
        private void addButton_Click(object sender, EventArgs e)
        {
            addButton.BackColor = Color.Green;
            addButton.ForeColor = Color.White;
            if (recipeName.Text == "")
            {
                MessageBox.Show("Enter recipe name!!!");
                return;
            }
            if (ingredientsField.Text == "")
            {
                MessageBox.Show("Enter your ingredients!!!");
                return;
            }
            if (description.Text == "")
            {
                MessageBox.Show("Enter the description!!!");
                return;
            }
            byte[] imageBytes;

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `recipes` (`ID`, `Name`, `Ingredients`, `Description`, `Tags`, `Image`) VALUES (NULL, @name, @ingr, @description, @tags, @image);", db.getConnection());
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = recipeName.Text;
            cmd.Parameters.Add("@ingr", MySqlDbType.VarChar).Value = ingredientsField.Text;
            cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = description.Text;
            cmd.Parameters.Add("@tags", MySqlDbType.VarChar).Value = tagsField.Text;
            cmd.Parameters.Add("@image", MySqlDbType.VarChar).Value = imageBytes;

            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Recipe added!");
            else
                MessageBox.Show("Something went wrong...");
            db.closeConnection();

        }

        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.BackColor = Color.Transparent;
        }

        private void choosePic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            buttonClose.BackColor = Color.Red;
        }

        private void buttonClose_MouseHover(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Red;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Transparent;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           homePage homePage = new homePage();  
            homePage.Show();
            this.Hide();

        }

        private void addRecipe_MouseDown(object sender, MouseEventArgs e)
        {
            movingPoint = new Point(e.X, e.Y);
           
        }
        Point movingPoint;
        private void addRecipe_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - movingPoint.X;
                this.Top += e.Y - movingPoint.Y;
            }

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
