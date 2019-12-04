
using System;
using System.Collections.Generic;
using ggb.enterprise.ibas.model.Models;
using ggb.enterprise.ibas.common.data;


namespace ggb.enterprise.ibas.data.Repositories
{
	public interface IEnum_listRepository : IRepository<Enum_list,int>
    {
    }
    public class Enum_listRepository : RepositoryBase<Enum_list,int>, IEnum_listRepository
    {
        public Enum_listRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}