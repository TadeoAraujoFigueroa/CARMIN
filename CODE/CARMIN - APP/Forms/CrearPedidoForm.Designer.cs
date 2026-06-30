namespace CARMIN___APP.Forms
{
    partial class CrearPedidoForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            mainPanelNew = new Panel();
            logoBoxNew = new PictureBox();
            subMainPanel = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnCrearPedidoNew = new ReaLTaiizor.Controls.CyberButton();
            tableLayoutMain = new TableLayoutPanel();
            panelNombrePedido = new Panel();
            panelNombrePedidoInt = new Panel();
            panelFechaEntrega = new Panel();
            panelFechaEntregaInt = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            fechaEntrega = new DateTimePicker();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panelPresuExt = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSeleccionarPresupuestoNew = new ReaLTaiizor.Controls.CyberButton();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            dgvPresupuestos = new ReaLTaiizor.Controls.PoisonDataGridView();
            txtFiltroPresu = new ReaLTaiizor.Controls.MetroTextBox();
            panelClientesExistentes = new Panel();
            panelClientesExistentesInt = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSeleccionarClienteNew = new ReaLTaiizor.Controls.CyberButton();
            txtFiltroCliente = new ReaLTaiizor.Controls.MetroTextBox();
            labelClientes = new ReaLTaiizor.Controls.BigLabel();
            dgvClientes = new ReaLTaiizor.Controls.PoisonDataGridView();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            txtNomPedidoNew = new ReaLTaiizor.Controls.CyberTextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            mainPanelNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBoxNew).BeginInit();
            subMainPanel.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            panelNombrePedido.SuspendLayout();
            panelNombrePedidoInt.SuspendLayout();
            panelFechaEntrega.SuspendLayout();
            panelFechaEntregaInt.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelPresuExt.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).BeginInit();
            panelClientesExistentes.SuspendLayout();
            panelClientesExistentesInt.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanelNew
            // 
            mainPanelNew.BackColor = Color.FromArgb(255, 248, 231);
            mainPanelNew.Controls.Add(logoBoxNew);
            mainPanelNew.Controls.Add(subMainPanel);
            mainPanelNew.Location = new Point(34, 31);
            mainPanelNew.Name = "mainPanelNew";
            mainPanelNew.Size = new Size(1700, 989);
            mainPanelNew.TabIndex = 3;
            // 
            // logoBoxNew
            // 
            logoBoxNew.Location = new Point(1571, 16);
            logoBoxNew.Name = "logoBoxNew";
            logoBoxNew.Size = new Size(84, 44);
            logoBoxNew.TabIndex = 33;
            logoBoxNew.TabStop = false;
            // 
            // subMainPanel
            // 
            subMainPanel.Controls.Add(tableLayoutPanel5);
            subMainPanel.Location = new Point(39, 66);
            subMainPanel.Margin = new Padding(4);
            subMainPanel.Name = "subMainPanel";
            subMainPanel.Size = new Size(1561, 856);
            subMainPanel.TabIndex = 32;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutMain, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.Size = new Size(1561, 856);
            tableLayoutPanel5.TabIndex = 33;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Controls.Add(btnCrearPedidoNew, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 773);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1555, 80);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btnCrearPedidoNew
            // 
            btnCrearPedidoNew.Alpha = 20;
            btnCrearPedidoNew.BackColor = Color.Transparent;
            btnCrearPedidoNew.Background = true;
            btnCrearPedidoNew.Background_WidthPen = 4F;
            btnCrearPedidoNew.BackgroundPen = true;
            btnCrearPedidoNew.ColorBackground = Color.FromArgb(158, 24, 43);
            btnCrearPedidoNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCrearPedidoNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCrearPedidoNew.ColorBackground_Pen = Color.Black;
            btnCrearPedidoNew.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCrearPedidoNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCrearPedidoNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCrearPedidoNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCrearPedidoNew.Dock = DockStyle.Fill;
            btnCrearPedidoNew.Effect_1 = true;
            btnCrearPedidoNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCrearPedidoNew.Effect_1_Transparency = 25;
            btnCrearPedidoNew.Effect_2 = true;
            btnCrearPedidoNew.Effect_2_ColorBackground = Color.White;
            btnCrearPedidoNew.Effect_2_Transparency = 20;
            btnCrearPedidoNew.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearPedidoNew.ForeColor = Color.FromArgb(245, 245, 245);
            btnCrearPedidoNew.Lighting = false;
            btnCrearPedidoNew.LinearGradient_Background = false;
            btnCrearPedidoNew.LinearGradientPen = false;
            btnCrearPedidoNew.Location = new Point(520, 2);
            btnCrearPedidoNew.Margin = new Padding(2);
            btnCrearPedidoNew.Name = "btnCrearPedidoNew";
            btnCrearPedidoNew.Padding = new Padding(15);
            btnCrearPedidoNew.PenWidth = 15;
            btnCrearPedidoNew.Rounding = true;
            btnCrearPedidoNew.RoundingInt = 70;
            btnCrearPedidoNew.Size = new Size(514, 76);
            btnCrearPedidoNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCrearPedidoNew.TabIndex = 34;
            btnCrearPedidoNew.Tag = "Cyber";
            btnCrearPedidoNew.TextButton = "CREAR PEDIDO";
            btnCrearPedidoNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCrearPedidoNew.Timer_Effect_1 = 5;
            btnCrearPedidoNew.Timer_RGB = 300;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.Controls.Add(panelNombrePedido, 1, 1);
            tableLayoutMain.Controls.Add(panelFechaEntrega, 0, 1);
            tableLayoutMain.Controls.Add(panelPresuExt, 1, 0);
            tableLayoutMain.Controls.Add(panelClientesExistentes, 0, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(3, 3);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 2;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutMain.Size = new Size(1555, 764);
            tableLayoutMain.TabIndex = 32;
            // 
            // panelNombrePedido
            // 
            panelNombrePedido.BackColor = Color.FromArgb(158, 24, 43);
            panelNombrePedido.Controls.Add(panelNombrePedidoInt);
            panelNombrePedido.Dock = DockStyle.Fill;
            panelNombrePedido.Location = new Point(780, 597);
            panelNombrePedido.Name = "panelNombrePedido";
            panelNombrePedido.Padding = new Padding(30);
            panelNombrePedido.Size = new Size(772, 164);
            panelNombrePedido.TabIndex = 3;
            // 
            // panelNombrePedidoInt
            // 
            panelNombrePedidoInt.BackColor = Color.FromArgb(255, 248, 231);
            panelNombrePedidoInt.Controls.Add(tableLayoutPanel4);
            panelNombrePedidoInt.Dock = DockStyle.Fill;
            panelNombrePedidoInt.Location = new Point(30, 30);
            panelNombrePedidoInt.Name = "panelNombrePedidoInt";
            panelNombrePedidoInt.Size = new Size(712, 104);
            panelNombrePedidoInt.TabIndex = 0;
            // 
            // panelFechaEntrega
            // 
            panelFechaEntrega.BackColor = Color.FromArgb(158, 24, 43);
            panelFechaEntrega.Controls.Add(panelFechaEntregaInt);
            panelFechaEntrega.Dock = DockStyle.Fill;
            panelFechaEntrega.Location = new Point(3, 597);
            panelFechaEntrega.Name = "panelFechaEntrega";
            panelFechaEntrega.Padding = new Padding(30);
            panelFechaEntrega.Size = new Size(771, 164);
            panelFechaEntrega.TabIndex = 2;
            // 
            // panelFechaEntregaInt
            // 
            panelFechaEntregaInt.BackColor = Color.FromArgb(255, 248, 231);
            panelFechaEntregaInt.Controls.Add(tableLayoutPanel3);
            panelFechaEntregaInt.Dock = DockStyle.Fill;
            panelFechaEntregaInt.Location = new Point(30, 30);
            panelFechaEntregaInt.Name = "panelFechaEntregaInt";
            panelFechaEntregaInt.Size = new Size(711, 104);
            panelFechaEntregaInt.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(fechaEntrega, 0, 1);
            tableLayoutPanel3.Controls.Add(bigLabel1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Size = new Size(711, 104);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // fechaEntrega
            // 
            fechaEntrega.Anchor = AnchorStyles.None;
            fechaEntrega.Location = new Point(216, 69);
            fechaEntrega.Margin = new Padding(4);
            fechaEntrega.Name = "fechaEntrega";
            fechaEntrega.Size = new Size(278, 27);
            fechaEntrega.TabIndex = 30;
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.None;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.FlatStyle = FlatStyle.Popup;
            bigLabel1.Font = new Font("Poppins SemiBold", 25.2F, FontStyle.Bold);
            bigLabel1.ForeColor = Color.FromArgb(158, 24, 43);
            bigLabel1.Location = new Point(141, 0);
            bigLabel1.Margin = new Padding(4, 0, 4, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(428, 62);
            bigLabel1.TabIndex = 29;
            bigLabel1.Text = "FECHA DE ENTREGA";
            // 
            // panelPresuExt
            // 
            panelPresuExt.BackColor = Color.FromArgb(158, 24, 43);
            panelPresuExt.Controls.Add(panel2);
            panelPresuExt.Dock = DockStyle.Fill;
            panelPresuExt.Location = new Point(780, 3);
            panelPresuExt.Name = "panelPresuExt";
            panelPresuExt.Padding = new Padding(30);
            panelPresuExt.Size = new Size(772, 588);
            panelPresuExt.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 248, 231);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(30, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 528);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnSeleccionarPresupuestoNew, 0, 3);
            tableLayoutPanel2.Controls.Add(bigLabel2, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvPresupuestos, 0, 2);
            tableLayoutPanel2.Controls.Add(txtFiltroPresu, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(712, 528);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSeleccionarPresupuestoNew
            // 
            btnSeleccionarPresupuestoNew.Alpha = 20;
            btnSeleccionarPresupuestoNew.BackColor = Color.Transparent;
            btnSeleccionarPresupuestoNew.Background = true;
            btnSeleccionarPresupuestoNew.Background_WidthPen = 4F;
            btnSeleccionarPresupuestoNew.BackgroundPen = true;
            btnSeleccionarPresupuestoNew.ColorBackground = Color.FromArgb(158, 24, 43);
            btnSeleccionarPresupuestoNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnSeleccionarPresupuestoNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnSeleccionarPresupuestoNew.ColorBackground_Pen = Color.Black;
            btnSeleccionarPresupuestoNew.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSeleccionarPresupuestoNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSeleccionarPresupuestoNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSeleccionarPresupuestoNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSeleccionarPresupuestoNew.Dock = DockStyle.Fill;
            btnSeleccionarPresupuestoNew.Effect_1 = true;
            btnSeleccionarPresupuestoNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSeleccionarPresupuestoNew.Effect_1_Transparency = 25;
            btnSeleccionarPresupuestoNew.Effect_2 = true;
            btnSeleccionarPresupuestoNew.Effect_2_ColorBackground = Color.White;
            btnSeleccionarPresupuestoNew.Effect_2_Transparency = 20;
            btnSeleccionarPresupuestoNew.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionarPresupuestoNew.ForeColor = Color.FromArgb(245, 245, 245);
            btnSeleccionarPresupuestoNew.Lighting = false;
            btnSeleccionarPresupuestoNew.LinearGradient_Background = false;
            btnSeleccionarPresupuestoNew.LinearGradientPen = false;
            btnSeleccionarPresupuestoNew.Location = new Point(150, 420);
            btnSeleccionarPresupuestoNew.Margin = new Padding(150, 25, 150, 25);
            btnSeleccionarPresupuestoNew.Name = "btnSeleccionarPresupuestoNew";
            btnSeleccionarPresupuestoNew.Padding = new Padding(15);
            btnSeleccionarPresupuestoNew.PenWidth = 15;
            btnSeleccionarPresupuestoNew.Rounding = true;
            btnSeleccionarPresupuestoNew.RoundingInt = 70;
            btnSeleccionarPresupuestoNew.Size = new Size(412, 83);
            btnSeleccionarPresupuestoNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSeleccionarPresupuestoNew.TabIndex = 34;
            btnSeleccionarPresupuestoNew.Tag = "Cyber";
            btnSeleccionarPresupuestoNew.TextButton = "SELECCIONAR PRESUPUESTO";
            btnSeleccionarPresupuestoNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSeleccionarPresupuestoNew.Timer_Effect_1 = 5;
            btnSeleccionarPresupuestoNew.Timer_RGB = 300;
            // 
            // bigLabel2
            // 
            bigLabel2.Anchor = AnchorStyles.None;
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.FlatStyle = FlatStyle.Popup;
            bigLabel2.Font = new Font("Poppins SemiBold", 25.2F, FontStyle.Bold);
            bigLabel2.ForeColor = Color.FromArgb(158, 24, 43);
            bigLabel2.Location = new Point(58, 0);
            bigLabel2.Margin = new Padding(4, 0, 4, 0);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(596, 66);
            bigLabel2.TabIndex = 28;
            bigLabel2.Text = "PRESUPUESTOS EXISTENTES";
            // 
            // dgvPresupuestos
            // 
            dgvPresupuestos.AllowUserToAddRows = false;
            dgvPresupuestos.AllowUserToDeleteRows = false;
            dgvPresupuestos.AllowUserToResizeColumns = false;
            dgvPresupuestos.AllowUserToResizeRows = false;
            dgvPresupuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPresupuestos.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvPresupuestos.BorderStyle = BorderStyle.None;
            dgvPresupuestos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPresupuestos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(165, 81, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(200, 100, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPresupuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPresupuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(200, 100, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPresupuestos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPresupuestos.Dock = DockStyle.Fill;
            dgvPresupuestos.EnableHeadersVisualStyles = false;
            dgvPresupuestos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvPresupuestos.GridColor = Color.FromArgb(255, 255, 255);
            dgvPresupuestos.Location = new Point(4, 149);
            dgvPresupuestos.Margin = new Padding(4);
            dgvPresupuestos.Name = "dgvPresupuestos";
            dgvPresupuestos.ReadOnly = true;
            dgvPresupuestos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(165, 81, 0);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 100, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPresupuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPresupuestos.RowHeadersWidth = 51;
            dgvPresupuestos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPresupuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresupuestos.Size = new Size(704, 242);
            dgvPresupuestos.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Brown;
            dgvPresupuestos.TabIndex = 27;
            // 
            // txtFiltroPresu
            // 
            txtFiltroPresu.Anchor = AnchorStyles.None;
            txtFiltroPresu.AutoCompleteCustomSource = null;
            txtFiltroPresu.AutoCompleteMode = AutoCompleteMode.None;
            txtFiltroPresu.AutoCompleteSource = AutoCompleteSource.None;
            txtFiltroPresu.BorderColor = Color.FromArgb(155, 155, 155);
            txtFiltroPresu.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtFiltroPresu.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtFiltroPresu.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtFiltroPresu.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltroPresu.HoverColor = Color.FromArgb(102, 102, 102);
            txtFiltroPresu.Image = null;
            txtFiltroPresu.IsDerivedStyle = true;
            txtFiltroPresu.Lines = null;
            txtFiltroPresu.Location = new Point(217, 86);
            txtFiltroPresu.Margin = new Padding(4);
            txtFiltroPresu.MaxLength = 32767;
            txtFiltroPresu.Multiline = false;
            txtFiltroPresu.Name = "txtFiltroPresu";
            txtFiltroPresu.ReadOnly = false;
            txtFiltroPresu.Size = new Size(278, 39);
            txtFiltroPresu.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txtFiltroPresu.StyleManager = null;
            txtFiltroPresu.TabIndex = 31;
            txtFiltroPresu.Text = "BUSCAR PRESUPUESTO...";
            txtFiltroPresu.TextAlign = HorizontalAlignment.Center;
            txtFiltroPresu.ThemeAuthor = "Taiizor";
            txtFiltroPresu.ThemeName = "MetroLight";
            txtFiltroPresu.UseSystemPasswordChar = false;
            txtFiltroPresu.WatermarkText = "";
            // 
            // panelClientesExistentes
            // 
            panelClientesExistentes.BackColor = Color.FromArgb(158, 24, 43);
            panelClientesExistentes.Controls.Add(panelClientesExistentesInt);
            panelClientesExistentes.Dock = DockStyle.Fill;
            panelClientesExistentes.Location = new Point(3, 3);
            panelClientesExistentes.Name = "panelClientesExistentes";
            panelClientesExistentes.Padding = new Padding(30);
            panelClientesExistentes.Size = new Size(771, 588);
            panelClientesExistentes.TabIndex = 0;
            // 
            // panelClientesExistentesInt
            // 
            panelClientesExistentesInt.BackColor = Color.FromArgb(255, 248, 231);
            panelClientesExistentesInt.Controls.Add(tableLayoutPanel1);
            panelClientesExistentesInt.Dock = DockStyle.Fill;
            panelClientesExistentesInt.Location = new Point(30, 30);
            panelClientesExistentesInt.Name = "panelClientesExistentesInt";
            panelClientesExistentesInt.Size = new Size(711, 528);
            panelClientesExistentesInt.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnSeleccionarClienteNew, 0, 3);
            tableLayoutPanel1.Controls.Add(txtFiltroCliente, 0, 1);
            tableLayoutPanel1.Controls.Add(labelClientes, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvClientes, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(711, 528);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSeleccionarClienteNew
            // 
            btnSeleccionarClienteNew.Alpha = 20;
            btnSeleccionarClienteNew.BackColor = Color.Transparent;
            btnSeleccionarClienteNew.Background = true;
            btnSeleccionarClienteNew.Background_WidthPen = 4F;
            btnSeleccionarClienteNew.BackgroundPen = true;
            btnSeleccionarClienteNew.ColorBackground = Color.FromArgb(158, 24, 43);
            btnSeleccionarClienteNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnSeleccionarClienteNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnSeleccionarClienteNew.ColorBackground_Pen = Color.Black;
            btnSeleccionarClienteNew.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSeleccionarClienteNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSeleccionarClienteNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSeleccionarClienteNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSeleccionarClienteNew.Dock = DockStyle.Fill;
            btnSeleccionarClienteNew.Effect_1 = true;
            btnSeleccionarClienteNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSeleccionarClienteNew.Effect_1_Transparency = 25;
            btnSeleccionarClienteNew.Effect_2 = true;
            btnSeleccionarClienteNew.Effect_2_ColorBackground = Color.White;
            btnSeleccionarClienteNew.Effect_2_Transparency = 20;
            btnSeleccionarClienteNew.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionarClienteNew.ForeColor = Color.FromArgb(245, 245, 245);
            btnSeleccionarClienteNew.Lighting = false;
            btnSeleccionarClienteNew.LinearGradient_Background = false;
            btnSeleccionarClienteNew.LinearGradientPen = false;
            btnSeleccionarClienteNew.Location = new Point(150, 420);
            btnSeleccionarClienteNew.Margin = new Padding(150, 25, 150, 25);
            btnSeleccionarClienteNew.Name = "btnSeleccionarClienteNew";
            btnSeleccionarClienteNew.Padding = new Padding(15);
            btnSeleccionarClienteNew.PenWidth = 15;
            btnSeleccionarClienteNew.Rounding = true;
            btnSeleccionarClienteNew.RoundingInt = 70;
            btnSeleccionarClienteNew.Size = new Size(411, 83);
            btnSeleccionarClienteNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSeleccionarClienteNew.TabIndex = 33;
            btnSeleccionarClienteNew.Tag = "Cyber";
            btnSeleccionarClienteNew.TextButton = "SELECCIONAR CLIENTE";
            btnSeleccionarClienteNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSeleccionarClienteNew.Timer_Effect_1 = 5;
            btnSeleccionarClienteNew.Timer_RGB = 300;
            // 
            // txtFiltroCliente
            // 
            txtFiltroCliente.Anchor = AnchorStyles.None;
            txtFiltroCliente.AutoCompleteCustomSource = null;
            txtFiltroCliente.AutoCompleteMode = AutoCompleteMode.None;
            txtFiltroCliente.AutoCompleteSource = AutoCompleteSource.None;
            txtFiltroCliente.BorderColor = Color.FromArgb(155, 155, 155);
            txtFiltroCliente.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtFiltroCliente.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtFiltroCliente.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtFiltroCliente.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltroCliente.HoverColor = Color.FromArgb(102, 102, 102);
            txtFiltroCliente.Image = null;
            txtFiltroCliente.IsDerivedStyle = true;
            txtFiltroCliente.Lines = null;
            txtFiltroCliente.Location = new Point(216, 86);
            txtFiltroCliente.Margin = new Padding(4);
            txtFiltroCliente.MaxLength = 32767;
            txtFiltroCliente.Multiline = false;
            txtFiltroCliente.Name = "txtFiltroCliente";
            txtFiltroCliente.ReadOnly = false;
            txtFiltroCliente.Size = new Size(278, 39);
            txtFiltroCliente.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txtFiltroCliente.StyleManager = null;
            txtFiltroCliente.TabIndex = 32;
            txtFiltroCliente.Text = "BUSCAR CLIENTE...";
            txtFiltroCliente.TextAlign = HorizontalAlignment.Center;
            txtFiltroCliente.ThemeAuthor = "Taiizor";
            txtFiltroCliente.ThemeName = "MetroLight";
            txtFiltroCliente.UseSystemPasswordChar = false;
            txtFiltroCliente.WatermarkText = "";
            // 
            // labelClientes
            // 
            labelClientes.Anchor = AnchorStyles.None;
            labelClientes.AutoSize = true;
            labelClientes.BackColor = Color.Transparent;
            labelClientes.FlatStyle = FlatStyle.Popup;
            labelClientes.Font = new Font("Poppins SemiBold", 25.2F, FontStyle.Bold);
            labelClientes.ForeColor = Color.FromArgb(158, 24, 43);
            labelClientes.Location = new Point(121, 0);
            labelClientes.Margin = new Padding(4, 0, 4, 0);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(468, 66);
            labelClientes.TabIndex = 28;
            labelClientes.Text = "CLIENTES EXISTENTES";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(165, 81, 0);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(200, 100, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(200, 100, 0);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle5;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvClientes.GridColor = Color.FromArgb(255, 255, 255);
            dgvClientes.Location = new Point(4, 149);
            dgvClientes.Margin = new Padding(4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(165, 81, 0);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(200, 100, 0);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(703, 242);
            dgvClientes.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Brown;
            dgvClientes.TabIndex = 27;
            // 
            // bigLabel3
            // 
            bigLabel3.Anchor = AnchorStyles.None;
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.FlatStyle = FlatStyle.Popup;
            bigLabel3.Font = new Font("Poppins SemiBold", 25.2F, FontStyle.Bold);
            bigLabel3.ForeColor = Color.FromArgb(158, 24, 43);
            bigLabel3.Location = new Point(169, 0);
            bigLabel3.Margin = new Padding(4, 0, 4, 0);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(373, 62);
            bigLabel3.TabIndex = 29;
            bigLabel3.Text = "NOMBRE PEDIDO";
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
            txtNomPedidoNew.Font = new Font("Poppins", 9F);
            txtNomPedidoNew.ForeColor = Color.DarkGray;
            txtNomPedidoNew.Lighting = false;
            txtNomPedidoNew.LinearGradientPen = false;
            txtNomPedidoNew.Location = new Point(100, 64);
            txtNomPedidoNew.Margin = new Padding(100, 2, 100, 2);
            txtNomPedidoNew.Name = "txtNomPedidoNew";
            txtNomPedidoNew.Padding = new Padding(15);
            txtNomPedidoNew.PenWidth = 15;
            txtNomPedidoNew.RGB = false;
            txtNomPedidoNew.Rounding = true;
            txtNomPedidoNew.RoundingInt = 60;
            txtNomPedidoNew.Size = new Size(512, 38);
            txtNomPedidoNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNomPedidoNew.TabIndex = 30;
            txtNomPedidoNew.Tag = "Cyber";
            txtNomPedidoNew.TextButton = "Escribir aquí...";
            txtNomPedidoNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNomPedidoNew.Timer_RGB = 300;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(txtNomPedidoNew, 0, 1);
            tableLayoutPanel4.Controls.Add(bigLabel3, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.Size = new Size(712, 104);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // CrearPedidoForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(158, 24, 43);
            ClientSize = new Size(1942, 1102);
            Controls.Add(mainPanelNew);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CrearPedidoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearPedidoForm";
            WindowState = FormWindowState.Maximized;
            Load += CrearPedidoForm_Load;
            Shown += CrearPedidoForm_Shown;
            VisibleChanged += CrearPedidoForm_VisibleChanged;
            mainPanelNew.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBoxNew).EndInit();
            subMainPanel.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            panelNombrePedido.ResumeLayout(false);
            panelNombrePedidoInt.ResumeLayout(false);
            panelFechaEntrega.ResumeLayout(false);
            panelFechaEntregaInt.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panelPresuExt.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).EndInit();
            panelClientesExistentes.ResumeLayout(false);
            panelClientesExistentesInt.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainPanelNew;
        private Panel subMainPanel;
        private Controls.CARMIN.UI.Controls.ShadowRoundedPanel shadowRoundedPanel6;
        private Controls.CARMIN.UI.Controls.ShadowRoundedPanel panelNomPedido;
        private Controls.CARMIN.UI.Controls.ShadowRoundedTextBox txtNomPedido;
        private Controls.ShadowRoundedButton shadowRoundedButton2;
        private Controls.CARMIN.UI.Controls.ShadowRoundedPanel shadowRoundedPanel2;
        private Controls.CARMIN.UI.Controls.ShadowRoundedPanel panelModificarInsumo;
        private Controls.ShadowRoundedButton btnSeleccionarPresu;
        private Controls.ShadowRoundedButton shadowRoundedButton1;
        private Controls.ShadowRoundedButton btnCrearPedido;
        private DateTimePicker fechaEntrega;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.MetroTextBox txtFiltroCliente;
        private ReaLTaiizor.Controls.BigLabel labelClientes;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvClientes;
        private TableLayoutPanel tableLayoutMain;
        private Panel panelClientesExistentes;
        private Panel panelClientesExistentesInt;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelFechaEntrega;
        private Panel panelFechaEntregaInt;
        private Panel panelPresuExt;
        private Panel panel2;
        private ReaLTaiizor.Controls.CyberButton btnSeleccionarClienteNew;
        private Panel panelNombrePedido;
        private Panel panelNombrePedidoInt;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private ReaLTaiizor.Controls.CyberButton btnCrearPedidoNew;
        private PictureBox logoBoxNew;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.CyberButton btnSeleccionarPresupuestoNew;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvPresupuestos;
        private ReaLTaiizor.Controls.MetroTextBox txtFiltroPresu;
        private TableLayoutPanel tableLayoutPanel4;
        private ReaLTaiizor.Controls.CyberTextBox txtNomPedidoNew;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
    }
}
