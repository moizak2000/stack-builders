using Sample.Entity;
using Sample.Repo.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Repo
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {

        }
    }
}
