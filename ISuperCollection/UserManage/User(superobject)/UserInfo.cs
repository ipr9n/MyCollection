namespace ISuperCollection.Partials
{
     partial class SuperObject
     {
        public string UserInfo { get; private set; }

        public string Username { get; private set; }
        public string Password { get; private set; }

        public SuperObject()
        {
            Username = "Noname";
        }

        partial void SetInfo(string text) => UserInfo = text;


        public void SetUsername(string name) => Username = name;

        public void SetPassword(string pass) => Password = pass;
    }
}
