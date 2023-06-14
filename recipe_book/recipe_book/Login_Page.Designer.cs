namespace recipe_book
{
    partial class mainPage
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
            this.closeButton = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(457, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 29);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "x";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseClick);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(418, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(33, 29);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = " _";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.minimizeButton.MouseHover += new System.EventHandler(this.minimizeButton_MouseHover);
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(123, 232);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(252, 41);
            this.usernameField.TabIndex = 2;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(123, 324);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(252, 41);
            this.passwordField.TabIndex = 3;
            this.passwordField.UseSystemPasswordChar = true;
            this.passwordField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordField_KeyDown);
            // 
            // login_text
            // 
            this.login_text.AutoSize = true;
            this.login_text.BackColor = System.Drawing.Color.Transparent;
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_text.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.login_text.Location = new System.Drawing.Point(117, 197);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(144, 32);
            this.login_text.TabIndex = 4;
            this.login_text.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(117, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.Info;
            this.loginButton.Location = new System.Drawing.Point(153, 402);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(192, 54);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Authorization";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loginButton_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(196, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(108, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Do not have an account yet?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::recipe_book.Properties.Resources.login_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 655);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainPage";
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainPage_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainPage_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label login_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

