using ProytectoCoreEF.Data;
using ProytectoCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProytectoCoreEF.Repositories
{
    public class RepositoryDoctores
    {
        private HospitalContext context;

        public RepositoryDoctores(HospitalContext context)
        {
            this.context = context;
        }

        public List<Doctor> GetDoctoresHospital(int idhospital)
        {
            var consulta = from datos in this.context.Doctores
                           where datos.IdHospital == idhospital
                           select datos;
            return consulta.ToList();
        }
        public Doctor FindDoctor(int id)
        {
            var consulta = from datos in this.context.Doctores
                           where datos.IdDoctor == id
                           select datos;
            return consulta.FirstOrDefault();
        }
    }
}
