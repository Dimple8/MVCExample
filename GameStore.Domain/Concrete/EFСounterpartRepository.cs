using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Concrete
{
    public class EFСounterpartyRepository : IСounterpartyRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Сounterpartys> Сounterpartys
        {
            get { return context.Сounterpartys; }
        }

    }
}


