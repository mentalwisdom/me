using System.ComponentModel.DataAnnotations;
//Code First for Database Migration
namespace me.Models{

    //automatically create a Car Table in the database
    public class Car {
        //carId,brand,model, qty, rentalPrice, status
        [Key]
        public int carId {get;set;}
        public string brand {get;set;}
        public string model {get;set;}
        public double qty {get;set;}
        public double rentalPrice {get;set;}
        //status : 0 => in
        //status : 1 => out
        public int status {get;set;}

    }//ec

    public class CarModel {
        //carId,brand,model, qty, rentalPrice, status
    
        public int carId {get;set;}
        public string brand {get;set;}
        public string model {get;set;}
        public double qty {get;set;}
        public double rentalPrice {get;set;}
    
        public double total {get;set;}

    }//ec

}//en