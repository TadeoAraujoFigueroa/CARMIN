namespace CARMIN___APP.Forms
{
    partial class PedidosForm
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
            mainPanel = new CARMIN___APP.Controls.CARMIN.UI.Controls.ShadowRoundedPanel();
            panelBotones = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCrearPedidoNew = new ReaLTaiizor.Controls.CyberButton();
            btnControlDePedidosNew = new ReaLTaiizor.Controls.CyberButton();
            logoBox = new PictureBox();
            mainPanel.SuspendLayout();
            panelBotones.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.BorderColor = Color.FromArgb(255, 248, 231);
            mainPanel.BorderRadius = 20;
            mainPanel.BorderThickness = 1;
            mainPanel.ContentTopPadding = 42;
            mainPanel.Controls.Add(panelBotones);
            mainPanel.Controls.Add(logoBox);
            mainPanel.FillColor = Color.FromArgb(255, 248, 231);
            mainPanel.Location = new Point(-6, 20);
            mainPanel.Margin = new Padding(4);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(22, 52, 22, 22);
            mainPanel.ShadowColor = Color.FromArgb(18, 0, 0, 0);
            mainPanel.ShadowOffset = 4;
            mainPanel.Size = new Size(2290, 1258);
            mainPanel.TabIndex = 1;
            mainPanel.Title = "";
            mainPanel.TitleColor = Color.FromArgb(60, 60, 60);
            mainPanel.TitleFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            mainPanel.TitlePaddingLeft = 18;
            mainPanel.TitlePaddingTop = 14;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(tableLayoutPanel1);
            panelBotones.Location = new Point(471, 461);
            panelBotones.Margin = new Padding(4);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1601, 335);
            panelBotones.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnCrearPedidoNew, 1, 0);
            tableLayoutPanel1.Controls.Add(btnControlDePedidosNew, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1601, 335);
            tableLayoutPanel1.TabIndex = 0;
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
            btnCrearPedidoNew.ColorBackground_Pen = Color.DarkGray;
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
            btnCrearPedidoNew.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearPedidoNew.ForeColor = Color.FromArgb(245, 245, 245);
            btnCrearPedidoNew.Lighting = false;
            btnCrearPedidoNew.LinearGradient_Background = false;
            btnCrearPedidoNew.LinearGradientPen = false;
            btnCrearPedidoNew.Location = new Point(810, 10);
            btnCrearPedidoNew.Margin = new Padding(10);
            btnCrearPedidoNew.Name = "btnCrearPedidoNew";
            btnCrearPedidoNew.Padding = new Padding(19);
            btnCrearPedidoNew.PenWidth = 15;
            btnCrearPedidoNew.Rounding = true;
            btnCrearPedidoNew.RoundingInt = 70;
            btnCrearPedidoNew.Size = new Size(781, 315);
            btnCrearPedidoNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCrearPedidoNew.TabIndex = 4;
            btnCrearPedidoNew.Tag = "Cyber";
            btnCrearPedidoNew.TextButton = "CREAR PEDIDO";
            btnCrearPedidoNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCrearPedidoNew.Timer_Effect_1 = 5;
            btnCrearPedidoNew.Timer_RGB = 300;
            // 
            // btnControlDePedidosNew
            // 
            btnControlDePedidosNew.Alpha = 20;
            btnControlDePedidosNew.BackColor = Color.Transparent;
            btnControlDePedidosNew.Background = true;
            btnControlDePedidosNew.Background_WidthPen = 4F;
            btnControlDePedidosNew.BackgroundPen = true;
            btnControlDePedidosNew.ColorBackground = Color.FromArgb(158, 24, 43);
            btnControlDePedidosNew.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnControlDePedidosNew.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnControlDePedidosNew.ColorBackground_Pen = Color.DarkGray;
            btnControlDePedidosNew.ColorLighting = Color.FromArgb(29, 200, 238);
            btnControlDePedidosNew.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnControlDePedidosNew.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnControlDePedidosNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnControlDePedidosNew.Dock = DockStyle.Fill;
            btnControlDePedidosNew.Effect_1 = true;
            btnControlDePedidosNew.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnControlDePedidosNew.Effect_1_Transparency = 25;
            btnControlDePedidosNew.Effect_2 = true;
            btnControlDePedidosNew.Effect_2_ColorBackground = Color.White;
            btnControlDePedidosNew.Effect_2_Transparency = 20;
            btnControlDePedidosNew.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnControlDePedidosNew.ForeColor = Color.FromArgb(245, 245, 245);
            btnControlDePedidosNew.Lighting = false;
            btnControlDePedidosNew.LinearGradient_Background = false;
            btnControlDePedidosNew.LinearGradientPen = false;
            btnControlDePedidosNew.Location = new Point(10, 10);
            btnControlDePedidosNew.Margin = new Padding(10);
            btnControlDePedidosNew.Name = "btnControlDePedidosNew";
            btnControlDePedidosNew.Padding = new Padding(19);
            btnControlDePedidosNew.PenWidth = 15;
            btnControlDePedidosNew.Rounding = true;
            btnControlDePedidosNew.RoundingInt = 70;
            btnControlDePedidosNew.Size = new Size(780, 315);
            btnControlDePedidosNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnControlDePedidosNew.TabIndex = 3;
            btnControlDePedidosNew.Tag = "Cyber";
            btnControlDePedidosNew.TextButton = "CONTROL DE PEDIDOS";
            btnControlDePedidosNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnControlDePedidosNew.Timer_Effect_1 = 5;
            btnControlDePedidosNew.Timer_RGB = 300;
            // 
            // logoBox
            // 
            logoBox.Location = new Point(2169, 28);
            logoBox.Margin = new Padding(4);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(81, 40);
            logoBox.TabIndex = 25;
            logoBox.TabStop = false;
            logoBox.Click += logoBox_Click_1;
            // 
            // PedidosForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(158, 24, 43);
            ClientSize = new Size(2279, 1299);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "PedidosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PedidosForm";
            WindowState = FormWindowState.Maximized;
            Load += PedidosForm_Load;
            Shown += PedidosForm_Shown;
            mainPanel.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.CARMIN.UI.Controls.ShadowRoundedPanel mainPanel;
        private PictureBox logoBox;
        private Panel panelBotones;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.CyberButton btnCrearPedidoNew;
        private ReaLTaiizor.Controls.CyberButton btnControlDePedidosNew;
    }
}