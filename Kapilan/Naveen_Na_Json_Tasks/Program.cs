using Newtonsoft.Json;
using static Naveen_Na_Json_Tasks.Model.Model_Class;

namespace Naveen_Na_Json_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var Files = File.ReadAllText(@"C:\Kapilan\Naveen_Na_Json_Tasks\Json\Enrollment.json");
            Root[] array = JsonConvert.DeserializeObject<Root[]>(Files);
            var result = from root in array
                         //.SelectMany(std => s)
                         select new
                         {
                             ConfirmNumber = root.ConfirmationNumber,
                             ComName = root.EnrollmentCustomer.CompanyName,
                             DOB = root.EnrollmentCustomer.BirthDate,
                             Paymode = root.EnrollmentCustomer.PaymentCategoryCode,
                             //ComName2 = root.EnrollmentCustomer.ServiceAccount.EnrollmentHikariService
                         };

            
            foreach (var buy in result)
            {
                Console.WriteLine(buy);
            }
        }
    }
}