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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Usuario,Senha from dbo.Login where Usuario='" + txtUsuario.Text + "' and Senha='" + txtSenha.Text + "'";
            ClassConexao.Verificando();
            if (ClassConexao.Table.Rows.Count == 0)
            {
                MessageBox.Show("Não foi possiver se conectar com o sistema!");
                txtUsuario.Focus();
            }
            else
            {
                FrmMenu Menu = new FrmMenu();
                Menu.Show();
                this.Hide();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
