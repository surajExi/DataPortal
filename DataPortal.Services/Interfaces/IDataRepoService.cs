using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPortal.Services.Interfaces
{
    public interface IDataRepoService<T> where T : class
    {
        /// <summary>
        /// Gets all the data based on the Entity type being queried
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Returns the Entity of type T after querying based on the entity ID
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        T GetByID(long entityId);
    }
}
