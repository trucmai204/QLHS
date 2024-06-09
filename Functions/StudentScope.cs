using Database_Connector;
using Entities;

namespace Functions
{
    public static class StudentScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();

        public static List<DTO.StudentDTO> FindByName(string name = "")
        {
            return null; // Tìm học sinh theo tên            

        }
    }
}
