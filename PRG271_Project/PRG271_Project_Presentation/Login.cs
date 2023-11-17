using PRG271_Project_Services;

namespace PRG271_Project_Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = txt_username.Text;
            string password = mtxt_password.Text;
            SystemService systemService = new SystemService();

            //check if any of the fields are empty
            if (username == "")
            {
                lbl_error.Text = "Username is empty";
            }
            else if (password == "")
            {
                lbl_error.Text = "Password is empty";
            }
            else
            {
                try
                {
                    Boolean result = systemService.Login(username, password);
                    if (result)
                    {
                        MainForm mf = new MainForm();
                        mf.Show();
                        this.Hide();
                    }
                    else
                    {
                        lbl_error.Text = "There was an error with your username or password";
                    }
                }
                catch(Exception ex)
                {
                    lbl_error.Text = ex.Message;
                }
            }



        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }
    }
}