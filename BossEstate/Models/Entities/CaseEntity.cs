namespace BossEstate.Models.Entities;

internal class CaseEntity
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public Guid UserId { get; set; }
    public int StatusTypeId { get; set; }
}
