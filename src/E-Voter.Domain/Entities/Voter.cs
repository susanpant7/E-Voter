namespace E_Voter.Domain.Entities;

public class Voter
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public DateTime RegisteredAt { get; set; }
}