using RecruitFlow.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {

        Task<T?> GetByIdAsync(Guid id);

        Task<IEnumerable<T>> GetAllAsync(PaginationRequest paginationRequest);

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}
