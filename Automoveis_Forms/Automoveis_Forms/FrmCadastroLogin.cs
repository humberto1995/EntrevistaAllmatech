using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automoveis_Forms.Class;

namespace Automoveis_Forms
{
    public partial class FrmCadastroLogin : Form
    {
        public FrmCadastroLogin()
        {
            InitializeComponent();
        }

        private void FrmCadastroLoguin_Load(object sender, EventArgs e)
        {
            gpbCadastroLogin.Enabled = false;
            gpbAutenticar.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Impossivel de cadastrar Login, Campos em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClassConexao.Conectando();
                ClassConexao.StrConexao = "insert into dbo.Login (Usuario,Senha) values('" + txtUsuario.Text + "','" + txtSenha.Text + "')";
                ClassConexao.Modificando();

                MessageBox.Show("Loguin Cadastrado com Sucesso");
            }
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            if ((txtUsuarioAutenticado.Text == "usuario") && (txtSenhaAutenticado.Text == "123456"))
            {
                ClassConexao.Conectando();
                ClassConexao.StrConexao = "insert into dbo.Login (Usuario,Senha) values('" + txtUsuario.Text + "','" + txtSenha.Text + "')";
                ClassConexao.Modificando();


                gpbAutenticar.Enabled = false;
                gpbCadastroLogin.Enabled = true;
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
            else
            {

                gpbAutenticar.Enabled = false;
                gpbCadastroLogin.Enabled = true;
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
        }

        private void gpbAutenticar_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsuarioAutenticado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

