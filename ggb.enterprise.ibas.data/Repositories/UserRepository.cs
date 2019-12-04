
using System;
using System.Collections.Generic;
using ggb.enterprise.ibas.model.Models;
using ggb.enterprise.ibas.common.data;

namespace ggb.enterprise.ibas.data.Repositories
{
    public interface IUserRepository : IRepository<User, int>
    {
    }

    public class UserRepository : RepositoryBase<User, int>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}