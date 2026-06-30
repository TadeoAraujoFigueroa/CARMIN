namespace CARMIN___APP.Forms
{
    partial class ClientesForm
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
            mainPanel = new Panel();
            panelAltaCliente = new Panel();
            panelCargaCliente = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCargarClienteNew = new ReaLTaiizor.Controls.CyberButton();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            txtDirNew = new ReaLTaiizor.Controls.CyberTextBox();
            txtTelNew = new ReaLTaiizor.Controls.CyberTextBox();
            txtNomNew = new ReaLTaiizor.Controls.CyberTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            logoBox = new PictureBox();
            mainPanel.SuspendLayout();
            panelAltaCliente.SuspendLayout();
            panelCargaCliente.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(255, 248, 231);
            mainPanel.Controls.Add(panelAltaCliente);
            mainPanel.Controls.Add(logoBox);
            mainPanel.Location = new Point(15, 15);
            mainPanel.Margin = new Padding(4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1802, 1002);
            mainPanel.TabIndex = 30;
            // 
            // panelAltaCliente
            // 
            panelAltaCliente.BackColor = Color.FromArgb(158, 24, 43);
            panelAltaCliente.Controls.Add(panelCargaCliente);
            panelAltaCliente.Location = new Point(45, 34);
            panelAltaCliente.Margin = new Padding(4);
            panelAltaCliente.Name = "panelAltaCliente";
            panelAltaCliente.Size = new Size(978, 778);
            panelAltaCliente.TabIndex = 30;
            // 
            // panelCargaCliente
            // 
            panelCargaCliente.BackColor = Color.FromArgb(255, 248, 231);
            panelCargaCliente.Controls.Add(tableLayoutPanel1);
            panelCargaCliente.Location = new Point(71, 68);
            panelCargaCliente.Margin = new Padding(4);
            panelCargaCliente.Name = "panelCargaCliente";
            panelCargaCliente.Size = new Size(820, 339);
            panelCargaCliente.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 248, 231);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnCargarClienteNew, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(820, 339);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // btnCargarClienteNew
            // 
            btnCargarClienteNew.Alpha = 20;
            btnCargarClienteNew.BackColor = Color.Transparent;
            btnCargarClienteNew.Background = true;
            btnCargarClienteNew.Background_WidthPen = 4F;
            btnCargarClienteNew.BackgroundPen = true;
            btnCargarClienteNew.ColorBackground = Color.FromArgb(158, 24, 43);
            btnCargarClienteNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCargarClienteNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCargarClienteNew.ColorBackground_Pen = Color.Black;
            btnCargarClienteNew.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCargarClienteNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCargarClienteNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCargarClienteNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCargarClienteNew.Dock = DockStyle.Fill;
            btnCargarClienteNew.Effect_1 = true;
            btnCargarClienteNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCargarClienteNew.Effect_1_Transparency = 25;
            btnCargarClienteNew.Effect_2 = true;
            btnCargarClienteNew.Effect_2_ColorBackground = Color.White;
            btnCargarClienteNew.Effect_2_Transparency = 20;
            btnCargarClienteNew.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarClienteNew.ForeColor = Color.FromArgb(245, 245, 245);
            btnCargarClienteNew.Lighting = false;
            btnCargarClienteNew.LinearGradient_Background = false;
            btnCargarClienteNew.LinearGradientPen = false;
            btnCargarClienteNew.Location = new Point(2, 272);
            btnCargarClienteNew.Margin = new Padding(2);
            btnCargarClienteNew.Name = "btnCargarClienteNew";
            btnCargarClienteNew.Padding = new Padding(15);
            btnCargarClienteNew.PenWidth = 15;
            btnCargarClienteNew.Rounding = true;
            btnCargarClienteNew.RoundingInt = 70;
            btnCargarClienteNew.Size = new Size(816, 65);
            btnCargarClienteNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCargarClienteNew.TabIndex = 3;
            btnCargarClienteNew.Tag = "Cyber";
            btnCargarClienteNew.TextButton = "CARGAR CLIENTE";
            btnCargarClienteNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCargarClienteNew.Timer_Effect_1 = 5;
            btnCargarClienteNew.Timer_RGB = 300;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(158, 24, 43);
            label6.Location = new Point(207, 1);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(406, 65);
            label6.TabIndex = 0;
            label6.Text = "CARGA DE CLIENTES";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 70);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Size = new Size(814, 197);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.Controls.Add(txtDirNew, 2, 1);
            tableLayoutPanel7.Controls.Add(txtTelNew, 1, 1);
            tableLayoutPanel7.Controls.Add(txtNomNew, 0, 1);
            tableLayoutPanel7.Controls.Add(label1, 2, 0);
            tableLayoutPanel7.Controls.Add(label2, 1, 0);
            tableLayoutPanel7.Controls.Add(label3, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 62);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.Size = new Size(808, 72);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // txtDirNew
            // 
            txtDirNew.Alpha = 20;
            txtDirNew.BackColor = Color.Transparent;
            txtDirNew.Background_WidthPen = 3F;
            txtDirNew.BackgroundPen = true;
            txtDirNew.ColorBackground = Color.White;
            txtDirNew.ColorBackground_Pen = Color.Silver;
            txtDirNew.ColorLighting = Color.FromArgb(29, 200, 238);
            txtDirNew.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtDirNew.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtDirNew.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtDirNew.Dock = DockStyle.Fill;
            txtDirNew.Font = new Font("Poppins", 11F);
            txtDirNew.ForeColor = Color.DarkGray;
            txtDirNew.Lighting = false;
            txtDirNew.LinearGradientPen = false;
            txtDirNew.Location = new Point(540, 23);
            txtDirNew.Margin = new Padding(2);
            txtDirNew.Name = "txtDirNew";
            txtDirNew.Padding = new Padding(15);
            txtDirNew.PenWidth = 15;
            txtDirNew.RGB = false;
            txtDirNew.Rounding = true;
            txtDirNew.RoundingInt = 60;
            txtDirNew.Size = new Size(266, 47);
            txtDirNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtDirNew.TabIndex = 22;
            txtDirNew.Tag = "txtDirNew";
            txtDirNew.TextButton = "Escribir aquí...";
            txtDirNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtDirNew.Timer_RGB = 300;
            // 
            // txtTelNew
            // 
            txtTelNew.Alpha = 20;
            txtTelNew.BackColor = Color.Transparent;
            txtTelNew.Background_WidthPen = 3F;
            txtTelNew.BackgroundPen = true;
            txtTelNew.ColorBackground = Color.White;
            txtTelNew.ColorBackground_Pen = Color.Silver;
            txtTelNew.ColorLighting = Color.FromArgb(29, 200, 238);
            txtTelNew.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtTelNew.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtTelNew.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtTelNew.Dock = DockStyle.Fill;
            txtTelNew.Font = new Font("Poppins", 11F);
            txtTelNew.ForeColor = Color.DarkGray;
            txtTelNew.Lighting = false;
            txtTelNew.LinearGradientPen = false;
            txtTelNew.Location = new Point(271, 23);
            txtTelNew.Margin = new Padding(2);
            txtTelNew.Name = "txtTelNew";
            txtTelNew.Padding = new Padding(15);
            txtTelNew.PenWidth = 15;
            txtTelNew.RGB = false;
            txtTelNew.Rounding = true;
            txtTelNew.RoundingInt = 60;
            txtTelNew.Size = new Size(265, 47);
            txtTelNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtTelNew.TabIndex = 21;
            txtTelNew.Tag = "txtTelNew";
            txtTelNew.TextButton = "Escribir aquí...";
            txtTelNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtTelNew.Timer_RGB = 300;
            // 
            // txtNomNew
            // 
            txtNomNew.Alpha = 20;
            txtNomNew.BackColor = Color.Transparent;
            txtNomNew.Background_WidthPen = 3F;
            txtNomNew.BackgroundPen = true;
            txtNomNew.ColorBackground = Color.White;
            txtNomNew.ColorBackground_Pen = Color.Silver;
            txtNomNew.ColorLighting = Color.FromArgb(29, 200, 238);
            txtNomNew.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtNomNew.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtNomNew.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNomNew.Dock = DockStyle.Fill;
            txtNomNew.Font = new Font("Poppins", 11F);
            txtNomNew.ForeColor = Color.DarkGray;
            txtNomNew.Lighting = false;
            txtNomNew.LinearGradientPen = false;
            txtNomNew.Location = new Point(2, 23);
            txtNomNew.Margin = new Padding(2);
            txtNomNew.Name = "txtNomNew";
            txtNomNew.Padding = new Padding(15);
            txtNomNew.PenWidth = 15;
            txtNomNew.RGB = false;
            txtNomNew.Rounding = true;
            txtNomNew.RoundingInt = 60;
            txtNomNew.Size = new Size(265, 47);
            txtNomNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNomNew.TabIndex = 20;
            txtNomNew.Tag = "txtNomNew";
            txtNomNew.TextButton = "Escribir aquí...";
            txtNomNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNomNew.Timer_RGB = 300;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(158, 24, 43);
            label1.Location = new Point(633, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 10;
            label1.Text = "DIRECCIÓN";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 24, 43);
            label2.Location = new Point(367, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 10;
            label2.Text = "TELÉFONO";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(158, 24, 43);
            label3.Location = new Point(103, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 10;
            label3.Text = "NOMBRE";
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.Transparent;
            logoBox.Location = new Point(1670, 34);
            logoBox.Margin = new Padding(4);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(81, 40);
            logoBox.TabIndex = 29;
            logoBox.TabStop = false;
            logoBox.Click += logoBox_Click;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(158, 24, 43);
            ClientSize = new Size(1942, 1025);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ClientesForm";
            Text = "ClientesForm";
            WindowState = FormWindowState.Maximized;
            Load += ClientesForm_Load;
            Shown += ClientesForm_Shown;
            mainPanel.ResumeLayout(false);
            panelAltaCliente.ResumeLayout(false);
            panelCargaCliente.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private PictureBox logoBox;
        private Panel panelAltaCliente;
        private Panel panelCargaCliente;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.CyberButton btnCargarClienteNew;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel7;
        private ReaLTaiizor.Controls.CyberTextBox txtDirNew;
        private ReaLTaiizor.Controls.CyberTextBox txtTelNew;
        private ReaLTaiizor.Controls.CyberTextBox txtNomNew;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}