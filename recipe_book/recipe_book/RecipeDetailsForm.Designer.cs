namespace recipe_book
{
    partial class RecipeDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ingredientsField = new System.Windows.Forms.TextBox();
            this.ingredients = new System.Windows.Forms.Label();
            this.recipeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tagsField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(27, 522);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description.Size = new System.Drawing.Size(554, 238);
            this.description.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Pink;
            this.label3.Location = new System.Drawing.Point(23, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // ingredientsField
            // 
            this.ingredientsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsField.Location = new System.Drawing.Point(27, 416);
            this.ingredientsField.Multiline = true;
            this.ingredientsField.Name = "ingredientsField";
            this.ingredientsField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ingredientsField.Size = new System.Drawing.Size(554, 78);
            this.ingredientsField.TabIndex = 10;
            // 
            // ingredients
            // 
            this.ingredients.AutoSize = true;
            this.ingredients.BackColor = System.Drawing.Color.Transparent;
            this.ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredients.ForeColor = System.Drawing.Color.Pink;
            this.ingredients.Location = new System.Drawing.Point(25, 391);
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(109, 22);
            this.ingredients.TabIndex = 9;
            this.ingredients.Text = "Ingredients";
            // 
            // recipeName
            // 
            this.recipeName.AllowDrop = true;
            this.recipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeName.Location = new System.Drawing.Point(27, 264);
            this.recipeName.Multiline = true;
            this.recipeName.Name = "recipeName";
            this.recipeName.ReadOnly = true;
            this.recipeName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.recipeName.Size = new System.Drawing.Size(364, 48);
            this.recipeName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(23, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // tagsField
            // 
            this.tagsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsField.Location = new System.Drawing.Point(29, 340);
            this.tagsField.Multiline = true;
            this.tagsField.Name = "tagsField";
            this.tagsField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tagsField.Size = new System.Drawing.Size(364, 48);
            this.tagsField.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(25, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tags";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(198, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonClose.Location = new System.Drawing.Point(571, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 29);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "x";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SandyBrown;
            this.label4.Location = new System.Drawing.Point(532, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "_";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // RecipeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::recipe_book.Properties.Resources._4d23179424b2fbe00524fdc7d7c5575d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 793);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tagsField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingredientsField);
            this.Controls.Add(this.ingredients);
            this.Controls.Add(this.recipeName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecipeDetailsForm";
            this.Text = "RecipeDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ingredientsField;
        private System.Windows.Forms.Label ingredients;
        private System.Windows.Forms.TextBox recipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tagsField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}