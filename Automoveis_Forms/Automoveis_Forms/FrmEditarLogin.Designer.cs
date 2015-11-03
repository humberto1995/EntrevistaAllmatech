namespace Automoveis_Forms
{
    partial class FrmEditarLogin
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
            this.lblSenhaAutenticado = new System.Windows.Forms.Label();
            this.lblUsuarioAltenticado = new System.Windows.Forms.Label();
            this.gpbEditarLogin = new System.Windows.Forms.GroupBox();
            this.cbbUsuario = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblAlterarUsuario = new System.Windows.Forms.Label();
            this.txtAlterarUsuario = new System.Windows.Forms.TextBox();
            this.gpbAutenticar.SuspendLayout();
            this.gpbEditarLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAutenticar
            // 
            this.gpbAutenticar.BackColor = System.Drawing.SystemColors.Control;
            this.gpbAutenticar.Controls.Add(this.btnAutenticar);
            this.gpbAutenticar.Controls.Add(this.txtUsuarioAutenticado);
            this.gpbAutenticar.Controls.Add(this.txtSenhaAutenticado);
            this.gpbAutenticar.Controls.Add(this.lblSenhaAutenticado);
            this.gpbAutenticar.Controls.Add(this.lblUsuarioAltenticado);
            this.gpbAutenticar.ForeColor = System.Drawing.Color.Red;
            this.gpbAutenticar.Location = new System.Drawing.Point(24, 23);
            this.gpbAutenticar.Name = "gpbAutenticar";
            this.gpbAutenticar.Size = new System.Drawing.Size(453, 212);
            this.gpbAutenticar.TabIndex = 4;
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
            // gpbEditarLogin
            // 
            this.gpbEditarLogin.BackColor = System.Drawing.SystemColors.Control;
            this.gpbEditarLogin.Controls.Add(this.txtAlterarUsuario);
            this.gpbEditarLogin.Controls.Add(this.lblAlterarUsuario);
            this.gpbEditarLogin.Controls.Add(this.cbbUsuario);
            this.gpbEditarLogin.Controls.Add(this.btnExcluir);
            this.gpbEditarLogin.Controls.Add(this.btnAlterar);
            this.gpbEditarLogin.Controls.Add(this.txtSenha);
            this.gpbEditarLogin.Controls.Add(this.lblSenha);
            this.gpbEditarLogin.Controls.Add(this.lblUsuario);
            this.gpbEditarLogin.ForeColor = System.Drawing.Color.Red;
            this.gpbEditarLogin.Location = new System.Drawing.Point(508, 23);
            this.gpbEditarLogin.Name = "gpbEditarLogin";
            this.gpbEditarLogin.Size = new System.Drawing.Size(453, 260);
            this.gpbEditarLogin.TabIndex = 3;
            this.gpbEditarLogin.TabStop = false;
            this.gpbEditarLogin.Text = "Editar Login";
            // 
            // cbbUsuario
            // 
            this.cbbUsuario.FormattingEnabled = true;
            this.cbbUsuario.Location = new System.Drawing.Point(113, 50);
            this.cbbUsuario.Name = "cbbUsuario";
            this.cbbUsuario.Size = new System.Drawing.Size(265, 24);
            this.cbbUsuario.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(224, 187);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(154, 51);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(53, 187);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(154, 51);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(105, 132);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(273, 22);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(50, 135);
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
            // lblAlterarUsuario
            // 
            this.lblAlterarUsuario.AutoSize = true;
            this.lblAlterarUsuario.Location = new System.Drawing.Point(50, 96);
            this.lblAlterarUsuario.Name = "lblAlterarUsuario";
            this.lblAlterarUsuario.Size = new System.Drawing.Size(103, 17);
            this.lblAlterarUsuario.TabIndex = 6;
            this.lblAlterarUsuario.Text = "Alterar Usuario";
            // 
            // txtAlterarUsuario
            // 
            this.txtAlterarUsuario.Location = new System.Drawing.Point(159, 93);
            this.txtAlterarUsuario.Name = "txtAlterarUsuario";
            this.txtAlterarUsuario.Size = new System.Drawing.Size(219, 22);
            this.txtAlterarUsuario.TabIndex = 7;
            // 
            // FrmEditarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Automoveis_Forms.Properties.Resources.Allmatech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 295);
            this.Controls.Add(this.gpbAutenticar);
            this.Controls.Add(this.gpbEditarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Login";
            this.Load += new System.EventHandler(this.FrmEditarLogin_Load);
            this.gpbAutenticar.ResumeLayout(false);
            this.gpbAutenticar.PerformLayout();
            this.gpbEditarLogin.ResumeLayout(false);
            this.gpbEditarLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAutenticar;
        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.TextBox txtUsuarioAutenticado;
        private System.Windows.Forms.TextBox txtSenhaAutenticado;
        private System.Windows.Forms.Label lblSenhaAutenticado;
        private System.Windows.Forms.Label lblUsuarioAltenticado;
        private System.Windows.Forms.GroupBox gpbEditarLogin;
        private System.Windows.Forms.ComboBox cbbUsuario;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtAlterarUsuario;
        private System.Windows.Forms.Label lblAlterarUsuario;
    }
}