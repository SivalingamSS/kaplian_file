using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Office.Interop.Excel;
using Microsoft.PowerBI.Api.Models;
using OfficeOpenXml;
using System.Data;
using Workbook = DocumentFormat.OpenXml.Spreadsheet.Workbook;

namespace Excel_To_Db_NaveenNaTasks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public WeatherForecastController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet("Excel")]
        public async Task<IActionResult> Excels()
        {
            List<object> list = new List<object>();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(@"C:\Kapilan\Contract_Attr.xlsx")))
            {
                List<string> distinctValues = new List<string>();

                ExcelWorksheet worksheet1 = package.Workbook.Worksheets[0];
                int rowCount = worksheet1.Dimension.End.Row;
                int colcount = worksheet1.Dimension.End.Column;
                var startCell = worksheet1.Cells["A1"];
                var endCell = worksheet1.Cells["D987"];
                var range = worksheet1.Cells[startCell.Start.Row, startCell.Start.Column, endCell.End.Row, endCell.End.Column];
                var rowCount1 = range.End.Row;
                string columnName = "ContractDetailId";
                var dict = new Dictionary<object,object>();

                int columnIndex = -1;

                for (int col = 1; col <= colcount; col++)
                {
                    if (worksheet1.Cells[1, col].Value.ToString() == columnName)
                    {
                        columnIndex = col;
                        break;
                    }
                }

                if (columnIndex == -1)
                {
                    return null;
                }

                for (int row = 2; row <= rowCount; row++)
                {
                    string cellValue = worksheet1.Cells[row, columnIndex].Value?.ToString();

                    if (!string.IsNullOrEmpty(cellValue) && !distinctValues.Contains(cellValue))
                    {
                        if(cellValue != null)
                        {
                            distinctValues.Add(cellValue);
                        }
                    }
                }
                return null;
            }
        }
    }
}