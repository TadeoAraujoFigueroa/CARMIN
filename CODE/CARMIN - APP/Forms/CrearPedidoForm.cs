using CARMIN___APP.Helpers;
using CARMIN___BE.Entities;
using CARMIN___BLL.Helper;
using CARMIN___BLL.Services;
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
    public partial class CrearPedidoForm : Form
    {
        PresupuestoBLL _presupuestoBLL;
        Presupuesto? _presupuesto;

        ClienteBLL _clienteBLL;
        Cliente? _cliente;

        Pedido _pedido;
        PedidoBLL _pedidoBLL;

        List<Cliente> clientesList = new List<Cliente>();
        List<Presupuesto> presupuestosList = new List<Presupuesto>();

        private int cont = 0;

        public CrearPedidoForm()
        {
            InitializeComponent();
            //Inicializamos las variables necesarias
            _presupuestoBLL = new PresupuestoBLL();
            _clienteBLL = new ClienteBLL();
            _pedidoBLL = new PedidoBLL();
            _pedido = new Pedido();
        }

        private void CrearPedidoForm_Load(object sender, EventArgs e)
        {

            
            try
            {

                btnSeleccionarPresupuestoNew.Click += btnSeleccionarPresu_Click_1;
                btnCrearPedidoNew.Click += btnCrearPedido_Click;
                btnSeleccionarClienteNew.Click += btnSeleccionarCliente_Click_1;
                txtFiltroCliente.TextChanged += txtFiltroCliente_TextChanged;
                txtFiltroPresu.TextChanged += txtFiltroPresu_TextChanged;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           



        }
        private void CrearPedidoForm_Shown(object sender, EventArgs e)
        {
            this.SuspendLayout();
            try
            {
                CargarGrillas();
                AjustarLayout();
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
            try
            {
                //Carga de panel principal
                mainPanelNew.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
                mainPanelNew.Location = new Point(10, 10);

                logoBoxNew.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
                logoBoxNew.SizeMode = PictureBoxSizeMode.Zoom;
                logoBoxNew.Location = new Point(
               mainPanelNew.Width - logoBoxNew.Width,
               20);
                logoBoxNew.Click += logoBox_Click_1;
                logoBoxNew.BackColor = Color.Transparent;

                subMainPanel.Size = new Size(this.mainPanelNew.Width - 120, this.mainPanelNew.Height - 120);
                subMainPanel.Location = new Point((mainPanelNew.Width - subMainPanel.Width) / 2, (mainPanelNew.Height - subMainPanel.Height) / 2);

                panelClientesExistentes.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelClientesExistentes.ClientRectangle, 30));
                panelClientesExistentesInt.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelClientesExistentesInt.ClientRectangle, 30));
                panelFechaEntregaInt.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelFechaEntregaInt.ClientRectangle, 30));
                panelFechaEntrega.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelFechaEntrega.ClientRectangle, 30));
                panelNombrePedidoInt.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelNombrePedidoInt.ClientRectangle, 30));
                panelNombrePedido.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelNombrePedido.ClientRectangle, 30));
                panelNombrePedido.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelNombrePedido.ClientRectangle, 30));
                panelPresuExt.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelPresuExt.ClientRectangle, 30));
                //panelPresuInt
                panel2.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panel2.ClientRectangle, 30));
                mainPanelNew.Region = new Region(RoundedPanelHelper.CreateRoundedPath(mainPanelNew.ClientRectangle, 30));


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void CargarGrillaCliente(List<Cliente> listaActualizada)
        {
            try
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaActualizada;
                dgvClientes.Columns["Id"].Visible = false;
                dgvClientes.Columns["Nombre"].HeaderText = "NOMBRE";
                dgvClientes.Columns["Telefono"].HeaderText = "TELÉFONO";
                dgvClientes.Columns["Direccion"].HeaderText = "DIRECCIÓN";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarGrillaPresupuesto(List<Presupuesto> listaActualizada)
        {
            try
            {
                //Lógica de carga de grilla de insumos
                dgvPresupuestos.DataSource = null;
                dgvPresupuestos.DataSource = listaActualizada;

                dgvPresupuestos.Columns["Id"].Visible = false;
                dgvPresupuestos.Columns["CostoTotal"].Visible = false;
                dgvPresupuestos.Columns["MargenMerma"].Visible = false;
                dgvPresupuestos.Columns["MargenMaquinaria"].Visible = false;
                dgvPresupuestos.Columns["MargenGanancia"].Visible = false;
                dgvPresupuestos.Columns["HorasTrabajo"].Visible = false;
                dgvPresupuestos.Columns["HorasDiseño"].Visible = false;
                dgvPresupuestos.Columns["Recargo"].Visible = false;


                dgvPresupuestos.Columns["Nombre"].HeaderText = "NOMBRE";
                dgvPresupuestos.Columns["MontoTotal"].HeaderText = "MONTO TOTAL";
                dgvPresupuestos.Columns["Descuento"].HeaderText = "DESCUENTO";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #region "FUNCIONES DE BOTONES"

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            try
            {
                //Lógica de creación de pedido
                if (_presupuesto == null)
                {
                    MessageBox.Show("Por favor, seleccione un presupuesto antes de crear el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_cliente == null)
                {
                    MessageBox.Show("Por favor, seleccione un cliente antes de crear el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidationHelper.TextBoxAreEmpty(panelNombrePedidoInt))
                {
                    MessageBox.Show("Debe colocarle un nombre al pedido");
                    return;
                }
                //Creamos un pedido a partir de un presupuesto
                _pedido = new Pedido
                {
                    IdPresupuesto = _presupuesto.Id,
                    IdCliente = _cliente.Id,
                    Nombre = txtNomPedidoNew.TextButton,
                    Estado = "ENCARGADO",
                    EstadoDePago = "PENDIENTE",
                    FechaDeEntrega = fechaEntrega.Value,
                    Importe = _presupuesto.MontoTotal,
                    TiempoTotalDeProduccion = _presupuesto.HorasTrabajo + _presupuesto.HorasDiseño
                };

                if (_pedidoBLL.Guardar(_pedido))
                {
                    MessageBox.Show("Pedido creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Hubo un error al crear el pedido. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
        private void btnSeleccionarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnSeleccionarPresu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvPresupuestos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un presupuesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _presupuesto = (Presupuesto)dgvPresupuestos.SelectedRows[0].DataBoundItem;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region "FUNCIONES NO UTILIZADAS"
        private void subMainPanel_Paint(object sender, PaintEventArgs e)
        {

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
        private void txtFiltroCliente_Click(object sender, EventArgs e)
        {

        }
        private void btnSeleccionarPresu_Click(object sender, EventArgs e)
        {

        }
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {


        }
        #endregion


        //Funciones para filtrar grillas en base a lo escrito en los text box
        private void txtFiltroPresu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltroPresu.Text.ToLower();
                var listaActualizada = presupuestosList.Where(p => p.Nombre.ToLower().Contains(filtro)).ToList();
                CargarGrillaPresupuesto(listaActualizada);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void txtFiltroCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltroCliente.Text.ToLower();
                var listaActualizada = clientesList.Where(c => c.Nombre.ToLower().Contains(filtro)).ToList();
                CargarGrillaCliente(listaActualizada);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void CrearPedidoForm_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                cont++;
                if (this.Visible == false) { return; }
                if(cont == 1) { return; }
                CargarGrillas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarGrillas()
        {
            try
            {
                clientesList = _clienteBLL.ListarTodo();
                presupuestosList = _presupuestoBLL.ListarTodo();
                CargarGrillaCliente(clientesList);
                CargarGrillaPresupuesto(presupuestosList);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
