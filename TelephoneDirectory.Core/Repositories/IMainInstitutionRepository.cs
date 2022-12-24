using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Core.Repositories
{
    public interface IMainInstitutionRepository : IGenericRepository<MainInstitution>
    {
        Task<List<MainInstitution>> GetMainInstitutionWithInstitution();
    }
}
