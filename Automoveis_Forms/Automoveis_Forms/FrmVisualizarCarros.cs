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
    public partial class FrmVisualizarCarros : Form
    {
        public FrmVisualizarCarros()
        {
            InitializeComponent();
        }

        private void cbbCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Atlerar o ComboBox Talks para Todos os Carros
            //ClassConexao.Conectando();
            //if (cbbCarros.Text == "Todos os Carros")
            //{
            //    ClassConexao.StrConexao = "select * from dbo.Carros ordem by Marca";
            //    ClassConexao.Verificando();
            //    dgvCarros.DataSource = ClassConexao.Table;
            //}
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select * from dbo.Carros where Marca='" + cbbCarros.Text + "'";
            ClassConexao.Verificando();

            dgvCarros.DataSource = ClassConexao.Table;
        }

        private void FrmVisualizarCarros_Load(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            ClassConexao.StrConexao = "select Marca from dbo.Marcas order by Marca";
            ClassConexao.Verificando();

            for (int i = 0; i < ClassConexao.Table.Rows.Count; i++)
            {
                cbbCarros.Items.Insert(i, ClassConexao.Table.Rows[i][0].ToString());
            }
        }
    }
}

