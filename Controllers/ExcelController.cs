using MVCTasks.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTasks.Controllers
{
    public class ExcelController : Controller
    {
        // GET: Excel
        public ActionResult Index()
        {
            return View();
        }

        //POST :Excel

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if (fileExtension == ".xls" || fileExtension == ".xlsx" || fileExtension == ".xlsb" || fileExtension == ".xlsm")
                {
                    List<ExcelData> excelDataList = new List<ExcelData>();

                    using (var package = new ExcelPackage(file.InputStream))
                    {
                        var worksheet = package.Workbook.Worksheets[0];
                        var rowCount = worksheet.Dimension.Rows;

                        for (int row = 2; row <= rowCount; row++)
                        {
                            int id;
                            if (int.TryParse(worksheet.Cells[row, 1].Text, out id))
                            {
                                excelDataList.Add(new ExcelData
                                {
                                    Id = id,
                                    Name = worksheet.Cells[row, 2].Text,
                                    Email = worksheet.Cells[row, 3].Text
                                });
                            }
                            else
                            {
                                ViewBag.Error = $"Invalid data in row {row}";

                                return View("Index");
                            }
                        }
                    }

                    return View("Index", excelDataList);
                }
                else
                {
                    ViewBag.Error = "Invalid file format . Upload an Excel file,Please.";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.Error = "Please upload Excel file.";
                return View("Index");
            }
        }
    }
}