using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Owner.API.Data;
using Owner.API.Model;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Owner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        [Route("All")]
        [HttpGet]
        public List<OwnerModel> GetAll()
        {
            return new List<OwnerModel>
            {
                new OwnerModel
                {
                Id = 1,
                Name = "Merve",
                Surname = "Bakır",
                Date = System.DateTime.Now,
                Description = "xxxxx",
                Type = "A"
                },
                new OwnerModel
                {
                Id = 2,
                Name = "Leyla",
                Surname = "Bakır",
                Date = System.DateTime.Now,
                Description = "yyyyyy",
                Type = "b"
                },
               new OwnerModel
                {
                Id = 3,
                Name = "Onur",
                Surname = "Bakır",
                Date = System.DateTime.Now,
                Description = "zzzzzz",
                Type = "C"
                },
            };
        }

        [HttpPost("Add")]
        [Consumes("application/json")]
        public IActionResult AddOwner(OwnerModel model)
        {
            var owners = new List<OwnerModel>();
            owners.Add(model);
            if (!owners.Any(o => o.Description.Contains("hack")))
            {
                return Ok(owners);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var owners = new OwnersData().GetAllOwner();
            var owner = owners.FirstOrDefault(o => o.Id == id);

            if (owner == null)
                return NotFound(string.Format("Owner with Id={0} not found", id));

            owners.Remove(owner);
            return Ok(owners);

        }


        [HttpPut("{id:int}")]
        public IActionResult Update(int id,OwnerModel owner)
        {
            if(id != owner.Id)
                return BadRequest("Id not found");

            var owners = new OwnersData().GetAllOwner();

            var update = owners.FirstOrDefault(x => x.Id == id);

            update.Name = owner.Name.ToUpper();
            update.Surname= owner.Surname.ToUpper();
            update.Date = owner.Date;
            update.Description= owner.Description.ToLower();
            update.Type = $"{owner.Type} Type";

            return Ok(update);
        }

    }
}
