namespace YoungConService.DTOs.Users;

public class AssignAchievmentByQrResultDto
{
    public required Guid UserId { get; set; }
    public required Guid AchievmentId { get; set; }
    public required bool AssignedNow { get; set; }
    public required bool RemovedNow { get; set; }
    public required bool HasAchievmentNow { get; set; }
}

