using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using json_filter.Model;

class Program
{
    static void Main()
    {
        string filePath = @"C:\Kapilan\Dharun Json Task\json filter\Enrollment.json";

        string json = File.ReadAllText(filePath);

        List<register> dataList = JsonConvert.DeserializeObject<List<register>>(json);

        string targetConfirmationNumber = "WE72681994";

        List<register> filteredData = dataList
            .Where(item => item.ConfirmationNumber == targetConfirmationNumber)
            .ToList();

        foreach (var item in filteredData)
        {
            Console.WriteLine($"ConfirmationNumber: {item.ConfirmationNumber}");
            Console.WriteLine($"CompanyName: {item.CompanyName}");
            Console.WriteLine($"BirthDate: {item.BirthDate}");
            Console.WriteLine($"PaymentCategoryCode: {item.PaymentCategoryCode}");
            Console.WriteLine($"UtilityAccountNumber: {item.UtilityAccountNumber}");
            Console.WriteLine($"ContractSignedDate: {item.ContractSignedDate}");
            Console.WriteLine($"DivisionCode: {item.DivisionCode}");
            Console.WriteLine($"CreateDate: {item.CreateDate}");

            Console.WriteLine();
        }
    }
}
