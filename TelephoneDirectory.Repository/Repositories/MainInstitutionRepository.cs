using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Repositories;

namespace TelephoneDirectory.Repository.Repositories
{
    public class MainInstitutionRepository : GenericRepository<MainInstitution>, IMainInstitutionRepository
    {
        public MainInstitutionRepository(AppDbContext context) : base(context)
        {
        }

        public Task<List<MainInstitution>> GetMainInstitutionWithInstitution()
        {
            throw new NotImplementedException();
        }
    }
}
