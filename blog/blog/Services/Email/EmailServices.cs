using blog.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.Email
{
    public class EmailServices : IEmailServices
    {
        private readonly SmtpSettings _settings;
        private readonly SmtpClient _client;

        public EmailServices(IOptions<SmtpSettings> options)
        {
            _settings = options.Value;
            _client = new SmtpClient(_settings.Server)
            {
                Credentials = new NetworkCredential(_settings.Username, _settings.Password),
            };
        }
        public Task SendEmail(string email, string subject, string message)
        {
            var mailMessage = new MailMessage(_settings.From, email, subject, message);
            return _client.SendMailAsync(mailMessage);    
        }
    }
}
