using me.Data;
using me.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace me.Controllers{

    [Route("api/[controller]/[action]")]
    public class CustomerController:Controller{
        private meDbContext _db;

        public CustomerController(meDbContext db){
            _db = db;
        }//ef

        [HttpGet]
        public IActionResult customers(){
            var result = _db.Customer.ToList();
            return Json(result);
        }//ef

        [HttpPost]
        public IActionResult register([FromBody] Customer customer){
            _db.Customer.Add(customer);
            _db.SaveChanges();
            return Json(customer);
        }//ef


        
    }//ec
}//en