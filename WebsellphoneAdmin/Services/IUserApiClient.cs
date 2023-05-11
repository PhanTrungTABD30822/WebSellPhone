using CommonViewModel;
using SellPhoneVIewModel.System.Users;
using System.Threading.Tasks;

namespace WebsellphoneAdmin.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<bool> RegisterUser(RegisterRequest registerRequest);
        Task<PagedResult<UserViewModel>> GetUsersPaging(GetUserPagingRequest request);
    }
}
