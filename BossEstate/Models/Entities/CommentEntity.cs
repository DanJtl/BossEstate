namespace BossEstate.Models.Entities;

internal class CommentEntity
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public string Comment { get; set; } = null!;
    public Guid CaseId { get; set; }
    public Guid UserId { get; set; }
}
