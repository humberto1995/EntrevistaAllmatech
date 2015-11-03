namespace Automoveis_Forms
{
    partial class FrmCadastroMarcas
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gpbCadastroMarcas = new System.Windows.Forms.GroupBox();
            this.gpbCadastroMarcas.SuspendLayout();
            this.SuspendLayout();
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
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(75, 48);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(594, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(25, 101);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(644, 68);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // gpbCadastroMarcas
            // 
            this.gpbCadastroMarcas.BackColor = System.Drawing.SystemColors.Control;
            this.gpbCadastroMarcas.Controls.Add(this.btnAdicionar);
            this.gpbCadastroMarcas.Controls.Add(this.txtMarca);
            this.gpbCadastroMarcas.Controls.Add(this.lblMarca);
            this.gpbCadastroMarcas.ForeColor = System.Drawing.Color.Red;
            this.gpbCadastroMarcas.Location = new System.Drawing.Point(21, 22);
            this.gpbCadastroMarcas.Name = "gpbCadastroMarcas";
            this.gpbCadastroMarcas.Size = new System.Drawing.Size(702, 204);
            this.gpbCadastroMarcas.TabIndex = 8;
            this.gpbCadastroMarcas.TabStop = false;
            this.gpbCadastroMarcas.Text = "Cadastro de Marcas";
            this.gpbCadastroMarcas.Enter += new System.EventHandler(this.gpbCadastroMarcas_Enter);
            // 
            // FrmCadastroMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Automoveis_Forms.Properties.Resources.Allmatech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 253);
            this.Controls.Add(this.gpbCadastroMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Marcas";
            this.gpbCadastroMarcas.ResumeLayout(false);
            this.gpbCadastroMarcas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox gpbCadastroMarcas;
    }
}