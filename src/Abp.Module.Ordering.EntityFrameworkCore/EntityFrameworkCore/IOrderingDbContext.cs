﻿using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Module.Ordering.EntityFrameworkCore
{
    [ConnectionStringName(OrderingDbProperties.ConnectionStringName)]
    public interface IOrderingDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}