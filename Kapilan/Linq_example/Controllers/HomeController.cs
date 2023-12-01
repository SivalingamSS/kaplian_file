using Linq_example.Modal;
using Microsoft.AspNetCore.Mvc;

namespace Linq_example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("Union")]
        public IActionResult Union()
        {
            var District = new List<string>() { "Salem", "Namakkal", "Erode", "Attur" };
            var District1 = new List<string>() { "Coimbatore", "Trichy", "Karur", "Salem" };
            List<string> list = new List<string>();

            //Query Syntax
            var MS = District.Union(District1);

            foreach (var item in MS)
            {
                list.Add(item);
            }
            return Ok(list);
        }
        [HttpGet("UnionAll")]
        public IActionResult UnionAll()
        {
            var District = new List<string>() { "Attur", "Cuddalore", "Dindugal", "Erode" };
            var District1 = new List<string>() { "Karur", "Madurai", "Namakkal", "Salem" };
            List<string> list = new List<string>();

            //Method Syntax
            var MS = (from num in District select num).Concat(District1);

            foreach (var item in MS)
            {
                list.Add(item);
            }
            return Ok(list);
        }
        [HttpGet("Intersect")]
        public IActionResult Intersect()
        {
            var District = new List<string>() { "Attur", "Cuddalore", "Dindugal", "Karur" };
            var District1 = new List<string>() { "Karur", "Madurai", "Namakkal", "Attur" };
            List<string> list = new List<string>();

            //Query Syntax
            var MS = District.Intersect(District1);

            foreach (var item in MS)
            {
                list.Add(item);
            }
            return Ok(list);
        }
        [HttpGet("JoinsAll")]
        public IActionResult JoinsAll()
        {
            List<Employee> employees = new List<Employee>
                {
                   new Employee { EmployeeId = 1, Name = "Alice" },
                   new Employee { EmployeeId = 2, Name = "Bob" },
                   new Employee { EmployeeId = 3, Name = "Charlie" }
                };
            List<Department> departments = new List<Department>
                {
                   new Department { DepartmentId = 1, DepartmentName = "HR" },
                   new Department { DepartmentId = 2, DepartmentName = "Finance" },
                   new Department { DepartmentId = 3, DepartmentName = "IT" }
                };
            List<string> order = new List<string>();
            var innerJoinQuery = from emp in employees
                                 join dept in departments
                                 on emp.EmployeeId equals dept.DepartmentId
                                 select new
                                 {
                                     emp.Name,
                                     dept.DepartmentName
                                 };
            foreach (var result in innerJoinQuery)
            {
                order.Add(result.Name);
                order.Add(result.DepartmentName);
            }
            return Ok(order);
        }
        [HttpGet("LeftJoin")]
        public IActionResult LeftJoin()
        {
            List<Employee> employees = new List<Employee>
                {
                   new Employee { EmployeeId = 1, Name = "Alice" },
                   new Employee { EmployeeId = 2, Name = "Bob" },
                   new Employee { EmployeeId = 3, Name = "Charlie" }
                };
            List<Department> departments = new List<Department>
                {
                   new Department { DepartmentId = 1, DepartmentName = "HR" },
                   new Department { DepartmentId = 2, DepartmentName = "Finance" },
                   new Department { DepartmentId = 3, DepartmentName = "IT" }
                };
            List<string> list = new List<string>();

            var Ljoin = from emp in employees
                        join dep in departments
                            on emp.EmployeeId equals dep.DepartmentId into JoinedEmpDept
                        from proj in JoinedEmpDept.DefaultIfEmpty()
                        select new
                        {
                            DepartmentName = proj.DepartmentName,
                            Name = emp.Name, 
                        };

            foreach (var result in Ljoin)
            {
                list.Add(result.DepartmentName);
                list.Add(result.Name);
            }
            return Ok(list);
        }
        [HttpGet("RightJoin")]
        public IActionResult RightJoin()
        {
            List<Employee> employees = new List<Employee>
                {
                   new Employee { EmployeeId = 1, Name = "Alice" },
                   new Employee { EmployeeId = 2, Name = "Bob" },
                   new Employee { EmployeeId = 3, Name = "Charlie" }
                };
            List<Department> departments = new List<Department>
                {
                   new Department { DepartmentId = 1, DepartmentName = "HR" },
                   new Department { DepartmentId = 2, DepartmentName = "Finance" },
                   new Department { DepartmentId = 3, DepartmentName = "IT" }
                };
            List<string> list = new List<string>();

            var RJoin = from dep in departments
                        join employee in employees
                        on dep.DepartmentName equals employee.Name into joinDeptEmp
                        from employee in joinDeptEmp.DefaultIfEmpty()
                        select new
                        {
                            EmployeeName = employee.Name,
                            DepartmentName = dep.DepartmentName,
                        };

            foreach (var result in RJoin)
            {
                list.Add(result.EmployeeName);
                list.Add(result.DepartmentName);
            }
            return Ok(list);
        }
        [HttpGet("FullJoin")]
        public IActionResult FullJoin()
        {
            var leftJoinQuery = new List<string>() { "Attur", "Cuddalore", "Dindugal", "Karur" };
            var rightJoinQuery = new List<string>() { "Karur", "Madurai", "Namakkal", "Attur" };
            List<string> list = new List<string>();

            var fullOuterJoinQuery = leftJoinQuery.Union(rightJoinQuery);

            foreach (var result in fullOuterJoinQuery)
            {
                list.Add(result);
            }
            return Ok(list);
        }
    }
}
