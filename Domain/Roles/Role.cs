
using System.ComponentModel.DataAnnotations;
using Abyster_Test_Project.Domain.Users;
using Abyster_Test_Project.SharedKernel;

namespace Abyster_Test_Project.Domain.Roles;

public class Role : Common {

    [Required]
    public string libelle {get; set; }

    public IEnumerable<User> users {get; set;}

    public enum RoleLabel{

        Admin , User
        
    }

}
