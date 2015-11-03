namespace Automoveis_Forms
{
    partial class FrmVisualizarMarcas
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
            this.gpbVisualizarMarcas = new System.Windows.Forms.GroupBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.cbbMarcas = new System.Windows.Forms.ComboBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.gpbVisualizarMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbVisualizarMarcas
            // 
            this.gpbVisualizarMarcas.BackColor = System.Drawing.SystemColors.Control;
            this.gpbVisualizarMarcas.Controls.Add(this.dgvMarcas);
            this.gpbVisualizarMarcas.Controls.Add(this.cbbMarcas);
            this.gpbVisualizarMarcas.Controls.Add(this.lblMarcas);
            this.gpbVisualizarMarcas.ForeColor = System.Drawing.Color.Red;
            this.gpbVisualizarMarcas.Location = new System.Drawing.Point(61, 26);
            this.gpbVisualizarMarcas.Name = "gpbVisualizarMarcas";
            this.gpbVisualizarMarcas.Size = new System.Drawing.Size(423, 307);
            this.gpbVisualizarMarcas.TabIndex = 1;
            this.gpbVisualizarMarcas.TabStop = false;
            this.gpbVisualizarMarcas.Text = "Visualizar Marcas";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(40, 98);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.Size = new System.Drawing.Size(354, 183);
            this.dgvMarcas.TabIndex = 2;
            // 
            // cbbMarcas
            // 
            this.cbbMarcas.FormattingEnabled = true;
            this.cbbMarcas.Items.AddRange(new object[] {
            "Todas as Marcas"});
            this.cbbMarcas.Location = new System.Drawing.Point(93, 51);
            this.cbbMarcas.Name = "cbbMarcas";
            this.cbbMarcas.Size = new System.Drawing.Size(301, 24);
            this.cbbMarcas.TabIndex = 1;
            this.cbbMarcas.SelectedIndexChanged += new System.EventHandler(this.cbbMarcas_SelectedIndexChanged);
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(37, 54);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(54, 17);
            this.lblMarcas.TabIndex = 0;
            this.lblMarcas.Text = "Marcas";
            // 
            // FrmVisualizarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Automoveis_Forms.Properties.Resources.Allmatech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 358);
            this.Controls.Add(this.gpbVisualizarMarcas);
            this.Name = "FrmVisualizarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Marcas";
            this.gpbVisualizarMarcas.ResumeLayout(false);
            this.gpbVisualizarMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbVisualizarMarcas;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.ComboBox cbbMarcas;
        private System.Windows.Forms.Label lblMarcas;
    }
}