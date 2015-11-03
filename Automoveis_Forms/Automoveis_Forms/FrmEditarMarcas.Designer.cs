namespace Automoveis_Forms
{
    partial class FrmEditarMarcas
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
            this.gpbEditarMarcas = new System.Windows.Forms.GroupBox();
            this.cbbMarca = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.gpbAutenticar = new System.Windows.Forms.GroupBox();
            this.btnAutenticar = new System.Windows.Forms.Button();
            this.txtUsuarioAutenticado = new System.Windows.Forms.TextBox();
            this.txtSenhaAutenticado = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblAlterarMarca = new System.Windows.Forms.Label();
            this.txtAlterarMarca = new System.Windows.Forms.TextBox();
            this.gpbEditarMarcas.SuspendLayout();
            this.gpbAutenticar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEditarMarcas
            // 
            this.gpbEditarMarcas.BackColor = System.Drawing.SystemColors.Control;
            this.gpbEditarMarcas.Controls.Add(this.txtAlterarMarca);
            this.gpbEditarMarcas.Controls.Add(this.lblAlterarMarca);
            this.gpbEditarMarcas.Controls.Add(this.cbbMarca);
            this.gpbEditarMarcas.Controls.Add(this.btnExcluir);
            this.gpbEditarMarcas.Controls.Add(this.btnAlterar);
            this.gpbEditarMarcas.Controls.Add(this.lblMarca);
            this.gpbEditarMarcas.ForeColor = System.Drawing.Color.Red;
            this.gpbEditarMarcas.Location = new System.Drawing.Point(36, 261);
            this.gpbEditarMarcas.Name = "gpbEditarMarcas";
            this.gpbEditarMarcas.Size = new System.Drawing.Size(702, 240);
            this.gpbEditarMarcas.TabIndex = 9;
            this.gpbEditarMarcas.TabStop = false;
            this.gpbEditarMarcas.Text = "Editar Marcas";
            // 
            // cbbMarca
            // 
            this.cbbMarca.FormattingEnabled = true;
            this.cbbMarca.Location = new System.Drawing.Point(75, 48);
            this.cbbMarca.Name = "cbbMarca";
            this.cbbMarca.Size = new System.Drawing.Size(594, 24);
            this.cbbMarca.TabIndex = 7;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(366, 144);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(303, 68);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(25, 144);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(303, 68);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(22, 51);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca";
            // 
            // gpbAutenticar
            // 
            this.gpbAutenticar.BackColor = System.Drawing.SystemColors.Control;
            this.gpbAutenticar.Controls.Add(this.btnAutenticar);
            this.gpbAutenticar.Controls.Add(this.txtUsuarioAutenticado);
            this.gpbAutenticar.Controls.Add(this.txtSenhaAutenticado);
            this.gpbAutenticar.Controls.Add(this.lblSenha);
            this.gpbAutenticar.Controls.Add(this.lblUsuario);
            this.gpbAutenticar.Enabled = false;
            this.gpbAutenticar.ForeColor = System.Drawing.Color.Red;
            this.gpbAutenticar.Location = new System.Drawing.Point(163, 28);
            this.gpbAutenticar.Name = "gpbAutenticar";
            this.gpbAutenticar.Size = new System.Drawing.Size(453, 212);
            this.gpbAutenticar.TabIndex = 10;
            this.gpbAutenticar.TabStop = false;
            this.gpbAutenticar.Text = "Autenticar";
            // 
            // btnAutenticar
            // 
            this.btnAutenticar.Location = new System.Drawing.Point(53, 135);
            this.btnAutenticar.Name = "btnAutenticar";
            this.btnAutenticar.Size = new System.Drawing.Size(325, 51);
            this.btnAutenticar.TabIndex = 3;
            this.btnAutenticar.Text = "Autenticar";
            this.btnAutenticar.UseVisualStyleBackColor = true;
            this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click);
            // 
            // txtUsuarioAutenticado
            // 
            this.txtUsuarioAutenticado.Location = new System.Drawing.Point(113, 50);
            this.txtUsuarioAutenticado.Name = "txtUsuarioAutenticado";
            this.txtUsuarioAutenticado.Size = new System.Drawing.Size(265, 22);
            this.txtUsuarioAutenticado.TabIndex = 1;
            this.txtUsuarioAutenticado.Text = "usuario";
            // 
            // txtSenhaAutenticado
            // 
            this.txtSenhaAutenticado.Location = new System.Drawing.Point(113, 96);
            this.txtSenhaAutenticado.Name = "txtSenhaAutenticado";
            this.txtSenhaAutenticado.Size = new System.Drawing.Size(265, 22);
            this.txtSenhaAutenticado.TabIndex = 2;
            this.txtSenhaAutenticado.Text = "123456";
            this.txtSenhaAutenticado.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(50, 101);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(50, 53);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblAlterarMarca
            // 
            this.lblAlterarMarca.AutoSize = true;
            this.lblAlterarMarca.Location = new System.Drawing.Point(22, 103);
            this.lblAlterarMarca.Name = "lblAlterarMarca";
            this.lblAlterarMarca.Size = new System.Drawing.Size(93, 17);
            this.lblAlterarMarca.TabIndex = 8;
            this.lblAlterarMarca.Text = "Alterar Marca";
            // 
            // txtAlterarMarca
            // 
            this.txtAlterarMarca.Location = new System.Drawing.Point(121, 100);
            this.txtAlterarMarca.Name = "txtAlterarMarca";
            this.txtAlterarMarca.Size = new System.Drawing.Size(548, 22);
            this.txtAlterarMarca.TabIndex = 9;
            // 
            // FrmEditarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Automoveis_Forms.Properties.Resources.Allmatech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 513);
            this.Controls.Add(this.gpbAutenticar);
            this.Controls.Add(this.gpbEditarMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Marcas";
            this.Load += new System.EventHandler(this.FrmEditarMarcas_Load);
            this.gpbEditarMarcas.ResumeLayout(false);
            this.gpbEditarMarcas.PerformLayout();
            this.gpbAutenticar.ResumeLayout(false);
            this.gpbAutenticar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEditarMarcas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox gpbAutenticar;
        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.TextBox txtUsuarioAutenticado;
        private System.Windows.Forms.TextBox txtSenhaAutenticado;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbbMarca;
        private System.Windows.Forms.TextBox txtAlterarMarca;
        private System.Windows.Forms.Label lblAlterarMarca;
    }
}