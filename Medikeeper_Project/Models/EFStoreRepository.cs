using Medikeeper_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medikeeper_Project.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private WellnessShopContext context;

        public EFStoreRepository(WellnessShopContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Store> Stores => context.Store;
    }
}