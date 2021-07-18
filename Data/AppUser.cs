using Microsoft.AspNetCore.Identity;

namespace me.Data{

    public class AppUser:IdentityUser<int>{

        public string first_name {get;set;}
        public string last_name {get;set;}
        public string department {get;set;}
        
        
    }
}