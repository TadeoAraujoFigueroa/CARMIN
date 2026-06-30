using CARMIN___APP.Helpers;
using CARMIN___BE.Entities;
using CARMIN___BE.Enums;
using CARMIN___BLL.Helper;
using CARMIN___BLL.Services;
using Microsoft.VisualBasic;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARMIN___APP.Forms
{
    public partial class CargaDeCostosForm : Form
    {
        private bool loading = true;

        private InsumoImpresora insumoImpresora;
        private Insumo insumoRegular;
        private Servicios servicio;

        private Servicios servicioSeleccionado;
        private Insumo insumoSeleccionado;
        private InsumoImpresora insumoImpresoraSeleccionado;

        private InsumoImpresoraBLL insumoImpresoraBLL;
        private ServiciosBLL serviciosBLL;
        private InsumoBLL insumoBLL;

        private List<InsumoImpresora> insumosImpresora;
        private List<Insumo> insumosRegulares;

        Form modificarInsumo;
        Form modificarServicio;

        public CargaDeCostosForm()
        {
            InitializeComponent();
        }

        private void CargaDeCostosForm_Load(object sender, EventArgs e)
        {
           
            try
            {

                switchInsumos.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;
                switchInsModify.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;


                //Carga de eventos de botones
                buttonCargaInsumosNew.Click += btnCargarInsumo_Click;
                btnAgregarServicesNew.Click += btnAgregarServicio_Click;
                btnModServicesNew.Click += btnModServices_Click;
                btnEliminarInsumNew.Click += btnEliminarInsum_Click;
                btnEliminarServicesNew.Click += btnEliminarServicio_Click;

                //Carga del combo box
                comboInsumo.Items.Clear();
                comboInsumo.Items.AddRange(Enum.GetNames(typeof(MetodoCalculoCosto)));
                comboInsumo.SelectedIndex = 0;


                //Configuramos la grilla
                dgvInsModify.AllowUserToAddRows = false;
                dgvInsModify.AllowUserToDeleteRows = false;
                dgvInsModify.MultiSelect = false;
                dgvInsModify.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvInsModify.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                dgvServices.AllowUserToAddRows = false;
                dgvServices.AllowUserToDeleteRows = false;
                dgvServices.MultiSelect = false;
                dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                //Inicialización de objetos
                insumoImpresora = new InsumoImpresora();
                insumoRegular = new Insumo();
                servicio = new Servicios();

                insumoImpresoraBLL = new InsumoImpresoraBLL();
                insumoBLL = new InsumoBLL();
                serviciosBLL = new ServiciosBLL();

                //Inicialización de listas
                insumosImpresora = new List<InsumoImpresora>();
                insumosRegulares = new List<Insumo>();

                //Los paneles de modificación se desactivan hasta el momento de su uso
                panelModificacionServicio.Enabled = false;
                panelModificacionInsumo.Enabled = false;
                //Invisibilizamos los paneles, que se muestrán solo al querer modificar
                panelModificacionServicio.Visible = false;
                panelModificacionInsumo.Visible = false;
                //FINALIZACIÓN DE CARGA
                loading = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void CargaDeCostosForm_Shown(object sender, EventArgs e)
        {
             //Función que optimiza el renderizado de componentes, evitando lags al cargar el form
            this.SuspendLayout();
            try
            {
                //Carga de panel principal
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

        //Función que cambia los textos y las posiciones de los labels dependiendo del tipo de insumo seleccionado
        private void cambioDeInsumo(int y, bool esRegular)
        {
            try
            {

                labelTipoInsumo2.Text = esRegular ? "REGULAR" : "PARA IMPRESORA";
                ///labelTipoInsumo2.Location = new Point((panelCargaIns.Width - labelTipoInsumo2.Width) / 2, y);

                y = labelStockIns.Location.Y;
                labelStockIns.Text = esRegular ? "STOCK" : "RENDIMIENTO";
                //labelStockIns.Location = new Point((panelStockRendimiento.Width - labelStockIns.Width) / 2, y);

                y = labelTipoInsumos.Location.Y;
                labelTipoInsumos.Text = esRegular ? "TIPO DE CÁLCULO" : "¿ES COLOR?";
                //labelTipoInsumos.Location = new Point((panelColor.Width - labelTipoInsumos.Width) / 2, y);

                if (esRegular)
                {
                    comboInsumo.Items.Clear();
                    comboInsumo.Items.AddRange(Enum.GetNames(typeof(MetodoCalculoCosto)));
                    comboInsumo.SelectedIndex = 0;
                }
                else
                {
                    comboInsumo.Items.Clear();
                    comboInsumo.Items.AddRange(new object[] { "SÍ", "NO" });
                    comboInsumo.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Función de limpieza de cuadros de texto
        private void limpiarTextBox()
        {
            try
            {
                txtCantidadInsumosNew.Text = string.Empty;
                txtMedidaInsumosNew.Text = string.Empty;
                txtNombreInsumosNew.Text = string.Empty;
                txtStockInsNew.Text = string.Empty;
                txtCostoInsumoNew.Text = string.Empty;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Función que situa correctamente los componentes
        private void AjustarLayout()
        {
            //Carga de panel principal
            mainPaneles.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
            mainPaneles.Location = new Point(10, 10);

            //Carga del subpanel
            subMainPanel2.Size = new Size(mainPaneles.Width - 100, mainPaneles.Height - 100);
            subMainPanel2.BackColor = Color.FromArgb(255, 248, 231);
            subMainPanel2.Location = new Point(
                  (mainPaneles.Width - subMainPanel2.Width) / 2,
                  (mainPaneles.Height - subMainPanel2.Height) / 2);

            //Carga del tableLayoutMain
            tableLayoutInsMain.Dock = DockStyle.Fill;

            //Carga del panel de insumos 
            panelInsumos2.Dock = DockStyle.Fill;

            //Carga del tableLayoutIns
            tableLayoutInsMain.Dock = DockStyle.Fill;
            tableLayoutInsMain.Padding = new Padding(15);

            //Carga del tableLayoutServices
            tableLayoutServicesMain.Dock = DockStyle.Fill;
            tableLayoutServicesMain.Padding = new Padding(15);


            //Inicialización y localización del icono de salida
            pictureBoxExit.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
            pictureBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExit.BackColor = Color.Transparent;
            pictureBoxExit.SendToBack();
            pictureBoxExit.Location = new Point(
                mainPaneles.Width - logoBox.Width - 20,
                20);

          

            exitPictureBox.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
            exitPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            exitPictureBoxModInsumo.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
            exitPictureBoxModInsumo.SizeMode = PictureBoxSizeMode.Zoom;



            //Utilizamos el RoundedPanelHelper para redondear los bordes de todos los paneles con un fin estético
            mainPaneles.Region = new Region(
                 RoundedPanelHelper.CreateRoundedPath(mainPaneles.ClientRectangle, 20));
            subMainPanel2.Region = new Region(
                 RoundedPanelHelper.CreateRoundedPath(subMainPanel2.ClientRectangle, 20));
            panelInsumos2.Region = new Region(
                RoundedPanelHelper.CreateRoundedPath(panelInsumos2.ClientRectangle, 20));
            panelServicios2.Region = new Region(
                RoundedPanelHelper.CreateRoundedPath(panelServicios2.ClientRectangle, 20));
            panelCargaIns.Region = new Region(
                RoundedPanelHelper.CreateRoundedPath(panelCargaIns.ClientRectangle, 20));
            tableLayoutCargarServices.Region = new Region(
                RoundedPanelHelper.CreateRoundedPath(tableLayoutCargarServices.ClientRectangle, 20));
            tableLayoutModServices.Region = new Region(
                RoundedPanelHelper.CreateRoundedPath(tableLayoutModServices.ClientRectangle, 20));
            tableLayoutModIns.Region = new Region(
                RoundedPanelHelper.CreateRoundedPath(tableLayoutModIns.ClientRectangle, 20));
            panelModIns.Region = new Region(
              RoundedPanelHelper.CreateRoundedPath(panelModIns.ClientRectangle, 20));
            panelModificacionInsumo.Region = new Region(
              RoundedPanelHelper.CreateRoundedPath(panelModificacionInsumo.ClientRectangle, 20));
            panelModificacionServicio.Region = new Region(
              RoundedPanelHelper.CreateRoundedPath(panelModificacionServicio.ClientRectangle, 20));

            btnAgregarServicesNew.Size = buttonCargaInsumosNew.Size;
            btnModServicesNew.Size = buttonCargaInsumosNew.Size;
            btnEliminarServicesNew.Size = buttonCargaInsumosNew.Size;

            panelModificacionInsumo.Location = new Point((this.ClientSize.Width - panelModificacionInsumo.Width) / 2, (this.ClientSize.Height - panelModificacionInsumo.Height) / 2);
            panelModificacionServicio.Location = new Point((this.ClientSize.Width - panelModificacionServicio.Width) / 2, (this.ClientSize.Height - panelModificacionServicio.Height) / 2);



            //Cargamos la grilla de servicios
            CargarGrillasServicios();

            //Cargar grilla con insumos regulares por defecto
            CargarGrilla();
        }

        //Botón de salida
        private void pictureBoxExit_Click(object sender, EventArgs e)
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

        #region "CARGAS DE GRILLAS"
        private void CargarGrilla()
        {
            try
            {
                if (switchInsModify.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.On)
                {
                    //Cargar grilla con insumos para impresora

                    dgvInsModify.DataSource = null;
                    dgvInsModify.DataSource = insumoImpresoraBLL.ListarTodo();
                    dgvInsModify.Columns["Contenido"].HeaderText = "CONTENIDO";
                    dgvInsModify.Columns["UnidadContenido"].HeaderText = "UNIDAD CONTENIDO";
                    dgvInsModify.Columns["Nombre"].DisplayIndex = 0;
                    dgvInsModify.Columns["Contenido"].DisplayIndex = 1;
                    dgvInsModify.Columns["UnidadContenido"].DisplayIndex = 2;
                    dgvInsModify.Columns["Precio"].Visible = false;
                    dgvInsModify.Columns["Rendimiento"].Visible = false;
                    dgvInsModify.Columns["EsColor"].Visible = false;

                }
                else
                {

                    //Cargar grilla con insumos regulares
                    dgvInsModify.DataSource = null;
                    dgvInsModify.DataSource = insumoBLL.ListarTodo();
                    dgvInsModify.Columns["Cantidad"].HeaderText = "CONTENIDO";
                    dgvInsModify.Columns["UnidadMedida"].HeaderText = "UNIDAD CONTENIDO";
                    dgvInsModify.Columns["Nombre"].DisplayIndex = 0;
                    dgvInsModify.Columns["Cantidad"].DisplayIndex = 1;
                    dgvInsModify.Columns["UnidadMedida"].DisplayIndex = 2;
                    dgvInsModify.Columns["Stock"].Visible = false;
                    dgvInsModify.Columns["PrecioUnitario"].Visible = false;
                    dgvInsModify.Columns["TipoDeCalculo"].Visible = false;
                    dgvInsModify.Columns["CostoInsumo"].Visible = false;
                }

                dgvInsModify.Columns["Id"].Visible = false;
                dgvInsModify.Columns["Nombre"].HeaderText = "NOMBRE";
                foreach (DataGridViewColumn col in dgvInsModify.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarGrillasServicios()
        {
            try
            {

                dgvServices.DataSource = null;
                dgvServices.DataSource = serviciosBLL.ListarTodo();
                dgvServices.Columns["Id"].Visible = false;
                dgvServices.Columns["Nombre"].HeaderText = "NOMBRE";
                dgvServices.Columns["ImporteMensual"].HeaderText = "IMPORTE MENSUAL";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "EVENTOS DE BOTONES"

        #region "ABM INSUMO"
        private void btnCargarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationHelper.TextBoxAreEmpty(tableLayoutInsMain))
                {
                    MessageBox.Show("Debe completar todos los campos para cargar un insumo.");
                    return;
                }
                if (switchInsumos.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.On)
                {
                    //Lógica para cargar insumo para impresora
                    insumoImpresora.Id = insumoImpresoraBLL.obtenerUltimoId() + 1;
                    insumoImpresora.Nombre = txtNombreInsumosNew.TextButton;
                    insumoImpresora.Contenido = int.Parse(txtCantidadInsumosNew.TextButton);
                    insumoImpresora.UnidadContenido = txtMedidaInsumosNew.TextButton;
                    insumoImpresora.Precio = decimal.Parse(txtCostoInsumoNew.TextButton);
                    insumoImpresora.Rendimiento = int.Parse(txtStockInsNew.TextButton);
                    insumoImpresora.EsColor = comboInsumo.SelectedItem.ToString() == "SÍ";

                    if (insumoImpresoraBLL.Guardar(insumoImpresora))
                    {
                        MessageBox.Show("Insumo para impresora guardado correctamente.");
                        limpiarTextBox();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el insumo.");
                    }

                }
                else
                {

                    //Lógica para cargar insumo regular
                    insumoRegular.Id = insumoBLL.obtenerUltimoId() + 1;
                    insumoRegular.Nombre = txtNombreInsumosNew.TextButton;
                    insumoRegular.Cantidad = int.Parse(txtCantidadInsumosNew.TextButton);
                    insumoRegular.CostoInsumo = decimal.Parse(txtCostoInsumoNew.TextButton);
                    insumoRegular.UnidadMedida = txtMedidaInsumosNew.TextButton;
                    insumoRegular.Stock = int.Parse(txtStockInsNew.TextButton);
                    insumoRegular.TipoDeCalculo = comboInsumo.SelectedItem.ToString();

                    if (insumoBLL.Guardar(insumoRegular))
                    {
                        MessageBox.Show("Insumo regular guardado correctamente.");
                        limpiarTextBox();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el insumo regular.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminarInsum_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rta = MessageBox.Show("¿Desea eliminar el insumo seleccionado?", "ELIMINANDO INSUMO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rta == DialogResult.Yes)
                {
                    if (switchInsModify.SwitchState == ParrotSwitch.State.On)
                    {
                        if (insumoImpresoraSeleccionado == null)
                        {
                            MessageBox.Show("Debe seleccionar un insumo para eliminar");
                            return;
                        }

                        if (insumoImpresoraBLL.Eliminar(insumoImpresoraSeleccionado))
                        {
                            MessageBox.Show($"Insumo {insumoImpresoraSeleccionado.Nombre} eliminado con éxito");
                            insumoImpresoraSeleccionado = null;
                            CargarGrilla();
                            return;
                        }
                    }
                    else
                    {
                        if (insumoSeleccionado == null)
                        {
                            MessageBox.Show("Debe seleccionar un insumo para eliminar");
                            return;
                        }
                        if (insumoBLL.Eliminar(insumoSeleccionado))
                        {
                            MessageBox.Show($"Insumo {insumoSeleccionado.Nombre} eliminado con éxito");
                            insumoSeleccionado = null;
                            CargarGrilla();
                            return;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarInsNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (loading) return;


                if (insumoImpresoraSeleccionado != null || insumoSeleccionado != null)
                {
                    LlenarPanelModificacionInsumo();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un insumo");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
        #endregion
        #region "ABM SERVICIO"

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationHelper.TextBoxAreEmpty(tableLayoutServicesMain))
                {
                    MessageBox.Show("Debe completar todos los campos para cargar un servicio.");
                    return;
                }
                //Lógica para cargar servicio
                servicio.Id = serviciosBLL.ObtenerUltimoId() + 1;
                servicio.Nombre = txtNombreServiceNew.TextButton;
                servicio.ImporteMensual = decimal.Parse(txtMontoServiceNew.TextButton);

                if (serviciosBLL.Guardar(servicio))
                {
                    MessageBox.Show("Servicio guardado correctamente.");
                    CargarGrillasServicios();
                    return;
                }
                else
                {
                    MessageBox.Show("Error al guardar el servicio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarServices_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rta = MessageBox.Show("¿Desea eliminar el servicio seleccionado?", "ELIMINANDO INSUMO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rta == DialogResult.Yes)
                {
                    if (servicioSeleccionado == null)
                    {
                        MessageBox.Show("Debe seleccionar un servicio para eliminar");
                        return;
                    }
                    if (serviciosBLL.Eliminar(servicioSeleccionado))
                    {
                        MessageBox.Show($"Servicio de {servicioSeleccionado.Nombre} eliminado con éxito");
                        servicioSeleccionado = null;
                        CargarGrillasServicios();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Falla al eliminar servicio");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModServices_Click(object sender, EventArgs e)
        {
            try
            {
                if (servicioSeleccionado != null)
                {
                    LlenarPanelModificacionServicio();

                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un servicio");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #endregion

        #region "SELECCION DE INSUMO"

        private void dgvInsModify_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (switchInsModify.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.On)
                {
                    insumoImpresoraSeleccionado = dgvInsModify.SelectedRows[0].DataBoundItem as InsumoImpresora;
                    insumoSeleccionado = null;
                }
                else
                {
                    insumoSeleccionado = dgvInsModify.SelectedRows[0].DataBoundItem as Insumo;
                    insumoImpresoraSeleccionado = null;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                servicioSeleccionado = dgvServices.SelectedRows[0].DataBoundItem as Servicios;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "SWITCHES"

        private void switchInsumos_SwitchStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (loading) { return; }

                if (switchInsumos.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.On)
                {
                    cambioDeInsumo(labelTipoInsumo2.Location.Y, false);
                    limpiarTextBox();

                }
                else
                {
                    cambioDeInsumo(labelTipoInsumo2.Location.Y, true);
                    limpiarTextBox();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void switchInsModify_SwitchStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (loading) return;

                if (switchInsModify.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.On)
                {
                    //Cambiar el label del switch para indicar que se están mostrando los insumos para impresora
                    labelInsModify.Text = "PARA IMPRESORA";
                    labelInsModify.Location = new Point((panelModIns.Width - labelInsModify.Width) / 2, labelInsModify.Location.Y);
                    CargarGrilla();
                }
                else
                {
                    //Cambiar el label del switch para indicar que se están mostrando los insumos regulares
                    labelInsModify.Text = "REGULAR";
                    labelInsModify.Location = new Point((panelModIns.Width - labelInsModify.Width) / 2, labelInsModify.Location.Y);
                    CargarGrilla();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "LÓGICA DE PANELES MODIFICACIÓN"
        private void LlenarPanelModificacionServicio()
        {
            try
            {
                if (servicioSeleccionado == null) { MessageBox.Show("Por favor, seleccione un servicio para modificar"); return; }
                panelModificacionServicio.Visible = true;
                panelModificacionServicio.Enabled = true;
                txtNomServicesMod.TextButton = servicioSeleccionado.Nombre;
                txtImporteModServices.TextButton = servicioSeleccionado.ImporteMensual.ToString();

                //Solo mostramos el panel de modificación, por ende todo el resto se invisibiliza
                mainPaneles.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void LlenarPanelModificacionInsumo()
        {
            try
            {
                if (insumoSeleccionado == null && insumoImpresoraSeleccionado == null) { MessageBox.Show("Por favor, seleccione un insumo para modificar"); return; }

                panelModificacionInsumo.Visible = true;

                panelModificacionInsumo.Enabled = true;

                if (insumoImpresoraSeleccionado != null) //Esto significa que insumoRegularSeleccionado seleccionado es null, por lo establecido en la lógica de selección
                {

                    txtNomInsumoMod.TextButton = insumoImpresoraSeleccionado.Nombre;
                    txtCantidadInsMod.TextButton = insumoImpresoraSeleccionado.Contenido.ToString();
                    txtUnidadInsMod.TextButton = insumoImpresoraSeleccionado.UnidadContenido;
                    txtCostoInsMod.TextButton = insumoImpresoraSeleccionado.Precio.ToString();
                    txtStockInsMod.TextButton = insumoImpresoraSeleccionado.Rendimiento.ToString();

                    //Cargar el combo box con los valores "SÍ" y "NO" para indicar si el insumo es color o no
                    comboBoxModIns.Items.Clear();
                    comboBoxModIns.Items.AddRange(new object[] { "SÍ", "NO" });
                    comboBoxModIns.SelectedItem = insumoImpresoraSeleccionado.EsColor ? "SÍ" : "NO";

                    //Cambiar los labels para que se adapten a la clase InsumoImpresora
                    labelStockRendimientoMod.Text = "RENDIMIENTO";
                    labelTipoCalculoEsColorMod.Text = "¿ES COLOR?";


                }
                else //Esto significa que insumoImpresoraSeleccionado es null, por ende la selección es de un insumo regular
                {

                    txtNomInsumoMod.TextButton = insumoSeleccionado.Nombre;
                    txtCantidadInsMod.TextButton = insumoSeleccionado.Cantidad.ToString();
                    txtUnidadInsMod.TextButton = insumoSeleccionado.UnidadMedida;
                    txtStockInsMod.TextButton = insumoSeleccionado.Stock.ToString();
                    txtCostoInsMod.TextButton = insumoSeleccionado.CostoInsumo.ToString();

                    //Cambiar los labels para que se adapten a la clase Insumo
                    labelStockRendimientoMod.Text = "STOCK";
                    labelTipoCalculoEsColorMod.Text = "TIPO DE CÁLCULO";


                    //Cargar el combo box con los valores del enum MetodoCalculoTinta
                    comboBoxModIns.Items.Clear();
                    comboBoxModIns.Items.AddRange(Enum.GetNames(typeof(MetodoCalculoCosto)));
                    comboBoxModIns.SelectedItem = insumoSeleccionado.TipoDeCalculo;

                }

                //Solo mostramos el panel de modificación, por ende todo el resto se invisibiliza
                mainPaneles.Visible = false;
                mainPaneles.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void MostrarPanelPrincipal()
        {
            try
            {
                panelModificacionInsumo.Visible = false;
                panelModificacionInsumo.Enabled = false;

                panelModificacionServicio.Visible = false;
                panelModificacionServicio.Enabled = false;


                mainPaneles.Visible = true;
                mainPaneles.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #region "BOTONES DE MODIFICACIÓN"
        private void btnConfirmarModServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationHelper.TextBoxAreEmpty(panelModificacionServicio)) { MessageBox.Show("Debe rellenar todos los campos"); return; }
                if (!Information.IsNumeric(txtImporteModServices.TextButton)) { MessageBox.Show("El importe debe ser númerico"); return; }

                servicioSeleccionado.Nombre = txtNomServicesMod.TextButton;
                servicioSeleccionado.ImporteMensual = decimal.Parse(txtImporteModServices.TextButton);

                if (serviciosBLL.Modificar(servicioSeleccionado))
                {
                    MessageBox.Show("Servicio modificado correctamente :)");
                    MostrarPanelPrincipal();
                }
                else
                {
                    MessageBox.Show("Falla al modificar serivicio :(");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmarModInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                if (insumoImpresoraSeleccionado != null) //Esto significa que insumoRegularSeleccionado seleccionado es null, por lo establecido en la lógica de selección
                {

                    insumoImpresoraSeleccionado.Nombre = txtNomInsumoMod.TextButton;
                    insumoImpresoraSeleccionado.Contenido = int.Parse(txtCantidadInsMod.TextButton);
                    insumoImpresoraSeleccionado.UnidadContenido = txtUnidadInsMod.TextButton;
                    insumoImpresoraSeleccionado.Precio = decimal.Parse(txtCostoInsMod.TextButton);
                    insumoImpresoraSeleccionado.Rendimiento = int.Parse(txtStockInsMod.TextButton);

                    if (insumoImpresoraBLL.Modificar(insumoImpresoraSeleccionado))
                    {
                        MessageBox.Show($"¡Insumo {insumoImpresoraSeleccionado.Nombre} modificado con éxito!");
                        MostrarPanelPrincipal();
                    }
                    else
                    {
                        MessageBox.Show($"Falla al modificar insumo :(");
                        MostrarPanelPrincipal();
                    }


                }
                else //Esto significa que insumoImpresoraSeleccionado es null, por ende la selección es de un insumo regular
                {

                    insumoSeleccionado.Nombre = txtNomInsumoMod.TextButton;
                    insumoSeleccionado.Cantidad = int.Parse(txtCantidadInsMod.TextButton);
                    insumoSeleccionado.UnidadMedida = txtUnidadInsMod.TextButton;
                    insumoSeleccionado.CostoInsumo = decimal.Parse(txtCostoInsMod.TextButton);
                    insumoSeleccionado.Stock = int.Parse(txtStockInsMod.TextButton);

                    if (insumoBLL.Modificar(insumoSeleccionado))
                    {
                        MessageBox.Show($"¡Insumo{insumoSeleccionado.Nombre} modificado con éxito!");
                        MostrarPanelPrincipal();
                    }
                    else
                    {
                        MessageBox.Show($"Falla al modificar insumo :(");
                        MostrarPanelPrincipal();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarPanelPrincipal();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void exitPictureBoxModInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarPanelPrincipal();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        #endregion

        #region "FUNCIONES NO UTILIZADAS"

        private void btnModificarIns_Click(object sender, EventArgs e)
        {
            try
            {
                if (loading) return;


                if (insumoImpresoraSeleccionado != null || insumoSeleccionado != null)
                {
                    LlenarPanelModificacionInsumo();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un insumo");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void dgvInsModify_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvIns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (switchInsumoMod.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.On)
                {
                    insumoImpresoraSeleccionado = dgvInsModify.SelectedRows[0].DataBoundItem as InsumoImpresora;
                }
                else
                {
                    insumoSeleccionado = dgvInsModify.SelectedRows[0].DataBoundItem as Insumo;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void switchInsModify_Click(object sender, EventArgs e)
        {

        }
        private void btnModServicio_Click(object sender, EventArgs e)
        {
            try
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEliminarIns_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEliminarServicio_Click(object? sender, EventArgs e)
        {
            try
            {
                if (servicioSeleccionado.Id != 0)
                {
                    if (serviciosBLL.Eliminar(servicioSeleccionado))
                    {
                        MessageBox.Show("Servicio eliminado correctamente");
                        CargarGrillasServicios();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Falla al eliminar servicio");
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un servicio para eliminar");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnMod_Click(object sender, EventArgs e)
        {

            try
            {



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvInsumos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (switchInsumoMod.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.On)
                {
                    insumoImpresoraSeleccionado = dgvInsModify.SelectedRows[0].DataBoundItem as InsumoImpresora;
                }
                else
                {
                    insumoSeleccionado = dgvInsModify.SelectedRows[0].DataBoundItem as Insumo;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void switchInsumoMod_SwitchStateChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void logoBox_Click(object sender, EventArgs e)
        {


        }
        private void switchInsumo_SwitchStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (loading) { return; }

                if (switchInsumo.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.On)
                {
                    cambioDeInsumo(labelTipoInsumo.Location.Y, false);
                    limpiarTextBox();

                }
                else
                {
                    cambioDeInsumo(labelTipoInsumo.Location.Y, true);
                    limpiarTextBox();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnMod_Load(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCargarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                //Lógica para cargar servicio
                servicio.Id = serviciosBLL.ObtenerUltimoId() + 1;
                servicio.Nombre = txtNombreServicio.Text;
                servicio.ImporteMensual = decimal.Parse(txtImporteServicio.Text);

                if (serviciosBLL.Guardar(servicio))
                {
                    MessageBox.Show("Servicio guardado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al guardar el servicio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnCargarInsumo_Click_1(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion





     
    }
}
