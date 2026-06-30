namespace CARMIN___APP.Forms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            sISTEMAToolStripMenuItem2 = new ToolStripMenuItem();
            sALIRToolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            sISTEMAToolStripMenuItem1 = new ToolStripMenuItem();
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnClientesNew = new ReaLTaiizor.Controls.CyberButton();
            buttonFinanzasNew = new ReaLTaiizor.Controls.CyberButton();
            buttonCostosNew = new ReaLTaiizor.Controls.CyberButton();
            buttonStockNew = new ReaLTaiizor.Controls.CyberButton();
            buttonPresupuestoNew = new ReaLTaiizor.Controls.CyberButton();
            buttonPedidosNew = new ReaLTaiizor.Controls.CyberButton();
            logoBox = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(158, 24, 43);
            menuStrip1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, sISTEMAToolStripMenuItem2 });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1556, 55);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(14, 51);
            // 
            // sISTEMAToolStripMenuItem2
            // 
            sISTEMAToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { sALIRToolStripMenuItem1 });
            sISTEMAToolStripMenuItem2.Name = "sISTEMAToolStripMenuItem2";
            sISTEMAToolStripMenuItem2.Size = new Size(94, 51);
            sISTEMAToolStripMenuItem2.Text = "SISTEMA";
            // 
            // sALIRToolStripMenuItem1
            // 
            sALIRToolStripMenuItem1.Name = "sALIRToolStripMenuItem1";
            sALIRToolStripMenuItem1.Size = new Size(142, 30);
            sALIRToolStripMenuItem1.Text = "SALIR";
            sALIRToolStripMenuItem1.Click += sALIRToolStripMenuItem1_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(32, 19);
            // 
            // sISTEMAToolStripMenuItem1
            // 
            sISTEMAToolStripMenuItem1.Name = "sISTEMAToolStripMenuItem1";
            sISTEMAToolStripMenuItem1.Size = new Size(32, 19);
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel.Controls.Add(logoBox, 1, 0);
            tableLayoutPanel.Location = new Point(258, 222);
            tableLayoutPanel.Margin = new Padding(4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(2320, 804);
            tableLayoutPanel.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnClientesNew, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonFinanzasNew, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonCostosNew, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonStockNew, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonPresupuestoNew, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonPedidosNew, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Size = new Size(1384, 796);
            tableLayoutPanel1.TabIndex = 16;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // btnClientesNew
            // 
            btnClientesNew.Alpha = 20;
            btnClientesNew.BackColor = Color.Transparent;
            btnClientesNew.Background = true;
            btnClientesNew.Background_WidthPen = 4F;
            btnClientesNew.BackgroundPen = true;
            btnClientesNew.ColorBackground = Color.FromArgb(158, 24, 43);
            btnClientesNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnClientesNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnClientesNew.ColorBackground_Pen = Color.DarkGray;
            btnClientesNew.ColorLighting = Color.FromArgb(29, 200, 238);
            btnClientesNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnClientesNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnClientesNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnClientesNew.Dock = DockStyle.Fill;
            btnClientesNew.Effect_1 = true;
            btnClientesNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnClientesNew.Effect_1_Transparency = 25;
            btnClientesNew.Effect_2 = true;
            btnClientesNew.Effect_2_ColorBackground = Color.White;
            btnClientesNew.Effect_2_Transparency = 20;
            btnClientesNew.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientesNew.ForeColor = Color.FromArgb(245, 245, 245);
            btnClientesNew.Lighting = false;
            btnClientesNew.LinearGradient_Background = false;
            btnClientesNew.LinearGradientPen = false;
            btnClientesNew.Location = new Point(712, 550);
            btnClientesNew.Margin = new Padding(20);
            btnClientesNew.Name = "btnClientesNew";
            btnClientesNew.Padding = new Padding(24);
            btnClientesNew.PenWidth = 15;
            btnClientesNew.Rounding = true;
            btnClientesNew.RoundingInt = 70;
            btnClientesNew.Size = new Size(652, 226);
            btnClientesNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnClientesNew.TabIndex = 17;
            btnClientesNew.Tag = "Cyber";
            btnClientesNew.TextButton = "CLIENTES";
            btnClientesNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClientesNew.Timer_Effect_1 = 5;
            btnClientesNew.Timer_RGB = 300;
            // 
            // buttonFinanzasNew
            // 
            buttonFinanzasNew.Alpha = 20;
            buttonFinanzasNew.BackColor = Color.Transparent;
            buttonFinanzasNew.Background = true;
            buttonFinanzasNew.Background_WidthPen = 4F;
            buttonFinanzasNew.BackgroundPen = true;
            buttonFinanzasNew.ColorBackground = Color.FromArgb(158, 24, 43);
            buttonFinanzasNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonFinanzasNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonFinanzasNew.ColorBackground_Pen = Color.DarkGray;
            buttonFinanzasNew.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonFinanzasNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonFinanzasNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonFinanzasNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonFinanzasNew.Dock = DockStyle.Fill;
            buttonFinanzasNew.Effect_1 = true;
            buttonFinanzasNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonFinanzasNew.Effect_1_Transparency = 25;
            buttonFinanzasNew.Effect_2 = true;
            buttonFinanzasNew.Effect_2_ColorBackground = Color.White;
            buttonFinanzasNew.Effect_2_Transparency = 20;
            buttonFinanzasNew.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFinanzasNew.ForeColor = Color.FromArgb(245, 245, 245);
            buttonFinanzasNew.Lighting = false;
            buttonFinanzasNew.LinearGradient_Background = false;
            buttonFinanzasNew.LinearGradientPen = false;
            buttonFinanzasNew.Location = new Point(20, 550);
            buttonFinanzasNew.Margin = new Padding(20);
            buttonFinanzasNew.Name = "buttonFinanzasNew";
            buttonFinanzasNew.Padding = new Padding(24);
            buttonFinanzasNew.PenWidth = 15;
            buttonFinanzasNew.Rounding = true;
            buttonFinanzasNew.RoundingInt = 70;
            buttonFinanzasNew.Size = new Size(652, 226);
            buttonFinanzasNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonFinanzasNew.TabIndex = 16;
            buttonFinanzasNew.Tag = "Cyber";
            buttonFinanzasNew.TextButton = "FINANZAS";
            buttonFinanzasNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonFinanzasNew.Timer_Effect_1 = 5;
            buttonFinanzasNew.Timer_RGB = 300;
            // 
            // buttonCostosNew
            // 
            buttonCostosNew.Alpha = 20;
            buttonCostosNew.BackColor = Color.Transparent;
            buttonCostosNew.Background = true;
            buttonCostosNew.Background_WidthPen = 4F;
            buttonCostosNew.BackgroundPen = true;
            buttonCostosNew.ColorBackground = Color.FromArgb(158, 24, 43);
            buttonCostosNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonCostosNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonCostosNew.ColorBackground_Pen = Color.DarkGray;
            buttonCostosNew.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonCostosNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonCostosNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonCostosNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonCostosNew.Dock = DockStyle.Fill;
            buttonCostosNew.Effect_1 = true;
            buttonCostosNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonCostosNew.Effect_1_Transparency = 25;
            buttonCostosNew.Effect_2 = true;
            buttonCostosNew.Effect_2_ColorBackground = Color.White;
            buttonCostosNew.Effect_2_Transparency = 20;
            buttonCostosNew.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCostosNew.ForeColor = Color.FromArgb(245, 245, 245);
            buttonCostosNew.Lighting = false;
            buttonCostosNew.LinearGradient_Background = false;
            buttonCostosNew.LinearGradientPen = false;
            buttonCostosNew.Location = new Point(712, 285);
            buttonCostosNew.Margin = new Padding(20);
            buttonCostosNew.Name = "buttonCostosNew";
            buttonCostosNew.Padding = new Padding(24);
            buttonCostosNew.PenWidth = 15;
            buttonCostosNew.Rounding = true;
            buttonCostosNew.RoundingInt = 70;
            buttonCostosNew.Size = new Size(652, 225);
            buttonCostosNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonCostosNew.TabIndex = 15;
            buttonCostosNew.Tag = "Cyber";
            buttonCostosNew.TextButton = "COSTOS";
            buttonCostosNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonCostosNew.Timer_Effect_1 = 5;
            buttonCostosNew.Timer_RGB = 300;
            // 
            // buttonStockNew
            // 
            buttonStockNew.Alpha = 20;
            buttonStockNew.BackColor = Color.Transparent;
            buttonStockNew.Background = true;
            buttonStockNew.Background_WidthPen = 4F;
            buttonStockNew.BackgroundPen = true;
            buttonStockNew.ColorBackground = Color.FromArgb(158, 24, 43);
            buttonStockNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonStockNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonStockNew.ColorBackground_Pen = Color.DarkGray;
            buttonStockNew.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonStockNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonStockNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonStockNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonStockNew.Dock = DockStyle.Fill;
            buttonStockNew.Effect_1 = true;
            buttonStockNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonStockNew.Effect_1_Transparency = 25;
            buttonStockNew.Effect_2 = true;
            buttonStockNew.Effect_2_ColorBackground = Color.White;
            buttonStockNew.Effect_2_Transparency = 20;
            buttonStockNew.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStockNew.ForeColor = Color.FromArgb(245, 245, 245);
            buttonStockNew.Lighting = false;
            buttonStockNew.LinearGradient_Background = false;
            buttonStockNew.LinearGradientPen = false;
            buttonStockNew.Location = new Point(20, 285);
            buttonStockNew.Margin = new Padding(20);
            buttonStockNew.Name = "buttonStockNew";
            buttonStockNew.Padding = new Padding(24);
            buttonStockNew.PenWidth = 15;
            buttonStockNew.Rounding = true;
            buttonStockNew.RoundingInt = 70;
            buttonStockNew.Size = new Size(652, 225);
            buttonStockNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonStockNew.TabIndex = 14;
            buttonStockNew.Tag = "Cyber";
            buttonStockNew.TextButton = "STOCK";
            buttonStockNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonStockNew.Timer_Effect_1 = 5;
            buttonStockNew.Timer_RGB = 300;
            // 
            // buttonPresupuestoNew
            // 
            buttonPresupuestoNew.Alpha = 20;
            buttonPresupuestoNew.BackColor = Color.Transparent;
            buttonPresupuestoNew.Background = true;
            buttonPresupuestoNew.Background_WidthPen = 4F;
            buttonPresupuestoNew.BackgroundPen = true;
            buttonPresupuestoNew.ColorBackground = Color.FromArgb(158, 24, 43);
            buttonPresupuestoNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonPresupuestoNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonPresupuestoNew.ColorBackground_Pen = Color.DarkGray;
            buttonPresupuestoNew.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonPresupuestoNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonPresupuestoNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonPresupuestoNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonPresupuestoNew.Dock = DockStyle.Fill;
            buttonPresupuestoNew.Effect_1 = true;
            buttonPresupuestoNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonPresupuestoNew.Effect_1_Transparency = 25;
            buttonPresupuestoNew.Effect_2 = true;
            buttonPresupuestoNew.Effect_2_ColorBackground = Color.White;
            buttonPresupuestoNew.Effect_2_Transparency = 20;
            buttonPresupuestoNew.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPresupuestoNew.ForeColor = Color.FromArgb(245, 245, 245);
            buttonPresupuestoNew.Lighting = false;
            buttonPresupuestoNew.LinearGradient_Background = false;
            buttonPresupuestoNew.LinearGradientPen = false;
            buttonPresupuestoNew.Location = new Point(712, 20);
            buttonPresupuestoNew.Margin = new Padding(20);
            buttonPresupuestoNew.Name = "buttonPresupuestoNew";
            buttonPresupuestoNew.Padding = new Padding(24);
            buttonPresupuestoNew.PenWidth = 15;
            buttonPresupuestoNew.Rounding = true;
            buttonPresupuestoNew.RoundingInt = 70;
            buttonPresupuestoNew.Size = new Size(652, 225);
            buttonPresupuestoNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonPresupuestoNew.TabIndex = 13;
            buttonPresupuestoNew.Tag = "Cyber";
            buttonPresupuestoNew.TextButton = "PRESUPUESTO";
            buttonPresupuestoNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonPresupuestoNew.Timer_Effect_1 = 5;
            buttonPresupuestoNew.Timer_RGB = 300;
            // 
            // buttonPedidosNew
            // 
            buttonPedidosNew.Alpha = 20;
            buttonPedidosNew.BackColor = Color.Transparent;
            buttonPedidosNew.Background = true;
            buttonPedidosNew.Background_WidthPen = 4F;
            buttonPedidosNew.BackgroundPen = true;
            buttonPedidosNew.ColorBackground = Color.FromArgb(158, 24, 43);
            buttonPedidosNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonPedidosNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonPedidosNew.ColorBackground_Pen = Color.DarkGray;
            buttonPedidosNew.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonPedidosNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonPedidosNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonPedidosNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonPedidosNew.Dock = DockStyle.Fill;
            buttonPedidosNew.Effect_1 = true;
            buttonPedidosNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonPedidosNew.Effect_1_Transparency = 25;
            buttonPedidosNew.Effect_2 = true;
            buttonPedidosNew.Effect_2_ColorBackground = Color.White;
            buttonPedidosNew.Effect_2_Transparency = 20;
            buttonPedidosNew.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPedidosNew.ForeColor = Color.FromArgb(245, 245, 245);
            buttonPedidosNew.Lighting = false;
            buttonPedidosNew.LinearGradient_Background = false;
            buttonPedidosNew.LinearGradientPen = false;
            buttonPedidosNew.Location = new Point(20, 20);
            buttonPedidosNew.Margin = new Padding(20);
            buttonPedidosNew.Name = "buttonPedidosNew";
            buttonPedidosNew.Padding = new Padding(24);
            buttonPedidosNew.PenWidth = 15;
            buttonPedidosNew.Rounding = true;
            buttonPedidosNew.RoundingInt = 70;
            buttonPedidosNew.Size = new Size(652, 225);
            buttonPedidosNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonPedidosNew.TabIndex = 12;
            buttonPedidosNew.Tag = "Cyber";
            buttonPedidosNew.TextButton = "PEDIDOS";
            buttonPedidosNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonPedidosNew.Timer_Effect_1 = 5;
            buttonPedidosNew.Timer_RGB = 300;
            // 
            // logoBox
            // 
            logoBox.Anchor = AnchorStyles.None;
            logoBox.BackColor = Color.Transparent;
            logoBox.Location = new Point(1396, 4);
            logoBox.Margin = new Padding(4);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(920, 796);
            logoBox.TabIndex = 13;
            logoBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(255, 248, 231);
            ClientSize = new Size(1556, 882);
            Controls.Add(tableLayoutPanel);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.ShadowRoundedButton shadowRoundedButton1;
        private Controls.ShadowRoundedButton shadowRoundedButton2;
        private Controls.ShadowRoundedButton shadowRoundedButton3;
        private Controls.ShadowRoundedButton shadowRoundedButton4;
        private Controls.ShadowRoundedButton shadowRoundedButton5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem sISTEMAToolStripMenuItem1;
        private ToolStripMenuItem sISTEMAToolStripMenuItem2;
        private ToolStripMenuItem sALIRToolStripMenuItem1;
        private TableLayoutPanel tableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox logoBox;
        private ReaLTaiizor.Controls.CyberButton buttonPedidosNew;
        private ReaLTaiizor.Controls.CyberButton btnClientesNew;
        private ReaLTaiizor.Controls.CyberButton buttonFinanzasNew;
        private ReaLTaiizor.Controls.CyberButton buttonCostosNew;
        private ReaLTaiizor.Controls.CyberButton buttonStockNew;
        private ReaLTaiizor.Controls.CyberButton buttonPresupuestoNew;
    }
}