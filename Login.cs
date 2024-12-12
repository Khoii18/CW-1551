namespace Quizzgame
{
    public partial class Login : Form
    {
        Creator form_creator = new Creator();
        public Login()
        {
            InitializeComponent();
            tb_password.PasswordChar = '*';
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "khoiimen" && tb_password.Text == "123")
            {
                if (cb_role.Text == "Creator")
                {
                    MessageBox.Show("Login as Creator");
                    form_creator.ShowDialog();

                }
                if (cb_role.Text == "Player")
                {
                    MessageBox.Show("Login as Player");
                    Player form_player = new Player(form_creator.question_bank);
                    form_player.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("incorect username or password");
            }
        }
    }
}
