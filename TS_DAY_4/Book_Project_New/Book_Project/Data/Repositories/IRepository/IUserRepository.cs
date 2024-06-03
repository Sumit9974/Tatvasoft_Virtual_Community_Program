using Book_Project.Model;

namespace Book_Project.Data.Repositories.IRepository
{
    public interface IUserRepository
    {
        public List<User> GetAllUsersFromDatabase();
        public void AddUser(User user);
        public List<IGrouping<string, User>> GetUsersGroupedByRole();



    }
}
