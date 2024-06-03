using Book_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace Book_Project.Data.Repositories.IRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly BookDbContext _context;

        public UserRepository(BookDbContext context)
        {
            _context = context;
        }

        
        public List<User> GetAllUsersFromDatabase()
        {
            List<User> users = new List<User>();
            var dataList = _context.Users.ToList();
            dataList.ForEach(user => users.Add(new User()
            {
                UserId = user.UserId,
                Username = user.Username,
                Password = user.Password,
                RoleId = user.RoleId,
                Role = _context.Roles.Where(d => d.RoleId.Equals(user.RoleId)).FirstOrDefault()
            }));


            return users;
        }


        public void AddUser(User user)
        {
            User dbTable = new User();

            dbTable.Username = user.Username;
            dbTable.UserId = user.UserId;
            dbTable.Password = user.Password;
            dbTable.RoleId = user.RoleId;
            dbTable.Role = _context.Roles.Where(e => e.RoleId.Equals(user.RoleId)).FirstOrDefault();

            _context.Users.Add(dbTable);

            _context.SaveChanges();
        }

      

        public List<IGrouping<string, User>> GetUsersGroupedByRole()
        {
            return _context.Users.GroupBy(u => u.Role.RoleName).ToList();
        }

   
    }
}
