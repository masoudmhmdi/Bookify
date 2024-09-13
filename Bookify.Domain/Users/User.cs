using Bookify.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Users
{
    public class User : Entity
    {
        public User(Guid guid, FirstName firstName, LastName lastName, Email email) : base(guid)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }   

        public FirstName FirstName { get; private set; }
        public LastName LastName { get; private set; }
        public Email Email { get; private set; }

        public User Create (Guid guid,FirstName firstName, LastName lastName ,Email email)
        {
            var user = new User (guid,firstName,lastName,email);

            return user;
        }
    }
}
