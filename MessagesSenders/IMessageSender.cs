namespace MessagesSenders
{
    public interface IMessageSender
    {
        IMessageSenderService GetService(MessageServices service);
    }

}
