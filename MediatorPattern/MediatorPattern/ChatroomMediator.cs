namespace MediatorPattern
{
    public class ChatroomMediator : IChatroomMediator
    {
        private Dictionary<string, User> _user = new Dictionary<string, User>();

        public void Register(User user)
        {
            if (!_user.ContainsValue(user))
            {
                _user[user.Name] = user;
            }

            user.chatRoomMediator=this;
        }

        public void Send(string from, string to, string message)
        {
            User user = _user[to];

            if (user !=null)
            {
                user.Receive(from,message);
            }
        }
    }
}