using Ardalis.Result;
using MessagesSenders.SendersImplementations;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MessagesSenders.SMS.SendersImplementations
{
    internal class SMSMessageSender : IMessageSender
    {
        private readonly IConfiguration _config;

        public SMSMessageSender(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IMessageSenderService GetService(MessageServices service)
        {
            switch (service)
            {
                case MessageServices.ePochta:
                    return new EPochtaMessageService(_config.GetSection(Resources.Config.ePochta).GetValue<string>(Resources.Config.Token));
                default:
                    throw new NotSupportedException();
            }

        }
    }
}
