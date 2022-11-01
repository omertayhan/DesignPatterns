namespace MediatorPattern
{
    public interface IChatroomMediator
    {
        public void Register(User user);
        public void Send(string from, string to, string message);
    }
}