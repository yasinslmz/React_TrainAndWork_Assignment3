using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementWebApi.Models;
using System.Net;

namespace ProductManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public static List<Category> categories = ProductController.categories;
        
        [HttpGet]
        public List<Category> Get()
        {
            
            return categories;
        }

        [HttpGet("{id}")]
        public Category Get(int id)
        {
           
            

            Category category = categories.FirstOrDefault(x => x.Id == id);

            return category ;
        }

        [HttpPost]

        public ActionResult Post([FromBody] Category value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            int maxId = categories.Max(p => p.Id);
            value.Id = maxId + 1;
            categories.Add(value);

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Category value)
        {
            var category = categories.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            category.Name = value.Name;
            category.IsStatus = value.IsStatus;

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var category = categories.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            categories.Remove(category);

            return Ok();
        }



    }
}
