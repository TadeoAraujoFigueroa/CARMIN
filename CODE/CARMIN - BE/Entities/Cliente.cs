namespace CARMIN___BE.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string? Telefono { get; set; }

        public string? Direccion { get; set; }

    }
}
