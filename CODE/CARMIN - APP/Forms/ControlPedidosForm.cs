using CARMIN___APP.Helpers;
using CARMIN___BE.Entities;
using CARMIN___BE.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CARMIN___APP.Forms
{
    public partial class ControlPedidosForm : Form
    {
        private List<Pedido> pedidos;
        private List<Cliente> clientes;
        private PedidoBLL pedidosBLL;
        private Pedido pedidoSeleccionado;
        private ClienteBLL clienteBLL;
        public ControlPedidosForm()
        {
            InitializeComponent();

            //Inicializar servicios
            pedidosBLL = new PedidoBLL();
            clienteBLL = new ClienteBLL();

            //Cargar datos
            pedidos = pedidosBLL.ListarTodo();
            clientes = clienteBLL.ListarTodo();


        }

        private void ControlPedidosForm_Load(object sender, EventArgs e)
        {
            try
            {

                comboEstado.Items.Clear();
                comboEstado.Items.AddRange(Enum.GetNames(typeof(EstadoPedidoProduccion)));

                comboPago.Items.Clear();
                comboPago.Items.AddRange(Enum.GetNames(typeof(EstadoPedidoPago)));

                btnEliminarPedidoNew.Click += btnEliminarPedido_Click;
                btnModificarPedidoNew.Click += btnModificarPedido_Click;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falla al cargar: " + ex.Message);
            }
        }
        private void ControlPedidosForm_Shown(object sender, EventArgs e)
        {
            this.SuspendLayout();
            try
            {
                int año = DateTime.Now.Year;
                int mes = DateTime.Now.Month;

                AjustarLayout();

                AcomodarCalendario();

                GenerarCalendario(calendario, año, mes, pedidos);
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


            tableLayoutPanel.Size = new Size(
                (int)(this.mainPanel.Width - 80),
                (int)(this.mainPanel.Height - 80));

            tableLayoutPanel.Location = new Point((this.mainPanel.Width - tableLayoutPanel.Width) / 2, (this.mainPanel.Height - tableLayoutPanel.Height) / 2);
            tableLayoutPanel1.Location = new Point((this.panelEstadoPedidoInt.Width - tableLayoutPanel1.Width) / 2, (this.panelEstadoPedidoInt.Height - tableLayoutPanel1.Height) / 2);


            panel1.Dock = DockStyle.Fill;




            pictureBox1.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Location = new Point(
                mainPanel.Width - logoBox.Width - 20,
                20);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.SendToBack();


            //Ajustamos los bordes
            mainPanel.Region = new Region(
                RoundedPanelHelper.CreateRoundedPath(mainPanel.ClientRectangle, 20)); // Ajusta el radio según tus necesidades)
            panelEstadoPedidoExt.Region = new Region(
               RoundedPanelHelper.CreateRoundedPath(panelEstadoPedidoExt.ClientRectangle, 20)); // Ajusta el radio según tus necesidades)
            panelEstadoPedidoInt.Region = new Region(
                RoundedPanelHelper.CreateRoundedPath(panelEstadoPedidoInt.ClientRectangle, 20)); // Ajusta el radio según tus necesidades)



        }

        #region "CREACIÓN DEL CALENDARIO"
        private void AcomodarCalendario()
        {

            calendario.Dock = DockStyle.Fill;
            calendario.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            calendario.ColumnCount = 7;
            calendario.RowCount = 6;
            calendario.ColumnStyles.Clear();
            calendario.RowStyles.Clear();
            for (int i = 0; i < 7; i++)
            {
                calendario.ColumnStyles.Add(
                    new ColumnStyle(
                        SizeType.Percent,
                        100f / 7f));
            }

            for (int i = 0; i < 6; i++)
            {
                calendario.RowStyles.Add(
                    new RowStyle(
                        SizeType.Percent,
                        100f / 6f));
            }

        }
        public void GenerarCalendario(TableLayoutPanel calendario, int año, int mes, List<Pedido> pedidos)
        {
            calendario.SuspendLayout();

            calendario.Controls.Clear();

            DateTime primerDia = new DateTime(año, mes, 1);

            int offset = (int)primerDia.DayOfWeek;

            if (offset == 0)
                offset = 7;

            offset--;

            DateTime fechaInicial = primerDia.AddDays(-offset);

            for (int i = 0; i < 42; i++)
            {
                Panel panelDia = CrearPanelDia();

                DateTime fechaCelda =
                        fechaInicial.AddDays(i);

                CargarContenidoDia(
                        panelDia,
                        fechaCelda,
                        pedidos);


                calendario.Controls.Add(panelDia);
            }

            calendario.ResumeLayout();
        }
        private Panel CrearPanelDia()
        {
            return new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(255, 248, 231),
                Margin = new Padding(1),
                BorderStyle = BorderStyle.FixedSingle

            };
        }
        private void CargarContenidoDia(Panel panel, DateTime fecha, List<Pedido> pedidos)
        {


            Label lblDia = new Label();

            if (fecha.Month != DateTime.Now.Month)
            {
                lblDia.ForeColor = Color.Silver;
            }

            if (fecha.Date == DateTime.Now.Date)
            {
                panel.BackColor = Color.FromArgb(255, 240, 210);
            }
            lblDia.Text = fecha.Day.ToString();

            lblDia.Font = new Font(
                "Poppins",
                10,
                FontStyle.Bold);

            lblDia.AutoSize = true;

            lblDia.Location = new Point(5, 5);

            panel.Controls.Add(lblDia);

            int top = 40;

            if (pedidos.Count == 0) return;

            List<Pedido> pedidosDelDia =
                pedidos.Where(
                    p => p.FechaDeEntrega.Date == fecha.Date)
                .ToList();

            foreach (Pedido pedido in pedidosDelDia.Take(3))
            {
                Label lblPedido = new Label();

                lblPedido.Font = new Font(
                    "Poppins",
                    8,
                    FontStyle.Regular);


                lblPedido.AutoSize = false;

                lblPedido.Left = 5;
                lblPedido.Top = top;
                lblPedido.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                lblPedido.Width = panel.ClientSize.Width - 10;

                lblPedido.AutoEllipsis = true;

                lblPedido.Height = 20;

                lblPedido.Text = pedido.Nombre;

                lblPedido.Location = new Point(5, top);


                lblPedido.BackColor =
                    ObtenerColorEstado(pedido);

                panel.Controls.Add(lblPedido);

                top += 20;

                lblPedido.Click += (s, e) => cargarDetallePedido(lblPedido.Text);

                lblPedido.Cursor = Cursors.Hand;
                lblPedido.MouseHover += (_, _) =>
                {
                    toolTip1.SetToolTip(lblPedido, pedido.Nombre);
                };
            }

            if (pedidosDelDia.Count > 3)
            {
                Label lblMas = new Label();

                lblMas.Text =
                    $"+{pedidosDelDia.Count - 3} más";

                lblMas.AutoSize = true;

                lblMas.Location =
                    new Point(5, top);

                panel.Controls.Add(lblMas);
            }
        }
        private Color ObtenerColorEstado(Pedido pedido)
        {
            var colorState = Color.White;

            if (pedido.Estado == "ENCARGADO" && pedido.EstadoDePago == "PENDIENTE")
            {
                colorState = Color.LightCoral;
            }
            if (pedido.Estado == "PROCESANDO" && pedido.EstadoDePago == "PENDIENTE")
            {
                colorState = Color.Yellow;
            }
            if (pedido.Estado == "PROCESANDO" && pedido.EstadoDePago == "SEÑADO")
            {
                colorState = Color.LightBlue;
            }
            if (pedido.Estado == "ENCARGADO" && pedido.EstadoDePago == "SEÑADO")
            {
                colorState = Color.LightBlue;
            }
            if (pedido.Estado == "FINALIZADO" && pedido.EstadoDePago == "SEÑADO")
            {
                colorState = Color.Red;
            }
            if (pedido.Estado == "FINALIZADO" && pedido.EstadoDePago == "PENDIENTE")
            {
                colorState = Color.Red;
            }
            if (pedido.Estado == "FINALIZADO" && pedido.EstadoDePago == "ABONADO")
            {
                colorState = Color.LightGreen;
            }
            if (pedido.Estado == "DEMORADO")
            {
                colorState = Color.Purple;
            }

            return colorState;
        }
        private void cargarDetallePedido(string nombrePedido)
        {
            try
            {
                pedidoSeleccionado = pedidos.FirstOrDefault(p => p.Nombre == nombrePedido);

                if (pedidoSeleccionado == null) { MessageBox.Show("Error al seleccionar pedido"); return; }

                var clienteVinculado = clientes.FirstOrDefault(c => c.Id == pedidoSeleccionado.IdCliente);

                txtNomPedidoNew.TextButton = pedidoSeleccionado.Nombre;
                txtNomClienteNew.TextButton = clienteVinculado.Nombre;
                txtImporteNew.TextButton = pedidoSeleccionado.Importe.ToString("C0");
                txtFechaEntregaNew.TextButton = pedidoSeleccionado.FechaDeEntrega.ToShortDateString();
                txtTiempoDeProduccionNew.TextButton = pedidoSeleccionado.TiempoTotalDeProduccion.ToString();

                comboEstado.SelectedItem = pedidoSeleccionado.Estado;
                comboPago.SelectedItem = pedidoSeleccionado.EstadoDePago;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ModificarLabel(Pedido pedidoModificado)
        {
            foreach (Panel panel in calendario.Controls)
            {
                if (panel is Panel)
                {
                    foreach (var label in panel.Controls)
                    {
                        if ((label as Label).Text == pedidoModificado.Nombre)
                        {
                            (label as Label).BackColor = ObtenerColorEstado(pedidoModificado);
                            return;
                        }
                    }

                }
            }
        }

        #endregion

        #region "FUNCIÓN DE BOTONES"
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

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (pedidoSeleccionado == null) { MessageBox.Show("Debe seleccionar un pedido"); return; }
                DialogResult rta = MessageBox.Show($"¿Seguro/a que desea eliminar el pedido {pedidoSeleccionado.Nombre}?", "Eliminando pedido...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rta == DialogResult.Yes)
                {
                    if (pedidosBLL.Eliminar(pedidoSeleccionado))
                    {
                        MessageBox.Show("Pedido eliminado correctamente");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Fallo al eliminar pedido");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (pedidoSeleccionado == null) { MessageBox.Show("Debe seleccionar un pedido"); return; }
                DialogResult rta = MessageBox.Show($"¿Seguro/a que desea modificar el pedido {pedidoSeleccionado.Nombre}?", "Modificando pedido...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rta == DialogResult.Yes)
                {
                    pedidoSeleccionado.Estado = comboEstado.SelectedItem.ToString();
                    pedidoSeleccionado.EstadoDePago = comboPago.SelectedItem.ToString();

                    if (pedidosBLL.Modificar(pedidoSeleccionado))
                    {
                        MessageBox.Show("Pedido modificado correctamente");
                        ModificarLabel(pedidoSeleccionado);
                        //pedidos = pedidosBLL.ListarTodo();
                        //ControlPedidosForm_Shown(this, null);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Fallo al modificar pedido");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void panelEstadoPedidoExt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



        }
        #endregion
    }
}
