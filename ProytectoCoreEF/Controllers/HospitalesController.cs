using Microsoft.AspNetCore.Mvc;
using ProytectoCoreEF.Models;
using ProytectoCoreEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProytectoCoreEF.Controllers
{
    public class HospitalesController : Controller
    {
        private RepositoryHospital repo;

        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            return View(hospitales);
        }
        public IActionResult Details(int idhospital)
        {
            Hospital hospital = this.repo.FindHOspital(idhospital);
            return View(hospital);
        }
    }
}
