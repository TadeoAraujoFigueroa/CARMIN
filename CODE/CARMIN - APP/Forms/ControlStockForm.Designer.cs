namespace CARMIN___APP.Forms
{
    partial class ControlStockForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            subMainPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtFiltro = new ReaLTaiizor.Controls.MetroTextBox();
            panelInsumoSeleccionadoNew = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            txtStockNew = new ReaLTaiizor.Controls.CyberTextBox();
            label1 = new Label();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtNomNew = new ReaLTaiizor.Controls.CyberTextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnConfirmarNew = new ReaLTaiizor.Controls.CyberButton();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnBitacoraNew = new ReaLTaiizor.Controls.CyberButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            switchInsumoMod = new ReaLTaiizor.Controls.ParrotSwitch();
            panelDgvInsumos = new Panel();
            dgvInsumos = new DataGridView();
            logoBox = new PictureBox();
            mainPanelNew = new Panel();
            subMainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelInsumoSeleccionadoNew.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panelDgvInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            mainPanelNew.SuspendLayout();
            SuspendLayout();
            // 
            // subMainPanel
            // 
            subMainPanel.Controls.Add(tableLayoutPanel1);
            subMainPanel.Location = new Point(67, 75);
            subMainPanel.Name = "subMainPanel";
            subMainPanel.Size = new Size(1127, 744);
            subMainPanel.TabIndex = 32;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtFiltro, 0, 0);
            tableLayoutPanel1.Controls.Add(panelInsumoSeleccionadoNew, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 3);
            tableLayoutPanel1.Controls.Add(panelDgvInsumos, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1127, 744);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtFiltro
            // 
            txtFiltro.Anchor = AnchorStyles.None;
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
            txtFiltro.Location = new Point(436, 18);
            txtFiltro.MaxLength = 32767;
            txtFiltro.Multiline = false;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.ReadOnly = false;
            txtFiltro.Size = new Size(254, 37);
            txtFiltro.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txtFiltro.StyleManager = null;
            txtFiltro.TabIndex = 27;
            txtFiltro.Text = "BUSCAR INSUMO...";
            txtFiltro.TextAlign = HorizontalAlignment.Center;
            txtFiltro.ThemeAuthor = "Taiizor";
            txtFiltro.ThemeName = "MetroLight";
            txtFiltro.UseSystemPasswordChar = false;
            txtFiltro.WatermarkText = "";
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // panelInsumoSeleccionadoNew
            // 
            panelInsumoSeleccionadoNew.BackColor = Color.FromArgb(158, 24, 43);
            panelInsumoSeleccionadoNew.Controls.Add(tableLayoutPanel2);
            panelInsumoSeleccionadoNew.Dock = DockStyle.Fill;
            panelInsumoSeleccionadoNew.Location = new Point(3, 449);
            panelInsumoSeleccionadoNew.Name = "panelInsumoSeleccionadoNew";
            panelInsumoSeleccionadoNew.Size = new Size(1121, 142);
            panelInsumoSeleccionadoNew.TabIndex = 28;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new Size(1121, 142);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 1, 1);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Size = new Size(1115, 79);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Controls.Add(txtStockNew, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(560, 26);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(552, 50);
            tableLayoutPanel8.TabIndex = 33;
            // 
            // txtStockNew
            // 
            txtStockNew.Alpha = 20;
            txtStockNew.BackColor = Color.Transparent;
            txtStockNew.Background_WidthPen = 3F;
            txtStockNew.BackgroundPen = true;
            txtStockNew.ColorBackground = Color.White;
            txtStockNew.ColorBackground_Pen = Color.Silver;
            txtStockNew.ColorLighting = Color.FromArgb(29, 200, 238);
            txtStockNew.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtStockNew.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtStockNew.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtStockNew.Dock = DockStyle.Fill;
            txtStockNew.Font = new Font("Poppins", 11F);
            txtStockNew.ForeColor = Color.DarkGray;
            txtStockNew.Lighting = false;
            txtStockNew.LinearGradientPen = false;
            txtStockNew.Location = new Point(186, 2);
            txtStockNew.Margin = new Padding(2);
            txtStockNew.Name = "txtStockNew";
            txtStockNew.Padding = new Padding(15);
            txtStockNew.PenWidth = 15;
            txtStockNew.RGB = false;
            txtStockNew.Rounding = true;
            txtStockNew.RoundingInt = 60;
            txtStockNew.Size = new Size(180, 46);
            txtStockNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtStockNew.TabIndex = 18;
            txtStockNew.Tag = "Cyber";
            txtStockNew.TextButton = "";
            txtStockNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtStockNew.Timer_RGB = 300;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 248, 231);
            label1.Location = new Point(798, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 31;
            label1.Text = "STOCK";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 248, 231);
            label3.Location = new Point(181, 0);
            label3.Name = "label3";
            label3.Size = new Size(195, 23);
            label3.TabIndex = 13;
            label3.Text = "NOMBRE DE INSUMO";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(txtNomNew, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 26);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(551, 50);
            tableLayoutPanel4.TabIndex = 32;
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
            txtNomNew.Location = new Point(185, 2);
            txtNomNew.Margin = new Padding(2);
            txtNomNew.Name = "txtNomNew";
            txtNomNew.Padding = new Padding(15);
            txtNomNew.PenWidth = 15;
            txtNomNew.RGB = false;
            txtNomNew.Rounding = true;
            txtNomNew.RoundingInt = 60;
            txtNomNew.Size = new Size(179, 46);
            txtNomNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNomNew.TabIndex = 17;
            txtNomNew.Tag = "Cyber";
            txtNomNew.TextButton = "";
            txtNomNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNomNew.Timer_RGB = 300;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Controls.Add(btnConfirmarNew, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 88);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1115, 51);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // btnConfirmarNew
            // 
            btnConfirmarNew.Alpha = 20;
            btnConfirmarNew.BackColor = Color.Transparent;
            btnConfirmarNew.Background = true;
            btnConfirmarNew.Background_WidthPen = 4F;
            btnConfirmarNew.BackgroundPen = true;
            btnConfirmarNew.ColorBackground = Color.FromArgb(149, 187, 234);
            btnConfirmarNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnConfirmarNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnConfirmarNew.ColorBackground_Pen = Color.Black;
            btnConfirmarNew.ColorLighting = Color.FromArgb(29, 200, 238);
            btnConfirmarNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnConfirmarNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnConfirmarNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnConfirmarNew.Dock = DockStyle.Fill;
            btnConfirmarNew.Effect_1 = true;
            btnConfirmarNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnConfirmarNew.Effect_1_Transparency = 25;
            btnConfirmarNew.Effect_2 = true;
            btnConfirmarNew.Effect_2_ColorBackground = Color.White;
            btnConfirmarNew.Effect_2_Transparency = 20;
            btnConfirmarNew.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarNew.ForeColor = Color.Black;
            btnConfirmarNew.Lighting = false;
            btnConfirmarNew.LinearGradient_Background = false;
            btnConfirmarNew.LinearGradientPen = false;
            btnConfirmarNew.Location = new Point(373, 2);
            btnConfirmarNew.Margin = new Padding(2);
            btnConfirmarNew.Name = "btnConfirmarNew";
            btnConfirmarNew.Padding = new Padding(15);
            btnConfirmarNew.PenWidth = 15;
            btnConfirmarNew.Rounding = true;
            btnConfirmarNew.RoundingInt = 70;
            btnConfirmarNew.Size = new Size(367, 47);
            btnConfirmarNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirmarNew.TabIndex = 33;
            btnConfirmarNew.Tag = "Cyber";
            btnConfirmarNew.TextButton = "CONFIRMAR";
            btnConfirmarNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirmarNew.Timer_Effect_1 = 5;
            btnConfirmarNew.Timer_RGB = 300;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.Controls.Add(btnBitacoraNew, 2, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 597);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.Padding = new Padding(20);
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1121, 144);
            tableLayoutPanel7.TabIndex = 29;
            // 
            // btnBitacoraNew
            // 
            btnBitacoraNew.Alpha = 20;
            btnBitacoraNew.BackColor = Color.Transparent;
            btnBitacoraNew.Background = true;
            btnBitacoraNew.Background_WidthPen = 4F;
            btnBitacoraNew.BackgroundPen = true;
            btnBitacoraNew.ColorBackground = Color.FromArgb(158, 24, 43);
            btnBitacoraNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnBitacoraNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnBitacoraNew.ColorBackground_Pen = Color.Black;
            btnBitacoraNew.ColorLighting = Color.FromArgb(29, 200, 238);
            btnBitacoraNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnBitacoraNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnBitacoraNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnBitacoraNew.Dock = DockStyle.Fill;
            btnBitacoraNew.Effect_1 = true;
            btnBitacoraNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnBitacoraNew.Effect_1_Transparency = 25;
            btnBitacoraNew.Effect_2 = true;
            btnBitacoraNew.Effect_2_ColorBackground = Color.White;
            btnBitacoraNew.Effect_2_Transparency = 20;
            btnBitacoraNew.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBitacoraNew.ForeColor = Color.FromArgb(245, 245, 245);
            btnBitacoraNew.Lighting = false;
            btnBitacoraNew.LinearGradient_Background = false;
            btnBitacoraNew.LinearGradientPen = false;
            btnBitacoraNew.Location = new Point(742, 22);
            btnBitacoraNew.Margin = new Padding(2);
            btnBitacoraNew.Name = "btnBitacoraNew";
            btnBitacoraNew.Padding = new Padding(15);
            btnBitacoraNew.PenWidth = 15;
            btnBitacoraNew.Rounding = true;
            btnBitacoraNew.RoundingInt = 70;
            btnBitacoraNew.Size = new Size(357, 100);
            btnBitacoraNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBitacoraNew.TabIndex = 4;
            btnBitacoraNew.Tag = "Cyber";
            btnBitacoraNew.TextButton = "VER MOVIMIENTOS HISTÓRICOS";
            btnBitacoraNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBitacoraNew.Timer_Effect_1 = 5;
            btnBitacoraNew.Timer_RGB = 300;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(switchInsumoMod, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(23, 23);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(354, 98);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(158, 24, 43);
            label4.Location = new Point(21, 13);
            label4.Name = "label4";
            label4.Size = new Size(312, 23);
            label4.TabIndex = 29;
            label4.Text = "MOSTRAR INSUMOS CON MENOS DE 10 UNIDADES";
            // 
            // switchInsumoMod
            // 
            switchInsumoMod.Anchor = AnchorStyles.None;
            switchInsumoMod.BackColor = Color.FromArgb(255, 248, 231);
            switchInsumoMod.HandleOffColor = Color.FromArgb(255, 255, 255);
            switchInsumoMod.HandleOnColor = Color.FromArgb(255, 255, 255);
            switchInsumoMod.Location = new Point(147, 58);
            switchInsumoMod.Name = "switchInsumoMod";
            switchInsumoMod.OffColor = Color.FromArgb(255, 255, 255);
            switchInsumoMod.OnColor = Color.FromArgb(76, 217, 100);
            switchInsumoMod.Size = new Size(60, 30);
            switchInsumoMod.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.On;
            switchInsumoMod.SwitchStyle = ReaLTaiizor.Controls.ParrotSwitch.Style.iOS;
            switchInsumoMod.TabIndex = 28;
            switchInsumoMod.Text = "parrotSwitch1";
            // 
            // panelDgvInsumos
            // 
            panelDgvInsumos.BackColor = Color.FromArgb(158, 24, 43);
            panelDgvInsumos.Controls.Add(dgvInsumos);
            panelDgvInsumos.Dock = DockStyle.Fill;
            panelDgvInsumos.Location = new Point(3, 77);
            panelDgvInsumos.Name = "panelDgvInsumos";
            panelDgvInsumos.Padding = new Padding(10);
            panelDgvInsumos.Size = new Size(1121, 366);
            panelDgvInsumos.TabIndex = 30;
            // 
            // dgvInsumos
            // 
            dgvInsumos.AllowUserToAddRows = false;
            dgvInsumos.AllowUserToDeleteRows = false;
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInsumos.BackgroundColor = Color.FromArgb(158, 24, 43);
            dgvInsumos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInsumos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInsumos.Dock = DockStyle.Fill;
            dgvInsumos.GridColor = Color.IndianRed;
            dgvInsumos.Location = new Point(10, 10);
            dgvInsumos.MultiSelect = false;
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.ReadOnly = true;
            dgvInsumos.RowHeadersWidth = 51;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.Size = new Size(1101, 346);
            dgvInsumos.TabIndex = 33;
            dgvInsumos.CellClick += dgvInsumos_CellClick_1;
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.Transparent;
            logoBox.Location = new Point(1419, 55);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(81, 40);
            logoBox.TabIndex = 25;
            logoBox.TabStop = false;
            logoBox.Click += logoBox_Click;
            // 
            // mainPanelNew
            // 
            mainPanelNew.BackColor = Color.FromArgb(255, 248, 231);
            mainPanelNew.Controls.Add(logoBox);
            mainPanelNew.Controls.Add(subMainPanel);
            mainPanelNew.Location = new Point(48, 20);
            mainPanelNew.Name = "mainPanelNew";
            mainPanelNew.Size = new Size(1871, 949);
            mainPanelNew.TabIndex = 2;
            // 
            // ControlStockForm
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(158, 24, 43);
            ClientSize = new Size(1859, 884);
            Controls.Add(mainPanelNew);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ControlStockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControlStockForm";
            WindowState = FormWindowState.Maximized;
            Load += ControlStockForm_Load;
            Shown += ControlStockForm_Shown;
            subMainPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelInsumoSeleccionadoNew.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panelDgvInsumos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            mainPanelNew.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox logoBox;
        private ReaLTaiizor.Controls.MetroTextBox txtFiltro;
        private Label label1;
        private Label label3;
        private Panel subMainPanel;
        private Panel mainPanelNew;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelInsumoSeleccionadoNew;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel7;
        private ReaLTaiizor.Controls.CyberButton btnBitacoraNew;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private ReaLTaiizor.Controls.ParrotSwitch switchInsumoMod;
        private TableLayoutPanel tableLayoutPanel8;
        private ReaLTaiizor.Controls.CyberTextBox txtStockNew;
        private ReaLTaiizor.Controls.CyberTextBox txtNomNew;
        private TableLayoutPanel tableLayoutPanel6;
        private ReaLTaiizor.Controls.CyberButton btnConfirmarNew;
        private Panel panelDgvInsumos;
        private DataGridView dgvInsumos;
    }
}