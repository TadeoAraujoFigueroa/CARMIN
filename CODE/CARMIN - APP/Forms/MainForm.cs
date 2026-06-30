using CARMIN___BLL.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARMIN___APP.Forms
{
    public partial class MainForm : Form
    {
        Form presupuestadorForm;
        Form seleccionDeCostosForm;
        Form stockForm;
        Form pedidosForm;
        Form clientesForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            try
            {
                logoBox.Image = Image.FromFile(ConfigHelper.GetRuta("Logo"));

                //Cargamos los eventos de los botones
                logoBox.SizeMode = PictureBoxSizeMode.Zoom;
                buttonPedidosNew.Click += buttonPedidos_Click;
                btnClientesNew.Click += btnClientes_Click;
                buttonFinanzasNew.Click += buttonFinanzas_Click;
                buttonPresupuestoNew.Click += buttonPresupuesto_Click;
                buttonCostosNew.Click += buttonCostos_Click;
                buttonStockNew.Click += buttonStock_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la aplicación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ResumeLayout();
            }


        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            AjustarLayout();
            tableLayoutPanel1.BringToFront();

        }
        private void AjustarLayout()
        {
            try
            {

                // Configuración del logo
                logoBox.SendToBack();


                tableLayoutPanel.Size = new Size(
                    (int)(this.ClientSize.Width - 200),
                    (int)(this.ClientSize.Height - 200)
);

                tableLayoutPanel.Location = new Point((this.ClientSize.Width - tableLayoutPanel.Width) / 2, (this.ClientSize.Height - tableLayoutPanel.Height) / 2);

                logoBox.SizeMode = PictureBoxSizeMode.Zoom;

                //Configuramos el panel de botones para que llene todo el espacio disponible
                tableLayoutPanel1.Dock = DockStyle.Fill;
                tableLayoutPanel1.BackColor = Color.FromArgb(255, 248, 230);



                tableLayoutPanel1.ColumnStyles.Clear();
                tableLayoutPanel1.RowStyles.Clear();

                for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                }

                for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
                {
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33f));
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void CambiarForm(Form form)
        {
            try
            {
                form.Owner = this;
                form.Show();
                this.Hide();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        #region "FUNCIONES DE BOTONES"

        private void buttonPresupuesto_Click(object sender, EventArgs e)
        {
            try
            {
                if(presupuestadorForm == null)
                {
                    presupuestadorForm= new PresupuestadorForm();
                }
                
                CambiarForm(presupuestadorForm);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCostos_Click(object sender, EventArgs e)
        {
            try
            {
                if(seleccionDeCostosForm == null)
                {
                   seleccionDeCostosForm = new SeleccionCargaForm();
                }
                
                CambiarForm(seleccionDeCostosForm);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            try
            {
                if(stockForm == null)
                {
                    stockForm = new ControlStockForm();
                }
                
                CambiarForm(stockForm);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                if(pedidosForm == null)
                {
                     pedidosForm = new PedidosForm();
                }
                
                CambiarForm(pedidosForm);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            try
            {
                if(clientesForm == null)
                {
                    clientesForm = new ClientesForm();
                }
               
                CambiarForm(clientesForm);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonFinanzas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OH NO CHA CHA, esta función todavía está en desarrollo :(");
        }

        #endregion

        #region "FUNCIONES NO UTILIZADAS"

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonPedidos_Load(object sender, EventArgs e)
        {

        }
        private void shadowRoundedButton1_Load(object sender, EventArgs e)
        {
        }
        private void buttonPresupuesto_Load(object sender, EventArgs e)
        {


        }
        private void buttonCostos_Load(object sender, EventArgs e)
        {

        }
        #endregion




   

       
    }
}
