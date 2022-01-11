using Microsoft.AspNetCore.Mvc;
using ProytectoCoreEF.Models;
using ProytectoCoreEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProytectoCoreEF.Controllers
{
    public class DoctoresController : Controller
    {
        private RepositoryDoctores repo;
        public DoctoresController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DoctoresHospital(int idhospital)
        {
            List<Doctor> doctores = this.repo.GetDoctoresHospital(idhospital);
            return View(doctores);
        }
        public IActionResult DetailsDoctor(int iddoctor)
        {
            Doctor doctor = this.repo.FindDoctor(iddoctor);
            return View(doctor);
        }
    }
}
