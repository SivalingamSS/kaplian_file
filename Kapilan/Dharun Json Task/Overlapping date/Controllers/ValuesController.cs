using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Overlapping_date.Model;
using static Overlapping_date.Dbcontext.Dbcon;

[ApiController]
[Route("[controller]")]
public class DateRangeService
{
    private readonly ApplicationDbContext _context;

    public DateRangeService(ApplicationDbContext context)
    {
        _context = context;
    }
    [HttpPost("Date")]
    public bool AreDatesOverlapping(DateTime firstDate, DateTime secondDate)
    {
        return _context.DateRanges.Any(dr =>
            firstDate <= dr.SecondDate && secondDate >= dr.FirstDate);
    }

    [HttpPost("time")]

    public object AddDateRange(DateRange dateRange)
    {
        if (!AreDatesOverlapping(dateRange.FirstDate, dateRange.SecondDate))
        {
            _context.DateRanges.Add(dateRange);
            _context.SaveChanges();  
        }
        return dateRange;
    }
}
