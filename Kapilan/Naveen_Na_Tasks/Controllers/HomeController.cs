using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static Naveen_Na_Tasks.Modal.Model_Class;
namespace Naveen_Na_Tasks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("JsonTasks")]
        public object get1()
        {

            var Files = System.IO.File.ReadAllText(@"C:\Kapilan\Naveen_Na_Tasks\Enrollement.json");
            List<Root> array = JsonConvert.DeserializeObject<List<Root>>(Files);
            var datas = new List<total>();



            /*for (int i = 0; i < array.Count; i++)
            {
                foreach (var serviceAccount in array[i].EnrollmentCustomer.ServiceAccount)
                {
                    datas.Add(new total
                    {
                        ConfirmNumber = array[i].ConfirmationNumber,
                        ComName = array[i].EnrollmentCustomer.CompanyName,
                        DOB = array[i].EnrollmentCustomer.BirthDate,
                        Paymode = array[i].EnrollmentCustomer.PaymentCategoryCode,
                        Utility = serviceAccount.UtilityAccountNumber,
                        ContactSign = serviceAccount.ContractSignedDate,
                        Divison = array[i].DivisionCode,
                    });
                }
            }*/

            /*            var Files = System.IO.File.ReadAllText(@"C:\Kapilan\Naveen_Na_Tasks\Enrollement.json");
                        List<Root> array = JsonConvert.DeserializeObject<List<Root>>(Files);
                        var datas = new List<total>();
                        var ConfirmationNumber = array.Select(a => a.ConfirmationNumber).ToList();
                        var ComName = array.Select(a => a.EnrollmentCustomer.CompanyName).ToList();
                        var DOB = array.Select(a => a.EnrollmentCustomer.BirthDate).ToList();
                        var Paymode = array.Select(a => a.EnrollmentCustomer.PaymentCategoryCode).ToList();
                        var Utility = array.SelectMany(a => a.EnrollmentCustomer.ServiceAccount.Select(b => b.UtilityAccountNumber)).ToList();
                        var ContactSign = array.SelectMany(a => a.EnrollmentCustomer.ServiceAccount.Select(b => b.ContractSignedDate)).ToList();
                        var Divison = array.Select(a => a.DivisionCode).ToList();
                        for (int i = 0; i < ConfirmationNumber.Count; i++)
                        {
                            datas.Add(new total
                            {
                                ConfirmNumber = ConfirmationNumber[i],
                                ComName = ComName[i],
                                DOB = DOB[i],
                                Paymode = Paymode[i],
                                Utility = Utility[i],
                                ContactSign = ContactSign[i],
                                Divison = Divison[i]
                            });
                        }*/
            /*            var MethodSyntaxResult = array.SelectMany(std => std.EnrollmentCustomer.ServiceAccount, total => datas.Add(new total
                        {
                            ConfirmNumber = total.ConfirmationNumber,
                            ComName = total.EnrollmentCustomer.CompanyName,
                            DOB = total.EnrollmentCustomer.BirthDate,
                            Paymode = total.EnrollmentCustomer.PaymentCategoryCode,
                            ComName2 = total.EnrollmentCustomer.ServiceAccount.Select(a => a.UtilityAccountNumber),
                            ContactSign = total.EnrollmentCustomer.ServiceAccount.Select(a => a.ContractSignedDate),
                            Division = total.DivisionCode
                        }).ToList());*/
            return datas;
        }
    }
}
/*var datas = new List<total>();
datas.Add(new total*/
//  List<object>obj = new List<object>();
/*            var MethodSyntax = array.SelectMany(std => std.EnrollmentCustomer.ServiceAccount, (root, ContractSignedDate) => new
            {
                ConfirmNumber = root.ConfirmationNumber,
                ComName = root.EnrollmentCustomer.CompanyName,
                DOB = root.EnrollmentCustomer.BirthDate,
                Paymode = root.EnrollmentCustomer.PaymentCategoryCode,
                ComName2 = root.EnrollmentCustomer.ServiceAccount.Select(a => a.UtilityAccountNumber),
                ContactSign = root.EnrollmentCustomer.ServiceAccount.Select(a => a.ContractSignedDate),
                Divison = root.DivisionCode,
                //  Date = root.EnrollmentCustomer.ServiceAccount.Select(a => a.),

            });
            var i = from s in array.SelectMany(x => x.EnrollmentCustomer.ServiceAccount),;
            {
                        ConfirmNumber = s.,
                        ComName = root.EnrollmentCustomer.CompanyName,
                        DOB = root.EnrollmentCustomer.BirthDate,
                        Paymode = root.EnrollmentCustomer.PaymentCategoryCode,
                        ComName2 = root.EnrollmentCustomer.ServiceAccount.Select(a => a.UtilityAccountNumber),
                        ContactSign = root.EnrollmentCustomer.ServiceAccount.Select(a => a.ContractSignedDate),
                        Divison = root.DivisionCode,
                    };


            var datas = new List<total>();
            datas.Add(new total
            {
                ConfirmNumber = datas.,
                ComName = root.EnrollmentCustomer.CompanyName,
                DOB = root.EnrollmentCustomer.BirthDate,
                Paymode = root.EnrollmentCustomer.PaymentCategoryCode,
                ComName2 = root.EnrollmentCustomer.ServiceAccount.Select(a => a.UtilityAccountNumber),
                ContactSign = root.EnrollmentCustomer.ServiceAccount.Select(a => a.ContractSignedDate),
                Divison = root.DivisionCode,
            });*/
// Assuming you want to convert it to a list