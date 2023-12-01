using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System.Linq;
using static filter_data.Model.Enroll;

namespace filter_data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Enroll")]
        public object get1(string? connum)
        {
            var emp = System.IO.File.ReadAllText(@"C:\Kapilan\Dharun Json Task\filter data\Enrollment.json");
            List<Root> roots = JsonConvert.DeserializeObject<List<Root>>(emp);
            List<total> data = new List<total>();
            var toll = roots.Where(r => r.ConfirmationNumber == connum).Select(r => new total
            {
                ConfirmatNumber = r.ConfirmationNumber,
                ComName = r.EnrollmentCustomer.CompanyName,
                DOB = r.EnrollmentCustomer.BirthDate,
                PaymentCode = r.EnrollmentCustomer.PaymentCategoryCode,
                UtilityActNum = r.EnrollmentCustomer.ServiceAccount.Select(s => s.UtilityAccountNumber).FirstOrDefault(),
                ContractSignDate = r.EnrollmentCustomer.ServiceAccount.Select(s => s.ContractSignedDate).FirstOrDefault(),
                DivCode = r.DivisionCode,
                CreDate = r.EnrollmentCustomer.CreateDate
            }).ToList();
            return toll;
        }
        [HttpGet("Enroll2")]
        public object? GetProjects(string? connum)
        {
            var emp1 = System.IO.File.ReadAllText(@"C:\Kapilan\Dharun Json Task\filter data\Enrollment.json");
            List<Root> roots1 = JsonConvert.DeserializeObject<List<Root>>(emp1);
            List<Roll> data1 = new List<Roll>();
            var toll1 = roots1.Where(r => r.ConfirmationNumber == connum).Select(r => new Roll
            {
                ConfirmatNumber = r.ConfirmationNumber,
                ComName = r.EnrollmentCustomer.CompanyName,
                DOB = r.EnrollmentCustomer.BirthDate,
                PaymentCode = r.EnrollmentCustomer.PaymentCategoryCode,
                DivCode = r.DivisionCode,
                CreDate = r.EnrollmentCustomer.CreateDate
            }).ToList();
            return toll1;
        }
        [HttpGet("Pagination")]
        public async Task<IActionResult> GetProjects(int? pageSize=1)
        {
            var employee = System.IO.File.ReadAllText(@"C:\Kapilan\Dharun Json Task\filter data\Enrollment.json");
            List<Root> Arrange =JsonConvert.DeserializeObject<List<Root>>(employee);
            int pageIndex = 1;
            var paginatedProducts =Arrange.Skip((int)(pageSize - 1)).Take(pageIndex).ToList();
            return Ok(paginatedProducts);
        }
    }
}