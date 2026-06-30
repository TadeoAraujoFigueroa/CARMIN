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

namespace CARMIN___APP.Forms
{
    public partial class CargaDeImpresoraForm : Form
    {
        private Impresora _impresoraSeleccionada;
        private Impresora _impresora;

        private InsumoImpresora _insumoSeleccionado;
        private InsumoImpresora _insumoSeleccionadoMod;

        private ImpresoraBLL _impresoraBLL;
        private InsumoImpresoraBLL _insumoBLL;

        private PerfilesImpresionBLL _perfilesBLL;

        private List<PerfilImpresion> perfilesImpresion = new List<PerfilImpresion>();
        private List<InsumoImpresora> insumosAsociados = new List<InsumoImpresora>();
        private List<InsumoImpresora> insumosAsociadosMod = new List<InsumoImpresora>();
        private List<InsumoImpresora> insumosTotales = new List<InsumoImpresora>();

        private bool _loading;
        public CargaDeImpresoraForm()
        {
            InitializeComponent();
        }

        private void CargaDeImpresoraForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                _loading = true;

                //Inicializamos los objetos
                _impresoraSeleccionada = null;
                _insumoSeleccionado = null;
                _impresoraBLL = new ImpresoraBLL();
                _insumoBLL = new InsumoImpresoraBLL();
                _perfilesBLL = new PerfilesImpresionBLL();


                logoBox.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
                logoBox.SizeMode = PictureBoxSizeMode.Zoom;



                btnAsociarInsumo.Image = Image.FromFile(ConfigHelper.GetRuta("Tilde"));
                btnAsociarInsumo.SizeMode = PictureBoxSizeMode.Zoom;
                btnAsociarInsumo.Click += btnAsociarInsumo_Click_1;
                btnAsociarInsMod.Image = Image.FromFile(ConfigHelper.GetRuta("Tilde"));
                btnAsociarInsMod.SizeMode = PictureBoxSizeMode.Zoom;

                btnDesInsumo.Image = Image.FromFile(ConfigHelper.GetRuta("Cruz"));
                btnDesInsumo.SizeMode = PictureBoxSizeMode.Zoom;
                btnDesInsumo.Click += btnDesInsumo_Click_1;

                btnDesasociarInsMod.Image = Image.FromFile(ConfigHelper.GetRuta("Cruz"));
                btnDesasociarInsMod.SizeMode = PictureBoxSizeMode.Zoom;

                //Cargamos los eventos de los botones
                buttonCargaImpresoraNew.Click += BtnCargarImpresora_Click;

                btnModificarImpresoraNew.Click += BtnModImpresora_Click;

                btnEliminarNew.Click += BtnEliminar_Click;


                btnAsociarInsumo.Click += BtnAsociar_Click;

                btnDesInsumo.Click += BtnDesasociar_Click;

                dgvImpresoras.CellClick += dgvImpresoras_CellContentClick;
                //Cargamos los combobox
                comboTecnologia.Items.Clear();
                comboTecnologia.Items.AddRange(Enum.GetNames(typeof(TecnologiaImpresora)));
                comboTecnologia.SelectedItem = 0;


                comboTipoCalculo.Items.Clear();
                comboTipoCalculo.Items.AddRange(Enum.GetNames(typeof(MetodoCalculoImpresora)));
                comboTipoCalculo.SelectedItem = 0;


                comboTecnoMod.Items.Clear();
                comboTecnoMod.Items.AddRange(Enum.GetNames(typeof(TecnologiaImpresora)));

                comboTipoMod.Items.Clear();
                comboTipoMod.Items.AddRange(Enum.GetNames(typeof(MetodoCalculoImpresora)));

                comboTipoMod.SelectedIndexChanged += comboTipoMod_SelectedIndexChanged;

                //Desactivamos los paneles relacionados a los perfiles de impresión, ya que el método de cálculo por defecto es por rendimiento
                panelPerfilesImpNew.Enabled = false;
                panelPerfilesImpModNew.Enabled = false;


