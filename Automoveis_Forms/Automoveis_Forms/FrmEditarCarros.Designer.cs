namespace Automoveis_Forms
{
    partial class FrmEditarCarros
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
            this.gpbAutenticar = new System.Windows.Forms.GroupBox();
            this.btnAutenticar = new System.Windows.Forms.Button();
            this.txtUsuarioAutenticado = new System.Windows.Forms.TextBox();
            this.txtSenhaAutenticado = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gpbEditatCarros = new System.Windows.Forms.GroupBox();
            this.btnCarregarModelo = new System.Windows.Forms.Button();
            this.btnCarregarMarca = new System.Windows.Forms.Button();
            this.txtAlterarModelo = new System.Windows.Forms.TextBox();
            this.lblAlterarModelo = new System.Windows.Forms.Label();
            this.cbbModelo = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.txtOpicionais = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.cbbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblOpicionais = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.gpbAutenticar.SuspendLayout();
            this.gpbEditatCarros.SuspendLayout();
            this.SuspendLayout();
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
            this.gpbAutenticar.Location = new System.Drawing.Point(28, 256);
            this.gpbAutenticar.Name = "gpbAutenticar";
            this.gpbAutenticar.Size = new System.Drawing.Size(453, 212);
            this.gpbAutenticar.TabIndex = 11;
            this.gpbAutenticar.TabStop = false;
            this.gpbAutenticar.Text = "Autenticar";
            this.gpbAutenticar.Enter += new System.EventHandler(this.gpbAutenticar_Enter);
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
            this.txtUsuarioAutenticado.TextChanged += new System.EventHandler(this.txtUsuarioAutenticado_TextChanged);
            // 
            // txtSenhaAutenticado
            // 
            this.txtSenhaAutenticado.Location = new System.Drawing.Point(113, 96);
            this.txtSenhaAutenticado.Name = "txtSenhaAutenticado";
            this.txtSenhaAutenticado.Size = new System.Drawing.Size(265, 22);
            this.txtSenhaAutenticado.TabIndex = 2;
            this.txtSenhaAutenticado.Text = "123456";
            this.txtSenhaAutenticado.UseSystemPasswordChar = true;
            this.txtSenhaAutenticado.TextChanged += new System.EventHandler(this.txtSenhaAutenticado_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(50, 101);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(50, 53);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // gpbEditatCarros
            // 
            this.gpbEditatCarros.BackColor = System.Drawing.SystemColors.Control;
            this.gpbEditatCarros.Controls.Add(this.btnCarregarModelo);
            this.gpbEditatCarros.Controls.Add(this.btnCarregarMarca);
            this.gpbEditatCarros.Controls.Add(this.txtAlterarModelo);
            this.gpbEditatCarros.Controls.Add(this.lblAlterarModelo);
            this.gpbEditatCarros.Controls.Add(this.cbbModelo);
            this.gpbEditatCarros.Controls.Add(this.btnExcluir);
            this.gpbEditatCarros.Controls.Add(this.dtpAno);
            this.gpbEditatCarros.Controls.Add(this.txtValorVenda);
            this.gpbEditatCarros.Controls.Add(this.txtValorCompra);
            this.gpbEditatCarros.Controls.Add(this.lblValorVenda);
            this.gpbEditatCarros.Controls.Add(this.lblValorCompra);
            this.gpbEditatCarros.Controls.Add(this.txtOpicionais);
            this.gpbEditatCarros.Controls.Add(this.txtCor);
            this.gpbEditatCarros.Controls.Add(this.btnAlterar);
            this.gpbEditatCarros.Controls.Add(this.txtVersao);
            this.gpbEditatCarros.Controls.Add(this.cbbMarca);
            this.gpbEditatCarros.Controls.Add(this.lblMarca);
            this.gpbEditatCarros.Controls.Add(this.lblOpicionais);
            this.gpbEditatCarros.Controls.Add(this.lblModelo);
            this.gpbEditatCarros.Controls.Add(this.lblCor);
            this.gpbEditatCarros.Controls.Add(this.lblAno);
            this.gpbEditatCarros.Controls.Add(this.lblVersao);
            this.gpbEditatCarros.ForeColor = System.Drawing.Color.Red;
            this.gpbEditatCarros.Location = new System.Drawing.Point(506, 66);
            this.gpbEditatCarros.Name = "gpbEditatCarros";
            this.gpbEditatCarros.Size = new System.Drawing.Size(722, 574);
            this.gpbEditatCarros.TabIndex = 12;
            this.gpbEditatCarros.TabStop = false;
            this.gpbEditatCarros.Text = "Editar Carros";
            this.gpbEditatCarros.Enter += new System.EventHandler(this.gpbEditatCarros_Enter);
            // 
            // btnCarregarModelo
            // 
            this.btnCarregarModelo.Location = new System.Drawing.Point(136, 180);
            this.btnCarregarModelo.Name = "btnCarregarModelo";
            this.btnCarregarModelo.Size = new System.Drawing.Size(478, 39);
            this.btnCarregarModelo.TabIndex = 37;
            this.btnCarregarModelo.Text = "Carregar Modelo";
            this.btnCarregarModelo.UseVisualStyleBackColor = true;
            this.btnCarregarModelo.Click += new System.EventHandler(this.btnCarregarModelo_Click);
            // 
            // btnCarregarMarca
            // 
            this.btnCarregarMarca.Location = new System.Drawing.Point(136, 79);
            this.btnCarregarMarca.Name = "btnCarregarMarca";
            this.btnCarregarMarca.Size = new System.Drawing.Size(478, 39);
            this.btnCarregarMarca.TabIndex = 36;
            this.btnCarregarMarca.Text = "Carregar Marca";
            this.btnCarregarMarca.UseVisualStyleBackColor = true;
            this.btnCarregarMarca.Click += new System.EventHandler(this.btnCarregarMarca_Click);
            // 
            // txtAlterarModelo
            // 
            this.txtAlterarModelo.Location = new System.Drawing.Point(144, 236);
            this.txtAlterarModelo.Name = "txtAlterarModelo";
            this.txtAlterarModelo.Size = new System.Drawing.Size(541, 22);
            this.txtAlterarModelo.TabIndex = 35;
            // 
            // lblAlterarModelo
            // 
            this.lblAlterarModelo.AutoSize = true;
            this.lblAlterarModelo.Location = new System.Drawing.Point(38, 239);
            this.lblAlterarModelo.Name = "lblAlterarModelo";
            this.lblAlterarModelo.Size = new System.Drawing.Size(100, 17);
            this.lblAlterarModelo.TabIndex = 34;
            this.lblAlterarModelo.Text = "Alterar Modelo";
            // 
            // cbbModelo
            // 
            this.cbbModelo.FormattingEnabled = true;
            this.cbbModelo.Location = new System.Drawing.Point(98, 138);
            this.cbbModelo.Name = "cbbModelo";
            this.cbbModelo.Size = new System.Drawing.Size(370, 24);
            this.cbbModelo.TabIndex = 33;
            this.cbbModelo.SelectedIndexChanged += new System.EventHandler(this.cbbModelo_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(360, 494);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(316, 68);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtpAno
            // 
            this.dtpAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAno.Location = new System.Drawing.Point(528, 138);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.Size = new System.Drawing.Size(157, 22);
            this.dtpAno.TabIndex = 20;
            this.dtpAno.Value = new System.DateTime(2015, 11, 1, 0, 0, 0, 0);
            this.dtpAno.ValueChanged += new System.EventHandler(this.dtpAno_ValueChanged);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(158, 429);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(189, 22);
            this.txtValorVenda.TabIndex = 27;
            this.txtValorVenda.TextChanged += new System.EventHandler(this.txtValorVenda_TextChanged);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(498, 432);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(187, 22);
            this.txtValorCompra.TabIndex = 28;
            this.txtValorCompra.TextChanged += new System.EventHandler(this.txtValorCompra_TextChanged);
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(384, 432);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(106, 17);
            this.lblValorVenda.TabIndex = 31;
            this.lblValorVenda.Text = "Valor de Venda";
            this.lblValorVenda.Click += new System.EventHandler(this.lblValorVenda_Click);
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(38, 432);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(114, 17);
            this.lblValorCompra.TabIndex = 30;
            this.lblValorCompra.Text = "Valor de Compra";
            this.lblValorCompra.Click += new System.EventHandler(this.lblValorCompra_Click);
            // 
            // txtOpicionais
            // 
            this.txtOpicionais.Location = new System.Drawing.Point(118, 338);
            this.txtOpicionais.Multiline = true;
            this.txtOpicionais.Name = "txtOpicionais";
            this.txtOpicionais.Size = new System.Drawing.Size(567, 64);
            this.txtOpicionais.TabIndex = 26;
            this.txtOpicionais.TextChanged += new System.EventHandler(this.txtOpicionais_TextChanged);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(525, 282);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(160, 22);
            this.txtCor.TabIndex = 23;
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(38, 494);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(316, 68);
            this.btnAlterar.TabIndex = 29;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtVersao
            // 
            this.txtVersao.Location = new System.Drawing.Point(98, 282);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(370, 22);
            this.txtVersao.TabIndex = 22;
            this.txtVersao.TextChanged += new System.EventHandler(this.txtVersao_TextChanged);
            // 
            // cbbMarca
            // 
            this.cbbMarca.DisplayMember = "Marcas";
            this.cbbMarca.FormattingEnabled = true;
            this.cbbMarca.Location = new System.Drawing.Point(88, 39);
            this.cbbMarca.Name = "cbbMarca";
            this.cbbMarca.Size = new System.Drawing.Size(594, 24);
            this.cbbMarca.TabIndex = 16;
            this.cbbMarca.ValueMember = "Marcas";
            this.cbbMarca.SelectedIndexChanged += new System.EventHandler(this.cbbMarca_SelectedIndexChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(35, 42);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // lblOpicionais
            // 
            this.lblOpicionais.AutoSize = true;
            this.lblOpicionais.Location = new System.Drawing.Point(38, 341);
            this.lblOpicionais.Name = "lblOpicionais";
            this.lblOpicionais.Size = new System.Drawing.Size(74, 17);
            this.lblOpicionais.TabIndex = 25;
            this.lblOpicionais.Text = "Opicionais";
            this.lblOpicionais.Click += new System.EventHandler(this.lblOpicionais_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(38, 141);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 15;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Click += new System.EventHandler(this.lblModelo_Click);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(489, 285);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(30, 17);
            this.lblCor.TabIndex = 21;
            this.lblCor.Text = "Cor";
            this.lblCor.Click += new System.EventHandler(this.lblCor_Click);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(489, 141);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(33, 17);
            this.lblAno.TabIndex = 19;
            this.lblAno.Text = "Ano";
            this.lblAno.Click += new System.EventHandler(this.lblAno_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(38, 285);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(53, 17);
            this.lblVersao.TabIndex = 17;
            this.lblVersao.Text = "Versão";
            this.lblVersao.Click += new System.EventHandler(this.lblVersao_Click);
            // 
            // FrmEditarCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Automoveis_Forms.Properties.Resources.Allmatech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 694);
            this.Controls.Add(this.gpbEditatCarros);
            this.Controls.Add(this.gpbAutenticar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Carros";
            this.Load += new System.EventHandler(this.FrmEditarCarros_Load);
            this.gpbAutenticar.ResumeLayout(false);
            this.gpbAutenticar.PerformLayout();
            this.gpbEditatCarros.ResumeLayout(false);
            this.gpbEditatCarros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAutenticar;
        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.TextBox txtUsuarioAutenticado;
        private System.Windows.Forms.TextBox txtSenhaAutenticado;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gpbEditatCarros;
        private System.Windows.Forms.DateTimePicker dtpAno;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.TextBox txtOpicionais;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtVersao;
        private System.Windows.Forms.ComboBox cbbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblOpicionais;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cbbModelo;
        private System.Windows.Forms.TextBox txtAlterarModelo;
        private System.Windows.Forms.Label lblAlterarModelo;
        private System.Windows.Forms.Button btnCarregarMarca;
        private System.Windows.Forms.Button btnCarregarModelo;
    }
}