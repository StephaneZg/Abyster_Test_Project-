
using System.Security.Claims;
using Abyster_Test_Project.Contract;
using Abyster_Test_Project.Domain.Users;

namespace Abyster_Test_Project.Services;

public class ClaimsService : IClaimsService
{
    public List<Claim> GetUserClaimsAsync(User user)
    {
        List<Claim> userClaims = new()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.emailAddress),
                new Claim(ClaimTypes.Name, user.lastName + user.firstName),
            };

        if (user.roles.Count() != 0)
        {
            foreach (var userRole in user.roles)
            {
                userClaims.Add(new Claim(ClaimTypes.Role, userRole.libelle));
            }
        }

        return userClaims;
    }
}