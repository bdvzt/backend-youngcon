using System.Text.Json.Serialization;

namespace YoungConService.Domain.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserRole
{
    Client,
    Employee
}
