using CARMIN___APP.Helpers;
using CARMIN___BE.Entities;
using CARMIN___BLL.Helper;
using CARMIN___BLL.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARMIN___APP.Forms
{
    public partial class ClientesForm : Form
    {
        private Cliente _cliente;
        private ClienteBLL _clienteBLL;
        public ClientesForm()
        {
             InitializeComponent();

            //Inicializamos los objetos
            _clienteBLL = new ClienteBLL();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            try
            {

                logoBox.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
                logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ClientesForm_Shown(object sender, EventArgs e)
        {
            this.SuspendLayout();
            try
            {
                AjustarLayout();
                btnCargarClienteNew.Click += btnCargarCliente_Click;


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
                this.ClientSize.Width - 20,
                this.ClientSize.Height - 20);

            mainPanel.Location = new Point(10, 10);

            logoBox.Location = new Point(
                mainPanel.Width - logoBox.Width - 20,
                20);
            

            panelAltaCliente.Location = new Point((mainPanel.Width - panelAltaCliente.Width) / 2, (mainPanel.Height - panelAltaCliente.Height) / 2);

            panelCargaCliente.Location = new Point((panelAltaCliente.Width - panelCargaCliente.Width) / 2, (panelAltaCliente.Height - panelCargaCliente.Height) / 2);
            mainPanel.Region = new Region(
            RoundedPanelHelper.CreateRoundedPath(mainPanel.ClientRectangle, 20)); // Ajusta el radio según tus necesidades)
            panelAltaCliente.Region = new Region(
            RoundedPanelHelper.CreateRoundedPath(panelAltaCliente.ClientRectangle, 20)); // Ajusta el radio según tus necesidades)
            panelCargaCliente.Region = new Region(
            RoundedPanelHelper.CreateRoundedPath(panelCargaCliente.ClientRectangle, 20)); // Ajusta el radio según tus necesidades)
        }

        
        #region "FUNCIÓN DE BOTONES"

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationHelper.TextBoxAreEmpty(panelCargaCliente))
                {
                    MessageBox.Show("Todos los campos deben completarse");
                    return;
                }
                if (!Information.IsNumeric(txtTelNew.TextButton))
                {
                    MessageBox.Show("El teléfono debe estar en el formato correcto");
                    return;
                }
                _cliente = new Cliente();
                _cliente.Nombre = txtNomNew.TextButton;
                _cliente.Telefono = txtTelNew.TextButton;
                if (txtDirNew.TextButton != "") { _cliente.Direccion = txtDirNew.TextButton; }
                else { _cliente.Direccion = "No especificada"; }

                if (_clienteBLL.Guardar(_cliente))
                {
                    MessageBox.Show("Cliente guardado con éxito");
                    return;
                }
                else
                {
                    MessageBox.Show("Fallo al cargar cliente");
                    return;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void logoBox_Click(object sender, EventArgs e)
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


  
    }
}
