using System.ComponentModel.DataAnnotations;
//code first
namespace me.Models{

    public class Staff {
        //staffId, firstName, LastName, mobile
        [Key]
        public int staffId {get;set;}
        public string firstName {get;set;}
        public string lastName {get;set;}
        public string mobile {get;set;}

    }//ec

}//en