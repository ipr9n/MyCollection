using System;
using ISuperCollection.Site;

namespace ISuperCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            MySite mySite = new MySite();
            mySite.Main();
            //SuperObject user = new SuperObject();
            //user.SetUsername("Lesha");
            //user.SetPassword("123");

            //SuperObject user2 = new SuperObject();
            //user2.SetUsername("Misha");
            //user2.SetPassword("1234");

            //user2.AddToFriend(user);

            //user2.ShowFriends();

            Console.ReadKey();
        }
    }
}
