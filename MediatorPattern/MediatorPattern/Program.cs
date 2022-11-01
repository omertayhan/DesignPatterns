using System;
using MediatorPattern;

namespace MediatorChatroomSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatroomMediator chatroom = new ChatroomMediator();

            User Omer = new User("Omer");
            User Tufan = new User("Tufan");
            User Ayhan = new User("Ayhan");

            chatroom.Register(Omer);
            chatroom.Register(Tufan);
            chatroom.Register(Ayhan);

            Omer.Send("Ayhan","Merhaba.");
            Ayhan.Send("Omer","Merhaba, nasılsın");
            Tufan.Send("Ayhan","Teşekkürler, sen nasılsın");
            Omer.Send("Tufan", "Derslere baktın mı");
            Tufan.Send("Omer","Hayır");
            Omer.Send("Tufan", "Çabbuk bak");
            Tufan.Send("Omer", "Tabi Efendim");
        }
    }
}