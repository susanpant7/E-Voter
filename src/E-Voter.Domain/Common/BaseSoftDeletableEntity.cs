namespace E_Voter.Domain.Common;

public abstract class BaseSoftDeletableEntity : BaseAuditableEntity, ISoftDeletable
{
    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedBy { get; set; }
}