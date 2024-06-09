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
        public static Student FindById(int id)
        {
            return null; // Tìm học sinh theo ID     
        }

        public static void Create(string name, DateTime birthdate, bool gender, int classId)
        {
            // Tạo học sinh mới     
        }
        public static void Update(int id, string name, DateTime birthdate, bool gender, int classId)
        {
            // Tìm học sinh theo ID, sau đó update thông tin hoc sinh tìm được      
        }
        public static void Delete(int id)
        {
            // Tìm học sinh theo ID, sau đó xóa những bảng điểm liên quan đến học sinh, sau đó xóa học sinh     
        }
    }
}
