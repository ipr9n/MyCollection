using System;
using ISuperCollection.Partials;

namespace ISuperCollection.Site
{
    class MySite
    {
        SuperCollection<SuperObject> users = new SuperCollection<SuperObject>();
        public void Main()
        {
            SuperObject.AddErrorMethod(ConsoleOutput);
            SuperObject testUser = new SuperObject();
            testUser.SetUsername("pr9n");
            testUser.SetPassword("pass");

            users.Add(testUser);

            users[0].AddToFriend(new SuperObject());
            Login("pr9n","pass");
            users[0].AddToFriend(new SuperObject());

        }

        private void Login(string username, string password)
        {
            foreach (SuperObject user in users)
            {
                if (username == user.Username && password == user.Password)
                {
                    user.Login();
                    break;
                }
            }
        }

        private void ConsoleOutput(string text)
        {
            Console.WriteLine(text);
        }
    }
}
