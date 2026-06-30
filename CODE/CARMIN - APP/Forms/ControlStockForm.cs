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
    public partial class ControlStockForm : Form
    {
        private InsumoBLL _insumoBLL;
        private Insumo _insumo;
        private List<Insumo> insumos = new List<Insumo>();
        private bool _loading = true;

        public ControlStockForm()
        {
            InitializeComponent();
            _insumoBLL = new InsumoBLL();

        }
        private void ControlStockForm_Load(object sender, EventArgs e)
        {
            try
            {

                logoBox.Image = Image.FromFile(ConfigHelper.GetRuta("Flecha", "flecha-02.png"));
                logoBox.SizeMode = PictureBoxSizeMode.Zoom;

                //Botones
                btnBitacoraNew.Click += btnBitacora_Click_1;
                btnConfirmarNew.Click += btnConfirmar_Click_1;

                insumos = _insumoBLL.ListarTodo();
                CargarGrilla(insumos);

                switchInsumoMod.SwitchStateChanged += switchInsumoMod_SwitchStateChanged;
                switchInsumoMod.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;
                _loading = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void ControlStockForm_Shown(object sender, EventArgs e)
        {
            this.SuspendLayout();
            try
            {
                AjustarLayout();
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

                subMainPanel.Size = new Size(mainPanelNew.Width - 50, mainPanelNew.Height - 50);
                subMainPanel.Location = new Point((int)(mainPanelNew.Width - subMainPanel.Width) / 2, (int)(mainPanelNew.Height - subMainPanel.Height) / 2);

                logoBox.Location = new Point(
               mainPanelNew.Width - logoBox.Width - 20,
               20);

                mainPanelNew.Region = new Region(RoundedPanelHelper.CreateRoundedPath(mainPanelNew.ClientRectangle, 30));
                panelInsumoSeleccionadoNew.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelInsumoSeleccionadoNew.ClientRectangle, 30));
                dgvInsumos.Region = new Region(RoundedPanelHelper.CreateRoundedPath(dgvInsumos.ClientRectangle, 30));
                panelDgvInsumos.Region = new Region(RoundedPanelHelper.CreateRoundedPath(panelDgvInsumos.ClientRectangle, 30));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarGrilla(List<Insumo> listaActualizada)
        {
            try
            {
                dgvInsumos.DataSource = null;
                dgvInsumos.DataSource = listaActualizada;
                dgvInsumos.Columns["Id"].Visible = false;
                dgvInsumos.Columns["Cantidad"].HeaderText = "CANTIDAD";
                dgvInsumos.Columns["UnidadMedida"].HeaderText = "UNIDAD DE MEDIDA";
                dgvInsumos.Columns["CostoInsumo"].Visible = false;
                dgvInsumos.Columns["Stock"].HeaderText = "STOCK";
                dgvInsumos.Columns["TipoDeCalculo"].Visible = false;
                dgvInsumos.Columns["PrecioUnitario"].Visible = false;
                dgvInsumos.Columns["Nombre"].HeaderText = "NOMBRE";
                dgvInsumos.Columns["Nombre"].DisplayIndex = 0;
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
                insumos = _insumoBLL.ListarTodo();
                CargarGrilla(insumos);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #region "FUNCIÓN DE BOTONES"
        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_insumo == null)
                {
                    MessageBox.Show("Debe seleccionar un insumo");
                    return;
                }

                _insumo.Stock = int.Parse(txtStockNew.TextButton);

                if (_insumoBLL.Modificar(_insumo))
                {
                    MessageBox.Show($"Stock del insumo {_insumo.Nombre} modificado con éxito");
                    //Una vez realizada la modificación, nos encargamos de actualizar la tabla de insumos para mostrar los cambios 
                    ActualizarGrilla();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnBitacora_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Función en desarrollo");
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


        //Función que filtra la grilla de insumos en función de lo escrito en el text box de búsqueda
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.ToLower();

                var listaActualizada = insumos.Where(i => i.Nombre.ToLower().Contains(filtro)).ToList();

                CargarGrilla(listaActualizada);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Función del switch
        private void switchInsumoMod_SwitchStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (_loading) return;
                if (switchInsumoMod.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.On)
                {
                    txtFiltro.Text = "";
                    var listaFiltrada = insumos.Where(i => i.Stock <= 10).ToList();
                    CargarGrilla(listaFiltrada);
                }
                else
                {
                    txtFiltro.Text = "";
                    var listaFiltrada = insumos;
                    CargarGrilla(listaFiltrada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvInsumos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvInsumos.SelectedRows.Count > 0)
                {
                    _insumo = dgvInsumos.SelectedRows[0].DataBoundItem as Insumo;

                    if (_insumo != null)
                    {
                        txtNomNew.TextButton = _insumo.Nombre;
                        txtStockNew.TextButton = _insumo.Stock.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        #region "FUNCIONES NO UTILIZADAS"
        private void dgvInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvInsumos.SelectedRows.Count > 0)
                {
                    _insumo = dgvInsumos.SelectedRows[0].DataBoundItem as Insumo;

                    if (_insumo != null)
                    {
                        txtNomNew.TextButton = _insumo.Nombre;
                        txtStockNew.TextButton = _insumo.Stock.ToString();
                    }
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

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            try
            {
                //Lógica de la bitácoras
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                //Lógica de la actualización
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

    
    }
}
