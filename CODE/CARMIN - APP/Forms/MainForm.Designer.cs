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
            buttonPedidos = new CARMIN___APP.Controls.ShadowRoundedButton();
            buttonPresupuesto = new CARMIN___APP.Controls.ShadowRoundedButton();
            buttonStock = new CARMIN___APP.Controls.ShadowRoundedButton();
            buttonCostos = new CARMIN___APP.Controls.ShadowRoundedButton();
            buttonFinanzas = new CARMIN___APP.Controls.ShadowRoundedButton();
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            logoBox = new PictureBox();
            salirToolStripMenuItem = new ToolStripMenuItem();
            sISTEMAToolStripMenuItem1 = new ToolStripMenuItem();
            sISTEMAToolStripMenuItem2 = new ToolStripMenuItem();
            sALIRToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // buttonPedidos
            // 
            buttonPedidos.BackColor = Color.FromArgb(255, 248, 231);
            buttonPedidos.BorderRadius = 100;
            buttonPedidos.ButtonTextColor = Color.FromArgb(255, 248, 231);
            buttonPedidos.FillColor = Color.FromArgb(158, 24, 43);
            buttonPedidos.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPedidos.HoverLift = 2;
            buttonPedidos.Location = new Point(73, 83);
            buttonPedidos.Name = "buttonPedidos";
            buttonPedidos.ShadowColor = Color.FromArgb(45, 0, 0, 0);
            buttonPedidos.ShadowOffset = 4;
            buttonPedidos.Size = new Size(393, 167);
            buttonPedidos.TabIndex = 6;
            buttonPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonPresupuesto
            // 
            buttonPresupuesto.BackColor = Color.FromArgb(255, 248, 231);
            buttonPresupuesto.BorderRadius = 100;
            buttonPresupuesto.ButtonTextColor = Color.FromArgb(255, 248, 231);
            buttonPresupuesto.FillColor = Color.FromArgb(158, 24, 43);
            buttonPresupuesto.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPresupuesto.HoverLift = 2;
            buttonPresupuesto.Location = new Point(508, 83);
            buttonPresupuesto.Name = "buttonPresupuesto";
            buttonPresupuesto.ShadowColor = Color.FromArgb(45, 0, 0, 0);
            buttonPresupuesto.ShadowOffset = 4;
            buttonPresupuesto.Size = new Size(393, 167);
            buttonPresupuesto.TabIndex = 7;
            buttonPresupuesto.TextAlign = ContentAlignment.MiddleCenter;
            buttonPresupuesto.Load += buttonPresupuesto_Load;
            buttonPresupuesto.Click += buttonPresupuesto_Click;
            // 
            // buttonStock
            // 
            buttonStock.BackColor = Color.FromArgb(255, 248, 231);
            buttonStock.BorderRadius = 100;
            buttonStock.ButtonTextColor = Color.FromArgb(255, 248, 231);
            buttonStock.FillColor = Color.FromArgb(158, 24, 43);
            buttonStock.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStock.HoverLift = 2;
            buttonStock.Location = new Point(73, 287);
            buttonStock.Name = "buttonStock";
            buttonStock.ShadowColor = Color.FromArgb(45, 0, 0, 0);
            buttonStock.ShadowOffset = 4;
            buttonStock.Size = new Size(393, 167);
            buttonStock.TabIndex = 8;
            buttonStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCostos
            // 
            buttonCostos.BackColor = Color.FromArgb(255, 248, 231);
            buttonCostos.BorderRadius = 100;
            buttonCostos.ButtonTextColor = Color.FromArgb(255, 248, 231);
            buttonCostos.FillColor = Color.FromArgb(158, 24, 43);
            buttonCostos.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCostos.HoverLift = 2;
            buttonCostos.Location = new Point(508, 287);
            buttonCostos.Name = "buttonCostos";
            buttonCostos.ShadowColor = Color.FromArgb(45, 0, 0, 0);
            buttonCostos.ShadowOffset = 4;
            buttonCostos.Size = new Size(393, 167);
            buttonCostos.TabIndex = 9;
            buttonCostos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonFinanzas
            // 
            buttonFinanzas.BackColor = Color.FromArgb(255, 248, 231);
            buttonFinanzas.BorderRadius = 100;
            buttonFinanzas.ButtonTextColor = Color.FromArgb(255, 248, 231);
            buttonFinanzas.FillColor = Color.FromArgb(158, 24, 43);
            buttonFinanzas.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFinanzas.HoverLift = 2;
            buttonFinanzas.Location = new Point(260, 483);
            buttonFinanzas.Name = "buttonFinanzas";
            buttonFinanzas.ShadowColor = Color.FromArgb(45, 0, 0, 0);
            buttonFinanzas.ShadowOffset = 4;
            buttonFinanzas.Size = new Size(393, 167);
            buttonFinanzas.TabIndex = 10;
            buttonFinanzas.TextAlign = ContentAlignment.MiddleCenter;
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
            menuStrip1.Size = new Size(1399, 44);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(14, 40);
            // 
            // logoBox
            // 
            logoBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoBox.BackColor = Color.Transparent;
            logoBox.Location = new Point(1017, 242);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(370, 282);
            logoBox.TabIndex = 13;
            logoBox.TabStop = false;
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
            // sISTEMAToolStripMenuItem2
            // 
            sISTEMAToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { sALIRToolStripMenuItem1 });
            sISTEMAToolStripMenuItem2.Name = "sISTEMAToolStripMenuItem2";
            sISTEMAToolStripMenuItem2.Size = new Size(94, 40);
            sISTEMAToolStripMenuItem2.Text = "SISTEMA";
            // 
            // sALIRToolStripMenuItem1
            // 
            sALIRToolStripMenuItem1.Name = "sALIRToolStripMenuItem1";
            sALIRToolStripMenuItem1.Size = new Size(224, 30);
            sALIRToolStripMenuItem1.Text = "SALIR";
            sALIRToolStripMenuItem1.Click += sALIRToolStripMenuItem1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 231);
            ClientSize = new Size(1399, 686);
            Controls.Add(logoBox);
            Controls.Add(buttonFinanzas);
            Controls.Add(buttonCostos);
            Controls.Add(buttonStock);
            Controls.Add(buttonPresupuesto);
            Controls.Add(buttonPedidos);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.ShadowRoundedButton shadowRoundedButton1;
        private Controls.ShadowRoundedButton shadowRoundedButton2;
        private Controls.ShadowRoundedButton shadowRoundedButton3;
        private Controls.ShadowRoundedButton shadowRoundedButton4;
        private Controls.ShadowRoundedButton shadowRoundedButton5;
        private Controls.ShadowRoundedButton buttonPedidos;
        private Controls.ShadowRoundedButton buttonPresupuesto;
        private Controls.ShadowRoundedButton buttonStock;
        private Controls.ShadowRoundedButton buttonCostos;
        private Controls.ShadowRoundedButton buttonFinanzas;
        private MenuStrip menuStrip1;
        private PictureBox logoBox;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem sISTEMAToolStripMenuItem1;
        private ToolStripMenuItem sISTEMAToolStripMenuItem2;
        private ToolStripMenuItem sALIRToolStripMenuItem1;
    }
}