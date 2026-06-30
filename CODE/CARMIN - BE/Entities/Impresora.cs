namespace CARMIN___BE.Entities
{
    public abstract class Impresora
    {
        public int Id { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Tecnologia { get; set; } = string.Empty;

        public List<PerfilImpresion> PerfilesDeImpresion { get; set; } = new();

        public abstract decimal CalcularCosto(int cantidadHojas, PerfilImpresion perfil);
    }

    public class ImpresoraPorRendimiento : Impresora
    {
        public List<InsumoImpresora> InsumosImpresora { get; set; } = new();

        public override decimal CalcularCosto(int cantidadHojas, PerfilImpresion perfil)
        {
            decimal costo = 0m;

            if (perfil.EsColor)
            {
                costo += InsumosImpresora.Sum(i => (i.Precio / i.Rendimiento) * cantidadHojas);
            }
            else
            {
                var insumosBlancoYNegro = InsumosImpresora.Where(i => !i.EsColor);
                costo += insumosBlancoYNegro.Sum(i => (i.Precio / i.Rendimiento) * cantidadHojas);
            }

            return costo * perfil.FactorMultiplicador;
        }
    }

    public class ImpresoraPorCalidad : Impresora
    {
        public override decimal CalcularCosto(int cantidadHojas, PerfilImpresion perfil)
        {
            return perfil.Precio * cantidadHojas;
        }
    }
}
