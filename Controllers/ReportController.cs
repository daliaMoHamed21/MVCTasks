using MVCTasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTasks.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            List<ReportData> reportData = new List<ReportData>
            {
                 new ReportData { Id = 1, Name = "Dalia Mohamed", Email = "daliam655@gmail.com" },
                 new ReportData { Id = 2, Name = "Basma Mohamed", Email = "basmam429@gmail.com" },
                 new ReportData { Id = 3, Name = "Aya Mohamed", Email = "ayam521@gmail.com" },
                 new ReportData { Id = 4, Name = "Omnia Mohamed", Email = "omniam212@gmail.com" },
                 new ReportData { Id = 5, Name = "Lina Mohamed", Email = "linam123@gmail.com" },
                 new ReportData { Id = 6, Name = "Mahy Mohamed", Email = "mahym321@gmail.com" },
                  new ReportData { Id = 7, Name = "Ahmed Mohamed", Email = "ahmedm791@gmail.com" },
                 new ReportData { Id = 8, Name = "Mostafa Taher", Email = "mostafa421@gmail.com" },
                 new ReportData { Id = 9, Name = "Rodayna Yasser", Email = "rodayna@gmail.com" },
                 new ReportData { Id = 10, Name = "abeer Ahmed", Email = "abeer@gmail.com" },
                 new ReportData { Id = 11, Name = "Mohamed Ahmed", Email = "mohamed@gmail.com" },
                 new ReportData { Id = 12, Name = "Mahmoud Ali", Email = "mahmoud@gmail.com" },

            };

            return View(reportData);
        }
    }
}