using BookProject.Models;
using BookProject.Service.IService;

namespace BookProject.Service
{
    public class UserService : IUserService
    {
        public readonly List<NewUser> _users = new()
        {
            new NewUser { UserName = "sumit", Password = "1234", Role = "Admin" },
            new NewUser { UserName = "sumit2", Password = "user", Role = "User" }
        };

        public NewUser Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(x => x.UserName == username && x.Password == password);
        }

        public IEnumerable<NewUser> GetAll()
        {
            return _users;
        }
    }
}