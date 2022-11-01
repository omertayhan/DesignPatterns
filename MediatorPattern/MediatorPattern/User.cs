namespace MediatorPattern
{
    public class User
    {
        public ChatroomMediator chatRoomMediator { get; set; }
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Send(string to, string message)
        {
            chatRoomMediator.Send(Name, to, message);
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: {2}", from, Name, message);
        }
    }
}
