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
    public partial class FrmCadastroMarcas : Form
    {
        public FrmCadastroMarcas()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                MessageBox.Show("Impossivel de Adicionar a Marca, Texto 'Marca' em Branco");
                txtMarca.Focus();
            }
            else
            {
                ClassConexao.Conectando();
                ClassConexao.StrConexao = "insert into dbo.Marcas(Marca) values('" + txtMarca.Text + "')";
                ClassConexao.Modificando();

                MessageBox.Show("Marca Adicionada com Sucesso");
                txtMarca.Text = "";
                txtMarca.Focus();
            }
        }

        private void gpbCadastroMarcas_Enter(object sender, EventArgs e)
        {

        }
    }
}
