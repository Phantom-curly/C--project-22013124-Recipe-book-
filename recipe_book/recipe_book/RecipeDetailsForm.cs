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
    public partial class RecipeDetailsForm : Form
    {
        
        private int recipeID;
        public RecipeDetailsForm(int id)
        {
            InitializeComponent();
            recipeID = id;

            LoadRecipeDetails();
        }

        
        private void LoadRecipeDetails()
        {
            string query = "SELECT `Name`, `Ingredients`, `Tags`, `Description`, `Image` FROM `recipes` WHERE `ID` = @recipeID";
            DB db = new DB();
            MessageBox.Show("pepep");
            using (MySqlConnection connection = db.getConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@recipeID", recipeID);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string recipename = reader.GetString(0);
                            recipeName.Text = recipename;
                            ingredientsField.Text = reader.GetString(1);
                            description.Text = reader.GetString(3);
                            tagsField.Text = reader.GetString(2);

                            if (!reader.IsDBNull(4))
                            {
                                byte[] imageData = (byte[])reader["Image"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    pictureBox1.Image = Image.FromStream(ms);
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Recipe not found!");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message);
                }
                finally { connection.Close(); } 
            }
        }
        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
            buttonClose.BackColor = Color.Red;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
