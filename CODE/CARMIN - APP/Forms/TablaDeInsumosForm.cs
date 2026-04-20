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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CARMIN___APP.Forms
{
    public partial class TablaDeInsumosForm : Form
    {
        private InsumoBLL insumoBLL;
        private Insumo insumoBE;
        private ItemPresupuesto itemPresupuestoBE;

        //Insumos existentes en la BD
        private List<Insumo> listaInsumos;

        //Insumos seleccionados por el usuario para agregar al presupuesto. Esta lista se va a ir llenando a medida que el usuario vaya seleccionando insumos de la grilla.
        //Se representan como items presupuesto para adecuarse al data grid del presupuestador
        private List<ItemPresupuesto> listaItemsElegidos;
        public TablaDeInsumosForm(List<ItemPresupuesto> itemsSeleccionado)
        {
            try
            {
                InitializeComponent();

                insumoBLL = new InsumoBLL();
                insumoBE = new Insumo();

                itemPresupuestoBE = new ItemPresupuesto();

                listaItemsElegidos = new List<ItemPresupuesto>();

                if (itemsSeleccionado != null && itemsSeleccionado.Count > 0) { listaItemsElegidos = itemsSeleccionado; }
                ;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void TablaDeInsumosForm_Load(object sender, EventArgs e)
        {
            try
            {

                //Inicializamos componentes

                txtFiltro.BackColor = Color.FromArgb(149, 187, 234);

                logoBox.Image = Image.FromFile(ConfigHelper.Configuration["Rutas:Flecha"] + "\\flecha-02.png");
                logoBox.SizeMode = PictureBoxSizeMode.Zoom;

                dgvInsumos.DataSource = null;
                // dgvInsumos.DataSource = insumoBLL.ListarTodo();

                //Hardcodeamos algunos insumos para mostrar en el DataGridView
                listaInsumos = new List<Insumo>();


                listaInsumos.Add(new Insumo
                {
                    Id = 1,
                    Nombre = "Papel fotografico",
                    Cantidad = 10,
                    UnidadMedida = "hojas",
                    CostoInsumo = 100,
                    Stock = 50
                });
                listaInsumos.Add(
             new Insumo
             {
                 Id = 2,
                 Nombre = "Papel fotografico adhesivo",
                 Cantidad = 10,
                 UnidadMedida = "hojas",
                 CostoInsumo = 200,
                 Stock = 50
             });
                listaInsumos.Add(
                    new Insumo
                    {
                        Id = 3,
                        Nombre = "Anillos doble alambre",
                        Cantidad = 30,
                        UnidadMedida = "unidades",
                        CostoInsumo = 300,
                        Stock = 50
                    });
                listaInsumos.Add(
                   new Insumo
                   {
                       Id = 4,
                       Nombre = "Matelina",
                       Cantidad = 10,
                       UnidadMedida = "hojas",
                       CostoInsumo = 400,
                       Stock = 50
                   }
                );

                CargarGrilla(listaInsumos);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void CargarGrilla(List<Insumo> insumosGrilla)
        {
            try
            {
                dgvInsumos.DataSource = null;
                dgvInsumos.DataSource = insumosGrilla;
                dgvInsumos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvInsumos_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                insumoBE = dgvInsumos.SelectedRows[0].DataBoundItem as Insumo;
                //Convertimos el insumo seleccionado a item presupuesto para agregarlo a la lista de items elegidos para el presupuestador
                if (ConvertirInsumoAItemsPresupuesto(insumoBE))
                {
                    this.Close();
                    // Abrimos el formulario de presupuestador y le pasamos la lista de items del presupuesto
                    Form Presupuestador = new PresupuestadorForm(listaItemsElegidos);
                    Presupuestador.Show();
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

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.ToLower();
                var insumosFiltrados = listaInsumos.Where(i => i.Nombre.ToLower().Contains(filtro)).ToList();
                CargarGrilla(insumosFiltrados);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool ConvertirInsumoAItemsPresupuesto(Insumo insumoElegido)
        {
            //A partir del insumo elegido por el usuario, creamos un item presupuesto con la información relevante (nombre, precio unitario, etc) y lo agregamos a la lista de items elegidos para el presupuestador
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
                listaItemsElegidos.Add(item);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir insumos a items de presupuesto: " + ex.Message);
                return false;
            }
        }
        #region "Funciones no utilizadas"

        private void dgvInsumos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        #endregion

        private void logoBox_Click(object sender, EventArgs e)
        {
            try
            {    
              this.Close();
              //Abrimos el formulario de presupuestador y le pasamos la lista de items del presupuesto
              Form Presupuestador = new PresupuestadorForm(listaItemsElegidos);
              Presupuestador.Show();
             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
