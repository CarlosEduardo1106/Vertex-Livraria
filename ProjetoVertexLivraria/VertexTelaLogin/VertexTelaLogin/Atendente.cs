using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VertexTelaLogin
{
    public partial class Atendente : UserControl
    {
        public Atendente()
        {
            InitializeComponent();
        }

        MySqlConnection conexao = new MySqlConnection("server=localhost;database=VertexSgbd;uid=root;pwd=Dor!nha1125");

        MySqlCommand cmd = new MySqlCommand();

        MySqlDataReader dt;
        private void desabilitaCampos()
        {
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnRemover.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
        }

        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;


        }

        private void Atendente_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" )
            {
                MessageBox.Show("Obrigatório informar o Nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o Login!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar a Senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                string nome = txtNome.Text;
                string login = txtLogin.Text;
                string senha= txtSenha.Text;
                string sql = "insert into Atendente(ds_Login,ds_Senha,nm_Atendente)values(@login,@senha,@nome)";

                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@senha",MySqlDbType.VarChar).Value = senha;
                cmd.Parameters.Add("nome", MySqlDbType.VarChar).Value = nome;

               cmd.CommandText = sql;
                cmd.Connection = conexao;
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Os dados foram gravados com sucesso!", "Dados gravados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                conexao.Close();
                
                txtNome.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";



            }

        }
    }
}
