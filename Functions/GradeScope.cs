using Database_Connector;

namespace Functions
{
    public class GradeScope
    {
        public AppDbContext Context { get; set; } = new AppDbContext();
        public int GetAllGradeCount()
        {
            return Context.NguoiDung.Count();
        }
    }
}
