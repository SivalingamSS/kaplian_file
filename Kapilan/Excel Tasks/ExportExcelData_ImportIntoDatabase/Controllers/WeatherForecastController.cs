using ExportExcelData_ImportIntoDatabase.DataBase;
using ExportExcelData_ImportIntoDatabase.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.Collections.Generic;
using System.Data;


namespace ExportExcelData_ImportIntoDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DBContext _dBContext;
        private readonly IConfiguration _configuration;
        public WeatherForecastController(DBContext dBContext, IConfiguration configuration)
        {
            _dBContext = dBContext;
            _configuration = configuration;
        }
        [HttpPost("GetData")]
        public async Task<IActionResult> ExcelToDatabase()
        {
            var Getvalues = new List<Excel>();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            using (ExcelPackage package = new ExcelPackage(@"C:\Users\visualapp\Desktop\posts.xlsx"))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int colCount = worksheet.Dimension.End.Column;
                int rowCount = worksheet.Dimension.End.Row;
                for (int row = 3; row <= rowCount; row++)
                {
                    var excelData = new Excel
                    {
                        SNo = int.Parse(worksheet.Cells[row, 1].Text),
                        CandidateName = worksheet.Cells[row, 2].Text,
                        FatherName = worksheet.Cells[row, 3].Text,
                        MotherName = worksheet.Cells[row, 4].Text,
                        IsExServiceMan = int.Parse(worksheet.Cells[row, 5].Text),
                        IsAdHocTeacher = int.Parse(worksheet.Cells[row, 6].Text),
                        IsDisabled = int.Parse(worksheet.Cells[row, 7].Text),
                        Category = worksheet.Cells[row, 8].Text,
                        RollNo = int.Parse(worksheet.Cells[row, 9].Text),
                        District = worksheet.Cells[row, 10].Text,
                        OutofState = worksheet.Cells[row, 11].Text,
                        DateofInterview = worksheet.Cells[row, 12].Text,
                        ReportingTime = worksheet.Cells[row, 13].Text,
                        InterviewSubBoard = int.Parse(worksheet.Cells[row, 14].Text),
                        Venue = worksheet.Cells[row, 15].Text
                    };

                    Getvalues.Add(excelData);
                }
                SqlConnection sqlconn = null;
                string constring = _configuration.GetConnectionString("MVC6CrudConnectionString");
                using (SqlConnection con = new SqlConnection(constring))
                {
                    foreach (var getdata in Getvalues)
                    {
                        using (SqlCommand command = new SqlCommand("Excel_Data", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            await con.OpenAsync();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@SNo", SqlDbType.Int).Value = getdata.SNo;
                            command.Parameters.AddWithValue("@CandidateName", SqlDbType.VarChar).Value = getdata.CandidateName;
                            command.Parameters.AddWithValue("@FatherName", SqlDbType.VarChar).Value = getdata.FatherName;
                            command.Parameters.AddWithValue("@MotherName", SqlDbType.VarChar).Value = getdata.MotherName;
                            command.Parameters.AddWithValue("@IsExServiceMan", SqlDbType.Int).Value = getdata.IsExServiceMan;
                            command.Parameters.AddWithValue("@IsAdHocTeacher", SqlDbType.Int).Value = getdata.IsAdHocTeacher;
                            command.Parameters.AddWithValue("@IsDisabled", SqlDbType.Int).Value = getdata.IsDisabled;
                            command.Parameters.AddWithValue("@Category", SqlDbType.VarChar).Value = getdata.Category;
                            command.Parameters.AddWithValue("@RollNo", SqlDbType.VarChar).Value = getdata.RollNo;
                            command.Parameters.AddWithValue("@District", SqlDbType.VarChar).Value = getdata.District;
                            command.Parameters.AddWithValue("@OutofState", SqlDbType.VarChar).Value = getdata.OutofState;
                            command.Parameters.AddWithValue("@DateofInterview", SqlDbType.VarChar).Value = getdata.DateofInterview;
                            command.Parameters.AddWithValue("@ReportingTime", SqlDbType.VarChar).Value = getdata.ReportingTime;
                            command.Parameters.AddWithValue("@InterviewSubBoard", SqlDbType.Int).Value = getdata.InterviewSubBoard;
                            command.Parameters.AddWithValue("@Venue", SqlDbType.VarChar).Value = getdata.Venue;
                            command.ExecuteNonQuery();
                            await con.CloseAsync();
                        }
                    }
                }
                return Ok();
            }
        }
        [HttpPost("PostData")]
        public async Task<IActionResult> UpdateData()
        {
            var Takevalues = new List<Excel>();
            var Getvalues1 = new List<Excel1>();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(@"C:\Users\visualapp\Desktop\posts.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                ExcelWorksheet worksheet1 = package.Workbook.Worksheets[1];
                int rowCount = worksheet.Dimension.End.Row;
                var startCell = worksheet1.Cells["A3"];
                var endCell = worksheet1.Cells["N620"];
                var range = worksheet.Cells[startCell.Start.Row, startCell.Start.Column, endCell.End.Row, endCell.End.Column];
                var rowCount1 = range.End.Row;

                for (int row = 3; row <= rowCount1; row++)
                {
                    var excelDatas = new Excel1
                    {
                        SNo = int.Parse(worksheet1.Cells[row, 1].Text),
                        Name = worksheet1.Cells[row, 2].Text,
                        FatherName = worksheet1.Cells[row, 3].Text,
                        MotherName = worksheet1.Cells[row, 4].Text,
                        IsExServiceMan = int.Parse(worksheet1.Cells[row, 5].Text),
                        IsAdHocTeacher = int.Parse(worksheet1.Cells[row, 6].Text),
                        IsDisabled = int.Parse(worksheet1.Cells[row, 7].Text),
                        Category = worksheet1.Cells[row, 8].Text,
                        RollNo = int.Parse(worksheet1.Cells[row, 9].Text),
                        District = worksheet1.Cells[row, 10].Text,
                        OutofState = worksheet1.Cells[row, 11].Text,
                        DateofInterview = worksheet1.Cells[row, 12].Text,
                        ReportingTime = worksheet1.Cells[row, 13].Text,
                        InterviewSubBoard = int.Parse(worksheet1.Cells[row, 14].Text)
                    };
                    Getvalues1.Add(excelDatas);
                }
                for (int row = 3; row <= rowCount; row++)
                {
                    var excelData = new Excel();

                    excelData.SNo = int.Parse(worksheet.Cells[row, 1].Text);
                    excelData.CandidateName = worksheet.Cells[row, 2].Text;
                    excelData.FatherName = worksheet.Cells[row, 3].Text;
                    excelData.MotherName = worksheet.Cells[row, 4].Text;
                    excelData.IsExServiceMan = int.Parse(worksheet.Cells[row, 5].Text);
                    excelData.IsAdHocTeacher = int.Parse(worksheet.Cells[row, 6].Text);
                    excelData.IsDisabled = int.Parse(worksheet.Cells[row, 7].Text);
                    excelData.Category = worksheet.Cells[row, 8].Text;
                    excelData.RollNo = int.Parse(worksheet.Cells[row, 9].Text);
                    excelData.District = worksheet.Cells[row, 10].Text;
                    excelData.OutofState = worksheet.Cells[row, 11].Text;
                    excelData.DateofInterview = worksheet.Cells[row, 12].Text;
                    excelData.ReportingTime = worksheet.Cells[row, 13].Text;
                    excelData.InterviewSubBoard = int.Parse(worksheet.Cells[row, 14].Text);
                    excelData.Venue = worksheet.Cells[row, 15].Text;
                    if (excelData.IsDisabled == 1)
                    {
                        foreach (var a in Getvalues1)
                        {
                            if (a.RollNo == excelData.RollNo)
                            {
                                excelData.InterviewSubBoard = a.InterviewSubBoard;
                            }
                        }
                    }
                    Takevalues.Add(excelData);
                }
                SqlConnection sqlconn = null;
                string constring = _configuration.GetConnectionString("MVC6CrudConnectionString");
                using (SqlConnection con = new SqlConnection(constring))
                {
                    foreach (var getdata in Takevalues)
                    {
                        using (SqlCommand command = new SqlCommand("Excel_Data1", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            await con.OpenAsync();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@SNo", SqlDbType.Int).Value = getdata.SNo;
                            command.Parameters.AddWithValue("@CandidateName", SqlDbType.VarChar).Value = getdata.CandidateName;
                            command.Parameters.AddWithValue("@FatherName", SqlDbType.VarChar).Value = getdata.FatherName;
                            command.Parameters.AddWithValue("@MotherName", SqlDbType.VarChar).Value = getdata.MotherName;
                            command.Parameters.AddWithValue("@IsExServiceMan", SqlDbType.Int).Value = getdata.IsExServiceMan;
                            command.Parameters.AddWithValue("@IsAdHocTeacher", SqlDbType.Int).Value = getdata.IsAdHocTeacher;
                            command.Parameters.AddWithValue("@IsDisabled", SqlDbType.Int).Value = getdata.IsDisabled;
                            command.Parameters.AddWithValue("@Category", SqlDbType.VarChar).Value = getdata.Category;
                            command.Parameters.AddWithValue("@RollNo", SqlDbType.VarChar).Value = getdata.RollNo;
                            command.Parameters.AddWithValue("@District", SqlDbType.VarChar).Value = getdata.District;
                            command.Parameters.AddWithValue("@OutofState", SqlDbType.VarChar).Value = getdata.OutofState;
                            command.Parameters.AddWithValue("@DateofInterview", SqlDbType.VarChar).Value = getdata.DateofInterview;
                            command.Parameters.AddWithValue("@ReportingTime", SqlDbType.VarChar).Value = getdata.ReportingTime;
                            command.Parameters.AddWithValue("@InterviewSubBoard", SqlDbType.Int).Value = getdata.InterviewSubBoard;
                            command.Parameters.AddWithValue("@Venue", SqlDbType.VarChar).Value = getdata.Venue;
                            command.ExecuteNonQuery();
                            await con.CloseAsync();
                        }
                    }
                }
                return Ok();
            }
        }
    }
}