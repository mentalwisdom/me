using Microsoft.AspNetCore.Identity;

namespace me.Data{

    public class AppRole:IdentityRole<int>{
 
        public AppRole(string Name):base(Name){}
        
    }
}