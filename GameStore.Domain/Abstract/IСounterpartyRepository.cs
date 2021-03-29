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
        IEnumerable<Сounterparty> Сounterpartys { get; }
        void SaveСounterparty(Сounterparty counterparty);
        Сounterparty DeleteСounterparty(int id_counterparty);
    }
}