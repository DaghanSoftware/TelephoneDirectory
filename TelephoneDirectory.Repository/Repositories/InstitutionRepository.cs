using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Repositories;

namespace TelephoneDirectory.Repository.Repositories
{
    public class InstitutionRepository : GenericRepository<Institution>, IInstitutionRepository
    {
        public InstitutionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
