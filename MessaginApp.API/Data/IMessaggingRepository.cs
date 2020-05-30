using System.Collections.Generic;
using System.Threading.Tasks;
using MessaginApp.API.Models;

namespace MessaginApp.API.Data
{
    public interface IMessaggingRepository
    {
         void Add<T>(T entity) where T:class;
         void Delete<T>(T entity) where T:class;
         Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        
    }
}