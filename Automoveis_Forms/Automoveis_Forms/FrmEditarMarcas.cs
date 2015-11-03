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
    public partial class FrmEditarMarcas : Form
    {
        public FrmEditarMarcas()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "update dbo.Marcas set Marca='" + txtAlterarMarca.Text + "' where Marca='" + cbbMarca.Text + "'";
            ClassConexao.Modificando();

            MessageBox.Show("Marca Alterada com sucesso");
            cbbMarca.Text = "";
            txtAlterarMarca.Text = "";

            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Marca from dbo.Marcas order by Marca";
            ClassConexao.Verificando();

            for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            {
                cbbMarca.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            }
        }

        private void FrmEditarMarcas_Load(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Marca from dbo.Marcas order by Marca";
            ClassConexao.Verificando();

            for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            {
                cbbMarca.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            }
            gpbAutenticar.Enabled = true;
            gpbEditarMarcas.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "delete from dbo.Marcas Where Marca='" + cbbMarca.Text + "'";
            ClassConexao.Modificando();

            MessageBox.Show("Marca Deletadada com sucesso");
            cbbMarca.Text = "";
            txtAlterarMarca.Text = "";

            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Marca from dbo.Marcas order by Marca";
            ClassConexao.Verificando();

            for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            {
                cbbMarca.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            }
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            if ((txtUsuarioAutenticado.Text == "usuario") && (txtSenhaAutenticado.Text == "123456"))
            {
                MessageBox.Show("Autenticado com Sucesso");
                gpbEditarMarcas.Enabled = true;
                gpbAutenticar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não foi possivel Autenticar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
