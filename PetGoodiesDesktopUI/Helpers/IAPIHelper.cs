using PetGoodiesDesktopUI.Models;
using System.Threading.Tasks;

namespace PetGoodiesDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}