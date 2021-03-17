﻿using GameStore.Domain.Entities;
using System.Data.Entity;

namespace GameStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Сounterpartys> Сounterpartys { get; set; }
    }
}
