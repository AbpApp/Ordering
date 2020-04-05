﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.Module.Ordering.MongoDB
{
    [ConnectionStringName(OrderingDbProperties.ConnectionStringName)]
    public interface IOrderingMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
