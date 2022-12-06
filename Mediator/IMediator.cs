namespace Mediator
{
    public interface IMediator
    {
        public void Notify(Component sender, string eventDescription);
    }
}