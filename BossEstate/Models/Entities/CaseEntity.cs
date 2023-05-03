namespace BossEstate.Models.Entities;

internal class CaseEntity
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;

    public Guid UserId { get; set; }
    public UserEntity User { get; set; } = null!;

    public int StatusTypeId { get; set; }
    public StatusTypeEntity StatusType { get; set; } = null!;
    public ICollection<CommentEntity> Comments { get; set; } = new HashSet<CommentEntity>();
}
