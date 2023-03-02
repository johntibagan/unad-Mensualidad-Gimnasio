namespace Gimnasio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            btn_login.Cursor = Cursors.Hand;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String password = txt_password.Text;
            if(password == "123")
            {
                GimnasioRobles gimnasioRobles = new GimnasioRobles();
                gimnasioRobles.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña no valida");
            }
        }

       
    }
}