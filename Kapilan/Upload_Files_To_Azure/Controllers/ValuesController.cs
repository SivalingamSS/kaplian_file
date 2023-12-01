using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Upload_Files_To_Azure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        private string _connectionstring = "DefaultEndpointsProtocol=https;AccountName=kapilanhubstorage;AccountKey=FIR7p5uk34clTAHh/bx0ArjjeO5UYGHqzgN1gBvl90OawC6zOnYJU0WL+XkEhRZollqLxOQkqc02+AStNk/j7g==;EndpointSuffix=core.windows.net";

        [HttpGet("GetFile")]
        public async Task<IActionResult> GetFile()
        {
            List<object> files = new List<object>();
            CloudStorageAccount backupStorageAccount = CloudStorageAccount.Parse(_connectionstring);
            var backupBlobClient = backupStorageAccount.CreateCloudBlobClient();
            var backupContainer = backupBlobClient.GetContainerReference("sales1");
            var blobs = backupContainer.ListBlobs().OfType<CloudBlockBlob>().ToList();
            foreach (var blob in blobs)
            {
                files.Add(blob.Name);
                files.Add(blob.Properties.Length);
                files.Add(blob.Properties.LastModified.ToString());
            }
            return Ok(files);
        }

        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFile(IList<IFormFile> files)
        {
            BlobContainerClient blobContainerClient = new BlobContainerClient(_connectionstring, "sales1");
            foreach (IFormFile file in files)
            {
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    stream.Position = 0;
                    await blobContainerClient.UploadBlobAsync(file.FileName, stream);
                }
            }
            return Ok("Uploaded Sucessfully");
        }

        [HttpGet(nameof(DownloadFile))]
        public async Task<IActionResult> DownloadFile(string fileName)
        {
            BlobClient blobClient = new BlobClient(_connectionstring, "sales1", fileName);
            using (var stream = new MemoryStream())
            {
                await blobClient.DownloadToAsync(stream);
                stream.Position = 0;
                var contenttype = (await blobClient.GetPropertiesAsync()).Value.ContentType;
                return File(stream.ToArray(), contenttype, blobClient.Name);
            }
        }
        [HttpDelete("DeleteFile")]
        public async Task<bool> DeleteFile(string strFileName)
        {
            var container = new BlobContainerClient(_connectionstring, "sales1");
            await container.SetAccessPolicyAsync(PublicAccessType.Blob);
            var blob = container.GetBlobClient(strFileName);
            await blob.DeleteIfExistsAsync(Azure.Storage.Blobs.Models.DeleteSnapshotsOption.IncludeSnapshots);
            return true;
        }
    }
}