                CargarGrillaInsumos();

                txtFotograficoAltoNew.TextButton = "FOT. CALIDAD ALTA";
                txtFotograficoStdNew.TextButton = "FOT. CALIDAD ESTÁNDAR";
                txtMateAltaNew.TextButton = "MATE CALIDAD ALTA";
                txtMateStdNew.TextButton = "MATE CALIDAD ESTÁNDAR";
                txtObraAltaNew.TextButton = "OBRA CALIDAD ALTA";
                txtObraStdNew.TextButton = "OBRA CALIDAD ESTÁNDAR";
                txtByNew.TextButton = "BLANCO Y NEGRO";


                txtFotAltModNew.TextButton = "FOT. CALIDAD ALTA";
                txtFotStdModNew.TextButton = "FOT. CALIDAD ESTÁNDAR";
                txtMateAltModNew.TextButton = "MATE CALIDAD ALTA";
                txtMateStdModNew.TextButton = "MATE CALIDAD ESTÁNDAR";
                txtObraAltModNew.TextButton = "OBRA CALIDAD ALTA";
                txtObraStdModNew.TextButton = "OBRA CALIDAD ESTÁNDAR";
                txtByNModNew.TextButton = "BLANCO Y NEGRO";

                //Cargamos el data grid con las impresoras disponibles
                CargarGrillaImpresoras();

