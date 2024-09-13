using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Users
{
    internal interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid id, CancellationToken cancellation = default);

        void Add(User user);
    }
}
