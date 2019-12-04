
using System;
using System.Collections.Generic;
using ggb.enterprise.ibas.model.Models;
using ggb.enterprise.ibas.common.data;


namespace ggb.enterprise.ibas.data.Repositories
{
	public interface IUser_deviceRepository : IRepository<User_device , int>
    {
    }

	public class User_deviceRepository : RepositoryBase<User_device , int>, IUser_deviceRepository
    {
        public User_deviceRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}