namespace PRG271_Project_Presentation
{
    partial class Register
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
            btn_register = new Button();
            mtxt_password = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            txt_username = new TextBox();
            btn_cancel = new Button();
            label3 = new Label();
            lbl_error = new Label();
            mtxt_confirm_password = new MaskedTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_register
            // 
            btn_register.Location = new Point(310, 477);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(140, 50);
            btn_register.TabIndex = 9;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // mtxt_password
            // 
            mtxt_password.Location = new Point(373, 310);
            mtxt_password.Name = "mtxt_password";
            mtxt_password.PasswordChar = '*';
            mtxt_password.Size = new Size(200, 39);
            mtxt_password.TabIndex = 8;
            mtxt_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 266);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 156);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(373, 207);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(200, 39);
            txt_username.TabIndex = 5;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(476, 477);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(140, 50);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(175, 68);
            label3.Name = "label3";
            label3.Size = new Size(621, 62);
            label3.TabIndex = 11;
            label3.Text = "Student Manager Application";
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(91, 543);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 32);
            lbl_error.TabIndex = 12;
            // 
            // mtxt_confirm_password
            // 
            mtxt_confirm_password.Location = new Point(373, 416);
            mtxt_confirm_password.Name = "mtxt_confirm_password";
            mtxt_confirm_password.PasswordChar = '*';
            mtxt_confirm_password.Size = new Size(200, 39);
            mtxt_confirm_password.TabIndex = 14;
            mtxt_confirm_password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 372);
            label4.Name = "label4";
            label4.Size = new Size(204, 32);
            label4.TabIndex = 13;
            label4.Text = "Confirm Password";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 584);
            Controls.Add(mtxt_confirm_password);
            Controls.Add(label4);
            Controls.Add(lbl_error);
            Controls.Add(label3);
            Controls.Add(btn_cancel);
            Controls.Add(btn_register);
            Controls.Add(mtxt_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_register;
        private MaskedTextBox mtxt_password;
        private Label label2;
        private Label label1;
        private TextBox txt_username;
        private Button btn_cancel;
        private Label label3;
        private Label lbl_error;
        private MaskedTextBox mtxt_confirm_password;
        private Label label4;
    }
}