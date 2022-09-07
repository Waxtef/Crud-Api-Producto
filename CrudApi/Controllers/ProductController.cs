using CrudApi.Contexts;
using CrudApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private DatabaseContext context;
        

        public ProductController(DatabaseContext context)
        {
            this.context = context;

        }
        //Get all
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            //return new string[] { "Todos los productos" };
            return context.Producto.ToList();
        }

        //Get one
        [HttpGet("{id}")]

        public Producto Get(int id)
        {
            var producto = context.Producto.FirstOrDefault(p=>p.id_Producto == id);
            return producto;
        }
      
        //Post prodcutos
        [HttpPost]
        public ActionResult Post([FromBody] Producto producto)
        {
            try
            {
                context.Producto.Add(producto);
                context.SaveChanges();
                return Ok(true);

            }
            catch(Exception ex)
            {
                return BadRequest(false);

            }
           

        }

        //Update prodcutos
        [HttpPut("{id}")]
        public ActionResult Put( int id ,[FromBody]Producto producto)
        {

            if(producto.id_Producto == id)
            {
                context.Entry(producto).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(true);
            }
            else
            {
                return BadRequest(false);
            }
        } 
        //Delete prodcutos
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existe = true;
            var producto = context.Producto.FirstOrDefault(p=>p.id_Producto==id);
            if(producto != null)
            {
                context.Producto.Remove(producto);
                context.SaveChanges();
                return Ok(existe);
            }
            else
            {
                existe = false;
                return BadRequest(existe);
               

            }
        }

    }
}
