using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Concrete
{
    public class EFTestRepository : ITestRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Test> Tests
        {
            get { return context.Tests; }
        }
    }
}
