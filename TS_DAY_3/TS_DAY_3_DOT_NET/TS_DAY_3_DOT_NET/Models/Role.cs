namespace TS_DAY_3_DOT_NET.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
