using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.Email
{
    public interface IEmailServices
    {
        Task SendEmail(string email, string subject, string message);
    }
}
