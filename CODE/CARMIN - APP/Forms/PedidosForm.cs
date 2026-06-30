using CARMIN___BLL.Helper;
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
    public partial class PedidosForm : Form
    {
        Form controlPedidos;
        Form crearPedidos;
        public PedidosForm()
        {
            InitializeComponent();
        }

        private void PedidosForm_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            try
            {
                btnControlDePedidosNew.Click += btnControlDePedidos_Click;
                btnCrearPedidoNew.Click += btnCrearPedido_Click;
                logoBox.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
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

        private void logoBox_Click(object sender, EventArgs e)
        {
            try
            {
                this.Owner.Show();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void AjustarLayout()
        {
            try
            {
                //Carga de panel principal
                mainPanel.Size = new Size(this.ClientSize.Width - 50, this.ClientSize.Height - 50);
                mainPanel.Location = new Point(25, 25);
                
                logoBox.SizeMode = PictureBoxSizeMode.Zoom;
                logoBox.Location = new Point(
           mainPanel.Width - logoBox.Width - 20,
           20);

                //Centrado del panel de botones
                panelBotones.Location = new Point((mainPanel.Width - panelBotones.Width) / 2, (mainPanel.Height - panelBotones.Height) / 2);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnControlDePedidos_Click(object sender, EventArgs e)
        {
            try
            {
                if(controlPedidos == null)
                {
                    controlPedidos = new ControlPedidosForm();
                    controlPedidos.Owner = this;
                }
             
                this.Hide();
                controlPedidos.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if(crearPedidos == null)
                {
                    crearPedidos = new CrearPedidoForm();
                    crearPedidos.Owner = this;
                }
               
                this.Hide();
                crearPedidos.Show();
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

        private void PedidosForm_Shown(object sender, EventArgs e)
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
    }
}
