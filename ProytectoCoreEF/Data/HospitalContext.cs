using Microsoft.EntityFrameworkCore;
using ProytectoCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProytectoCoreEF.Data
{
    public class HospitalContext: DbContext
    {
        //Constructor obligatorio para poder recibir cadena de conexion
        public HospitalContext(DbContextOptions options) : base(options) { }

        //mapeo de las clases de ddbb
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
    }
}
