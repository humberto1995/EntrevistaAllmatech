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
    public partial class FrmEditarLogin : Form
    {
        public FrmEditarLogin()
        {
            InitializeComponent();
        }

        private void FrmEditarLogin_Load(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Usuario from dbo.Login order by Usuario";
            ClassConexao.Verificando();

            for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            {
                cbbUsuario.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            }
            gpbEditarLogin.Enabled = false;
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            if ((txtUsuarioAutenticado.Text == "usuario") && (txtSenhaAutenticado.Text == "123456"))
            {
                MessageBox.Show("Autenticado com Sucesso");
                gpbEditarLogin.Enabled = true;
                gpbAutenticar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não foi possivel Autenticar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "update dbo.Login set Usuario='" + txtAlterarUsuario.Text + "' , Senha='"+ txtSenha.Text +"' where Usuario='" + cbbUsuario.Text + "'";
            ClassConexao.Modificando();

            MessageBox.Show("Login Alterada com sucesso");
            cbbUsuario.Text = "";
            txtAlterarUsuario.Text = "";
            txtSenha.Text = "";

            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Usuario from dbo.Login order by Usuario";
            ClassConexao.Verificando();

            for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            {
                cbbUsuario.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "delete from dbo.Login Where Usuario='" + cbbUsuario.Text + "'";
            ClassConexao.Modificando();

            MessageBox.Show("Login Deletadada com sucesso");
            cbbUsuario.Text = "";
            txtAlterarUsuario.Text = "";
            txtSenha.Text = "";

            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Usuario from dbo.Login order by Usuario";
            ClassConexao.Verificando();

            for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            {
                cbbUsuario.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            }
        }
    }
}
