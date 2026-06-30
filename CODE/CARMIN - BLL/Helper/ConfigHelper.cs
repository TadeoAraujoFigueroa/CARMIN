using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CARMIN___BLL.Helper
{
    public static class ConfigHelper
    {
        public static IConfiguration Configuration { get; set; }

        static ConfigHelper()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public static string GetRuta(string clave, params string[] segmentos)
        {
            var rutaConfigurada = Configuration[$"Rutas:{clave}"];

            if (string.IsNullOrWhiteSpace(rutaConfigurada))
            {
                throw new InvalidOperationException(
                    $"No se encontro la ruta 'Rutas:{clave}' en appsettings.json.");
            }

            var rutaBase = Path.IsPathRooted(rutaConfigurada)
                ? rutaConfigurada
                : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaConfigurada);

            return Path.GetFullPath(Path.Combine([rutaBase, .. segmentos]));
        }

    }
}
