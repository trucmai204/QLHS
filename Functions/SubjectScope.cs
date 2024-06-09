using Database_Connector;

namespace Functions
{
    public static class SubjectScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();
    }
}
