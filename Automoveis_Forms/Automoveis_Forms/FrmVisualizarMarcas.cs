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
    public partial class FrmVisualizarMarcas : Form
    {
        public FrmVisualizarMarcas()
        {
            InitializeComponent();
        }

        private void cbbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConexao.Conectando();
            if (cbbMarcas.Text == "Todas as Marcas")
            {
                ClassConexao.StrConexao = "select * from dbo.Marcas";
                ClassConexao.Verificando();
                dgvMarcas.DataSource = ClassConexao.Table;
            }
        }
    }
}
