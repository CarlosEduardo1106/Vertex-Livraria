using MySql.Data.MySqlClient;
using System.Data;


namespace VertexTelaLogin
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        MySqlConnection conexao = new MySqlConnection("server=localhost;database=VertexSgbd;uid=root;pwd=Dor!nha1125");

        MySqlCommand cmd = new MySqlCommand();

        MySqlDataReader dt;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" ||txtsenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o login e senha!","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                cmd.CommandText = "select * from Atendente where ds_Login = ('" + txtUsuario.Text + "') and ds_Senha = ('" + txtsenha.Text + "')";
                cmd.Connection = conexao;
                
                dt = cmd.ExecuteReader();

                if (dt.Read())
                {
                    frmMenu tela = new frmMenu();
                    tela.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Usuário ou Senha inválidos");
                }

                    dt.Close();
                conexao.Close();

            }
            }

        }
    }

