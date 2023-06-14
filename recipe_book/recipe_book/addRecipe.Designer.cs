namespace recipe_book
{
    partial class addRecipe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeName = new System.Windows.Forms.TextBox();
            this.ingredientsField = new System.Windows.Forms.TextBox();
            this.ingredients = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tag = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.choosePic = new System.Windows.Forms.Button();
            this.tagsField = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Recipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // recipeName
            // 
            this.recipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeName.Location = new System.Drawing.Point(12, 76);
            this.recipeName.Multiline = true;
            this.recipeName.Name = "recipeName";
            this.recipeName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.recipeName.Size = new System.Drawing.Size(364, 48);
            this.recipeName.TabIndex = 2;
            // 
            // ingredientsField
            // 
            this.ingredientsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsField.Location = new System.Drawing.Point(12, 152);
            this.ingredientsField.Multiline = true;
            this.ingredientsField.Name = "ingredientsField";
            this.ingredientsField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ingredientsField.Size = new System.Drawing.Size(364, 78);
            this.ingredientsField.TabIndex = 4;
            this.ingredientsField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ingredients
            // 
            this.ingredients.AutoSize = true;
            this.ingredients.BackColor = System.Drawing.Color.Transparent;
            this.ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredients.ForeColor = System.Drawing.Color.DarkOrange;
            this.ingredients.Location = new System.Drawing.Point(12, 127);
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(109, 22);
            this.ingredients.TabIndex = 3;
            this.ingredients.Text = "Ingredients";
            this.ingredients.Click += new System.EventHandler(this.label3_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(12, 275);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description.Size = new System.Drawing.Size(364, 238);
            this.description.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // Tag
            // 
            this.Tag.AutoSize = true;
            this.Tag.BackColor = System.Drawing.Color.Transparent;
            this.Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag.ForeColor = System.Drawing.Color.DarkOrange;
            this.Tag.Location = new System.Drawing.Point(545, 51);
            this.Tag.Name = "Tag";
            this.Tag.Size = new System.Drawing.Size(55, 22);
            this.Tag.TabIndex = 7;
            this.Tag.Text = "Tags";
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.addButton.Location = new System.Drawing.Point(379, 539);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(170, 44);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add recipe";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.MouseLeave += new System.EventHandler(this.addButton_MouseLeave);
            this.addButton.MouseHover += new System.EventHandler(this.addButton_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(549, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(545, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Add a picture";
            // 
            // choosePic
            // 
            this.choosePic.AutoSize = true;
            this.choosePic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.choosePic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.choosePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choosePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePic.Location = new System.Drawing.Point(549, 485);
            this.choosePic.Name = "choosePic";
            this.choosePic.Size = new System.Drawing.Size(85, 28);
            this.choosePic.TabIndex = 16;
            this.choosePic.Text = "Choose";
            this.choosePic.UseVisualStyleBackColor = false;
            this.choosePic.Click += new System.EventHandler(this.choosePic_Click);
            // 
            // tagsField
            // 
            this.tagsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsField.Location = new System.Drawing.Point(549, 76);
            this.tagsField.Multiline = true;
            this.tagsField.Name = "tagsField";
            this.tagsField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagsField.Size = new System.Drawing.Size(283, 78);
            this.tagsField.TabIndex = 17;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonClose.Location = new System.Drawing.Point(888, -2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 29);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "x";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseHover += new System.EventHandler(this.buttonClose_MouseHover);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonMinimize.Location = new System.Drawing.Point(849, -2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(33, 29);
            this.buttonMinimize.TabIndex = 19;
            this.buttonMinimize.Text = " _";
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.backButton.Location = new System.Drawing.Point(8, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 22);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::recipe_book.Properties.Resources._48e6e1c8d1511b1a017fb41104445ec4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 617);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tagsField);
            this.Controls.Add(this.choosePic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Tag);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingredientsField);
            this.Controls.Add(this.ingredients);
            this.Controls.Add(this.recipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addRecipe";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addRecipe_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addRecipe_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recipeName;
        private System.Windows.Forms.TextBox ingredientsField;
        private System.Windows.Forms.Label ingredients;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Tag;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button choosePic;
        private System.Windows.Forms.TextBox tagsField;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.Label buttonMinimize;
        private System.Windows.Forms.Label backButton;
    }
}