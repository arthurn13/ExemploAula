namespace ExemploAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == "usuario" && txtsenha.Text =="senha")
            {
            MessageBox.Show("Usuario Logado com sucesso");
            txtsenha.Clear();
            txtuser.Clear();
            }
            else
            {
            MessageBox.Show("Usuario/Senha Inv�lidos");
            txtsenha.Clear();
            txtuser.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
