using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Abstract
{
    public interface IСounterpartyRepository
    {
        IEnumerable<Сounterpartys> Сounterpartys { get; }
        void SaveСounterpartys(Сounterpartys counterparty);
        Сounterpartys DeleteСounterpartys(int id_counterparty);
    }
}