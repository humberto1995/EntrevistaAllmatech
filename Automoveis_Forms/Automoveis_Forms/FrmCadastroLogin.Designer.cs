namespace Automoveis_Forms
{
    partial class FrmCadastroLogin
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
            this.gpbCadastroLogin = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gpbAutenticar = new System.Windows.Forms.GroupBox();
            this.btnAutenticar = new System.Windows.Forms.Button();
            this.txtUsuarioAutenticado = new System.Windows.Forms.TextBox();
            this.txtSenhaAutenticado = new System.Windows.Forms.TextBox();
            this.lblSenhaAutenticado = new System.Windows.Forms.Label();
            this.lblUsuarioAltenticado = new System.Windows.Forms.Label();
            this.gpbCadastroLogin.SuspendLayout();
            this.gpbAutenticar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadastroLogin
            // 
            this.gpbCadastroLogin.BackColor = System.Drawing.SystemColors.Control;
            this.gpbCadastroLogin.Controls.Add(this.btnCadastrar);
            this.gpbCadastroLogin.Controls.Add(this.txtSenha);
            this.gpbCadastroLogin.Controls.Add(this.txtUsuario);
            this.gpbCadastroLogin.Controls.Add(this.lblSenha);
            this.gpbCadastroLogin.Controls.Add(this.lblUsuario);
            this.gpbCadastroLogin.ForeColor = System.Drawing.Color.Red;
            this.gpbCadastroLogin.Location = new System.Drawing.Point(518, 42);
            this.gpbCadastroLogin.Name = "gpbCadastroLogin";
            this.gpbCadastroLogin.Size = new System.Drawing.Size(453, 212);
            this.gpbCadastroLogin.TabIndex = 1;
            this.gpbCadastroLogin.TabStop = false;
            this.gpbCadastroLogin.Text = "Cadastro Login";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(53, 135);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(325, 51);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(113, 98);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(265, 22);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(113, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(265, 22);
            this.txtUsuario.TabIndex = 1;
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
            // gpbAutenticar
            // 
            this.gpbAutenticar.BackColor = System.Drawing.SystemColors.Control;
            this.gpbAutenticar.Controls.Add(this.btnAutenticar);
            this.gpbAutenticar.Controls.Add(this.txtUsuarioAutenticado);
            this.gpbAutenticar.Controls.Add(this.txtSenhaAutenticado);
            this.gpbAutenticar.Controls.Add(this.lblSenhaAutenticado);
            this.gpbAutenticar.Controls.Add(this.lblUsuarioAltenticado);
            this.gpbAutenticar.Enabled = false;
            this.gpbAutenticar.ForeColor = System.Drawing.Color.Red;
            this.gpbAutenticar.Location = new System.Drawing.Point(27, 42);
            this.gpbAutenticar.Name = "gpbAutenticar";
            this.gpbAutenticar.Size = new System.Drawing.Size(453, 212);
            this.gpbAutenticar.TabIndex = 2;
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
            // 
            // lblSenhaAutenticado
            // 
            this.lblSenhaAutenticado.AutoSize = true;
            this.lblSenhaAutenticado.Location = new System.Drawing.Point(50, 101);
            this.lblSenhaAutenticado.Name = "lblSenhaAutenticado";
            this.lblSenhaAutenticado.Size = new System.Drawing.Size(49, 17);
            this.lblSenhaAutenticado.TabIndex = 1;
            this.lblSenhaAutenticado.Text = "Senha";
            // 
            // lblUsuarioAltenticado
            // 
            this.lblUsuarioAltenticado.AutoSize = true;
            this.lblUsuarioAltenticado.Location = new System.Drawing.Point(50, 53);
            this.lblUsuarioAltenticado.Name = "lblUsuarioAltenticado";
            this.lblUsuarioAltenticado.Size = new System.Drawing.Size(57, 17);
            this.lblUsuarioAltenticado.TabIndex = 0;
            this.lblUsuarioAltenticado.Text = "Usuario";
            // 
            // FrmCadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Automoveis_Forms.Properties.Resources.Allmatech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 313);
            this.Controls.Add(this.gpbAutenticar);
            this.Controls.Add(this.gpbCadastroLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Login";
            this.Load += new System.EventHandler(this.FrmCadastroLoguin_Load);
            this.gpbCadastroLogin.ResumeLayout(false);
            this.gpbCadastroLogin.PerformLayout();
            this.gpbAutenticar.ResumeLayout(false);
            this.gpbAutenticar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadastroLogin;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gpbAutenticar;
        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.TextBox txtUsuarioAutenticado;
        private System.Windows.Forms.TextBox txtSenhaAutenticado;
        private System.Windows.Forms.Label lblSenhaAutenticado;
        private System.Windows.Forms.Label lblUsuarioAltenticado;
    }
}