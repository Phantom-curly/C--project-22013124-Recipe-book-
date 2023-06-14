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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            buttonClose.BackColor = Color.Red;
        }

        private void homePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - movingPoint.X;
                this.Top += e.Y - movingPoint.Y;
            }
        }
        Point movingPoint;
        private void homePage_MouseDown(object sender, MouseEventArgs e)
        {
            movingPoint = new Point(e.X, e.Y);
        }

        private void buttonClose_MouseHover(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Red;
        }

       

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Transparent;
        }

        private void addRecipe_Click(object sender, EventArgs e)
        {
            addRecipe add = new addRecipe();
            add.Show();
            this.Hide();
        }

        private void myRecipes_Click(object sender, EventArgs e)
        {
            myRec myRec = new myRec();      
            myRec.Show();
            this.Hide();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
