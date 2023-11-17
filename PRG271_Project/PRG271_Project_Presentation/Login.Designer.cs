namespace PRG271_Project_Presentation
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            mtxt_password = new MaskedTextBox();
            btn_login = new Button();
            label3 = new Label();
            lbl_error = new Label();
            btn_register = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(276, 163);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(200, 39);
            txt_username.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 112);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 222);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // mtxt_password
            // 
            mtxt_password.Location = new Point(276, 266);
            mtxt_password.Name = "mtxt_password";
            mtxt_password.PasswordChar = '*';
            mtxt_password.Size = new Size(200, 39);
            mtxt_password.TabIndex = 3;
            mtxt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(214, 332);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(140, 50);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(78, 21);
            label3.Name = "label3";
            label3.Size = new Size(621, 62);
            label3.TabIndex = 5;
            label3.Text = "Student Manager Application";
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(87, 397);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 32);
            lbl_error.TabIndex = 6;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_register.Location = new Point(397, 332);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(140, 50);
            btn_register.TabIndex = 7;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_register);
            Controls.Add(lbl_error);
            Controls.Add(label3);
            Controls.Add(btn_login);
            Controls.Add(mtxt_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private Label label1;
        private Label label2;
        private MaskedTextBox mtxt_password;
        private Button btn_login;
        private Label label3;
        private Label lbl_error;
        private Button btn_register;
    }
}