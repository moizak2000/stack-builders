using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Entity
{
    public class User
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatationDate { get; set; }

    }
}

