using Database_Connector;

namespace Functions
{
    public class StudentScope
    {
        private AppDbContext Context { get; set; } = new AppDbContext();
    }
}
