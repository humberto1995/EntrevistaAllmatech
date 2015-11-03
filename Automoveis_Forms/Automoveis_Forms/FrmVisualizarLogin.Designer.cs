namespace Automoveis_Forms
{
    partial class FrmVisualizarLogin
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
            this.gpbVisualizarLogin = new System.Windows.Forms.GroupBox();
            this.dgvLogin = new System.Windows.Forms.DataGridView();
            this.cbbLogin = new System.Windows.Forms.ComboBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.gpbAutenticar = new System.Windows.Forms.GroupBox();
            this.btnAutenticar = new System.Windows.Forms.Button();
            this.txtUsuarioAutenticado = new System.Windows.Forms.TextBox();
            this.txtSenhaAutenticado = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gpbVisualizarLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            this.gpbAutenticar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbVisualizarLogin
            // 
            this.gpbVisualizarLogin.BackColor = System.Drawing.SystemColors.Control;
            this.gpbVisualizarLogin.Controls.Add(this.dgvLogin);
            this.gpbVisualizarLogin.Controls.Add(this.cbbLogin);
            this.gpbVisualizarLogin.Controls.Add(this.lblLogin);
            this.gpbVisualizarLogin.ForeColor = System.Drawing.Color.Red;
            this.gpbVisualizarLogin.Location = new System.Drawing.Point(516, 39);
            this.gpbVisualizarLogin.Name = "gpbVisualizarLogin";
            this.gpbVisualizarLogin.Size = new System.Drawing.Size(433, 342);
            this.gpbVisualizarLogin.TabIndex = 2;
            this.gpbVisualizarLogin.TabStop = false;
            this.gpbVisualizarLogin.Text = "Visualizar Login";
            // 
            // dgvLogin
            // 
            this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogin.Location = new System.Drawing.Point(40, 98);
            this.dgvLogin.Name = "dgvLogin";
            this.dgvLogin.RowTemplate.Height = 24;
            this.dgvLogin.Size = new System.Drawing.Size(360, 221);
            this.dgvLogin.TabIndex = 2;
            // 
            // cbbLogin
            // 
            this.cbbLogin.FormattingEnabled = true;
            this.cbbLogin.Items.AddRange(new object[] {
            "Todos os Login"});
            this.cbbLogin.Location = new System.Drawing.Point(93, 51);
            this.cbbLogin.Name = "cbbLogin";
            this.cbbLogin.Size = new System.Drawing.Size(307, 24);
            this.cbbLogin.TabIndex = 1;
            this.cbbLogin.SelectedIndexChanged += new System.EventHandler(this.cbbLoguin_SelectedIndexChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(37, 54);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
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
            this.gpbAutenticar.Location = new System.Drawing.Point(30, 93);
            this.gpbAutenticar.Name = "gpbAutenticar";
            this.gpbAutenticar.Size = new System.Drawing.Size(453, 212);
            this.gpbAutenticar.TabIndex = 12;
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
            // FrmVisualizarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Automoveis_Forms.Properties.Resources.Allmatech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 393);
            this.Controls.Add(this.gpbAutenticar);
            this.Controls.Add(this.gpbVisualizarLogin);
            this.Name = "FrmVisualizarLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Login";
            this.Load += new System.EventHandler(this.FrmVisualizarLogin_Load);
            this.gpbVisualizarLogin.ResumeLayout(false);
            this.gpbVisualizarLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            this.gpbAutenticar.ResumeLayout(false);
            this.gpbAutenticar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbVisualizarLogin;
        private System.Windows.Forms.DataGridView dgvLogin;
        private System.Windows.Forms.ComboBox cbbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox gpbAutenticar;
        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.TextBox txtUsuarioAutenticado;
        private System.Windows.Forms.TextBox txtSenhaAutenticado;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
    }
}