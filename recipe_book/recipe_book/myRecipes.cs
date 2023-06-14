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
    public partial class myRec : Form
    {
        public myRec()
        {
            InitializeComponent();
            loadData();
            
        }

        private void loadData()
        {
            string sql = "SELECT `ID`, `Name`, `Ingredients`, `Tags`  FROM `recipes` WHERE 1";
            DB db = new DB();
            db.openConnection();
            MySqlCommand cmd = new MySqlCommand(sql, db.getConnection());
            using(MySqlDataAdapter adapter =  new MySqlDataAdapter(cmd)) {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            db.closeConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Name"].Index && e.RowIndex >= 0)
            {

                int recipeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                RecipeDetailsForm detailsForm = new RecipeDetailsForm(recipeID);
                detailsForm.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Name"].Index && e.RowIndex >= 0)
            {

                int recipeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                RecipeDetailsForm detailsForm = new RecipeDetailsForm(recipeID);
                detailsForm.Show();
                this.Hide();
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
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
    }
}
