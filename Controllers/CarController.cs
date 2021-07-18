using me.Data;
using me.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace me.Controllers{

    [Route("api/[controller]/[action]")]
    public class CarController:Controller{
        meDbContext _db;//field variable that can be referenced from any functions in this class
        //inject database context into constructor
        public CarController(meDbContext db){
            _db = db;
        }
        //action to output a list of all car from database table->car
        public IActionResult cars(){
            var result = _db.Car.ToList();
            return Json(result);
        }//ef

        [HttpPost]
        public IActionResult register([FromBody] Car car){
            //save the car please
            _db.Car.Add(car);
            //commit to change from memory to physical database
            _db.SaveChanges();
            return Json(car);
        }//ef

    }
}//en