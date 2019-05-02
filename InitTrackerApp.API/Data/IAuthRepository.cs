using System.Threading.Tasks;
using InitTrackerApp.API.Models;

namespace InitTrackerApp.API.Data
{
    public interface IAuthRepository
    {
         Task<Users> Register(Users user, string password);
         Task<Users> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}