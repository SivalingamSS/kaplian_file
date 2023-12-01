using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;
using binding_pdf.DB;
using binding_pdf.Modal;
using binding_pdf.Scancode;
using DinkToPdf;
using DinkToPdf.Contracts;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.qrcode;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.OpenApi.Models;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharpCore;
using PdfSharpCore.Pdf;
using QRCoder;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace binding_pdf.Controllers
{
    public class DataController : ControllerBase
    {
        private readonly DBContext _dbcontext;
        public DataController(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet("GeneratePDf")]
        public async Task<IActionResult> GeneratePDf(int id)
        {
            var data = _dbcontext.Excel_Export.Where(a => a.SNo == id).Select(a => new ViewModal
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
            });

            Document doc = new Document();

            using (MemoryStream ms = new MemoryStream())
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, ms);
                doc.Open();

                foreach (var item in data)
                {
                    doc.Add(new Paragraph($"SNo: {item.SNo}"));
                    doc.Add(new Paragraph($"CandidateName: {item.CandidateName}"));
                    doc.Add(new Paragraph($"FatherName: {item.FatherName}"));
                    doc.Add(new Paragraph($"MotherName: {item.MotherName}"));
                    doc.Add(new Paragraph($"IsExServiceMan: {item.IsExServiceMan}"));
                    doc.Add(new Paragraph($"IsAdHocTeacher: {item.IsAdHocTeacher}"));
                    doc.Add(new Paragraph($"IsDisabled: {item.IsDisabled}"));
                    doc.Add(new Paragraph($"Category: {item.Category}"));
                    doc.Add(new Paragraph($"RollNo: {item.RollNo}"));
                    doc.Add(new Paragraph($"District: {item.District}"));
                    doc.Add(new Paragraph($"OutofState: {item.OutofState}"));
                    doc.Add(new Paragraph($"DateofInterview: {item.DateofInterview}"));
                    doc.Add(new Paragraph($"ReportingTime: {item.ReportingTime}"));
                    doc.Add(new Paragraph($"InterviewSubBoard: {item.InterviewSubBoard}"));
                    doc.Add(new Paragraph($"Venue: {item.Venue}"));
                }
                doc.Close();

              /*  var qrGenerator = new QRCodeGenerator();
                var qrCodeData = qrGenerator.CreateQrCode($"Candidate ID: {id}", QRCodeGenerator.ECCLevel.Q);
                var qrCode = new QRCode(qrCodeData);
                var qrCodeImage = qrCode.GetGraphic(10);

                // Save QR code to a memory stream
                using (MemoryStream qrCodeStream = new MemoryStream())
                {
                    qrCodeImage.Save(qrCodeStream, System.Drawing.Imaging.ImageFormat.Png);
                    try
                    {
                        iTextSharp.text.Image qrImage = iTextSharp.text.Image.GetInstance(qrCodeStream.GetBuffer());
                        qrImage.ScaleAbsolute(100, 100);
                        doc.Add(qrImage);
                    }
                    catch (Exception ex)
                    {
                         return NotFound (ex.Message);
                    }*/
                
                byte[] pdfContent = ms.ToArray();
                return File(pdfContent, "application/pdf", "CandidateInformation.pdf");
            }
        }
        [HttpPost("DecodeQRCode")]
        public IActionResult DecodeQRCode([FromBody] byte[] qrCodeImageBytes)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            string decodedData = decoder.DecodeQRCode(qrCodeImageBytes);

            if (decodedData.StartsWith("An error occurred"))
            {
                return BadRequest(decodedData);
            }
            else
            {
                return Ok(decodedData);
            }
        }
    }
}