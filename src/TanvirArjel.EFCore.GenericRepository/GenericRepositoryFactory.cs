using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TanvirArjel.EFCore.GenericRepository
{
    public class GenericRepositoryFactory
    {
        public static IRepository<T> CreateRepository<T>(T dbContext) where T : DbContext
        {
            IRepository<T> ret = new Repository<T>(dbContext);
            return ret;
        }
    }
}
