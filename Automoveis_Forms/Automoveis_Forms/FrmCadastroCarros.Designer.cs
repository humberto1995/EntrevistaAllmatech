namespace Automoveis_Forms
{
    partial class FrmCadastroCarros
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
            this.lblCor = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblOpicionais = new System.Windows.Forms.Label();
            this.gpbCadastroCarros = new System.Windows.Forms.GroupBox();
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.txtOpicionais = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cbbMarca = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpbCadastroCarros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(473, 164);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(30, 17);
            this.lblCor.TabIndex = 4;
            this.lblCor.Text = "Cor";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(473, 107);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(33, 17);
            this.lblAno.TabIndex = 3;
            this.lblAno.Text = "Ano";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(22, 164);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(53, 17);
            this.lblVersao.TabIndex = 2;
            this.lblVersao.Text = "Versão";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(22, 107);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
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
            // lblOpicionais
            // 
            this.lblOpicionais.AutoSize = true;
            this.lblOpicionais.Location = new System.Drawing.Point(22, 220);
            this.lblOpicionais.Name = "lblOpicionais";
            this.lblOpicionais.Size = new System.Drawing.Size(74, 17);
            this.lblOpicionais.TabIndex = 6;
            this.lblOpicionais.Text = "Opicionais";
            // 
            // gpbCadastroCarros
            // 
            this.gpbCadastroCarros.BackColor = System.Drawing.SystemColors.Control;
            this.gpbCadastroCarros.Controls.Add(this.dtpAno);
            this.gpbCadastroCarros.Controls.Add(this.txtValorVenda);
            this.gpbCadastroCarros.Controls.Add(this.txtValorCompra);
            this.gpbCadastroCarros.Controls.Add(this.lblValorVenda);
            this.gpbCadastroCarros.Controls.Add(this.lblValorCompra);
            this.gpbCadastroCarros.Controls.Add(this.txtOpicionais);
            this.gpbCadastroCarros.Controls.Add(this.txtCor);
            this.gpbCadastroCarros.Controls.Add(this.btnAdicionar);
            this.gpbCadastroCarros.Controls.Add(this.txtVersao);
            this.gpbCadastroCarros.Controls.Add(this.txtModelo);
            this.gpbCadastroCarros.Controls.Add(this.cbbMarca);
            this.gpbCadastroCarros.Controls.Add(this.lblMarca);
            this.gpbCadastroCarros.Controls.Add(this.lblOpicionais);
            this.gpbCadastroCarros.Controls.Add(this.lblModelo);
            this.gpbCadastroCarros.Controls.Add(this.lblCor);
            this.gpbCadastroCarros.Controls.Add(this.lblAno);
            this.gpbCadastroCarros.Controls.Add(this.lblVersao);
            this.gpbCadastroCarros.ForeColor = System.Drawing.Color.Red;
            this.gpbCadastroCarros.Location = new System.Drawing.Point(32, 38);
            this.gpbCadastroCarros.Name = "gpbCadastroCarros";
            this.gpbCadastroCarros.Size = new System.Drawing.Size(702, 454);
            this.gpbCadastroCarros.TabIndex = 7;
            this.gpbCadastroCarros.TabStop = false;
            this.gpbCadastroCarros.Text = "Cadastro de Carros";
            // 
            // dtpAno
            // 
            this.dtpAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAno.Location = new System.Drawing.Point(512, 104);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.Size = new System.Drawing.Size(157, 22);
            this.dtpAno.TabIndex = 3;
            this.dtpAno.Value = new System.DateTime(2015, 11, 1, 0, 0, 0, 0);
            this.dtpAno.FormatChanged += new System.EventHandler(this.dtpAno_FormatChanged);
            this.dtpAno.ValueChanged += new System.EventHandler(this.dtpAno_ValueChanged);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(142, 308);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(189, 22);
            this.txtValorVenda.TabIndex = 7;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(482, 311);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(187, 22);
            this.txtValorCompra.TabIndex = 8;
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(368, 311);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(106, 17);
            this.lblValorVenda.TabIndex = 14;
            this.lblValorVenda.Text = "Valor de Venda";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(22, 311);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(114, 17);
            this.lblValorCompra.TabIndex = 13;
            this.lblValorCompra.Text = "Valor de Compra";
            // 
            // txtOpicionais
            // 
            this.txtOpicionais.Location = new System.Drawing.Point(102, 217);
            this.txtOpicionais.Multiline = true;
            this.txtOpicionais.Name = "txtOpicionais";
            this.txtOpicionais.Size = new System.Drawing.Size(567, 64);
            this.txtOpicionais.TabIndex = 6;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(509, 161);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(160, 22);
            this.txtCor.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(25, 362);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(644, 68);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtVersao
            // 
            this.txtVersao.Location = new System.Drawing.Point(82, 161);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(370, 22);
            this.txtVersao.TabIndex = 4;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(82, 104);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(370, 22);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // cbbMarca
            // 
            this.cbbMarca.DisplayMember = "Marcas";
            this.cbbMarca.FormattingEnabled = true;
            this.cbbMarca.Location = new System.Drawing.Point(75, 48);
            this.cbbMarca.Name = "cbbMarca";
            this.cbbMarca.Size = new System.Drawing.Size(594, 24);
            this.cbbMarca.TabIndex = 1;
            this.cbbMarca.ValueMember = "Marcas";
            this.cbbMarca.SelectedIndexChanged += new System.EventHandler(this.FrmCadastroCarros_Load);
            // 
            // FrmCadastroCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Automoveis_Forms.Properties.Resources.Allmatech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 504);
            this.Controls.Add(this.gpbCadastroCarros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Carros";
            this.Load += new System.EventHandler(this.FrmCadastroCarros_Load);
            this.gpbCadastroCarros.ResumeLayout(false);
            this.gpbCadastroCarros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblOpicionais;
        private System.Windows.Forms.GroupBox gpbCadastroCarros;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtOpicionais;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtVersao;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cbbMarca;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.DateTimePicker dtpAno;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

