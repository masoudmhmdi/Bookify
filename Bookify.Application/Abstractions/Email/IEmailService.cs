using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bookify.Application.Abstractions.Email
{
     public interface IEmailService
    {
        public Task SendAsync(Domain.Users.Email email, string subject, string body);
    }
}
