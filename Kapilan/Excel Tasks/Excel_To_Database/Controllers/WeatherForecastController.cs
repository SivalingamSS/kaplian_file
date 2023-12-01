using IronXL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using OfficeOpenXml;
using Operation1.DBContact;
using Operation1.Model;
using System.Data;

namespace Operation1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ContactsAPIDbContext _contactsAPIDbContext;

        public WeatherForecastController(ContactsAPIDbContext contactsAPIDbContext)
        {
            _contactsAPIDbContext = contactsAPIDbContext;
        }

        [HttpPost("Excel")]
        public async Task<IActionResult> AddExcel(Excel addContactRequest)
        {
            List<object> list = new List<object>();
            WorkBook workbook = WorkBook.Load(@"C:\Kapilan\Excel Tasks\Excel_To_Database\ExcelData.xlsx");
            WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
            var range = sheet["A1:D5"];
            DataTable dt = range.ToDataTable(true);
            List<Excel> custlist = (from DataRow dr in dt.Rows
                                    select new Excel()
                                    {
                                        CustomerID = Convert.ToInt32(dr["CustomerID"]),
                                        FirstName = dr["FirstName"].ToString(),
                                        LastName = dr["LastName"].ToString(),
                                        Address = dr["Address"].ToString(),
                                    }).ToList();
            foreach (var name in custlist)
            {
                await _contactsAPIDbContext.Persons.AddAsync(name);
            }

            await _contactsAPIDbContext.SaveChangesAsync();
            return Ok(custlist);
        }
    }
}