                _loading = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void CargaDeImpresoraForm_Shown(object sender, EventArgs e)
        {
            this.SuspendLayout();
            try
            {
                AjustarLayout();
                insumosAsociados.Clear();
                ActualizarGrilla();
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

                tableLayoutPanel.Size = new Size(
              (int)(mainPanelNew.Width - 100),
              (int)(mainPanelNew.Height - 100));

                tableLayoutPanel.Location = new Point(
        (mainPanelNew.ClientSize.Width - tableLayoutPanel.Width) / 2,
        (mainPanelNew.ClientSize.Height - tableLayoutPanel.Height) / 2);
                tableLayoutPanel.SendToBack();


                logoBox.Location = new Point(
          mainPanelNew.Width - logoBox.Width - 20,
          10);


                miniPanelV.Region = new Region(RoundedPanelHelper.CreateRoundedPath(miniPanelV.ClientRectangle, 50));
                miniPanelX.Region = new Region(RoundedPanelHelper.CreateRoundedPath(miniPanelX.ClientRectangle, 50));
                panelTildeMod.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelTildeMod.ClientRectangle, 50));
                panelCruzMod.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelCruzMod.ClientRectangle, 50));
                panelModificacionNew.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelModificacionNew.ClientRectangle, 30));
                panelModImpresoraMain.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelModImpresoraMain.ClientRectangle, 30));
                tableLayoutCargaImp.Region = new Region(RoundedPanelHelper.CreateRoundedPath(tableLayoutCargaImp.ClientRectangle, 30));
                panelCargaImpresoraNew.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelCargaImpresoraNew.ClientRectangle, 30));
                panelCargaNew.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelCargaNew.ClientRectangle, 30));
                mainPanelNew.Region = new Region(RoundedPanelHelper.CreateRoundedPath(mainPanelNew.ClientRectangle, 30));


                panelCargaNew.Dock = DockStyle.Fill;
                panelCargaNew.Padding = new Padding(5);

                panelModificacionNew.Dock = DockStyle.Fill;
                panelModificacionNew.Padding = new Padding(5);


                bigLabel1.SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ActualizarGrilla()
        {
            try
            {
                CargarGrillaImpresoras();
                CargarGrillaInsumos();
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

        #region "FUNCIONES DE BOTONES"
        private void BtnCargarImpresora_Click(object sender, EventArgs e)
        {
            try
            {
                // Aquí iría la lógica para cargar la impresora utilizando los datos ingresados en el formulario.
                if (txtNombreNew.TextButton == "" || txtModeloNew.TextButton == "" || txtMarcaNew.TextButton == "")
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de cargar la impresora.");
                    return;
                }
                //Cargamos en memoria los perfiles a vincular con la impresora, para luego guardarlos junto con la impresora en la base de datos, ya que el perfil de impresión no es un dato que se ingresa al sistema de forma independiente, sino que se crea y se vincula a la impresora al momento de cargarla, por lo que no es necesario guardarlos en la base de datos antes de cargar la impresora
                cargarPerfilesDeImpresion();

                if (comboTipoCalculo.SelectedIndex == 0)
                {

                    _impresora = new ImpresoraPorRendimiento();
                    _impresora.Id = _impresoraBLL.ObtenerUltimoId();
                    _impresora.Modelo = txtModeloNew.TextButton;
                    _impresora.Marca = txtMarcaNew.TextButton;
                    _impresora.Nombre = txtNombreNew.TextButton;
                    _impresora.Tecnologia = comboTecnologia.SelectedItem.ToString();
                    _impresora.PerfilesDeImpresion = perfilesImpresion;



                    if (insumosAsociados.Count == 0)
                    {
                        MessageBox.Show("Por favor, asocie al menos un insumo a la impresora antes de cargarla.");
                        return;
                    }

                    //Carga de los insumos asociados a la impresora, solo si el método de cálculo seleccionado es por rendimiento, ya que si es por perfil de impresión, los insumos no son necesarios para el cálculo del costo
                    ((ImpresoraPorRendimiento)_impresora).InsumosImpresora = insumosAsociados;

                    if (_impresoraBLL.Guardar(_impresora))
                    {
                        MessageBox.Show("Impresora cargada exitosamente.");
                        insumosAsociados.Clear();
                        CargarGrillaImpresoras();
                        return;
                    }
                }
                else
                {
                    if (ValidationHelper.TextBoxAreEmpty(panelPerfilesImpNew))
                    {
                        MessageBox.Show("Por favor, complete todos los campos relacionados a los perfiles de impresión antes de cargar la impresora.");
                        return;
                    }
                    actualizarPerfilesDeImpresion();
                    _impresora = new ImpresoraPorCalidad();
                    _impresora.Id = _impresoraBLL.ObtenerUltimoId();
                    _impresora.Modelo = txtModeloNew.TextButton;
                    _impresora.Marca = txtMarcaNew.TextButton;
                    _impresora.Nombre = txtNombreNew.TextButton;
                    _impresora.Tecnologia = comboTecnologia.SelectedItem.ToString();
                    _impresora.PerfilesDeImpresion = perfilesImpresion;

                    if (_impresoraBLL.Guardar(_impresora))
                    {
                        MessageBox.Show("Impresora cargada exitosamente.");
                        CargarGrillaImpresoras();
                        return;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModImpresora_Click(object sender, EventArgs e)
        {
            try
            {
                if (_impresoraSeleccionada == null)
                {
                    MessageBox.Show("Por favor, seleccione una impresora para modificar.");
                    return;
                }

                // Aquí iría la lógica para modificar la impresora utilizando los datos ingresados en el formulario.
                // Por ejemplo, podrías buscar una impresora existente y actualizar sus valores con los datos del formulario.
                MessageBox.Show("Impresora modificada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_impresoraSeleccionada == null)
                {
                    MessageBox.Show("Por favor, seleccione una impresora para eliminar.");
                    return;
                }

                if (_impresoraBLL.Eliminar(_impresoraSeleccionada))
                {
                    MessageBox.Show("Impresora eliminada exitosamente.");
                    CargarGrillaImpresoras();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la impresora.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAsociarInsumo_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (_insumoSeleccionado == null)
                {
                    MessageBox.Show("Por favor, seleccione un insumo para asociar a la impresora.");
                    return;
                }

                if (insumosAsociados.Any(i => i.Id == _insumoSeleccionado.Id))
                {
                    MessageBox.Show("El insumo seleccionado ya está asociado a la impresora.");
                    return;
                }

                insumosAsociados.Add(_insumoSeleccionado);
                MessageBox.Show("Insumo asociado exitosamente a la impresora."); return;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesInsumo_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvInsumos.Rows.Count == 0) { return; }
                _insumoSeleccionado = dgvInsumos.SelectedRows[0].DataBoundItem as InsumoImpresora;

                if (_insumoSeleccionado == null)
                {
                    MessageBox.Show("Por favor, seleccione un insumo para desasociar de la impresora.");
                    return;
                }
                if (insumosAsociados.Any(ins => ins.Id == _insumoSeleccionado.Id))
                {
                    insumosAsociados.Remove(_insumoSeleccionado);
                    MessageBox.Show("Insumo desasociado exitosamente.");
                }
                else
                {
                    MessageBox.Show("El insumo seleccionado no está asociado a la impresora.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "FUNCIONES DE COMBO BOX"
        private void comboTipoCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_loading) return;

                MetodoCalculoImpresora metodoSeleccionado = (MetodoCalculoImpresora)comboTipoCalculo.SelectedIndex;

                if (metodoSeleccionado == MetodoCalculoImpresora.PerfilDeImpresion)
                {
                    //Si el método seleccionado es por perfil de impresión, se muestran los campos relacionados a los perfiles y se ocultan los campos relacionados al rendimiento
                    panelInsumosAsociadosNew.Enabled = false;
                    panelPerfilesImpNew.Enabled = true;
                }
                else if (metodoSeleccionado == MetodoCalculoImpresora.Rendimiento)
                {
                    // Caso contrario, se muestran los campos relacionados al rendimiento y se ocultan los campos relacionados a los perfiles
                    panelInsumosAsociadosNew.Enabled = true;
                    panelPerfilesImpNew.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "GRILLA INSUMOS"
        private void dgvInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        private void dgvInsumos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _insumoSeleccionado = dgvInsumos.SelectedRows[0].DataBoundItem as InsumoImpresora;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "MODIFICACIÓN DE IMPRESORA"

        #region "GRILLA IMPRESORA"

        private void CargarGrillaImpresoras()
        {
            try
            {
                dgvImpresoras.MultiSelect = false;
                dgvImpresoras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvImpresoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvImpresoras.DataSource = null;
                dgvImpresoras.DataSource = _impresoraBLL.ListarTodo();
                dgvImpresoras.Columns["Id"].Visible = false;
                dgvImpresoras.Columns["Modelo"].HeaderText = "MODELO";
                dgvImpresoras.Columns["Marca"].HeaderText = "MARCA";
                dgvImpresoras.Columns["Nombre"].HeaderText = "NOMBRE";
                dgvImpresoras.Columns["Tecnologia"].HeaderText = "TECNOLOGÍA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvImpresoras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _impresoraSeleccionada = dgvImpresoras.Rows[e.RowIndex].DataBoundItem as Impresora;

                if (_impresoraSeleccionada != null)
                {
                    txtNomModNew.TextButton = _impresoraSeleccionada.Nombre;
                    txtModeloModNew.TextButton = _impresoraSeleccionada.Modelo;
                    txtMarcaModNew.TextButton = _impresoraSeleccionada.Marca;
                    comboTecnoMod.SelectedItem = _impresoraSeleccionada.Tecnologia;
                    comboTipoMod.SelectedItem = _impresoraSeleccionada is ImpresoraPorRendimiento ? MetodoCalculoImpresora.Rendimiento.ToString() : MetodoCalculoImpresora.PerfilDeImpresion.ToString();

                    if (_impresoraSeleccionada is ImpresoraPorRendimiento)
                    {
                        insumosAsociadosMod = (_impresoraSeleccionada as ImpresoraPorRendimiento).InsumosImpresora;
                        panelPerfilesImpModNew.Enabled = false;
                        panelInsumosAsociadosModNew.Enabled = true;

                        txtByNModPrNew.TextButton = "$";
                        txtObraStdModPrNew.TextButton = "$";
                        txtObraAltModPrNew.TextButton = "$";
                        txtMateStdModPrNew.TextButton = "$";
                        txtMateAltModPrNew.TextButton = "$";
                        txtFotStdModPrNew.TextButton = "$";
                        txtFotAModPrNew.TextButton = "$";
                    }
                    else
                    {

                        panelPerfilesImpModNew.Enabled = true;
                        panelInsumosAsociadosModNew.Enabled = false;

                        var preciosPerfiles = (_impresoraSeleccionada as ImpresoraPorCalidad).PerfilesDeImpresion;

                        if (preciosPerfiles.Count > 0)
                        {
                            txtByNModPrNew.TextButton = preciosPerfiles.FirstOrDefault(p => p.Nombre == "BLANCO Y NEGRO").Precio.ToString();
                            txtObraStdModPrNew.TextButton = preciosPerfiles.FirstOrDefault(p => p.Nombre == "OBRA CALIDAD ESTÁNDAR").Precio.ToString();
                            txtObraAltModPrNew.TextButton = preciosPerfiles.FirstOrDefault(p => p.Nombre == "OBRA CALIDAD ALTA").Precio.ToString();
                            txtMateStdModPrNew.TextButton = preciosPerfiles.FirstOrDefault(p => p.Nombre == "MATE CALIDAD ESTÁNDAR").Precio.ToString();
                            txtMateAltModPrNew.TextButton = preciosPerfiles.FirstOrDefault(p => p.Nombre == "MATE CALIDAD ALTA").Precio.ToString();
                            txtFotStdModPrNew.TextButton = preciosPerfiles.FirstOrDefault(p => p.Nombre == "FOTOGRÁFICO CALIDAD ESTÁNDAR").Precio.ToString();
                            txtFotAModPrNew.TextButton = preciosPerfiles.FirstOrDefault(p => p.Nombre == "FOTOGRÁFICO CALIDAD ALTA").Precio.ToString();
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        #region "GRILLA INSUMOS ASOCIADOS"
        private void dgvInsumosMod_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvInsumosMod.SelectedRows.Count > 0)
                {
                    _insumoSeleccionadoMod = dgvInsumosMod.SelectedRows[0].DataBoundItem as InsumoImpresora;
                }

            }
            catch (Exception ex)
            {


            }
        }
        private void CargarGrillaInsumos()
        {
            try
            {
                insumosTotales = _insumoBLL.ListarTodo();
                //Cargamos el datagridview con los insumos disponibles
                dgvInsumos.DataSource = insumosTotales;
                dgvInsumos.Columns["Id"].Visible = false;
                dgvInsumos.Columns["Precio"].Visible = false;
                dgvInsumos.Columns["Rendimiento"].Visible = false;
                dgvInsumos.Columns["EsColor"].Visible = false;
                dgvInsumos.Columns["Nombre"].HeaderText = "NOMBRE";
                dgvInsumos.Columns["Contenido"].HeaderText = "CONTENIDO";
                dgvInsumos.Columns["UnidadContenido"].HeaderText = "UNIDAD CONTENIDO";

                dgvInsumos.Columns["Nombre"].DisplayIndex = 0;
                dgvInsumos.Columns["Contenido"].DisplayIndex = 1;
                dgvInsumos.Columns["UnidadContenido"].DisplayIndex = 2;

                dgvInsumosMod.DataSource = insumosTotales;
                dgvInsumosMod.Columns["Id"].Visible = false;
                dgvInsumosMod.Columns["Precio"].Visible = false;
                dgvInsumosMod.Columns["Rendimiento"].Visible = false;
                dgvInsumosMod.Columns["EsColor"].Visible = false;
                dgvInsumosMod.Columns["Nombre"].HeaderText = "NOMBRE";
                dgvInsumosMod.Columns["Contenido"].HeaderText = "CONTENIDO";
                dgvInsumosMod.Columns["UnidadContenido"].HeaderText = "UNIDAD CONTENIDO";

                dgvInsumosMod.Columns["Nombre"].DisplayIndex = 0;
                dgvInsumosMod.Columns["Contenido"].DisplayIndex = 1;
                dgvInsumosMod.Columns["UnidadContenido"].DisplayIndex = 2;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        #endregion

        #region "BOTONES"

        private void btnAsociarInsMod_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_insumoSeleccionadoMod == null)
                {
                    MessageBox.Show("Por favor, seleccione un insumo para asociar a la impresora.");
                    return;
                }

                if (insumosAsociadosMod.Any(i => i.Id == _insumoSeleccionadoMod.Id))
                {
                    MessageBox.Show("El insumo seleccionado ya está asociado a la impresora.");
                    return;
                }

                insumosAsociados.Add(_insumoSeleccionado);
                MessageBox.Show("Insumo asociado exitosamente a la impresora."); return;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesasociarInsMod_Click(object sender, EventArgs e)
        {
            try
            {

                if (_insumoSeleccionadoMod == null)
                {
                    MessageBox.Show("Por favor, seleccione un insumo para desasociar de la impresora.");
                    return;
                }
                if (insumosAsociadosMod.Any(ins => ins.Id == _insumoSeleccionadoMod.Id))
                {
                    insumosAsociadosMod.Remove(_insumoSeleccionado);
                    MessageBox.Show("Insumo desasociado exitosamente.");
                }
                else
                {
                    MessageBox.Show("El insumo seleccionado no está asociado a la impresora.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarImpresora_Click(object sender, EventArgs e)
        {
            try
            {
                if (_impresoraSeleccionada == null)
                {
                    MessageBox.Show("Por favor, seleccione una impresora para modificar.");
                    return;
                }

                _impresoraSeleccionada.Nombre = txtNomModNew.TextButton;
                _impresoraSeleccionada.Tecnologia = comboTecnoMod.SelectedItem.ToString();
                _impresoraSeleccionada.Marca = txtMarcaModNew.TextButton;
                _impresoraSeleccionada.Modelo = txtModeloModNew.TextButton;


                if (_impresoraBLL.Modificar(_impresoraSeleccionada))
                {
                    MessageBox.Show("Impresora modificada exitosamente.");
                    CargarGrillaImpresoras();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la impresora.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void comboTipoMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) return;

            MetodoCalculoImpresora metodoSeleccionado = (MetodoCalculoImpresora)comboTipoMod.SelectedIndex;

            if (metodoSeleccionado == MetodoCalculoImpresora.PerfilDeImpresion)
            {
                //Si el método seleccionado es por perfil de impresión, se muestran los campos relacionados a los perfiles y se ocultan los campos relacionados al rendimiento
                panelInsumosAsociadosModNew.Enabled = false;
                panelPerfilesImpModNew.Enabled = true;
            }
            else if (metodoSeleccionado == MetodoCalculoImpresora.Rendimiento)
            {
                // Caso contrario, se muestran los campos relacionados al rendimiento y se ocultan los campos relacionados a los perfiles
                panelInsumosAsociadosModNew.Enabled = true;
                panelPerfilesImpModNew.Enabled = false;
            }

        }

        #endregion
        private void cargarPerfilesDeImpresion()
        {
            try
            {

                PerfilImpresion perfilByN = new PerfilImpresion();

                perfilByN.Nombre = "BLANCO Y NEGRO";
                perfilByN.Precio = 0;
                perfilByN.FactorMultiplicador = 2;
                perfilByN.EsColor = false;

                PerfilImpresion perfilObraEstandar = new PerfilImpresion();

                perfilObraEstandar.Nombre = "OBRA CALIDAD ESTÁNDAR";
                perfilObraEstandar.Precio = 0;
                perfilObraEstandar.FactorMultiplicador = 3;
                perfilObraEstandar.EsColor = true;

                PerfilImpresion perfilObraAlta = new PerfilImpresion();

                perfilObraAlta.Nombre = "OBRA CALIDAD ALTA";
                perfilObraAlta.Precio = 0;
                perfilObraAlta.FactorMultiplicador = 3.5m;
                perfilObraAlta.EsColor = true;

                PerfilImpresion perfilMateEstandar = new PerfilImpresion();

                perfilMateEstandar.Nombre = "MATE CALIDAD ESTÁNDAR";
                perfilMateEstandar.Precio = 0;
                perfilMateEstandar.FactorMultiplicador = 5;
                perfilMateEstandar.EsColor = true;

                PerfilImpresion perfilMateAlta = new PerfilImpresion();

                perfilMateAlta.Nombre = "MATE CALIDAD ALTA";
                perfilMateAlta.Precio = 0;
                perfilMateAlta.FactorMultiplicador = 5.5m;
                perfilMateAlta.EsColor = true;

                PerfilImpresion perfilFotograficoEstandar = new PerfilImpresion();

                perfilFotograficoEstandar.Nombre = "FOTOGRÁFICO CALIDAD ESTÁNDAR";
                perfilFotograficoEstandar.Precio = 0;
                perfilFotograficoEstandar.FactorMultiplicador = 10m;
                perfilFotograficoEstandar.EsColor = true;

                PerfilImpresion perfilFotograficoAlta = new PerfilImpresion();

                perfilFotograficoAlta.Nombre = "FOTOGRÁFICO CALIDAD ALTA";
                perfilFotograficoAlta.Precio = 0;
                perfilFotograficoAlta.FactorMultiplicador = 15m;
                perfilFotograficoAlta.EsColor = true;

                //Seteamos los ID's de forma temporal ya que el ID real se lo dará la capa DAL
                perfilByN.Id = 1;
                perfilObraEstandar.Id = 2;
                perfilObraAlta.Id = 3;
                perfilMateEstandar.Id = 4;
                perfilMateAlta.Id = 5;
                perfilFotograficoEstandar.Id = 6;
                perfilFotograficoAlta.Id = 7;

                perfilesImpresion.Add(perfilByN);
                perfilesImpresion.Add(perfilObraEstandar);
                perfilesImpresion.Add(perfilObraAlta);
                perfilesImpresion.Add(perfilMateEstandar);
                perfilesImpresion.Add(perfilMateAlta);
                perfilesImpresion.Add(perfilFotograficoEstandar);
                perfilesImpresion.Add(perfilFotograficoAlta);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void actualizarPerfilesDeImpresion()
        {
            try
            {
                foreach (PerfilImpresion perfil in perfilesImpresion)
                {
                    switch (perfil.Id)
                    {
                        case 1:
                            perfil.Precio = decimal.Parse(txtPrecioByNNew.TextButton);
                            break;
                        case 2:
                            perfil.Precio = decimal.Parse(txtPrecioObraStdNew.TextButton);
                            break;
                        case 3:
                            perfil.Precio = decimal.Parse(txtPrecioObraAltaNew.TextButton);
                            break;
                        case 4:
                            perfil.Precio = decimal.Parse(txtPrecioMateStdNew.TextButton);
                            break;
                        case 5:
                            perfil.Precio = decimal.Parse(txtPrecioMateAltaNew.TextButton);
                            break;
                        case 6:
                            perfil.Precio = decimal.Parse(txtPrecioFotoStdNew.TextButton);
                            break;
                        case 7:
                            perfil.Precio = decimal.Parse(txtPrecioFotAltaNew.TextButton);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #region "FUNCIONES NO UTILIZADAS"
        private void dgvImpresoras_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void dgvInsumosMod_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelCarga_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BtnDesasociar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAsociarInsMod_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDesInsumoMod_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void panelCargaImpresora_Paint(object sender, PaintEventArgs e)
        { }

        private void btnAsociarInsumo_Click(object sender, EventArgs e)
        {

        }

        private void btnDesInsumo_Click(object sender, EventArgs e)
        {

        }
        private void btnCargarImpresora_Click_1(object sender, EventArgs e)
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnAsociar_Click(object sender, EventArgs e)
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion





   
    }
}