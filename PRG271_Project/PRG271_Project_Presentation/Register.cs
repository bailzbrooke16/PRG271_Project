using PRG271_Project_Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG271_Project_Presentation
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Dispose();
            l.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = mtxt_password.Text;
            string confirmPassword = mtxt_confirm_password.Text;
            SystemService sysService = new SystemService();

            //check if any of the fields are empty
            if (username == "")
            {
                lbl_error.Text = "Username is empty";
            }
            else if (password == "")
            {
                lbl_error.Text = "Password is empty";
            }
            else if (confirmPassword == "")
            {
                lbl_error.Text = "Confirm password is empty";
            }
            else
            {
                if (password == confirmPassword)
                {
                    try
                    {
                        Boolean result = sysService.Register(username, password);
                        if (result)
                        {
                            Login l = new Login();
                            this.Dispose();
                            l.Show();
                        }
                        else
                        {
                            lbl_error.Text = "There was an error registering a new user";
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        lbl_error.Text = ex.Message;
                    }
                }
                else
                {
                    lbl_error.Text = "The passwords do not match";
                }

            }
        }
    }
}
