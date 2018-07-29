using Sample.Entity;
using Sample.Repo.DataContracts;
using Sample.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Service
{
   public class UserService :IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Get(int UserId)
        {
            return await _userRepository.GetAsync(UserId);
        }
        public virtual async Task<User> AddAsyn(User user)
        {
            return await _userRepository.AddAsyn(user);
        }
    }
}
