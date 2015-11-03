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
    public partial class FrmVisualizarLogin : Form
    {
        public FrmVisualizarLogin()
        {
            InitializeComponent();
        }

        private void cbbLoguin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            if (cbbLogin.Text == "Todos os Login")
            {
                ClassConexao.StrConexao = "select * from dbo.Login";
                ClassConexao.Verificando();
                dgvLogin.DataSource = ClassConexao.Table;
            }
        }

        private void FrmVisualizarLogin_Load(object sender, EventArgs e)
        {
            gpbVisualizarLogin.Enabled = false;
            gpbAutenticar.Enabled = true;
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            if ((txtUsuarioAutenticado.Text == "usuario") && (txtSenhaAutenticado.Text == "123456"))
            {
                MessageBox.Show("Autenticado com Sucesso");
                gpbVisualizarLogin.Enabled = true;
                gpbAutenticar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não foi possivel Autenticar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
