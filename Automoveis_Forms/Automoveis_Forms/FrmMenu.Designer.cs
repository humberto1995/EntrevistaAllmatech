namespace Automoveis_Forms
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCarrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCarrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCarrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loguinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeLoguinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarLoguinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.BackColor = System.Drawing.Color.Red;
            this.mnsPrincipal.Font = new System.Drawing.Font("Rockwell", 20F);
            this.mnsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.carrosToolStripMenuItem,
            this.loguinToolStripMenuItem});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(1458, 46);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroMarcaToolStripMenuItem,
            this.visualizarMarcaToolStripMenuItem,
            this.editarMarcasToolStripMenuItem});
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(143, 42);
            this.marcaToolStripMenuItem.Text = "Marcas";
            // 
            // cadastroMarcaToolStripMenuItem
            // 
            this.cadastroMarcaToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.cadastroMarcaToolStripMenuItem.Name = "cadastroMarcaToolStripMenuItem";
            this.cadastroMarcaToolStripMenuItem.Size = new System.Drawing.Size(414, 42);
            this.cadastroMarcaToolStripMenuItem.Text = "Cadastro de Marcas";
            this.cadastroMarcaToolStripMenuItem.Click += new System.EventHandler(this.cadastroMarcaToolStripMenuItem_Click);
            // 
            // visualizarMarcaToolStripMenuItem
            // 
            this.visualizarMarcaToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.visualizarMarcaToolStripMenuItem.Name = "visualizarMarcaToolStripMenuItem";
            this.visualizarMarcaToolStripMenuItem.Size = new System.Drawing.Size(414, 42);
            this.visualizarMarcaToolStripMenuItem.Text = "Visualizar Marcas";
            this.visualizarMarcaToolStripMenuItem.Click += new System.EventHandler(this.visualizarMarcaToolStripMenuItem_Click);
            // 
            // editarMarcasToolStripMenuItem
            // 
            this.editarMarcasToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.editarMarcasToolStripMenuItem.Name = "editarMarcasToolStripMenuItem";
            this.editarMarcasToolStripMenuItem.Size = new System.Drawing.Size(414, 42);
            this.editarMarcasToolStripMenuItem.Text = "Editar Marcas";
            this.editarMarcasToolStripMenuItem.Click += new System.EventHandler(this.editarMarcasToolStripMenuItem_Click);
            // 
            // carrosToolStripMenuItem
            // 
            this.carrosToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.carrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeCarrosToolStripMenuItem,
            this.visualizarCarrosToolStripMenuItem,
            this.editarCarrosToolStripMenuItem});
            this.carrosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.carrosToolStripMenuItem.Name = "carrosToolStripMenuItem";
            this.carrosToolStripMenuItem.Size = new System.Drawing.Size(136, 42);
            this.carrosToolStripMenuItem.Text = "Carros";
            // 
            // cadastroDeCarrosToolStripMenuItem
            // 
            this.cadastroDeCarrosToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.cadastroDeCarrosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastroDeCarrosToolStripMenuItem.Name = "cadastroDeCarrosToolStripMenuItem";
            this.cadastroDeCarrosToolStripMenuItem.Size = new System.Drawing.Size(407, 42);
            this.cadastroDeCarrosToolStripMenuItem.Text = "Cadastro de Carros";
            this.cadastroDeCarrosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCarrosToolStripMenuItem_Click);
            // 
            // visualizarCarrosToolStripMenuItem
            // 
            this.visualizarCarrosToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.visualizarCarrosToolStripMenuItem.Name = "visualizarCarrosToolStripMenuItem";
            this.visualizarCarrosToolStripMenuItem.Size = new System.Drawing.Size(407, 42);
            this.visualizarCarrosToolStripMenuItem.Text = "Visualizar Carros";
            this.visualizarCarrosToolStripMenuItem.Click += new System.EventHandler(this.visualizarCarrosToolStripMenuItem_Click);
            // 
            // editarCarrosToolStripMenuItem
            // 
            this.editarCarrosToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.editarCarrosToolStripMenuItem.Name = "editarCarrosToolStripMenuItem";
            this.editarCarrosToolStripMenuItem.Size = new System.Drawing.Size(407, 42);
            this.editarCarrosToolStripMenuItem.Text = "Editar Carros";
            this.editarCarrosToolStripMenuItem.Click += new System.EventHandler(this.editarCarrosToolStripMenuItem_Click);
            // 
            // loguinToolStripMenuItem
            // 
            this.loguinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeLoguinToolStripMenuItem,
            this.visualizarLoguinToolStripMenuItem,
            this.editarLoginToolStripMenuItem});
            this.loguinToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.loguinToolStripMenuItem.Name = "loguinToolStripMenuItem";
            this.loguinToolStripMenuItem.Size = new System.Drawing.Size(116, 42);
            this.loguinToolStripMenuItem.Text = "Login";
            this.loguinToolStripMenuItem.Click += new System.EventHandler(this.loguinToolStripMenuItem_Click);
            // 
            // cadastroDeLoguinToolStripMenuItem
            // 
            this.cadastroDeLoguinToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.cadastroDeLoguinToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastroDeLoguinToolStripMenuItem.Name = "cadastroDeLoguinToolStripMenuItem";
            this.cadastroDeLoguinToolStripMenuItem.Size = new System.Drawing.Size(387, 42);
            this.cadastroDeLoguinToolStripMenuItem.Text = "Cadastro de Login";
            this.cadastroDeLoguinToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeLoguinToolStripMenuItem_Click);
            // 
            // visualizarLoguinToolStripMenuItem
            // 
            this.visualizarLoguinToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.visualizarLoguinToolStripMenuItem.Name = "visualizarLoguinToolStripMenuItem";
            this.visualizarLoguinToolStripMenuItem.Size = new System.Drawing.Size(387, 42);
            this.visualizarLoguinToolStripMenuItem.Text = "Visualizar Login";
            this.visualizarLoguinToolStripMenuItem.Click += new System.EventHandler(this.visualizarLoguinToolStripMenuItem_Click);
            // 
            // editarLoginToolStripMenuItem
            // 
            this.editarLoginToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.editarLoginToolStripMenuItem.Name = "editarLoginToolStripMenuItem";
            this.editarLoginToolStripMenuItem.Size = new System.Drawing.Size(387, 42);
            this.editarLoginToolStripMenuItem.Text = "Editar Login";
            this.editarLoginToolStripMenuItem.Click += new System.EventHandler(this.editarLoginToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Automoveis_Forms.Properties.Resources.Allmatech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1458, 876);
            this.Controls.Add(this.mnsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem carrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCarrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loguinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeLoguinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCarrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarLoguinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCarrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLoginToolStripMenuItem;
    }
}