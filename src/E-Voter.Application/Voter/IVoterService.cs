namespace E_Voter.Application.Voter;

public interface IVoterService
{
    Task<VoterProfile?> GetVoterProfileAsync(string mobileNumber);
}