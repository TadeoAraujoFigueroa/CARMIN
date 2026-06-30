using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___DAL.Repositories
{
    public class PerfilImpresionRepository : IRepository<PerfilImpresion>
    {

        private readonly SqliteConnectionFactory connectionFactory;

        public PerfilImpresionRepository(SqliteConnectionFactory? sqliteConnectionFactory = null)
        {
            connectionFactory = sqliteConnectionFactory ?? new SqliteConnectionFactory();
        }
        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Guardar(PerfilImpresion entity)
        {
            throw new NotImplementedException();
        }

        public List<PerfilImpresion> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(PerfilImpresion entity)
        {
            throw new NotImplementedException();
        }

        public PerfilImpresion? ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM PerfilesImpresion;", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

    }
}

