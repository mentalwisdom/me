using Microsoft.AspNetCore.Mvc;

namespace me.Controllers {
    public class MainController: Controller{
        //action to output main view to show all of the car information as table
        public IActionResult Index(){
            return View("Index");
        }
        //action to output a form to allow user to register for a new car
        public IActionResult RegisterCar(){
             return View("RegisterCar");
        }

        public IActionResult CustomerIndex(){
            return View("CustomerIndex");
        }
         public IActionResult RegisterCustomer(){
             return View("RegisterCustomer");
        }
    }//ec
}//en