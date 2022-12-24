using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Repositories;

namespace TelephoneDirectory.Repository.Repositories
{
    public class CountyRepository : GenericRepository<County>, ICountyRepository
    {
        public CountyRepository(AppDbContext context) : base(context)
        {
        }
    }
}
