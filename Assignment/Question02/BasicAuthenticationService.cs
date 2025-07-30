namespace Assignment.Question02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        User[] users =  {
            new User() { Name = "Edward", Password = "1234", Role = "admin" },
            new User() { Name = "Ahmed", Password = "1234", Role = "user" },
            new User() { Name = "Ali", Password = "1234", Role = "user" },
        };

        public bool AuthenticateUser(string username, string password)
        {
            foreach (var user in users)
            {
                if (username == user.Name && password == "1234") return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string password)
        {
            if (this.AuthenticateUser(username, password))
            {
                foreach (var user in users)
                {
                    if (username == user.Name && user.Role == "Admin") return true;
                }
            }
            return false;
        }
    }
}
