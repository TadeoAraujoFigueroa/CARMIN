using CARMIN___APP.Controls;
using CARMIN___APP.Helpers;
using CARMIN___BE.Entities;
using CARMIN___BLL;
using CARMIN___BLL.Helper;
using CARMIN___BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CARMIN___APP.Forms
{
    public partial class PresupuestadorForm : Form
    {

        public BindingList<ItemPresupuesto> itemsPresupuesto { get; set; } = new BindingList<ItemPresupuesto>();
        private List<Impresora> impresoras = new List<Impresora>();
        private List<Servicios> servicios = new List<Servicios>();
        private List<Insumo> listaInsumos = new List<Insumo>();

        private Presupuesto presupuesto;
        private PresupuestoBLL presupuestoBLL;

        private ImpresoraBLL impresoraBLL;
        private Impresora _impresoraSeleccionada;
        private ServiciosBLL serviciosBLL;

        private Insumo insumoSeleccionado;
        private InsumoBLL insumoBLL;

        private bool loading = true;
        private bool loading_impresoras = false;

        private decimal costoTotalCalculado = 0m;
        private decimal costoTotalInsumos = 0m;
        private decimal costoTotalTinta = 0m;
        private decimal costoTotalHoras = 0m;

        private int cont = 0;

        ConfiguracionNegocio configMock = new ConfiguracionNegocio
        {
            Id = 1,
            HorasProductivasMensuales = 120,
            MargenGanancia = 100,
            PorcentajeMerma = 10,
            PorcentajeMaquinaria = 5,
            HoraManoDeObra = 8000
        };

        public PresupuestadorForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al inicializar el form: " + ex.Message);
            }
        }
        private void PresupuestadorForm_Load(object sender, EventArgs e)
        {
          
            try
            {
                //Configuración del picture box
                logoBox.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
                logoBox.SizeMode = PictureBoxSizeMode.Zoom;

                //Configuración del picture box
                exitPictureBox.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
                exitPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                questionBoxCostos.Image = Image.FromFile(ConfigHelper.GetRuta("Pregunta", "pregunta.png"));
                questionBoxImpresion.Image = Image.FromFile(ConfigHelper.GetRuta("Pregunta", "pregunta.png"));
                questionBoxCostos.SizeMode = PictureBoxSizeMode.Zoom;
                questionBoxImpresion.SizeMode = PictureBoxSizeMode.Zoom;


                //Suscribimos al evento TextChanged de los TextBox para recalcular los costos cada vez que el usuario modifique alguno de los campos relacionados con los costos.
                txtMermaNew2.TextChanged += CalcularCostos;
                txtMaquinariaNew2.TextChanged += CalcularCostos;
                txtDescuentoNew2.TextChanged += CalcularCostos;
                txtGananciaNew2.TextChanged += CalcularCostos;
                txtHorasManoDeObraNew2.TextChanged += CalcularCostoHoras;
                txtHorasGastoNew2.TextChanged += CalcularCostoHoras;

                //Cargamos los valores de configuración en los campos correspondientes. En el futuro, esto lo hará el BLL de presupuestos, pero por ahora lo dejo acá para que se vea el flujo completo.
                txtMermaNew2.TextButton = configMock.PorcentajeMerma.ToString();
                txtMaquinariaNew2.TextButton = configMock.PorcentajeMaquinaria.ToString();
                txtGananciaNew2.TextButton = configMock.MargenGanancia.ToString();
                txtDescuentoNew2.TextButton = "0";

                //Instanciamos la clase presupuesto (BE y BLL)
                presupuesto = new Presupuesto();
                presupuestoBLL = new PresupuestoBLL();
                impresoraBLL = new ImpresoraBLL();
                serviciosBLL = new ServiciosBLL();
                insumoBLL = new InsumoBLL();
                //Actualizamos la lista de servicios con los datos de la base de datos, para que se tengan en cuenta a la hora de calcular el costo por hora de gastos fijos.
                servicios = serviciosBLL.ListarTodo();

                //Configuramos los eventos de los botones
                btnAgNew.Click += btnAg_Click;
                btnElimNew.Click += btnElim_Click;
                btnAgImpreNew.Click += btnAgImpre_Click;
                btnElimImpreNew.Click += btnElimImpre_Click;
                btnGenerarPDFNew.Click += btnGenerarPDF_Click;
                btnGuardarNew.Click += btnGuardar_Click;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el form: " + ex.Message);
            }
           
        }
        private void PresupuestadorForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.SuspendLayout();

                AjustarLayout();

                this.ResumeLayout(true);
                //Este laburo lo realizará el BLL de presupuestos, pero por ahora lo dejo acá para que se vea el flujo completo.
                if (itemsPresupuesto != null && itemsPresupuesto.Count > 0)
                {
                    CalcularCostos();

                }


                CargarGrillasTotales();

                loading = false;
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

        private void CargarGrillasTotales()
        {
            try
            {
                listaInsumos = insumoBLL.ListarTodo();
                CargarGrillaInsumos(listaInsumos);
                CargarDatosImpresora();
                CargarDataGridImpresora();
                CargarGrilla();
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
                //TO DO: Chequear asignación del Owner, porque a veces me tira error de que el Owner es null. La idea es que el Owner sea el form desde el cual se abrió el form del presupuestador, para que al cerrar el form del presupuestador, se muestre nuevamente el form desde el cual se abrió.
                if (this.Owner != null)
                {
                    this.Owner.Show();
                    this.Hide();
                }
                else
                {
                    Form mainForm = new MainForm();
                    mainForm.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void combo_impresoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (loading_impresoras) return; // Evitamos que se ejecute el código al cargar los datos por primera vez

                _impresoraSeleccionada = combo_impresoras.SelectedItem as Impresora;

                CargarPerfilesImpresora(_impresoraSeleccionada);
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
                subMainPanel.Size = new Size(this.ClientSize.Width - 125, this.ClientSize.Height - 125);
                subMainPanel.Location = new Point((this.ClientSize.Width - subMainPanel.Width) / 2, (this.ClientSize.Height - subMainPanel.Height) / 2);
                panelMain.Location = new Point((this.ClientSize.Width - panelMain.Width) / 2, (this.ClientSize.Height - panelMain.Height) / 2);

                logoBox.Location = new Point(
                                       this.ClientSize.Width - logoBox.Width - 10,
                                       20);
                logoBox.BackColor = Color.Transparent;
                panelCostoImpresion.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelCostoImpresion.ClientRectangle, 30));
                panelHoras.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelHoras.ClientRectangle, 30));
                panelInsumos.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelInsumos.ClientRectangle, 30));
                tableLayoutResumen.Region = new Region(RoundedPanelHelper.CreateRoundedPath(tableLayoutResumen.ClientRectangle, 30));
                tableLayoutPanel3.Region = new Region(RoundedPanelHelper.CreateRoundedPath(tableLayoutPanel3.ClientRectangle, 30));
                tableLayoutPanel1.Region = new Region(RoundedPanelHelper.CreateRoundedPath(tableLayoutPanel1.ClientRectangle, 30));
                panelMain.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelMain.ClientRectangle, 30));
                questionBoxCostos.Region = new Region(RoundedPanelHelper.CreateRoundedPath(questionBoxCostos.ClientRectangle, 50));
                questionBoxImpresion.Region = new Region(RoundedPanelHelper.CreateRoundedPath(questionBoxImpresion.ClientRectangle, 50));

                dgvPresupuesto.ShowCellToolTips = true;

                MostrarPresupuestador();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarPresupuesto()
        {
            try
            {

                presupuesto.Id = presupuestoBLL.obtenerUltimoId() + 1;

                presupuesto.Nombre = txtNombrePresuNew2.TextButton;
                presupuesto.CostoTotal = int.Parse(txtCostoTotalNew2.TextButton.Replace(".", "").Replace("$", "").Trim());
                presupuesto.MontoTotal = decimal.Parse(txtTotalFinalNew2.TextButton.Replace(".", "").Replace("$", "").Trim());
                presupuesto.Descuento = decimal.Parse(txtDescuentoNew2.TextButton.Replace(".", "").Replace("$", "").Trim());
                presupuesto.MargenGanancia = decimal.Parse(txtGananciaNew2.TextButton.Replace(".", "").Replace("$", "").Trim());
                presupuesto.HorasTrabajo = decimal.Parse(txtHorasManoDeObraNew2.TextButton.Replace(".", "").Replace("$", "").Trim());
                presupuesto.HorasDiseño = decimal.Parse(txtHorasManoDeObraNew2.TextButton.Replace(".", "").Replace("$", "").Trim());
                presupuesto.MargenMaquinaria = decimal.Parse(txtMaquinariaNew2.TextButton.Replace(".", "").Replace("$", "").Trim());
                presupuesto.MargenMerma = decimal.Parse(txtMermaNew2.TextButton.Replace(".", "").Replace("$", "").Trim());
                presupuesto.Recargo = 0m;

                if (presupuestoBLL.Guardar(presupuesto))
                {
                    MessageBox.Show("Presupuesto guardado con éxito");
                    ReiniciarPresupuestador();
                }
                else
                {
                    MessageBox.Show("Error al cargar el presupuesto");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ReiniciarPresupuestador()
        {
            try
            {
                //Reiniciamos la lista de presupuestos
                itemsPresupuesto.Clear();
                //Reiniciamos la grilla de impresoras
                dgvImpresoras.Rows.Clear();

                costoTotalInsumos = 0m;
                costoTotalTinta = 0m;
                txtHorasGastoNew2.TextButton = "";
                txtHorasManoDeObraNew2.TextButton = "";

                txtNombrePresuNew2.TextButton = "Escribe aquí...";

                CalcularCostoHoras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region "CALCULO DE COSTOS"

        //El funcionamiento del presupuestador se basa en la suma constante de tres variables que engloban los costos de INSUMOS, TINTA Y HORAS DE MANO DE OBRA Y SERVICIOS
        //Las mismas definen el COSTO TOTAL CALCULADO sobre el cual se realiza posteriormente los calculos de merma, descuento y ganancia.
        private void CalcularCostoHoras()
        {
            try
            {
                costoTotalHoras = 0;
                decimal costoHorasManoDeObra = 0m;
                decimal costoHorasGastos = 0m;

                if (txtHorasGastoNew2.TextButton == null || txtHorasManoDeObraNew2.TextButton == null) return;

                decimal horasGastos = txtHorasGastoNew2.TextButton != "" ? decimal.Parse(txtHorasGastoNew2.TextButton) : 0m;
                decimal horasTotales = txtHorasManoDeObraNew2.TextButton != "" ? decimal.Parse(txtHorasManoDeObraNew2.TextButton) : 0m;

                costoHorasManoDeObra = horasTotales * configMock.HoraManoDeObra;

                //PRORATEAMOS LOS GASTOS FIJOS EN BASE A LAS HORAS PRODUCTIVAS MENSUALES Y AL IMPORTE MENSUAL DE LOS SERVICIOS, PARA OBTENER UN COSTO POR HORA DE GASTOS FIJOS,
                //Y LUEGO MULTIPLICAMOS ESE COSTO POR HORA POR LAS HORAS DE GASTOS QUE EL USUARIO INGRESÓ, PARA OBTENER EL COSTO TOTAL DE GASTOS FIJOS A INCLUIR EN EL PRESUPUESTO.

                decimal totalServicios = servicios.Sum(s => s.ImporteMensual);
                decimal costoFijoPorHora = totalServicios / configMock.HorasProductivasMensuales;

                costoHorasGastos = horasGastos * costoFijoPorHora;


                txtTotalManoDeObraNew2.TextButton = costoHorasManoDeObra.ToString("C0");
                txtTotalGastosFijosNew2.TextButton = costoHorasGastos.ToString("C0");

                costoTotalHoras = costoHorasManoDeObra + costoHorasGastos;

                CalcularCostos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el costo de horas: " + ex.Message);
            }
        }
        private void CalcularCostoTotal()
        {
            try
            {
                costoTotalCalculado = 0; ;
                costoTotalCalculado = (costoTotalInsumos + costoTotalTinta + costoTotalHoras);
                txtCostoTotalNew2.TextButton = costoTotalCalculado.ToString("C0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el costo total: " + ex.Message);
            }
        }
        private void CalcularCostos()
        {
            try
            {

                CalcularCostoTotal();

                if (txtMermaNew2.TextButton != "" && txtMaquinariaNew2.TextButton != "")
                {
                    decimal merma = decimal.Parse(txtMermaNew2.TextButton) / 100m;
                    decimal maquinaria = decimal.Parse(txtMaquinariaNew2.TextButton) / 100m;
                    costoTotalCalculado = costoTotalCalculado + (costoTotalCalculado * merma) + (costoTotalCalculado * maquinaria);
                    txtSubTotalTecNew2.TextButton = costoTotalCalculado.ToString("C0");
                }
                if (txtDescuentoNew2.TextButton != "" && txtGananciaNew2.TextButton != "")
                {
                    decimal descuento = decimal.Parse(txtDescuentoNew2.TextButton) / 100m;
                    decimal ganancia = decimal.Parse(txtGananciaNew2.TextButton) / 100m;
                    decimal total = costoTotalCalculado - (costoTotalCalculado * descuento) + (costoTotalCalculado * ganancia);
                    txtTotalFinalNew2.TextButton = total.ToString("C0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular costos: " + ex.Message);
            }
        }

        #endregion

        #region "CARGA DE COMBO BOX IMPRESORA"
        private void CargarDatosImpresora()
        {
            try
            {
                loading_impresoras = true;

                combo_impresoras.DataSource = null;
                combo_perfil.DataSource = null;

                impresoras = impresoraBLL.ListarTodo();

                combo_impresoras.DataSource = impresoras;
                combo_impresoras.DisplayMember = "Modelo";
                combo_impresoras.ValueMember = "Id";

                _impresoraSeleccionada = combo_impresoras.SelectedItem as Impresora;

                CargarPerfilesImpresora(_impresoraSeleccionada);

                loading_impresoras = false;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void CargarPerfilesImpresora(Impresora impresora)
        {
            try
            {
                if (impresora != null)
                {
                    combo_perfil.DataSource = null;
                    combo_perfil.DataSource = impresora.PerfilesDeImpresion;
                    combo_perfil.DisplayMember = "Nombre";
                    combo_perfil.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "BOTONES INSUMOS"
        private void btnAg_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarTablaInsumos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            try
            {
                var itemSeleccionado = dgvPresupuesto.SelectedRows[0].DataBoundItem as ItemPresupuesto;
                foreach (var item in itemsPresupuesto)
                {
                    if (item.Id == itemSeleccionado.Id)
                    {
                        itemsPresupuesto.Remove(item);
                        break;
                    }
                }
                //Cada vez que cargamos la grilla, recalculamos el costo total de los insumos para que se vaya actualizando en el calculo final.
                costoTotalInsumos = 0m;
                costoTotalInsumos = itemsPresupuesto.Sum(i => i.Costo);
                CalcularCostos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Funcionalidad en desarrollo. Próximamente podrá generar un PDF con el presupuesto detallado.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationHelper.TextBoxAreEmpty(this))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de guardar el presupuesto.");
                    return;
                }
                CargarPresupuesto();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "BOTONES IMPRESORA"
        private void btnElimImpre_Click(object sender, EventArgs e)
        {
            try
            {
                if (_impresoraSeleccionada == null)
                {
                    MessageBox.Show("Por favor, seleccione una impresora para eliminar.");
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in dgvImpresoras.Rows)
                    {
                        if (row.Cells["Impresora"].Value.ToString() == _impresoraSeleccionada.Modelo)
                        {
                            dgvImpresoras.Rows.Remove(row);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgImpre_Click(object sender, EventArgs e)
        {
            try
            {
                var impresoraSeleccionada = combo_impresoras.SelectedItem as Impresora;
                var perfilSeleccionado = combo_perfil.SelectedItem as PerfilImpresion;
                if (impresoraSeleccionada == null || perfilSeleccionado == null)
                {
                    MessageBox.Show("Por favor, seleccione una impresora y un perfil de impresión.");
                    return;
                }
                else
                {
                    dgvImpresoras.Rows.Add(impresoraSeleccionada.Modelo, perfilSeleccionado.Nombre, "0", "0");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "FUNCIONES GRILLAS"

        private void dgvPresupuesto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (loading) return; // Evitamos que se ejecute el código al cargar la grilla por primera vez
                ItemPresupuesto item = dgvPresupuesto.SelectedRows[0].DataBoundItem as ItemPresupuesto;
                item.Costo = item.PrecioUnitario * item.Cantidad;
                item.Costo = item.Costo - (item.Costo * (item.Descuento / 100));
                item.Costo = item.Costo + (item.Costo * (item.Recargo / 100));
                foreach (var itemViejo in itemsPresupuesto)
                {
                    if (itemViejo.Id == item.Id)
                    {
                        itemViejo.Cantidad = item.Cantidad;
                        itemViejo.Descuento = item.Descuento;
                        itemViejo.Recargo = item.Recargo;
                        itemViejo.Costo = item.Costo;
                    }
                }
                dgvPresupuesto.Refresh();
                //Cada vez que cargamos la grilla, recalculamos el costo total de los insumos para que se vaya actualizando en el calculo final.
                costoTotalInsumos = 0m;
                costoTotalInsumos = itemsPresupuesto.Sum(i => i.Costo);
                CalcularCostos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvImpresoras_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (loading) return; // Evitamos que se ejecute el código al cargar la grilla por primera vez

                if (e.ColumnIndex != dgvImpresoras.Columns["Cantidad"].Index) return; // Solo recalculamos el costo si se modificó la columna de cantidad

                var impresoraSeleccionada = impresoras.FirstOrDefault(i => i.Modelo == dgvImpresoras.Rows[e.RowIndex].Cells["Impresora"].Value.ToString());
                var perfilSeleccionado = impresoraSeleccionada.PerfilesDeImpresion.FirstOrDefault(p => p.Nombre == dgvImpresoras.Rows[e.RowIndex].Cells["Perfil"].Value.ToString());

                int cantidad_impresiones = int.Parse(dgvImpresoras.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                decimal costo_impresion = impresoraSeleccionada.CalcularCosto(cantidad_impresiones, perfilSeleccionado);

                dgvImpresoras.Rows[e.RowIndex].Cells["CostoAcumulado"].Value = costo_impresion.ToString("C0");

                //CADA VEZ QUE AGREGAMOS O MODIFICAMOS UNA IMPRESORA, RECALCULAMOS EL COSTO TOTAL DE TINTA PARA QUE SE VAYA ACTUALIZANDO EN EL CALCULO FINAL.
                costoTotalTinta = 0m;
                foreach (DataGridViewRow row in dgvImpresoras.Rows)
                {
                    if (row.Cells["CostoAcumulado"].Value != null)
                    {
                        string costoUnitarioStr = row.Cells["CostoAcumulado"].Value.ToString().Replace("$", "").Trim();
                        if (decimal.TryParse(costoUnitarioStr, out decimal costoUnitario))
                        {
                            costoTotalTinta += costoUnitario;
                        }
                    }
                }
                CalcularCostos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDataGridImpresora()
        {
            try
            {
                dgvImpresoras.AutoGenerateColumns = false;
                dgvImpresoras.Rows.Clear();
                dgvImpresoras.Columns.Clear();

                dgvImpresoras.AllowUserToAddRows = false;
                dgvImpresoras.AllowUserToDeleteRows = false;
                dgvImpresoras.MultiSelect = false;
                dgvImpresoras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvImpresoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvImpresoras.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Impresora",
                    HeaderText = "IMPRESORA"
                });

                dgvImpresoras.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Perfil",
                    HeaderText = "PERFIL DE IMPRESIÓN"
                });

                dgvImpresoras.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Cantidad",
                    HeaderText = "CANTIDAD"
                });

                dgvImpresoras.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "CostoAcumulado",
                    HeaderText = "COSTO ACUMULADO"
                });
                dgvImpresoras.Columns["Impresora"].ReadOnly = true;
                dgvImpresoras.Columns["Perfil"].ReadOnly = true;
                dgvImpresoras.Columns["CostoAcumulado"].ReadOnly = true;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla de impresoras: " + ex.Message);
            }
        }

        private void CargarGrilla()
        {
            try
            {
                dgvPresupuesto.DataSource = null;
                dgvPresupuesto.DataSource = itemsPresupuesto;
                dgvPresupuesto.Columns["Id"].Visible = false; // Ocultamos la columna Id, ya que no es relevante para el usuario    
                dgvPresupuesto.Columns["Nombre"].HeaderText = "INSUMO"; // Cambiamos el header de la columna Nombre a Insumo, para que sea más claro para el usuario
                dgvPresupuesto.Columns["PrecioUnitario"].HeaderText = "PRECIO UNITARIO";
                dgvPresupuesto.Columns["Costo"].HeaderText = "COSTO TOTAL";
                dgvPresupuesto.Columns["Cantidad"].HeaderText = "CANTIDAD";
                dgvPresupuesto.Columns["Descuento"].HeaderText = "DESCUENTO (%)";
                dgvPresupuesto.Columns["Recargo"].HeaderText = "RECARGO (%)";


                foreach (DataGridViewColumn column in dgvPresupuesto.Columns)
                {
                    if (column.Name == "Cantidad" || column.Name == "Descuento" || column.Name == "Recargo")
                    {
                        column.ReadOnly = false; // Permitimos que el usuario edite la cantidad, el descuento y el recargo, ya que estos campos afectan directamente al costo total del presupuesto.
                    }
                    else
                    {
                        column.ReadOnly = true; // Las demás columnas son de solo lectura, ya que se calculan automáticamente.
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla: " + ex.Message);
            }
        }

        private void dgvPresupuesto_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                var valor = dgvPresupuesto.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                e.ToolTipText = valor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "FUNCIÓN NO UTILIZADA"

        private void bigLabel4_Click(object sender, EventArgs e)
        {

        }

        private void shadowRoundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgImpre_Load(object sender, EventArgs e)
        {

        }

        private void dgvPresupuesto_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvPresupuesto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        #endregion

        private void MostrarPresupuestador()
        {
            try
            {
                panelMain.Visible = false;
                panelMain.Enabled = false;
                subMainPanel.Visible = true;
                subMainPanel.Enabled = true;
                logoBox.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void MostrarTablaInsumos()
        {
            try
            {
                panelMain.Visible = true;
                panelMain.Enabled = true;
                subMainPanel.Visible = false;
                subMainPanel.Enabled = false;
                logoBox.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                insumoSeleccionado = dgvInsumos.SelectedRows[0].DataBoundItem as Insumo;
                //Convertimos el insumo seleccionado a item presupuesto para agregarlo a la lista de items elegidos para el presupuestador
                if (ConvertirInsumoAItemsPresupuesto(insumoSeleccionado))
                {
                    //Cada vez que cargamos la grilla, recalculamos el costo total de los insumos para que se vaya actualizando en el calculo final.
                    costoTotalInsumos = 0m;
                    costoTotalInsumos = itemsPresupuesto.Sum(i => i.Costo);
                    CalcularCostos();
                    MostrarPresupuestador();

                }
                else
                {
                    MessageBox.Show("No se pudo agregar el insumo seleccionado al presupuesto. Intente nuevamente.");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool ConvertirInsumoAItemsPresupuesto(Insumo insumoElegido)
        {
            //A partir del insumo elegido por el usuario, creamos un item presupuesto con la información relevante (nombre, precio unitario, etc)
            //Esto es importante debido a que lo que nos interesa es devolver este ITEM al formulario de presupuestador
            try
            {
                ItemPresupuesto item = new ItemPresupuesto
                {
                    Id = insumoElegido.Id,
                    Nombre = insumoElegido.Nombre,
                    Cantidad = 1, // Por defecto, la cantidad es 1. El usuario puede modificarla después.
                    PrecioUnitario = insumoElegido.PrecioUnitario,
                    Costo = insumoElegido.PrecioUnitario * 1, // Costo inicial igual al precio unitario por la cantidad (que es 1)
                };
                itemsPresupuesto.Add(item);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir insumos a items de presupuesto: " + ex.Message);
                return false;
            }
        }

        private void CargarGrillaInsumos(List<Insumo> listaActualizada)
        {
            try
            {
                dgvInsumos.DataSource = null;
                dgvInsumos.DataSource = listaActualizada;
                dgvInsumos.Columns["Id"].Visible = false;
                dgvInsumos.Columns["TipoDeCalculo"].Visible = false;
                dgvInsumos.Columns["Nombre"].DisplayIndex = 0;
                dgvInsumos.Columns["Cantidad"].DisplayIndex = 1;
                dgvInsumos.Columns["UnidadMedida"].DisplayIndex = 2;
                dgvInsumos.Columns["CostoInsumo"].DisplayIndex = 3;
                dgvInsumos.Columns["Stock"].DisplayIndex = 4;
                dgvInsumos.Columns["PrecioUnitario"].DisplayIndex = 5;
                dgvInsumos.Columns["Nombre"].HeaderText = "NOMBRE";
                dgvInsumos.Columns["Cantidad"].HeaderText = "CANTIDAD";
                dgvInsumos.Columns["UnidadMedida"].HeaderText = "UNIDAD DE MEDIDA";
                dgvInsumos.Columns["CostoInsumo"].HeaderText = "COSTO";
                dgvInsumos.Columns["Stock"].HeaderText = "STOCK";
                dgvInsumos.Columns["PrecioUnitario"].HeaderText = "PRECIO UNITARIO";

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
                MostrarPresupuestador();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.ToLower();
                var insumosFiltrados = listaInsumos.Where(i => i.Nombre.ToLower().Contains(filtro)).ToList();
                CargarGrillaInsumos(insumosFiltrados);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void PresupuestadorForm_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                cont++;
                if (this.Visible == false) return;
                if (cont == 1) return;
                loading = true;
                CargarGrillasTotales();
                loading = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

