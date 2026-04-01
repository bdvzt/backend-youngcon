using System.Text.Json.Serialization;

namespace YoungConService.DTOs.Users;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserSortOption
{
    Created,
    LastName
}

