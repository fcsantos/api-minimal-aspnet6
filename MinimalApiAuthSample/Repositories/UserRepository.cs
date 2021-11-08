using MinimalApiAuthSample.Models;

namespace MinimalApiAuthSample.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User{ Id = 1, Username = "userteste1", Password = "userteste1", Role = "manager" },
                new User{ Id = 2, Username = "userteste2", Password = "userteste2", Role = "employee" }
            };

            return users.Where(x => x.Username.ToLower() == username.ToLower() && 
                                    x.Password == password).FirstOrDefault();
        }
    }
}
