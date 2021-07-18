using System.ComponentModel.DataAnnotations;

namespace me.Models{
    public class Customer {
        [Key]
        public int customerId {get;set;} 
        public string firstName {get;set;}
        public string LastName {get;set;} 
        public string NationalId {get;set;} 
        public string mobile {get;set;}
    }
}