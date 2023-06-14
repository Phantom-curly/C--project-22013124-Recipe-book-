namespace recipe_book
{
    partial class homePage
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
            this.buttonClose = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addRecipe = new System.Windows.Forms.Button();
            this.myRecipes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClose.Location = new System.Drawing.Point(734, -2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 29);
            this.buttonClose.TabIndex = 15;
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
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMinimize.Location = new System.Drawing.Point(704, -2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(33, 29);
            this.buttonMinimize.TabIndex = 16;
            this.buttonMinimize.Text = " _";
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(250, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Recipe book";
            // 
            // addRecipe
            // 
            this.addRecipe.AutoSize = true;
            this.addRecipe.BackColor = System.Drawing.Color.Crimson;
            this.addRecipe.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.addRecipe.FlatAppearance.BorderSize = 0;
            this.addRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecipe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addRecipe.Location = new System.Drawing.Point(89, 296);
            this.addRecipe.Name = "addRecipe";
            this.addRecipe.Size = new System.Drawing.Size(248, 54);
            this.addRecipe.TabIndex = 18;
            this.addRecipe.Text = "Add recipe";
            this.addRecipe.UseVisualStyleBackColor = false;
            this.addRecipe.Click += new System.EventHandler(this.addRecipe_Click);
            // 
            // myRecipes
            // 
            this.myRecipes.AutoSize = true;
            this.myRecipes.BackColor = System.Drawing.Color.Crimson;
            this.myRecipes.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.myRecipes.FlatAppearance.BorderSize = 0;
            this.myRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myRecipes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.myRecipes.Location = new System.Drawing.Point(422, 296);
            this.myRecipes.Name = "myRecipes";
            this.myRecipes.Size = new System.Drawing.Size(248, 54);
            this.myRecipes.TabIndex = 19;
            this.myRecipes.Text = "My recipes";
            this.myRecipes.UseVisualStyleBackColor = false;
            this.myRecipes.Click += new System.EventHandler(this.myRecipes_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::recipe_book.Properties.Resources._9aeb37c9d07993c2aad00fb6ba533980__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 616);
            this.Controls.Add(this.myRecipes);
            this.Controls.Add(this.addRecipe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.homePage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.homePage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.Label buttonMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRecipe;
        private System.Windows.Forms.Button myRecipes;
    }
}