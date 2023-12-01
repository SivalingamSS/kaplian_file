using DataBase.DB;
using DataBase.Model;
using DataLibrary.Interafce;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static iTextSharp.text.pdf.AcroFields;
using Document = iTextSharp.text.Document;

namespace DataLibrary.Class
{
    public class DataClass : IData
    {
        private readonly DBContext _dbcontext;
        public DataClass(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<object> GetData(int id)
        {
            List<object> list = new List<object>();

            var data = _dbcontext.Excel_Export.Where(a => a.SNo == id).Select(a => new ViewModel()
            {
                SNo = a.SNo,
                CandidateName = a.CandidateName,
                FatherName = a.FatherName,
                MotherName = a.MotherName,
                IsExServiceMan = a.IsExServiceMan,
                IsAdHocTeacher = a.IsAdHocTeacher,
                IsDisabled = a.IsDisabled,
                Category = a.Category,
                RollNo = a.RollNo,
                District = a.District,
                OutofState = a.OutofState,
                DateofInterview = a.DateofInterview,
                ReportingTime = a.ReportingTime,
                InterviewSubBoard = a.InterviewSubBoard,
                Venue = a.Venue

            }).FirstOrDefault();

            list.Add(data.ToString());

            Document doc = new Document();

            using (MemoryStream ms = new MemoryStream())
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, ms);

                doc.Open();

                foreach (var item in list)
                {
                    doc.Add(new Paragraph($"SNo: {item.SNo}"));
                    doc.Add(new Paragraph($"CandidateName: {item.CandidateName}"));
                    doc.Add(new Paragraph($"SNo: {item.FatherName}"));
                    doc.Add(new Paragraph($"SNo: {item.MotherName}"));
                    doc.Add(new Paragraph($"SNo: {item.IsExServiceMan}"));
                    doc.Add(new Paragraph($"SNo: {item.IsAdHocTeacher}"));
                    doc.Add(new Paragraph($"SNo: {item.IsDisabled}"));
                    doc.Add(new Paragraph($"SNo: {item.Category}"));
                    doc.Add(new Paragraph($"SNo: {item.RollNo}"));
                    doc.Add(new Paragraph($"SNo: {item.District}"));
                    doc.Add(new Paragraph($"SNo: {item.OutofState}"));
                    doc.Add(new Paragraph($"SNo: {item.DateofInterview}"));
                    doc.Add(new Paragraph($"SNo: {item.ReportingTime}"));
                    doc.Add(new Paragraph($"SNo: {item.InterviewSubBoard}"));
                    doc.Add(new Paragraph($"SNo: {item.Venue}"));
                }
                doc.Close();

                byte[] pdfContent = ms.ToArray();

                return File(pdfContent, "application/pdf", "CandidateInformation.pdf");
            }
        }
    }
}

          