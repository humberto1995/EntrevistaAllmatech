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
    public partial class FrmCadastroCarros : Form
    {
        public FrmCadastroCarros()
        {
            InitializeComponent();
        }

        private void FrmCadastroCarros_Load(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Marca from dbo.Marcas order by Marca";
            ClassConexao.Verificando();

            for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            {
                cbbMarca.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            }
            dtpAno.Format = DateTimePickerFormat.Custom;
            dtpAno.CustomFormat = "yyyy";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cbbMarca.Text == "" || txtModelo.Text == "" || dtpAno.Text == "" || txtVersao.Text == "" || txtCor.Text == "" || txtOpicionais.Text == "" || txtValorCompra.Text == "" || txtValorVenda.Text == "")
            {
                MessageBox.Show("Impossivel de Cadastrar um carro, Existe campos em branco");
                cbbMarca.Focus();
            }
            else
            {
                ClassConexao.Conectando();
                ClassConexao.StrConexao = "insert into dbo.Carros (Marca,Modelo,Ano,Versao,Cor,Opicionais,ValorCompra,ValorVenda) values ('" + cbbMarca.Text + "','" + txtModelo.Text + "','" + dtpAno.Text + "','" + txtVersao.Text + "','" + txtCor.Text + "','" + txtOpicionais.Text + "','" + txtValorCompra.Text + "','" + txtValorVenda.Text + "')";
                ClassConexao.Verificando();

                MessageBox.Show("Carro Cadastrado com Sucesso!");
                cbbMarca.Text = "";
                txtModelo.Text = "";
                txtVersao.Text = "";
                txtCor.Text = "";
                txtOpicionais.Text = "";
                txtValorCompra.Text = "";
                txtValorVenda.Text = "";
                cbbMarca.Focus();
            }
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpAno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpAno_FormatChanged(object sender, EventArgs e)
        {

        }
    }
}

