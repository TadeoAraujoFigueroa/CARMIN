using CARMIN___BE.Entities;
using CARMIN___BLL;
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
    public partial class PresupuestadorForm : Form
    {

        private List<ItemPresupuesto> itemsPresupuesto;


        //El form del presupuestador labura con una lista de insumos equivalentes a los insumos seleccionados en la tabla de insumos.
        //Internamente, convierte esa lista de insumos en una lista de items presupuesto, que es la que se muestra en la grilla del form.
        public PresupuestadorForm(List<ItemPresupuesto> itemsExt)
        {
            try
            {
                InitializeComponent();

                //Inicializamos la lista de insumos
                itemsPresupuesto = new List<ItemPresupuesto>();
                itemsPresupuesto = itemsExt;

                //Actualizamos la grilla con los datos recibidos
                if (itemsExt != null && itemsExt.Count > 0) { CargarGrilla(); }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void PresupuestadorForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Configuración de los botones
                btnAg.Text = "AGREGAR INSUMO";
                btnElim.Text = "ELIMINAR INSUMO";
                btnGuardar.Text = "GUARDAR";
                btnGenerarPDF.Text = "GENERAR PDF";
                //Configuración del picture box
                logoBox.Image = Image.FromFile(ConfigHelper.Configuration["Rutas:Flecha"] + "\\flecha-02.png");
                logoBox.SizeMode = PictureBoxSizeMode.Zoom;


                //Suscribimos al evento TextChanged de los TextBox para recalcular los costos cada vez que el usuario modifique alguno de los campos relacionados con los costos.
                txtMerma.TextChanged += (s, ev) => CalcularCostos();
                txtMaquinaria.TextChanged += (s, ev) => CalcularCostos();
                txtDescuento.TextChanged += (s, ev) => CalcularCostos();
                txtGanancia.TextChanged += (s, ev) => CalcularCostos();

                //Este laburo lo realizará el BLL de presupuestos, pero por ahora lo dejo acá para que se vea el flujo completo.
                if (itemsPresupuesto != null && itemsPresupuesto.Count > 0)
                {
                    CalcularCostos();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CalcularCostos()
        {
            try
            {
                float contador_costos = 0;
                float costoTotal = 0;

                foreach (var item in itemsPresupuesto)
                {
                    contador_costos += (float)(item.Costo);
                }

                txtCostoTotal.Text = contador_costos.ToString("C2"); // Formateamos el costo total como moneda

                if (txtMerma.Text != "" && txtMaquinaria.Text != "")
                {
                    float merma = float.Parse(txtMerma.Text) / 100;
                    float maquinaria = float.Parse(txtMaquinaria.Text) / 100;
                    costoTotal = contador_costos + (contador_costos * merma) + (contador_costos * maquinaria);
                    txtSubtotalTec.Text = costoTotal.ToString("C2");
                }
                if (txtDescuento.Text != "" && txtGanancia.Text != "")
                {
                    float descuento = float.Parse(txtDescuento.Text) / 100;
                    float ganancia = float.Parse(txtGanancia.Text) / 100;
                    float total = costoTotal - (costoTotal * descuento) + (costoTotal * ganancia);
                    txtTotalFinal.Text = total.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular costos: " + ex.Message);
            }
        }
        private void CargarGrilla()
        {
            try
            {
                dgvPresupuesto.DataSource = null;
                dgvPresupuesto.DataSource = itemsPresupuesto;
                dgvPresupuesto.Columns["Id"].Visible = false; // Ocultamos la columna Id, ya que no es relevante para el usuario
                CalcularCostos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla: " + ex.Message);
            }
        }



        private void btnAg_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Form tablaDeInsumos = new TablaDeInsumosForm(itemsPresupuesto);
                tablaDeInsumos.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #region "FUNCIÓN NO UTILIZADA"

        private void bigLabel4_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void dgvPresupuesto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
                Form main_form = new MainForm();
                this.Close();
                main_form.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
