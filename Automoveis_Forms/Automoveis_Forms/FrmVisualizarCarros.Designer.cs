namespace Automoveis_Forms
{
    partial class FrmVisualizarCarros
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
            this.gpbVisualizarCarros = new System.Windows.Forms.GroupBox();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.cbbCarros = new System.Windows.Forms.ComboBox();
            this.lblCarros = new System.Windows.Forms.Label();
            this.gpbVisualizarCarros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbVisualizarCarros
            // 
            this.gpbVisualizarCarros.BackColor = System.Drawing.SystemColors.Control;
            this.gpbVisualizarCarros.Controls.Add(this.dgvCarros);
            this.gpbVisualizarCarros.Controls.Add(this.cbbCarros);
            this.gpbVisualizarCarros.Controls.Add(this.lblCarros);
            this.gpbVisualizarCarros.ForeColor = System.Drawing.Color.Red;
            this.gpbVisualizarCarros.Location = new System.Drawing.Point(50, 34);
            this.gpbVisualizarCarros.Name = "gpbVisualizarCarros";
            this.gpbVisualizarCarros.Size = new System.Drawing.Size(854, 464);
            this.gpbVisualizarCarros.TabIndex = 0;
            this.gpbVisualizarCarros.TabStop = false;
            this.gpbVisualizarCarros.Text = "Visualizar Carros";
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.GridColor = System.Drawing.Color.DarkGray;
            this.dgvCarros.Location = new System.Drawing.Point(40, 98);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.RowTemplate.Height = 24;
            this.dgvCarros.Size = new System.Drawing.Size(773, 336);
            this.dgvCarros.TabIndex = 2;
            // 
            // cbbCarros
            // 
            this.cbbCarros.FormattingEnabled = true;
            this.cbbCarros.Location = new System.Drawing.Point(93, 51);
            this.cbbCarros.Name = "cbbCarros";
            this.cbbCarros.Size = new System.Drawing.Size(720, 24);
            this.cbbCarros.TabIndex = 1;
            this.cbbCarros.SelectedIndexChanged += new System.EventHandler(this.cbbCarros_SelectedIndexChanged);
            // 
            // lblCarros
            // 
            this.lblCarros.AutoSize = true;
            this.lblCarros.Location = new System.Drawing.Point(37, 54);
            this.lblCarros.Name = "lblCarros";
            this.lblCarros.Size = new System.Drawing.Size(50, 17);
            this.lblCarros.TabIndex = 0;
            this.lblCarros.Text = "Carros";
            // 
            // FrmVisualizarCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Automoveis_Forms.Properties.Resources.Allmatech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 510);
            this.Controls.Add(this.gpbVisualizarCarros);
            this.Name = "FrmVisualizarCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Carros";
            this.Load += new System.EventHandler(this.FrmVisualizarCarros_Load);
            this.gpbVisualizarCarros.ResumeLayout(false);
            this.gpbVisualizarCarros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbVisualizarCarros;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.ComboBox cbbCarros;
        private System.Windows.Forms.Label lblCarros;
    }
}