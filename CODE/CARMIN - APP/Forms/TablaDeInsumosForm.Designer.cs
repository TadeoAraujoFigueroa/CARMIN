namespace CARMIN___APP.Forms
{
    partial class TablaDeInsumosForm
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
            dgvInsumos = new DataGridView();
            txtFiltro = new ReaLTaiizor.Controls.MetroTextBox();
            logoBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // dgvInsumos
            // 
            dgvInsumos.AllowUserToAddRows = false;
            dgvInsumos.AllowUserToDeleteRows = false;
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInsumos.BackgroundColor = Color.FromArgb(158, 24, 43);
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Location = new Point(151, 88);
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.ReadOnly = true;
            dgvInsumos.RowHeadersWidth = 51;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.Size = new Size(827, 440);
            dgvInsumos.TabIndex = 0;
            dgvInsumos.CellContentDoubleClick += dgvInsumos_CellContentDoubleClick_1;
            // 
            // txtFiltro
            // 
            txtFiltro.AutoCompleteCustomSource = null;
            txtFiltro.AutoCompleteMode = AutoCompleteMode.None;
            txtFiltro.AutoCompleteSource = AutoCompleteSource.None;
            txtFiltro.BorderColor = Color.FromArgb(155, 155, 155);
            txtFiltro.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtFiltro.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtFiltro.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtFiltro.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltro.HoverColor = Color.FromArgb(102, 102, 102);
            txtFiltro.Image = null;
            txtFiltro.IsDerivedStyle = true;
            txtFiltro.Lines = null;
            txtFiltro.Location = new Point(437, 27);
            txtFiltro.MaxLength = 32767;
            txtFiltro.Multiline = false;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.ReadOnly = false;
            txtFiltro.Size = new Size(254, 37);
            txtFiltro.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txtFiltro.StyleManager = null;
            txtFiltro.TabIndex = 5;
            txtFiltro.Text = "Buscar insumo...";
            txtFiltro.TextAlign = HorizontalAlignment.Center;
            txtFiltro.ThemeAuthor = "Taiizor";
            txtFiltro.ThemeName = "MetroLight";
            txtFiltro.UseSystemPasswordChar = false;
            txtFiltro.WatermarkText = "";
            txtFiltro.TextChanged += metroTextBox1_TextChanged;
            // 
            // logoBox
            // 
            logoBox.Location = new Point(1062, 4);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(65, 32);
            logoBox.TabIndex = 6;
            logoBox.TabStop = false;
            logoBox.Click += logoBox_Click;
            // 
            // TablaDeInsumosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 231);
            ClientSize = new Size(1129, 616);
            Controls.Add(logoBox);
            Controls.Add(txtFiltro);
            Controls.Add(dgvInsumos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TablaDeInsumosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TablaDeInsumosForm";
            Load += TablaDeInsumosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInsumos;
        private ReaLTaiizor.Controls.MetroTextBox txtFiltro;
        private PictureBox logoBox;
    }
}