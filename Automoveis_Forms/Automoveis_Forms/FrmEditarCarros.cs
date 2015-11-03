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
    public partial class FrmEditarCarros : Form
    {
        public FrmEditarCarros()
        {
            InitializeComponent();
        }

        private void gpbEditatCarros_Enter(object sender, EventArgs e)
        {

        }

        private void gpbAutenticar_Enter(object sender, EventArgs e)
        {

        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            if ((txtUsuarioAutenticado.Text == "usuario") && (txtSenhaAutenticado.Text == "123456"))
            {
                MessageBox.Show("Autenticado com Sucesso");
                gpbEditatCarros.Enabled = true;
                gpbAutenticar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não foi possivel Autenticar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuarioAutenticado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaAutenticado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }



        private void dtpAno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblValorVenda_Click(object sender, EventArgs e)
        {

        }

        private void lblValorCompra_Click(object sender, EventArgs e)
        {

        }

        private void txtOpicionais_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVersao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void lblOpicionais_Click(object sender, EventArgs e)
        {

        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void lblCor_Click(object sender, EventArgs e)
        {

        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }

        private void lblVersao_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarCarros_Load(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Marca from dbo.Marcas order by Marca";
            ClassConexao.Verificando();

            for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            {
                cbbMarca.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            }

            //ClassConexao.Conectando();
            //ClassConexao.StrConexao = "select Modelo from dbo.Carros order by Modelo";
            //ClassConexao.Verificando();

            //for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            //{
            //    cbbModelo.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            //}

            gpbEditatCarros.Enabled = false;
            gpbAutenticar.Enabled = true;

            dtpAno.Format = DateTimePickerFormat.Custom;
            dtpAno.CustomFormat = "yyyy";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "delete from dbo.Carros Where Modelo='" + cbbModelo.Text + "'";
            ClassConexao.Modificando();

            MessageBox.Show("Carro Deletadado com sucesso");
            cbbMarca.Text = "";
            cbbModelo.Text = "";
            txtAlterarModelo.Text = "";
            txtVersao.Text = "";
            txtCor.Text = "";
            txtOpicionais.Text = "";
            txtValorCompra.Text = "";
            txtValorVenda.Text = "";

            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Marca from dbo.Marcas order by Marca";
            ClassConexao.Verificando();

            for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            {
                cbbMarca.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            }
        }

        private void cbbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCarregarMarca_Click(object sender, EventArgs e)
        {
            if (cbbMarca.Text == "")
            {
                MessageBox.Show("Nenhuma Marca Selecionada");
                return;
            }
            else
            {
                ClassConexao.Conectando();
                ClassConexao.StrConexao = "select Modelo from dbo.Carros where Marca='" + cbbMarca.Text + "'";
                ClassConexao.Verificando();

                for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
                {
                    cbbModelo.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
                }

                MessageBox.Show("Modelo Carregado com Sucesso");
            }
        }

        private void btnCarregarModelo_Click(object sender, EventArgs e)
        {
            if (cbbMarca.Text == "" || cbbModelo.Text == "")
            {
                MessageBox.Show("Nenhuma Marca / Modelo Selecionado");
                return;
            }
            else
            {
                ClassConexao.Conectando();
                ClassConexao.StrConexao = "select * from dbo.Carros where Marca='" + cbbMarca.Text + "' and Modelo='"+ cbbModelo.Text +"'";
                ClassConexao.Verificando();

                txtAlterarModelo.Text = ClassConexao.Table.Rows[0]["Modelo"].ToString();
                dtpAno.Text = ClassConexao.Table.Rows[0]["Ano"].ToString();
                txtVersao.Text = ClassConexao.Table.Rows[0]["Versao"].ToString();
                txtCor.Text = ClassConexao.Table.Rows[0]["Cor"].ToString();
                txtOpicionais.Text = ClassConexao.Table.Rows[0]["Opicionais"].ToString();
                txtValorCompra.Text = ClassConexao.Table.Rows[0]["ValorCompra"].ToString();
                txtValorVenda.Text = ClassConexao.Table.Rows[0]["ValorVenda"].ToString();

                MessageBox.Show("Modelo Carregado com Sucesso");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "update dbo.Carros set Marca='" + cbbMarca.Text + "', Modelo='" + txtAlterarModelo.Text + "', Ano='" + dtpAno.Text + "', Versao='" + txtVersao.Text + "', Cor='" + txtCor.Text + "', Opicionais='" + txtOpicionais.Text + "', ValorCompra='" + txtValorCompra.Text + "', ValorVenda='" + txtValorVenda.Text + "' where Marca='" + cbbMarca.Text + "' and Modelo='"+ cbbModelo.Text +"'";
            ClassConexao.Modificando();

            MessageBox.Show("Marca Alterada com sucesso");
            cbbMarca.Text = "";
            cbbModelo.Text = "";
            txtAlterarModelo.Text = "";
            dtpAno.Text = "";
            txtVersao.Text = "";
            txtCor.Text = "";
            txtOpicionais.Text = "";
            txtValorCompra.Text = "";
            txtValorVenda.Text = "";

        }
    }
}
