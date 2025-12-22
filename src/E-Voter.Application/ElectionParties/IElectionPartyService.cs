namespace E_Voter.Application.ElectionParties;

public interface IElectionPartyService
{
    Task<List<ElectionPartySummary>> GetElectionPartiesAsync();
    Task<ElectionPartyDetail?> GetByIdAsync(int id);
    Task<int> AddAsync(ElectionPartyDetail dto);
    Task UpdateAsync(int id, ElectionPartyDetail dto);
    Task<bool> DeleteAsync(int id);
}
