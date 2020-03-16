using ISuperCollection.Partials;
using System;

namespace ISuperCollection.Extensions
{
    static class SuperObjectExtensions
    {
        public static void ShowFriends(this SuperObject sup)
        {
            for (int i = 0; i < sup.friends.Count; i++)
            {
                Console.WriteLine(sup.friends[i].Username);
            }
        }
    }
}
