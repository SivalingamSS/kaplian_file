using Bytescout.Spreadsheet;
using createexcel.Modal;
using Microsoft.AspNetCore.Mvc;
using Worksheet = Bytescout.Spreadsheet.Worksheet;

namespace createexcel.Controllers
{
    /*    public class HomeController : ControllerBase
        {
            [HttpGet("ExcelNumberFormat")]
            public void Exceldata()
            {
                Spreadsheet Document = new Spreadsheet();
                Worksheet str = Document.Workbook.Worksheets.Add("writeexceldemo");
                str.Cell("A1").Value = "ID";
                str.Cell("A2").Value = "20UCS018";
                str.Cell("B1").Value = "Name";
                str.Cell("B2").Value = "KAPILAN";
                str.Cell("C1").Value = "Age";
                str.Cell("C2").Value = 20;
                str.Cell("D1").Value = "Department";
                str.Cell("D2").Value = "COMPUTER SCIENCE";
                str.Cell("E1").Value = "City";
                str.Cell("E2").Value = "NAMAKKAL";

                while (System.IO.File.Exists(@"C:\Users\visualapp\Desktop\CreateNew.xlsx")) ;
                {
                    System.IO.File.Delete(@"C:\Users\visualapp\Desktop\CreateNew.xlsx");
                }
                Document.SaveAs(@"C:\Users\visualapp\Desktop\CreateNew.xlsx");
                Document.Close();
            }
        }
    }*/

    public class ExcelController : ControllerBase
    {
        [HttpGet("ExcelData")]
        public void Exceldata()
        {
            List<ProductModal> GetProductList()
            {
                List<ProductModal> products = new List<ProductModal>();
                {
                    new ProductModal { id = 1, Name = "Thiyaku", Age = 20, Department = "Chemistry" };
                    new ProductModal { id = 2, Name = "Elavarasan", Age = 21, Department = "Chemistry" };
                    new ProductModal { id = 3, Name = "Vignesh", Age = 22, Department = "Chemistry" };

                };
                return products;
            }
        }
    }
}