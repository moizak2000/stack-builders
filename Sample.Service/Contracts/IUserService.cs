using Sample.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Service.Contracts
{
    public interface IUserService
    {
        Task<User> Get(int UserId);
        Task<User> AddAsyn(User users);
    }
}
