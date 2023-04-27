namespace BossEstate.Models.Entities;

internal class UserEntity
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set;} = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public int UserTypeId { get; set; }
    public int AdressId { get; set; }

    public ICollection<CaseEntity> Cases { get; set; } = new HashSet<CaseEntity>();
    public ICollection<CommentEntity> Comments { get; set; } = new HashSet<CommentEntity>();
}
