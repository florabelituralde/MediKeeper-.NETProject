using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medikeeper_Project.Models
{
    public interface IStoreRepository
    {
        IQueryable<Store> Stores { get; }
    }
}