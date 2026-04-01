using YoungConService.Domain.Entities;
using YoungConService.DTOs;
using YoungConService.DTOs.Users;

namespace YoungConService.Infrastructure.Mappers;

public static class UserMapper
{
    public static UserDto ToDto(this User user)
    {
        return new UserDto
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            QrCode = user.QrCode,
            Major = user.Major,
            Role = user.Role
        };
    }
}