using Ardalis.Result;
using MessagesSenders.MessageTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MessagesSenders.SendersImplementations
{
    internal class EPochtaMessageService : IMessageSenderService
    {
        private readonly string _token;

        public EPochtaMessageService(string token)
        {
            _token = token;
        }

        public Task<IResult> SendText(TextMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
