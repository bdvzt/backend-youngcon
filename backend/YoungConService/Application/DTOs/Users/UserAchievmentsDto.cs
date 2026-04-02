namespace YoungConService.DTOs.Users;

public class UserAchievmentsDto
{
    public required Guid UserId { get; set; }
    public required AchievmentDto[] Achievments { get; set; }
}

