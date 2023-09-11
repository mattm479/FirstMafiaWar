using FirstMafiaWar.Models.Requests;
using FirstMafiaWar.Models.Responses;

namespace FirstMafiaWar.Services
{
    public interface IAuthenticationService
    {
        Task<RegisterResponse> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken);
        Task<LoginResponse> LoginAsync(LoginRequest request, CancellationToken cancellationToken);
    }

    public class AuthenticationService : IAuthenticationService
    {
        public Task<LoginResponse> LoginAsync(LoginRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterResponse> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
