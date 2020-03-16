using System;

namespace ISuperCollection.Partials
{
   partial class SuperObject
    {
        public readonly SuperCollection<SuperObject> friends = new SuperCollection<SuperObject>();
        public bool login { get; private set; } = false;

        private static Action<string> errorAction;

        partial void SetInfo(string text);

        public void Login()
        {
            login = true;
            errorAction("Login succesfully");
        }

        public static void AddErrorMethod(Action<string> method)
        {
            errorAction += method;
        }

        public void DeleteFriend(SuperObject friend)
        {
            if (login)
            {
                if (friends.Contains(friend))
                {
                    friends.Remove(friend);
                    errorAction("Friend removed");
                }
                else
                {
                    errorAction("Friend not found");
                }
            }
            else
            {
                errorAction("Error. Please login");
            }
        }

        public void AddToFriend(SuperObject target)
        {
            if (login)
            {
                if (!friends.Contains(target))
                {
                    friends.Add(target);
                    errorAction("Friend added");
                }
                else
                {
                    errorAction("This already your friend");
                }
                
            }
            else
            {
                errorAction("Error, please login");
            }
        }
    }
}
