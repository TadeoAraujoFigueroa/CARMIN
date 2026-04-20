namespace CARMIN___APP.Forms
{
    partial class PresupuestadorForm
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
            shadowRoundedPanel1 = new CARMIN___APP.Controls.CARMIN.UI.Controls.ShadowRoundedPanel();
            dgvPresupuesto = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnElim = new CARMIN___APP.Controls.ShadowRoundedButton();
            btnAg = new CARMIN___APP.Controls.ShadowRoundedButton();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            shadowRoundedPanel2 = new CARMIN___APP.Controls.CARMIN.UI.Controls.ShadowRoundedPanel();
            bigLabel9 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            txtTotalFinal = new CARMIN___APP.Controls.CARMIN.UI.Controls.ShadowRoundedTextBox();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            txtDescuento = new CARMIN___APP.Controls.CARMIN.UI.Controls.ShadowRoundedTextBox();
            txtGanancia = new CARMIN___APP.Controls.CARMIN.UI.Controls.ShadowRoundedTextBox();
            txtSubtotalTec = new CARMIN___APP.Controls.CARMIN.UI.Controls.ShadowRoundedTextBox();
            txtMaquinaria = new CARMIN___APP.Controls.CARMIN.UI.Controls.ShadowRoundedTextBox();
            txtMerma = new CARMIN___APP.Controls.CARMIN.UI.Controls.ShadowRoundedTextBox();
            txtCostoTotal = new CARMIN___APP.Controls.CARMIN.UI.Controls.ShadowRoundedTextBox();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            btnGuardar = new CARMIN___APP.Controls.ShadowRoundedButton();
            btnGenerarPDF = new CARMIN___APP.Controls.ShadowRoundedButton();
            logoBox = new PictureBox();
            shadowRoundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuesto).BeginInit();
            shadowRoundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // shadowRoundedPanel1
            // 
            shadowRoundedPanel1.BackColor = Color.Transparent;
            shadowRoundedPanel1.BorderColor = Color.FromArgb(230, 230, 230);
            shadowRoundedPanel1.BorderRadius = 20;
            shadowRoundedPanel1.BorderThickness = 1;
            shadowRoundedPanel1.ContentTopPadding = 42;
            shadowRoundedPanel1.Controls.Add(dgvPresupuesto);
            shadowRoundedPanel1.Controls.Add(btnElim);
            shadowRoundedPanel1.Controls.Add(btnAg);
            shadowRoundedPanel1.Controls.Add(bigLabel1);
            shadowRoundedPanel1.FillColor = Color.FromArgb(158, 24, 43);
            shadowRoundedPanel1.Location = new Point(41, 36);
            shadowRoundedPanel1.Name = "shadowRoundedPanel1";
            shadowRoundedPanel1.Padding = new Padding(18, 42, 18, 18);
            shadowRoundedPanel1.ShadowColor = Color.FromArgb(18, 0, 0, 0);
            shadowRoundedPanel1.ShadowOffset = 4;
            shadowRoundedPanel1.Size = new Size(606, 589);
            shadowRoundedPanel1.TabIndex = 0;
            shadowRoundedPanel1.Title = "";
            shadowRoundedPanel1.TitleColor = Color.FromArgb(60, 60, 60);
            shadowRoundedPanel1.TitleFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            shadowRoundedPanel1.TitlePaddingLeft = 18;
            shadowRoundedPanel1.TitlePaddingTop = 14;
            // 
            // dgvPresupuesto
            // 
            dgvPresupuesto.AllowUserToAddRows = false;
            dgvPresupuesto.AllowUserToDeleteRows = false;
            dgvPresupuesto.AllowUserToResizeRows = false;
            dgvPresupuesto.BackgroundColor = Color.FromArgb(255, 248, 231);
            dgvPresupuesto.BorderStyle = BorderStyle.Fixed3D;
            dgvPresupuesto.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPresupuesto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPresupuesto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPresupuesto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPresupuesto.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPresupuesto.EnableHeadersVisualStyles = false;
            dgvPresupuesto.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvPresupuesto.GridColor = Color.FromArgb(255, 255, 255);
            dgvPresupuesto.Location = new Point(44, 75);
            dgvPresupuesto.Name = "dgvPresupuesto";
            dgvPresupuesto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPresupuesto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPresupuesto.RowHeadersWidth = 51;
            dgvPresupuesto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPresupuesto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresupuesto.Size = new Size(520, 392);
            dgvPresupuesto.TabIndex = 3;
            dgvPresupuesto.CellValueChanged += dgvPresupuesto_CellValueChanged;
            // 
            // btnElim
            // 
            btnElim.BackColor = Color.Transparent;
            btnElim.BorderRadius = 100;
            btnElim.ButtonTextColor = Color.FromArgb(158, 24, 43);
            btnElim.FillColor = Color.FromArgb(255, 248, 231);
            btnElim.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnElim.HoverLift = 2;
            btnElim.Location = new Point(363, 495);
            btnElim.Name = "btnElim";
            btnElim.ShadowColor = Color.FromArgb(45, 0, 0, 0);
            btnElim.ShadowOffset = 4;
            btnElim.Size = new Size(200, 60);
            btnElim.TabIndex = 2;
            btnElim.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAg
            // 
            btnAg.BackColor = Color.Transparent;
            btnAg.BorderRadius = 100;
            btnAg.ButtonTextColor = Color.FromArgb(158, 24, 43);
            btnAg.FillColor = Color.FromArgb(255, 248, 231);
            btnAg.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAg.HoverLift = 2;
            btnAg.Location = new Point(43, 495);
            btnAg.Name = "btnAg";
            btnAg.ShadowColor = Color.FromArgb(45, 0, 0, 0);
            btnAg.ShadowOffset = 4;
            btnAg.Size = new Size(200, 60);
            btnAg.TabIndex = 1;
            btnAg.TextAlign = ContentAlignment.MiddleCenter;
            btnAg.Click += btnAg_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.FlatStyle = FlatStyle.Popup;
            bigLabel1.Font = new Font("Poppins SemiBold", 25.2F, FontStyle.Bold);
            bigLabel1.ForeColor = Color.FromArgb(255, 248, 231);
            bigLabel1.Location = new Point(187, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(227, 74);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "INSUMOS";
            // 
            // shadowRoundedPanel2
            // 
            shadowRoundedPanel2.BackColor = Color.Transparent;
            shadowRoundedPanel2.BorderColor = Color.FromArgb(230, 230, 230);
            shadowRoundedPanel2.BorderRadius = 20;
            shadowRoundedPanel2.BorderThickness = 1;
            shadowRoundedPanel2.ContentTopPadding = 42;
            shadowRoundedPanel2.Controls.Add(bigLabel9);
            shadowRoundedPanel2.Controls.Add(bigLabel8);
            shadowRoundedPanel2.Controls.Add(bigLabel7);
            shadowRoundedPanel2.Controls.Add(bigLabel6);
            shadowRoundedPanel2.Controls.Add(bigLabel5);
            shadowRoundedPanel2.Controls.Add(bigLabel4);
            shadowRoundedPanel2.Controls.Add(txtTotalFinal);
            shadowRoundedPanel2.Controls.Add(bigLabel3);
            shadowRoundedPanel2.Controls.Add(txtDescuento);
            shadowRoundedPanel2.Controls.Add(txtGanancia);
            shadowRoundedPanel2.Controls.Add(txtSubtotalTec);
            shadowRoundedPanel2.Controls.Add(txtMaquinaria);
            shadowRoundedPanel2.Controls.Add(txtMerma);
            shadowRoundedPanel2.Controls.Add(txtCostoTotal);
            shadowRoundedPanel2.Controls.Add(bigLabel2);
            shadowRoundedPanel2.FillColor = Color.FromArgb(158, 24, 43);
            shadowRoundedPanel2.Location = new Point(751, 36);
            shadowRoundedPanel2.Name = "shadowRoundedPanel2";
            shadowRoundedPanel2.Padding = new Padding(18, 42, 18, 18);
            shadowRoundedPanel2.ShadowColor = Color.FromArgb(18, 0, 0, 0);
            shadowRoundedPanel2.ShadowOffset = 4;
            shadowRoundedPanel2.Size = new Size(606, 589);
            shadowRoundedPanel2.TabIndex = 1;
            shadowRoundedPanel2.Title = "";
            shadowRoundedPanel2.TitleColor = Color.FromArgb(60, 60, 60);
            shadowRoundedPanel2.TitleFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            shadowRoundedPanel2.TitlePaddingLeft = 18;
            shadowRoundedPanel2.TitlePaddingTop = 14;
            // 
            // bigLabel9
            // 
            bigLabel9.BackColor = Color.Transparent;
            bigLabel9.FlatStyle = FlatStyle.Popup;
            bigLabel9.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel9.ForeColor = Color.FromArgb(255, 248, 231);
            bigLabel9.Location = new Point(66, 424);
            bigLabel9.Name = "bigLabel9";
            bigLabel9.Size = new Size(254, 37);
            bigLabel9.TabIndex = 15;
            bigLabel9.Text = "DESCUENTO %";
            // 
            // bigLabel8
            // 
            bigLabel8.BackColor = Color.Transparent;
            bigLabel8.FlatStyle = FlatStyle.Popup;
            bigLabel8.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel8.ForeColor = Color.FromArgb(255, 248, 231);
            bigLabel8.Location = new Point(66, 356);
            bigLabel8.Name = "bigLabel8";
            bigLabel8.Size = new Size(254, 37);
            bigLabel8.TabIndex = 14;
            bigLabel8.Text = "GANANCIA %";
            // 
            // bigLabel7
            // 
            bigLabel7.BackColor = Color.Transparent;
            bigLabel7.FlatStyle = FlatStyle.Popup;
            bigLabel7.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel7.ForeColor = Color.FromArgb(255, 248, 231);
            bigLabel7.Location = new Point(66, 288);
            bigLabel7.Name = "bigLabel7";
            bigLabel7.Size = new Size(254, 37);
            bigLabel7.TabIndex = 13;
            bigLabel7.Text = "SUBTOTAL TÉCNICO";
            // 
            // bigLabel6
            // 
            bigLabel6.BackColor = Color.Transparent;
            bigLabel6.FlatStyle = FlatStyle.Popup;
            bigLabel6.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel6.ForeColor = Color.FromArgb(255, 248, 231);
            bigLabel6.Location = new Point(66, 220);
            bigLabel6.Name = "bigLabel6";
            bigLabel6.Size = new Size(254, 37);
            bigLabel6.TabIndex = 12;
            bigLabel6.Text = "MAQUINARIA %";
            // 
            // bigLabel5
            // 
            bigLabel5.BackColor = Color.Transparent;
            bigLabel5.FlatStyle = FlatStyle.Popup;
            bigLabel5.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel5.ForeColor = Color.FromArgb(255, 248, 231);
            bigLabel5.Location = new Point(66, 152);
            bigLabel5.Name = "bigLabel5";
            bigLabel5.Size = new Size(254, 37);
            bigLabel5.TabIndex = 11;
            bigLabel5.Text = "MERMA %";
            // 
            // bigLabel4
            // 
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.FlatStyle = FlatStyle.Popup;
            bigLabel4.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel4.ForeColor = Color.FromArgb(255, 248, 231);
            bigLabel4.Location = new Point(66, 84);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(254, 37);
            bigLabel4.TabIndex = 10;
            bigLabel4.Text = "COSTO BASE TOTAL";
            bigLabel4.Click += bigLabel4_Click;
            // 
            // txtTotalFinal
            // 
            txtTotalFinal.AutoValidate = AutoValidate.EnablePreventFocusChange;
            txtTotalFinal.BackColor = Color.Transparent;
            txtTotalFinal.BorderColor = Color.FromArgb(220, 220, 220);
            txtTotalFinal.BorderRadius = 16;
            txtTotalFinal.BorderThickness = 1;
            txtTotalFinal.CharacterCasing = CharacterCasing.Normal;
            txtTotalFinal.Enabled = false;
            txtTotalFinal.FillColor = Color.FromArgb(149, 187, 234);
            txtTotalFinal.FocusBorderColor = Color.FromArgb(232, 174, 183);
            txtTotalFinal.Location = new Point(272, 503);
            txtTotalFinal.MaxLength = 32767;
            txtTotalFinal.Multiline = false;
            txtTotalFinal.Name = "txtTotalFinal";
            txtTotalFinal.PlaceholderColor = Color.FromArgb(140, 140, 140);
            txtTotalFinal.PlaceholderText = "";
            txtTotalFinal.ScrollBars = ScrollBars.None;
            txtTotalFinal.ShadowColor = Color.FromArgb(25, 0, 0, 0);
            txtTotalFinal.ShadowOffset = 3;
            txtTotalFinal.Size = new Size(282, 60);
            txtTotalFinal.TabIndex = 9;
            txtTotalFinal.TextAlign = HorizontalAlignment.Left;
            txtTotalFinal.UseSystemPasswordChar = false;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.FlatStyle = FlatStyle.Popup;
            bigLabel3.Font = new Font("Poppins SemiBold", 25.2F, FontStyle.Bold);
            bigLabel3.ForeColor = Color.FromArgb(255, 248, 231);
            bigLabel3.Location = new Point(53, 503);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(173, 74);
            bigLabel3.TabIndex = 8;
            bigLabel3.Text = "TOTAL:";
            // 
            // txtDescuento
            // 
            txtDescuento.AutoValidate = AutoValidate.EnablePreventFocusChange;
            txtDescuento.BackColor = Color.Transparent;
            txtDescuento.BorderColor = Color.FromArgb(220, 220, 220);
            txtDescuento.BorderRadius = 16;
            txtDescuento.BorderThickness = 1;
            txtDescuento.CharacterCasing = CharacterCasing.Normal;
            txtDescuento.FillColor = Color.FromArgb(255, 248, 231);
            txtDescuento.FocusBorderColor = Color.FromArgb(232, 174, 183);
            txtDescuento.Location = new Point(326, 424);
            txtDescuento.MaxLength = 32767;
            txtDescuento.Multiline = false;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.PlaceholderColor = Color.FromArgb(140, 140, 140);
            txtDescuento.PlaceholderText = "Escribí aquí...";
            txtDescuento.ScrollBars = ScrollBars.None;
            txtDescuento.ShadowColor = Color.FromArgb(25, 0, 0, 0);
            txtDescuento.ShadowOffset = 3;
            txtDescuento.Size = new Size(214, 41);
            txtDescuento.TabIndex = 7;
            txtDescuento.TextAlign = HorizontalAlignment.Left;
            txtDescuento.UseSystemPasswordChar = false;
            // 
            // txtGanancia
            // 
            txtGanancia.AutoValidate = AutoValidate.EnablePreventFocusChange;
            txtGanancia.BackColor = Color.Transparent;
            txtGanancia.BorderColor = Color.FromArgb(220, 220, 220);
            txtGanancia.BorderRadius = 16;
            txtGanancia.BorderThickness = 1;
            txtGanancia.CharacterCasing = CharacterCasing.Normal;
            txtGanancia.FillColor = Color.FromArgb(255, 248, 231);
            txtGanancia.FocusBorderColor = Color.FromArgb(232, 174, 183);
            txtGanancia.Location = new Point(326, 356);
            txtGanancia.MaxLength = 32767;
            txtGanancia.Multiline = false;
            txtGanancia.Name = "txtGanancia";
            txtGanancia.PlaceholderColor = Color.FromArgb(140, 140, 140);
            txtGanancia.PlaceholderText = "Escribí aquí...";
            txtGanancia.ScrollBars = ScrollBars.None;
            txtGanancia.ShadowColor = Color.FromArgb(25, 0, 0, 0);
            txtGanancia.ShadowOffset = 3;
            txtGanancia.Size = new Size(214, 41);
            txtGanancia.TabIndex = 6;
            txtGanancia.TextAlign = HorizontalAlignment.Left;
            txtGanancia.UseSystemPasswordChar = false;
            // 
            // txtSubtotalTec
            // 
            txtSubtotalTec.AutoValidate = AutoValidate.EnablePreventFocusChange;
            txtSubtotalTec.BackColor = Color.Transparent;
            txtSubtotalTec.BorderColor = Color.FromArgb(220, 220, 220);
            txtSubtotalTec.BorderRadius = 16;
            txtSubtotalTec.BorderThickness = 1;
            txtSubtotalTec.CharacterCasing = CharacterCasing.Normal;
            txtSubtotalTec.Enabled = false;
            txtSubtotalTec.FillColor = Color.FromArgb(255, 248, 231);
            txtSubtotalTec.FocusBorderColor = Color.FromArgb(232, 174, 183);
            txtSubtotalTec.Location = new Point(326, 288);
            txtSubtotalTec.MaxLength = 32767;
            txtSubtotalTec.Multiline = false;
            txtSubtotalTec.Name = "txtSubtotalTec";
            txtSubtotalTec.PlaceholderColor = Color.FromArgb(140, 140, 140);
            txtSubtotalTec.PlaceholderText = "";
            txtSubtotalTec.ScrollBars = ScrollBars.None;
            txtSubtotalTec.ShadowColor = Color.FromArgb(25, 0, 0, 0);
            txtSubtotalTec.ShadowOffset = 3;
            txtSubtotalTec.Size = new Size(214, 41);
            txtSubtotalTec.TabIndex = 5;
            txtSubtotalTec.TextAlign = HorizontalAlignment.Left;
            txtSubtotalTec.UseSystemPasswordChar = false;
            // 
            // txtMaquinaria
            // 
            txtMaquinaria.AutoValidate = AutoValidate.EnablePreventFocusChange;
            txtMaquinaria.BackColor = Color.Transparent;
            txtMaquinaria.BorderColor = Color.FromArgb(220, 220, 220);
            txtMaquinaria.BorderRadius = 16;
            txtMaquinaria.BorderThickness = 1;
            txtMaquinaria.CharacterCasing = CharacterCasing.Normal;
            txtMaquinaria.FillColor = Color.FromArgb(255, 248, 231);
            txtMaquinaria.FocusBorderColor = Color.FromArgb(232, 174, 183);
            txtMaquinaria.Location = new Point(326, 220);
            txtMaquinaria.MaxLength = 32767;
            txtMaquinaria.Multiline = false;
            txtMaquinaria.Name = "txtMaquinaria";
            txtMaquinaria.PlaceholderColor = Color.FromArgb(140, 140, 140);
            txtMaquinaria.PlaceholderText = "Escribí aquí...";
            txtMaquinaria.ScrollBars = ScrollBars.None;
            txtMaquinaria.ShadowColor = Color.FromArgb(25, 0, 0, 0);
            txtMaquinaria.ShadowOffset = 3;
            txtMaquinaria.Size = new Size(214, 41);
            txtMaquinaria.TabIndex = 4;
            txtMaquinaria.TextAlign = HorizontalAlignment.Left;
            txtMaquinaria.UseSystemPasswordChar = false;
            // 
            // txtMerma
            // 
            txtMerma.AutoValidate = AutoValidate.EnablePreventFocusChange;
            txtMerma.BackColor = Color.Transparent;
            txtMerma.BorderColor = Color.FromArgb(220, 220, 220);
            txtMerma.BorderRadius = 16;
            txtMerma.BorderThickness = 1;
            txtMerma.CharacterCasing = CharacterCasing.Normal;
            txtMerma.FillColor = Color.FromArgb(255, 248, 231);
            txtMerma.FocusBorderColor = Color.FromArgb(232, 174, 183);
            txtMerma.Location = new Point(326, 152);
            txtMerma.MaxLength = 32767;
            txtMerma.Multiline = false;
            txtMerma.Name = "txtMerma";
            txtMerma.PlaceholderColor = Color.FromArgb(140, 140, 140);
            txtMerma.PlaceholderText = "Escribí aquí...";
            txtMerma.ScrollBars = ScrollBars.None;
            txtMerma.ShadowColor = Color.FromArgb(25, 0, 0, 0);
            txtMerma.ShadowOffset = 3;
            txtMerma.Size = new Size(214, 41);
            txtMerma.TabIndex = 3;
            txtMerma.TextAlign = HorizontalAlignment.Left;
            txtMerma.UseSystemPasswordChar = false;
            // 
            // txtCostoTotal
            // 
            txtCostoTotal.AutoValidate = AutoValidate.EnablePreventFocusChange;
            txtCostoTotal.BackColor = Color.Transparent;
            txtCostoTotal.BorderColor = Color.FromArgb(220, 220, 220);
            txtCostoTotal.BorderRadius = 16;
            txtCostoTotal.BorderThickness = 1;
            txtCostoTotal.CharacterCasing = CharacterCasing.Normal;
            txtCostoTotal.Enabled = false;
            txtCostoTotal.FillColor = Color.FromArgb(255, 248, 231);
            txtCostoTotal.FocusBorderColor = Color.FromArgb(232, 174, 183);
            txtCostoTotal.Location = new Point(326, 84);
            txtCostoTotal.MaxLength = 32767;
            txtCostoTotal.Multiline = false;
            txtCostoTotal.Name = "txtCostoTotal";
            txtCostoTotal.PlaceholderColor = Color.FromArgb(140, 140, 140);
            txtCostoTotal.PlaceholderText = "";
            txtCostoTotal.ScrollBars = ScrollBars.None;
            txtCostoTotal.ShadowColor = Color.FromArgb(25, 0, 0, 0);
            txtCostoTotal.ShadowOffset = 3;
            txtCostoTotal.Size = new Size(214, 41);
            txtCostoTotal.TabIndex = 2;
            txtCostoTotal.TextAlign = HorizontalAlignment.Left;
            txtCostoTotal.UseSystemPasswordChar = false;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.FlatStyle = FlatStyle.Popup;
            bigLabel2.Font = new Font("Poppins SemiBold", 25.2F, FontStyle.Bold);
            bigLabel2.ForeColor = Color.FromArgb(255, 248, 231);
            bigLabel2.Location = new Point(193, 0);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(227, 74);
            bigLabel2.TabIndex = 1;
            bigLabel2.Text = "RESÚMEN";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BorderRadius = 100;
            btnGuardar.ButtonTextColor = Color.White;
            btnGuardar.FillColor = Color.FromArgb(158, 24, 43);
            btnGuardar.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.HoverLift = 2;
            btnGuardar.Location = new Point(719, 632);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.ShadowColor = Color.FromArgb(45, 0, 0, 0);
            btnGuardar.ShadowOffset = 4;
            btnGuardar.Size = new Size(178, 47);
            btnGuardar.TabIndex = 2;
            btnGuardar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.BackColor = Color.Transparent;
            btnGenerarPDF.BorderRadius = 100;
            btnGenerarPDF.ButtonTextColor = Color.White;
            btnGenerarPDF.FillColor = Color.FromArgb(158, 24, 43);
            btnGenerarPDF.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarPDF.HoverLift = 2;
            btnGenerarPDF.Location = new Point(513, 632);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.ShadowColor = Color.FromArgb(45, 0, 0, 0);
            btnGenerarPDF.ShadowOffset = 4;
            btnGenerarPDF.Size = new Size(178, 47);
            btnGenerarPDF.TabIndex = 3;
            btnGenerarPDF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoBox
            // 
            logoBox.Location = new Point(1330, 2);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(65, 32);
            logoBox.TabIndex = 7;
            logoBox.TabStop = false;
            logoBox.Click += logoBox_Click;
            // 
            // PresupuestadorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 231);
            ClientSize = new Size(1399, 686);
            Controls.Add(logoBox);
            Controls.Add(btnGenerarPDF);
            Controls.Add(btnGuardar);
            Controls.Add(shadowRoundedPanel2);
            Controls.Add(shadowRoundedPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PresupuestadorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PresupuestadorForm";
            Load += PresupuestadorForm_Load;
            shadowRoundedPanel1.ResumeLayout(false);
            shadowRoundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuesto).EndInit();
            shadowRoundedPanel2.ResumeLayout(false);
            shadowRoundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.CARMIN.UI.Controls.ShadowRoundedPanel shadowRoundedPanel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Controls.CARMIN.UI.Controls.ShadowRoundedPanel shadowRoundedPanel2;
        private Controls.ShadowRoundedButton btnElim;
        private Controls.ShadowRoundedButton btnAg;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvPresupuesto;
        private Controls.CARMIN.UI.Controls.ShadowRoundedTextBox txtCostoTotal;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private Controls.CARMIN.UI.Controls.ShadowRoundedTextBox txtTotalFinal;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private Controls.CARMIN.UI.Controls.ShadowRoundedTextBox txtDescuento;
        private Controls.CARMIN.UI.Controls.ShadowRoundedTextBox txtGanancia;
        private Controls.CARMIN.UI.Controls.ShadowRoundedTextBox txtSubtotalTec;
        private Controls.CARMIN.UI.Controls.ShadowRoundedTextBox txtMaquinaria;
        private Controls.CARMIN.UI.Controls.ShadowRoundedTextBox txtMerma;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel9;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private Controls.ShadowRoundedButton btnGuardar;
        private Controls.ShadowRoundedButton btnGenerarPDF;
        private PictureBox logoBox;
    }
}