using Book_Project.Data;

namespace Book_Project.Model
{
    public class DbHelper
    {
        private BookDbContext _dbContext;

        public DbHelper(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }
         
        public List<User> getAllUsers() {
            List<User> users = new List<User>();
            var dataList = _dbContext.Users.ToList();
            dataList.ForEach(user => users.Add(new User()
            {
                UserId = user.UserId,
                Username = user.Username,
                Password = user.Password,
                RoleId = user.RoleId,
                Role = _dbContext.Roles.Where(d => d.RoleId.Equals(user.RoleId)).FirstOrDefault()
            })); 

            
            return users;
        }

        public void addUser(User user)
        {
            User dbTable = new User();  
            
                    dbTable.Username = user.Username;
                    dbTable.UserId= user.UserId;
                    dbTable.Password = user.Password;
                    dbTable.RoleId= user.RoleId;
                    dbTable.Role = _dbContext.Roles.Where(e => e.RoleId.Equals(user.RoleId)).FirstOrDefault();

                    _dbContext.Users.Add(dbTable);

                    _dbContext.SaveChanges();
                }
 
 

    }
}
