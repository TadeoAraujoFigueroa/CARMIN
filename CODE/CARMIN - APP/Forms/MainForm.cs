using CARMIN___BLL.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Inicialización de variables

                activeForm = this;

                // Configuración de botones
                buttonPedidos.Text = "PEDIDOS";
                buttonCostos.Text = "COSTOS";
                buttonFinanzas.Text = "FINANZAS";
                buttonStock.Text = "STOCK";
                buttonPresupuesto.Text = "PRESUPUESTOS";

                // Configuración del logo
                logoBox.SendToBack();
                logoBox.Image = Image.FromFile(ConfigHelper.Configuration["Rutas:Logo"] + "\\logo.png");
                logoBox.SizeMode = PictureBoxSizeMode.Zoom;

                logoBox.Size = new Size(
                    (int)(logoBox.Image.Width),
                    (int)(logoBox.Image.Height)
                );

                logoBox.Location = new Point(
                     1500,
                     (this.ClientSize.Height - logoBox.Height) / 2
                     );

                this.Resize += (s, e) =>
                {
                    logoBox.Location = new Point(
                        this.ClientSize.Width - logoBox.Width + 1000,
                        (this.ClientSize.Height - logoBox.Height) / 2
                    );
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la aplicación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CambiarForm(Form form)
        {
            try
            {
                activeForm.Visible = false;
                form.ShowDialog();
                activeForm = form;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonPresupuesto_Click(object sender, EventArgs e)
        {
            try
            {
                Form presupuestoForm = new PresupuestadorForm(null);
                CambiarForm(presupuestoForm);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #region "FUNCIONES NO UTILIZADAS"
        private void shadowRoundedButton1_Load(object sender, EventArgs e)
        {
        }
        private void buttonPresupuesto_Load(object sender, EventArgs e)
        {


        }
        #endregion


        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
