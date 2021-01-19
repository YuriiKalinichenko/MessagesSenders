using System.Threading.Tasks;
using Ardalis.Result;
using MessagesSenders.MessageTypes;

namespace MessagesSenders
{
    public interface IMessageSenderService
    {
        public Task<IResult> SendText(TextMessage message);
    }

}
