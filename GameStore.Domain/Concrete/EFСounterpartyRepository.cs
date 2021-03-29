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
        public IEnumerable<Сounterparty> Сounterpartys
        {
            get { return context.Сounterpartys; }
        }

        public void SaveСounterparty(Сounterparty counterparty)
        {

                if (counterparty.id_counterparty == 0)
                    context.Сounterpartys.Add(counterparty);
                else
                {
                    Сounterparty dbEntry = context.Сounterpartys.Find(counterparty.id_counterparty);
                    if (dbEntry != null)
                    {
                        dbEntry.name = counterparty.name;
                        dbEntry.inn = counterparty.inn;
                        dbEntry.nomDogEGAIS = counterparty.nomDogEGAIS;
                        dbEntry.nomDogKKM = counterparty.nomDogKKM;
                        dbEntry.phoneNumber = counterparty.phoneNumber;
                        dbEntry.type = counterparty.type;
                        dbEntry.email = counterparty.email;
                        dbEntry.dateDogEGAIS = counterparty.dateDogEGAIS;
                    }
                }
                context.SaveChanges();
            
        }

        public Сounterparty DeleteСounterparty(int id_counterparty)
        {
            Сounterparty dbEntry = context.Сounterpartys.Find(id_counterparty);
            if (dbEntry != null)
            {
                context.Сounterpartys.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}


