using CreateApi.DBcontact;
using CreateApi.Model;
using CreateApi.viewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CreateApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public readonly DBContacts _modelClass;
        public WeatherForecastController(DBContacts modelClass)
        {
            _modelClass = modelClass;
        }
        [HttpGet("GetData")]
        public async Task<IActionResult> GetData()
        {
            var result = await _modelClass.Persons.ToListAsync();
            List<ModelClass1> lst = new List<ModelClass1>();
            ModelClass1 mc1 = new ModelClass1();
            for (int i = 0; i < result.Count; i++)
            {
                mc1.CustomerID = result[i].CustomerID;
                mc1.FirstName = result[i].FirstName;
                lst.Add(mc1);
            }

            lst[1].LastName = "shdf";
            lst[1].Address = "jhdfjhg";
           
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> adddata(ModelClass Adddatatable)
        {
            var Name = new ModelClass()
            {
                CustomerID = Adddatatable.CustomerID,
                FirstName = Adddatatable.FirstName,
                LastName = Adddatatable.LastName,
                Address = Adddatatable.Address,
            };
            await _modelClass.Persons.AddAsync(Name);
            await _modelClass.SaveChangesAsync();
            return Ok(Name);
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, ViewModel rep)
        {
            var contact = await _modelClass.Persons.FindAsync(id);
            if (contact != null)
            {
                contact.FirstName = rep.FirstName;
                contact.LastName = rep.LastName;
                contact.Address = rep.Address;
                await _modelClass.SaveChangesAsync();
                return Ok(contact);
            }
            return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> delete(int id, ViewModel rep)
        {
            var contact = await _modelClass.Persons.FindAsync(id);
            if (contact != null)
            {
                _modelClass.Remove(contact);
                _modelClass.SaveChanges();
                return Ok(contact);
            }
            return Ok();
        }
    }
}

