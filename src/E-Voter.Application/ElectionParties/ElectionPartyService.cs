using E_Voter.Domain.Common;
using E_Voter.Domain.Entities;
using E_Voter.Domain.Exceptions;
using E_Voter.Domain.IRepositories;

namespace E_Voter.Application.ElectionParties;

public class ElectionPartyService(IElectionPartyRepository electionRepository, IMediaFileRepository mediaFileRepository,
    IUnitOfWork unitOfWork) : IElectionPartyService
{
    // -------------------------
    // Queries
    // -------------------------
    public async Task<List<ElectionPartySummary>> GetElectionPartiesAsync()
    {
        var parties = await electionRepository.GetAllAsync();

        return parties.Select(p => new ElectionPartySummary
        {
            Id = p.Id,
            Name = p.Name,
            LeaderName = p.LeaderName,
            LogoFileId = p.LogoFileId
        }).ToList();
    }

    public async Task<ElectionPartyDetail?> GetByIdAsync(int id)
    {
        var entity = await electionRepository.GetByIdAsync(id);
        if (entity == null) return null;

        return new ElectionPartyDetail
        {
            Id = entity.Id,
            Name = entity.Name,
            Abbreviation = entity.Abbreviation,
            Description = entity.Description,

            LeaderName = entity.LeaderName,
            FounderName = entity.FounderName,

            FoundedOn = entity.FoundedOn,
            RegisteredOn = entity.RegisteredOn,

            IsRecognizedNationally = entity.IsRecognizedNationally,
            Status = entity.Status,

            Ideology = entity.Ideology,
            PoliticalSpectrum = entity.PoliticalSpectrum,

            OfficialWebsite = entity.OfficialWebsite,
            ContactEmail = entity.ContactEmail,
            ContactPhone = entity.ContactPhone,

            HeadquartersAddress = entity.HeadquartersAddress,

            LogoFileId = entity.LogoFileId,
            LogoFileName = entity.LogoFile?.FileName
        };
    }

    // -------------------------
    // Commands
    // -------------------------
    public async Task<int> AddAsync(ElectionPartyDetail dto)
    {
        if (await electionRepository.ExistsByNameOrAbbreviationAsync(dto.Name, dto.Abbreviation))
            throw new InvalidOperationException("An election party with the same Name or Abbreviation already exists.");

        var entity = MapDtoToEntity(dto);

        await electionRepository.AddAsync(entity);
        return entity.Id;
    }

    public async Task UpdateAsync(int id, ElectionPartyDetail dto)
    {
        var entity = await electionRepository.GetByIdAsync(id);
        if (entity == null)
            throw new KeyNotFoundException("Election party not found.");

        if (await electionRepository.ExistsByNameOrAbbreviationAsync(dto.Name, dto.Abbreviation, id))
            throw new InvalidOperationException("Another election party with the same Name or Abbreviation already exists.");

        // Map DTO → Entity (logo is only linked via MediaFileId)
        entity = MapDtoToEntity(dto, entity);

        await electionRepository.UpdateAsync(entity);
    }

    // -------------------------
    // Private mapping helper
    // -------------------------
    private ElectionParty MapDtoToEntity(ElectionPartyDetail dto, ElectionParty? entity = null)
    {
        entity ??= new ElectionParty();

        entity.Name = dto.Name;
        entity.Abbreviation = dto.Abbreviation;
        entity.Description = dto.Description;
        entity.LeaderName = dto.LeaderName;
        entity.FounderName = dto.FounderName;
        entity.FoundedOn = dto.FoundedOn;
        entity.RegisteredOn = dto.RegisteredOn;
        entity.IsRecognizedNationally = dto.IsRecognizedNationally;
        entity.Status = dto.Status;
        entity.Ideology = dto.Ideology;
        entity.PoliticalSpectrum = dto.PoliticalSpectrum;
        entity.OfficialWebsite = dto.OfficialWebsite;
        entity.ContactEmail = dto.ContactEmail;
        entity.ContactPhone = dto.ContactPhone;
        entity.HeadquartersAddress = dto.HeadquartersAddress;

        // Only store MediaFile reference
        entity.LogoFileId = dto.LogoFileId;

        return entity;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var party = await electionRepository.GetByIdAsync(id)
                    ?? throw new EntityNotFoundException("Election party not found");

        if (party.LogoFileId.HasValue)
        {
            await mediaFileRepository.DeleteByIdAsync(party.LogoFileId.Value);
        }

        await electionRepository.DeleteAsync(party);

        await unitOfWork.SaveChangesAsync();
        return true;
    }
}
