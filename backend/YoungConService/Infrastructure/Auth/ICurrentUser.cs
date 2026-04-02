using YoungConService.Domain.Enums;

namespace YoungConService.Infrastructure.Auth;

public interface ICurrentUser
{
    Guid GetUserId();
    UserRole GetRole();
    bool IsAuthenticated();
}
