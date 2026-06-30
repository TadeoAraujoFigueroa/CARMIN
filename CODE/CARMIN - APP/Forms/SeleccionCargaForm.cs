using CARMIN___APP.Helpers;
using CARMIN___BLL.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARMIN___APP.Forms
{
    public partial class SeleccionCargaForm : Form
    {
        Form cargaImpresoras;
        Form cargaCostos;
        public SeleccionCargaForm()
        {

            InitializeComponent();
        }
        private void SeleccionCargaForm_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            try
            {

                //Suscribimos a los eventos de los botones
                btnCargarCostosNew.Click += btnCargarCostos_Click;
                btnCargarImpresorasNew.Click += btnCargarImpresoras_Click;

                //Carga del boton de salida
                logoBox.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
                logoBox.SizeMode = PictureBoxSizeMode.Zoom;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.ResumeLayout();
            }

        }
        private void AjustarLayout()
        {
            mainPanel.Size = new Size(
                this.ClientSize.Width - 50,
                this.ClientSize.Height - 50);

            mainPanel.Location = new Point(25, 25);

            panelBotones.Location = new Point(
                (mainPanel.Width - panelBotones.Width) / 2,
                (mainPanel.Height - panelBotones.Height) / 2);

            logoBox.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));

            logoBox.Location = new Point(
                mainPanel.Width - logoBox.Width - 20,
                20);


            mainPanel.Region = new Region(
            RoundedPanelHelper.CreateRoundedPath(mainPanel.ClientRectangle, 20)); // Ajusta el radio según tus necesidades);
        }

        #region "FUNCIONES DE BOTONES"

        private void btnCargarCostos_Click(object sender, EventArgs e)
        {
            try
            {
                if(cargaCostos == null)
                {
                    cargaCostos = new CargaDeCostosForm();
                    cargaCostos.Owner = this; // Establece el formulario actual como propietario del nuevo formulario
                }    
                cargaCostos.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCargarImpresoras_Click(object sender, EventArgs e)
        {
            try
            {
                if(cargaImpresoras == null)
                {
                    cargaImpresoras = new CargaDeImpresoraForm();
                    cargaImpresoras.Owner = this; // Establece el formulario actual como propietario del nuevo formulario
                }
                    
                this.Hide(); // Oculta el formulario actual
                cargaImpresoras.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void logoBox_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Owner.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "FUNCIONES NO UTILIZADAS"
        private void logoBox_Click(object sender, EventArgs e)
        {

        }

        private void SeleccionCargaForm_Shown(object sender, EventArgs e)
        {
            try
            {
                AjustarLayout();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
