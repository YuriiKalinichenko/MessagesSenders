using System.Threading.Tasks;
using Ardalis.Result;

namespace MessagesSenders
{
    public interface IMessageSender
    {
        public Task<IResult> Send();
    }
}
