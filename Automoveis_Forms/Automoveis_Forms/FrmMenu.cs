using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automoveis_Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        public void FecharTodos()
        {
            if (this.MdiChildren.Length > 0)
            {
                ActiveMdiChild.Close();
            }
        }
        private void cadastroDeMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void cadastroDeCarrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastroCarros>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCadastroCarros>().First().Focus();
            }
            else
            {
                FrmCadastroCarros CadastroCarros = new FrmCadastroCarros();
                CadastroCarros.MdiParent = this;
                CadastroCarros.Show();
            }
        }
        private void cadastroDeLoguinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastroLogin>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCadastroLogin>().First().Focus();
            }
            else
            {
                FrmCadastroLogin CadastroLogin = new FrmCadastroLogin();
                CadastroLogin.MdiParent = this;
                CadastroLogin.Show();
            }
        }
        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void visualizarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmVisualizarMarcas>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmVisualizarMarcas>().First().Focus();
            }
            else
            {
                FrmVisualizarMarcas VisualizarMarcas = new FrmVisualizarMarcas();
                VisualizarMarcas.MdiParent = this;
                VisualizarMarcas.Show();
            }
        }
        private void visualizarCarrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmVisualizarCarros>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmVisualizarCarros>().First().Focus();
            }
            else
            {
                FrmVisualizarCarros VisualizarCarros = new FrmVisualizarCarros();
                VisualizarCarros.MdiParent = this;
                VisualizarCarros.Show();
            }
        }

        private void visualizarLoguinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmVisualizarLogin>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmVisualizarLogin>().First().Focus();
            }
            else
            {
                FrmVisualizarLogin VisualizarLogin = new FrmVisualizarLogin();
                VisualizarLogin.MdiParent = this;
                VisualizarLogin.Show();
            }
        }

        private void cadastroMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastroMarcas>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCadastroMarcas>().First().Focus();
            }
            else
            {
                FrmCadastroMarcas CadastroMarcas = new FrmCadastroMarcas();
                CadastroMarcas.MdiParent = this;
                CadastroMarcas.Show();
            }
        }

        private void visualizarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmVisualizarMarcas>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmVisualizarMarcas>().First().Focus();
            }
            else
            {
                FrmVisualizarMarcas VisualizarMarcas = new FrmVisualizarMarcas();
                VisualizarMarcas.MdiParent = this;
                VisualizarMarcas.Show();
            }
        }

        private void loguinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmEditarMarcas>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmEditarMarcas>().First().Focus();
            }
            else
            {
                FrmEditarMarcas EditarMarcas = new FrmEditarMarcas();
                EditarMarcas.MdiParent = this;
                EditarMarcas.Show();
            }
        }

        private void editarCarrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmEditarCarros>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmEditarCarros>().First().Focus();
            }
            else
            {
                FrmEditarCarros EditarCarros = new FrmEditarCarros();
                EditarCarros.MdiParent = this;
                EditarCarros.Show();
            }
        }

        private void editarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmEditarLogin>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmEditarLogin>().First().Focus();
            }
            else
            {
                FrmEditarLogin EditarLogin = new FrmEditarLogin();
                EditarLogin.MdiParent = this;
                EditarLogin.Show();
            }
        }
    }
}
