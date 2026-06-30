using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BLL.Services
{
    public class PerfilesImpresionBLL
    {
        private readonly IRepository<PerfilImpresion> repository;

        public PerfilesImpresionBLL(IRepository<PerfilImpresion>? repository = null)
        {
            this.repository = repository ?? new PerfilImpresionRepository();
        }

        public int ObtenerUltimoId() => repository.ObtenerUltimoId();   

    }
}
