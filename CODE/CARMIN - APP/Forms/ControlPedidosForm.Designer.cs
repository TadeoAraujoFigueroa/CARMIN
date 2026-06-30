namespace CARMIN___APP.Forms
{
    partial class ControlPedidosForm
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
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel = new TableLayoutPanel();
            panel1 = new Panel();
            calendario = new TableLayoutPanel();
            panelEstadoPedidoExt = new Panel();
            panelEstadoPedidoInt = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnModificarPedidoNew = new ReaLTaiizor.Controls.CyberButton();
            btnEliminarPedidoNew = new ReaLTaiizor.Controls.CyberButton();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            comboPago = new ReaLTaiizor.Controls.ComboBoxEdit();
            label10 = new Label();
            comboEstado = new ReaLTaiizor.Controls.ComboBoxEdit();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtTiempoDeProduccionNew = new ReaLTaiizor.Controls.CyberTextBox();
            txtImporteNew = new ReaLTaiizor.Controls.CyberTextBox();
            txtFechaEntregaNew = new ReaLTaiizor.Controls.CyberTextBox();
            txtNomClienteNew = new ReaLTaiizor.Controls.CyberTextBox();
            txtNomPedidoNew = new ReaLTaiizor.Controls.CyberTextBox();
            label4 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            logoBox = new PictureBox();
            toolTip1 = new ToolTip(components);
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panelEstadoPedidoExt.SuspendLayout();
            panelEstadoPedidoInt.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(255, 248, 231);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(tableLayoutPanel);
            mainPanel.Controls.Add(logoBox);
            mainPanel.Location = new Point(13, 13);
            mainPanel.Margin = new Padding(4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(2318, 1015);
            mainPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2175, 19);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 40);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(panel1, 0, 0);
            tableLayoutPanel.Controls.Add(panelEstadoPedidoExt, 1, 0);
            tableLayoutPanel.Location = new Point(34, 83);
            tableLayoutPanel.Margin = new Padding(4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 875F));
            tableLayoutPanel.Size = new Size(1750, 792);
            tableLayoutPanel.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(calendario);
            panel1.Location = new Point(35, 45);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 701);
            panel1.TabIndex = 31;
            // 
            // calendario
            // 
            calendario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calendario.ColumnCount = 7;
            calendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            calendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            calendario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            calendario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 146F));
            calendario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            calendario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            calendario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            calendario.Location = new Point(0, 0);
            calendario.Margin = new Padding(4);
            calendario.Name = "calendario";
            calendario.RowCount = 6;
            calendario.RowStyles.Add(new RowStyle(SizeType.Percent, 42.46575F));
            calendario.RowStyles.Add(new RowStyle(SizeType.Percent, 57.53425F));
            calendario.RowStyles.Add(new RowStyle(SizeType.Absolute, 254F));
            calendario.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            calendario.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            calendario.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            calendario.Size = new Size(804, 701);
            calendario.TabIndex = 30;
            // 
            // panelEstadoPedidoExt
            // 
            panelEstadoPedidoExt.BackColor = Color.FromArgb(158, 24, 43);
            panelEstadoPedidoExt.Controls.Add(panelEstadoPedidoInt);
            panelEstadoPedidoExt.Dock = DockStyle.Fill;
            panelEstadoPedidoExt.Location = new Point(879, 4);
            panelEstadoPedidoExt.Margin = new Padding(4);
            panelEstadoPedidoExt.Name = "panelEstadoPedidoExt";
            panelEstadoPedidoExt.Padding = new Padding(50);
            panelEstadoPedidoExt.Size = new Size(867, 784);
            panelEstadoPedidoExt.TabIndex = 29;
            panelEstadoPedidoExt.Paint += panelEstadoPedidoExt_Paint;
            // 
            // panelEstadoPedidoInt
            // 
            panelEstadoPedidoInt.BackColor = Color.FromArgb(255, 248, 231);
            panelEstadoPedidoInt.Controls.Add(tableLayoutPanel1);
            panelEstadoPedidoInt.Dock = DockStyle.Fill;
            panelEstadoPedidoInt.Location = new Point(50, 50);
            panelEstadoPedidoInt.Margin = new Padding(4);
            panelEstadoPedidoInt.Name = "panelEstadoPedidoInt";
            panelEstadoPedidoInt.Size = new Size(767, 684);
            panelEstadoPedidoInt.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(bigLabel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(767, 684);
            tableLayoutPanel1.TabIndex = 40;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnModificarPedidoNew, 1, 0);
            tableLayoutPanel3.Controls.Add(btnEliminarPedidoNew, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 619);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(759, 61);
            tableLayoutPanel3.TabIndex = 41;
            // 
            // btnModificarPedidoNew
            // 
            btnModificarPedidoNew.Alpha = 20;
            btnModificarPedidoNew.BackColor = Color.Transparent;
            btnModificarPedidoNew.Background = true;
            btnModificarPedidoNew.Background_WidthPen = 4F;
            btnModificarPedidoNew.BackgroundPen = true;
            btnModificarPedidoNew.ColorBackground = Color.FromArgb(158, 24, 43);
            btnModificarPedidoNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnModificarPedidoNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnModificarPedidoNew.ColorBackground_Pen = Color.Black;
            btnModificarPedidoNew.ColorLighting = Color.FromArgb(29, 200, 238);
            btnModificarPedidoNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnModificarPedidoNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnModificarPedidoNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnModificarPedidoNew.Dock = DockStyle.Fill;
            btnModificarPedidoNew.Effect_1 = true;
            btnModificarPedidoNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnModificarPedidoNew.Effect_1_Transparency = 25;
            btnModificarPedidoNew.Effect_2 = true;
            btnModificarPedidoNew.Effect_2_ColorBackground = Color.White;
            btnModificarPedidoNew.Effect_2_Transparency = 20;
            btnModificarPedidoNew.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarPedidoNew.ForeColor = Color.FromArgb(245, 245, 245);
            btnModificarPedidoNew.Lighting = false;
            btnModificarPedidoNew.LinearGradient_Background = false;
            btnModificarPedidoNew.LinearGradientPen = false;
            btnModificarPedidoNew.Location = new Point(381, 2);
            btnModificarPedidoNew.Margin = new Padding(2);
            btnModificarPedidoNew.Name = "btnModificarPedidoNew";
            btnModificarPedidoNew.Padding = new Padding(15);
            btnModificarPedidoNew.PenWidth = 15;
            btnModificarPedidoNew.Rounding = true;
            btnModificarPedidoNew.RoundingInt = 70;
            btnModificarPedidoNew.Size = new Size(376, 57);
            btnModificarPedidoNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnModificarPedidoNew.TabIndex = 33;
            btnModificarPedidoNew.Tag = "Cyber";
            btnModificarPedidoNew.TextButton = "MODIFICAR";
            btnModificarPedidoNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnModificarPedidoNew.Timer_Effect_1 = 5;
            btnModificarPedidoNew.Timer_RGB = 300;
            // 
            // btnEliminarPedidoNew
            // 
            btnEliminarPedidoNew.Alpha = 20;
            btnEliminarPedidoNew.BackColor = Color.Transparent;
            btnEliminarPedidoNew.Background = true;
            btnEliminarPedidoNew.Background_WidthPen = 4F;
            btnEliminarPedidoNew.BackgroundPen = true;
            btnEliminarPedidoNew.ColorBackground = Color.FromArgb(158, 24, 43);
            btnEliminarPedidoNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnEliminarPedidoNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnEliminarPedidoNew.ColorBackground_Pen = Color.Black;
            btnEliminarPedidoNew.ColorLighting = Color.FromArgb(29, 200, 238);
            btnEliminarPedidoNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnEliminarPedidoNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnEliminarPedidoNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEliminarPedidoNew.Dock = DockStyle.Fill;
            btnEliminarPedidoNew.Effect_1 = true;
            btnEliminarPedidoNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnEliminarPedidoNew.Effect_1_Transparency = 25;
            btnEliminarPedidoNew.Effect_2 = true;
            btnEliminarPedidoNew.Effect_2_ColorBackground = Color.White;
            btnEliminarPedidoNew.Effect_2_Transparency = 20;
            btnEliminarPedidoNew.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPedidoNew.ForeColor = Color.FromArgb(245, 245, 245);
            btnEliminarPedidoNew.Lighting = false;
            btnEliminarPedidoNew.LinearGradient_Background = false;
            btnEliminarPedidoNew.LinearGradientPen = false;
            btnEliminarPedidoNew.Location = new Point(2, 2);
            btnEliminarPedidoNew.Margin = new Padding(2);
            btnEliminarPedidoNew.Name = "btnEliminarPedidoNew";
            btnEliminarPedidoNew.Padding = new Padding(15);
            btnEliminarPedidoNew.PenWidth = 15;
            btnEliminarPedidoNew.Rounding = true;
            btnEliminarPedidoNew.RoundingInt = 70;
            btnEliminarPedidoNew.Size = new Size(375, 57);
            btnEliminarPedidoNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEliminarPedidoNew.TabIndex = 32;
            btnEliminarPedidoNew.Tag = "Cyber";
            btnEliminarPedidoNew.TextButton = "ELIMINAR";
            btnEliminarPedidoNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEliminarPedidoNew.Timer_Effect_1 = 5;
            btnEliminarPedidoNew.Timer_RGB = 300;
            // 
            // bigLabel2
            // 
            bigLabel2.Anchor = AnchorStyles.None;
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.FlatStyle = FlatStyle.Popup;
            bigLabel2.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.FromArgb(158, 24, 43);
            bigLabel2.Location = new Point(223, 7);
            bigLabel2.Margin = new Padding(4, 0, 4, 0);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(321, 53);
            bigLabel2.TabIndex = 39;
            bigLabel2.Text = "DETALLE DEL PEDIDO";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Location = new Point(172, 105);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(422, 472);
            tableLayoutPanel2.TabIndex = 40;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label5, 0, 2);
            tableLayoutPanel4.Controls.Add(comboPago, 0, 3);
            tableLayoutPanel4.Controls.Add(label10, 0, 0);
            tableLayoutPanel4.Controls.Add(comboEstado, 0, 1);
            tableLayoutPanel4.Location = new Point(215, 99);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.Size = new Size(202, 274);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(158, 24, 43);
            label5.Location = new Point(41, 151);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 41;
            label5.Text = "ESTADO DE PAGO";
            // 
            // comboPago
            // 
            comboPago.Anchor = AnchorStyles.None;
            comboPago.BackColor = Color.FromArgb(246, 246, 246);
            comboPago.DrawMode = DrawMode.OwnerDrawFixed;
            comboPago.DropDownHeight = 100;
            comboPago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPago.Font = new Font("Segoe UI", 10F);
            comboPago.ForeColor = Color.FromArgb(142, 142, 142);
            comboPago.FormattingEnabled = true;
            comboPago.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            comboPago.IntegralHeight = false;
            comboPago.ItemHeight = 20;
            comboPago.Location = new Point(4, 219);
            comboPago.Margin = new Padding(4);
            comboPago.Name = "comboPago";
            comboPago.Size = new Size(194, 26);
            comboPago.StartIndex = 0;
            comboPago.TabIndex = 43;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(158, 24, 43);
            label10.Location = new Point(71, 15);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 23);
            label10.TabIndex = 40;
            label10.Text = "ESTADO";
            // 
            // comboEstado
            // 
            comboEstado.Anchor = AnchorStyles.None;
            comboEstado.BackColor = Color.FromArgb(246, 246, 246);
            comboEstado.DrawMode = DrawMode.OwnerDrawFixed;
            comboEstado.DropDownHeight = 100;
            comboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstado.Font = new Font("Segoe UI", 10F);
            comboEstado.ForeColor = Color.FromArgb(142, 142, 142);
            comboEstado.FormattingEnabled = true;
            comboEstado.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            comboEstado.IntegralHeight = false;
            comboEstado.ItemHeight = 20;
            comboEstado.Location = new Point(4, 82);
            comboEstado.Margin = new Padding(4);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(194, 26);
            comboEstado.StartIndex = 0;
            comboEstado.TabIndex = 42;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(txtTiempoDeProduccionNew, 0, 9);
            tableLayoutPanel5.Controls.Add(txtImporteNew, 0, 7);
            tableLayoutPanel5.Controls.Add(txtFechaEntregaNew, 0, 5);
            tableLayoutPanel5.Controls.Add(txtNomClienteNew, 0, 3);
            tableLayoutPanel5.Controls.Add(txtNomPedidoNew, 0, 1);
            tableLayoutPanel5.Controls.Add(label4, 0, 8);
            tableLayoutPanel5.Controls.Add(label9, 0, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 6);
            tableLayoutPanel5.Controls.Add(label2, 0, 4);
            tableLayoutPanel5.Controls.Add(label1, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(4, 4);
            tableLayoutPanel5.Margin = new Padding(4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 10;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 7.070707F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1313133F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 7.070707F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1313133F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 7.070707F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1313133F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 7.070707F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1313133F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 7.070707F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.121212F));
            tableLayoutPanel5.Size = new Size(203, 464);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // txtTiempoDeProduccionNew
            // 
            txtTiempoDeProduccionNew.Alpha = 20;
            txtTiempoDeProduccionNew.BackColor = Color.Transparent;
            txtTiempoDeProduccionNew.Background_WidthPen = 3F;
            txtTiempoDeProduccionNew.BackgroundPen = true;
            txtTiempoDeProduccionNew.ColorBackground = Color.White;
            txtTiempoDeProduccionNew.ColorBackground_Pen = Color.Silver;
            txtTiempoDeProduccionNew.ColorLighting = Color.FromArgb(29, 200, 238);
            txtTiempoDeProduccionNew.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtTiempoDeProduccionNew.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtTiempoDeProduccionNew.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtTiempoDeProduccionNew.Dock = DockStyle.Fill;
            txtTiempoDeProduccionNew.Enabled = false;
            txtTiempoDeProduccionNew.Font = new Font("Poppins", 15F);
            txtTiempoDeProduccionNew.ForeColor = Color.DarkGray;
            txtTiempoDeProduccionNew.Lighting = false;
            txtTiempoDeProduccionNew.LinearGradientPen = false;
            txtTiempoDeProduccionNew.Location = new Point(2, 402);
            txtTiempoDeProduccionNew.Margin = new Padding(2);
            txtTiempoDeProduccionNew.Name = "txtTiempoDeProduccionNew";
            txtTiempoDeProduccionNew.Padding = new Padding(15);
            txtTiempoDeProduccionNew.PenWidth = 15;
            txtTiempoDeProduccionNew.RGB = false;
            txtTiempoDeProduccionNew.Rounding = true;
            txtTiempoDeProduccionNew.RoundingInt = 60;
            txtTiempoDeProduccionNew.Size = new Size(199, 60);
            txtTiempoDeProduccionNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtTiempoDeProduccionNew.TabIndex = 46;
            txtTiempoDeProduccionNew.Tag = "Cyber";
            txtTiempoDeProduccionNew.TextButton = "";
            txtTiempoDeProduccionNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtTiempoDeProduccionNew.Timer_RGB = 300;
            // 
            // txtImporteNew
            // 
            txtImporteNew.Alpha = 20;
            txtImporteNew.BackColor = Color.Transparent;
            txtImporteNew.Background_WidthPen = 3F;
            txtImporteNew.BackgroundPen = true;
            txtImporteNew.ColorBackground = Color.White;
            txtImporteNew.ColorBackground_Pen = Color.Silver;
            txtImporteNew.ColorLighting = Color.FromArgb(29, 200, 238);
            txtImporteNew.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtImporteNew.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtImporteNew.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtImporteNew.Dock = DockStyle.Fill;
            txtImporteNew.Enabled = false;
            txtImporteNew.Font = new Font("Poppins", 14F);
            txtImporteNew.ForeColor = Color.DarkGray;
            txtImporteNew.Lighting = false;
            txtImporteNew.LinearGradientPen = false;
            txtImporteNew.Location = new Point(2, 310);
            txtImporteNew.Margin = new Padding(2);
            txtImporteNew.Name = "txtImporteNew";
            txtImporteNew.Padding = new Padding(38);
            txtImporteNew.PenWidth = 15;
            txtImporteNew.RGB = false;
            txtImporteNew.Rounding = true;
            txtImporteNew.RoundingInt = 60;
            txtImporteNew.Size = new Size(199, 56);
            txtImporteNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtImporteNew.TabIndex = 45;
            txtImporteNew.Tag = "Cyber";
            txtImporteNew.TextButton = "";
            txtImporteNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtImporteNew.Timer_RGB = 300;
            // 
            // txtFechaEntregaNew
            // 
            txtFechaEntregaNew.Alpha = 20;
            txtFechaEntregaNew.BackColor = Color.Transparent;
            txtFechaEntregaNew.Background_WidthPen = 3F;
            txtFechaEntregaNew.BackgroundPen = true;
            txtFechaEntregaNew.ColorBackground = Color.White;
            txtFechaEntregaNew.ColorBackground_Pen = Color.Silver;
            txtFechaEntregaNew.ColorLighting = Color.FromArgb(29, 200, 238);
            txtFechaEntregaNew.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtFechaEntregaNew.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtFechaEntregaNew.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtFechaEntregaNew.Dock = DockStyle.Fill;
            txtFechaEntregaNew.Enabled = false;
            txtFechaEntregaNew.Font = new Font("Poppins", 14F);
            txtFechaEntregaNew.ForeColor = Color.DarkGray;
            txtFechaEntregaNew.Lighting = false;
            txtFechaEntregaNew.LinearGradientPen = false;
            txtFechaEntregaNew.Location = new Point(2, 218);
            txtFechaEntregaNew.Margin = new Padding(2);
            txtFechaEntregaNew.Name = "txtFechaEntregaNew";
            txtFechaEntregaNew.Padding = new Padding(2);
            txtFechaEntregaNew.PenWidth = 15;
            txtFechaEntregaNew.RGB = false;
            txtFechaEntregaNew.Rounding = true;
            txtFechaEntregaNew.RoundingInt = 60;
            txtFechaEntregaNew.Size = new Size(199, 56);
            txtFechaEntregaNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtFechaEntregaNew.TabIndex = 44;
            txtFechaEntregaNew.Tag = "Cyber";
            txtFechaEntregaNew.TextButton = "";
            txtFechaEntregaNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtFechaEntregaNew.Timer_RGB = 300;
            // 
            // txtNomClienteNew
            // 
            txtNomClienteNew.Alpha = 20;
            txtNomClienteNew.BackColor = Color.Transparent;
            txtNomClienteNew.Background_WidthPen = 3F;
            txtNomClienteNew.BackgroundPen = true;
            txtNomClienteNew.ColorBackground = Color.White;
            txtNomClienteNew.ColorBackground_Pen = Color.Silver;
            txtNomClienteNew.ColorLighting = Color.FromArgb(29, 200, 238);
            txtNomClienteNew.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtNomClienteNew.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtNomClienteNew.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNomClienteNew.Dock = DockStyle.Fill;
            txtNomClienteNew.Enabled = false;
            txtNomClienteNew.Font = new Font("Poppins", 14F);
            txtNomClienteNew.ForeColor = Color.DarkGray;
            txtNomClienteNew.Lighting = false;
            txtNomClienteNew.LinearGradientPen = false;
            txtNomClienteNew.Location = new Point(2, 126);
            txtNomClienteNew.Margin = new Padding(2);
            txtNomClienteNew.Name = "txtNomClienteNew";
            txtNomClienteNew.Padding = new Padding(2);
            txtNomClienteNew.PenWidth = 15;
            txtNomClienteNew.RGB = false;
            txtNomClienteNew.Rounding = true;
            txtNomClienteNew.RoundingInt = 60;
            txtNomClienteNew.Size = new Size(199, 56);
            txtNomClienteNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNomClienteNew.TabIndex = 43;
            txtNomClienteNew.Tag = "Cyber";
            txtNomClienteNew.TextButton = "";
            txtNomClienteNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNomClienteNew.Timer_RGB = 300;
            // 
            // txtNomPedidoNew
            // 
            txtNomPedidoNew.Alpha = 20;
            txtNomPedidoNew.BackColor = Color.Transparent;
            txtNomPedidoNew.Background_WidthPen = 3F;
            txtNomPedidoNew.BackgroundPen = true;
            txtNomPedidoNew.ColorBackground = Color.White;
            txtNomPedidoNew.ColorBackground_Pen = Color.Silver;
            txtNomPedidoNew.ColorLighting = Color.FromArgb(29, 200, 238);
            txtNomPedidoNew.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtNomPedidoNew.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtNomPedidoNew.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNomPedidoNew.Dock = DockStyle.Fill;
            txtNomPedidoNew.Enabled = false;
            txtNomPedidoNew.Font = new Font("Poppins", 14F);
            txtNomPedidoNew.ForeColor = Color.DarkGray;
            txtNomPedidoNew.Lighting = false;
            txtNomPedidoNew.LinearGradientPen = false;
            txtNomPedidoNew.Location = new Point(2, 34);
            txtNomPedidoNew.Margin = new Padding(2);
            txtNomPedidoNew.Name = "txtNomPedidoNew";
            txtNomPedidoNew.Padding = new Padding(2);
            txtNomPedidoNew.PenWidth = 15;
            txtNomPedidoNew.RGB = false;
            txtNomPedidoNew.Rounding = true;
            txtNomPedidoNew.RoundingInt = 60;
            txtNomPedidoNew.Size = new Size(199, 56);
            txtNomPedidoNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNomPedidoNew.TabIndex = 42;
            txtNomPedidoNew.Tag = "Cyber";
            txtNomPedidoNew.TextButton = "";
            txtNomPedidoNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNomPedidoNew.Timer_RGB = 300;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(158, 24, 43);
            label4.Location = new Point(19, 372);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 23);
            label4.TabIndex = 41;
            label4.Text = "TIEMPO DE PRODUCCIÓN";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(158, 24, 43);
            label9.Location = new Point(70, 4);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 23);
            label9.TabIndex = 40;
            label9.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(158, 24, 43);
            label3.Location = new Point(69, 280);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 41;
            label3.Text = "IMPORTE";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 24, 43);
            label2.Location = new Point(36, 188);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 41;
            label2.Text = "FECHA DE ENTREGA";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(158, 24, 43);
            label1.Location = new Point(72, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 41;
            label1.Text = "CLIENTE";
            // 
            // logoBox
            // 
            logoBox.Location = new Point(1366, 19);
            logoBox.Margin = new Padding(4);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(81, 40);
            logoBox.TabIndex = 26;
            logoBox.TabStop = false;
            logoBox.Click += logoBox_Click;
            // 
            // ControlPedidosForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(158, 24, 43);
            ClientSize = new Size(1853, 884);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ControlPedidosForm";
            Text = "ControlPedidosForm";
            WindowState = FormWindowState.Maximized;
            Load += ControlPedidosForm_Load;
            Shown += ControlPedidosForm_Shown;
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelEstadoPedidoExt.ResumeLayout(false);
            panelEstadoPedidoInt.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private PictureBox logoBox;
        private Panel panelEstadoPedidoExt;
        private Panel panelEstadoPedidoInt;
        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private TableLayoutPanel tableLayoutPanel;
        private TableLayoutPanel calendario;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberButton btnModificarPedidoNew;
        private ReaLTaiizor.Controls.CyberButton btnEliminarPedidoNew;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private ReaLTaiizor.Controls.ComboBoxEdit comboPago;
        private Label label10;
        private ReaLTaiizor.Controls.ComboBoxEdit comboEstado;
        private TableLayoutPanel tableLayoutPanel5;
        private ReaLTaiizor.Controls.CyberTextBox txtTiempoDeProduccionNew;
        private ReaLTaiizor.Controls.CyberTextBox txtImporteNew;
        private ReaLTaiizor.Controls.CyberTextBox txtFechaEntregaNew;
        private ReaLTaiizor.Controls.CyberTextBox txtNomClienteNew;
        private ReaLTaiizor.Controls.CyberTextBox txtNomPedidoNew;
        private Label label4;
        private Label label9;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}