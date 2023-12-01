using Microsoft.AspNetCore.Mvc;
using Overlap_Interval.DB;
using Overlap_Interval.Modal;

namespace Overlap_Interval.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly DBClass _dbclass;
        public HomeController(DBClass dbclass)
        {
            _dbclass = dbclass;
        }
        [HttpPost("Date")]
        public DateTime AddEmployees(TableModal mod)
        {
            var data = _dbclass.Overlapinterval.ToList();
            bool get = false;
            foreach (var item in data)
            {
                if (mod.StartDate < item.EndDate && item.StartDate < mod.EndDate)
                {
                    get = true;
                    break;
                }
                if(!get)
                {
                    _dbclass.Overlapinterval.Add(mod);
                    _dbclass.SaveChanges();
                }
            }
            return mod.StartDate;
        }
        [HttpPost("Date2")]
        public DateTime Date2(Modalclass Reg)
        {
            TableModal EL = new TableModal();
            EL.StartDate = Reg.startDate;
            EL.EndDate = Reg.endDate;
            if (Reg.startDate != Reg.endDate)
            {
                _dbclass.Overlapinterval.Add(EL);
                _dbclass.SaveChanges();
            }
            return EL.EndDate;
        }
    }
}
