using Database_Connector;
using Entities;

namespace Functions
{
    public static class UserScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();

        public static bool IsValid(string userName, string password)
        {
            return Db.User.Any(user => user.Username == userName && user.Password == password); // Trả về TRUE nếu tồn tại ít nhất 1 item thỏa mãn điều kiện
        }

        public static User GetByInfo(string userName, string password)
        {
            return Db.User.FirstOrDefault(user => user.Username == userName && user.Password == password);
        }
        public static int GetRoleId(int id)
        {
            return Db.User.FirstOrDefault(user => user.Id == id).RoleId;
        }
    }
}
