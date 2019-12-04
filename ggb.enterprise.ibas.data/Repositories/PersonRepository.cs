
using System;
using System.Collections.Generic;
using ggb.enterprise.ibas.model.Models;
using ggb.enterprise.ibas.common.data;


namespace ggb.enterprise.ibas.data.Repositories
{
	public interface IPersonRepository : IRepository<Person , int>
    {
    }

	public class PersonRepository : RepositoryBase<Person , int>, IPersonRepository
    {
        public PersonRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}