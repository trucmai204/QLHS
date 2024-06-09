using Database_Connector;

namespace Functions
{
    public static class UserScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();

        public static bool IsValid(string userName, string password)
        {
            return Db.User.Any(user => user.Username == userName && user.Password == password); // Trả về TRUE nếu tồn tại ít nhất 1 item thỏa mãn điều kiện
        }
    }
}
