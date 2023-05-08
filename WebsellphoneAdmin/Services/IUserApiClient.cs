using SellPhoneVIewModel.System.Users;
using System.Threading.Tasks;

namespace WebsellphoneAdmin.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
