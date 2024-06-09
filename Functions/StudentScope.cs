using Database_Connector;
using Entities;
using Functions.DTO;

namespace Functions
{
    public static class StudentScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();

        public static List<DTO.StudentDTO> FindByName(string name = "")
        {
            return Db.Student.Where(student => student.Name.Contains(name)).Select(student => new StudentDTO
            {
                Id = student.Id,
                StudentName = student.Name,
                Birthdate = student.Birthdate,
                Gender = student.Gender,
                ClassName = student.Class.Name,
                Grade = student.Class.Grade,
                SchoolYear = student.Class.SchoolYear,
            }).ToList();
            
        }
        public static Student FindById(int id)
        {
            return Db.Student.FirstOrDefault(x => x.Id == id);     
        }

        public static void Create(string name, DateTime birthdate, bool gender, int classId)
        {
            var students = new Student
            {
                Name = name,
                Birthdate = birthdate,
                Gender = gender,
                ClassId = classId
            }; 
            Db.Student.Add(students);
            Db.SaveChanges();
        }
        public static void Update(int id, string name, DateTime birthdate, bool gender, int classId)
        {
            var students = Db.Student.FirstOrDefault(students => students.Id == id);
            students.Name = name;   
            students.Birthdate = birthdate;
            students.Gender = gender;
            students.ClassId = classId;
            Db.Student.Update(students);
            Db.SaveChanges();
        }
        public static void Delete(int id)
        {
            var transcripts = Db.Transcript.Where(transcript => transcript.StudentId == id);
            if (transcripts.Any())
            {
                Db.Transcript.RemoveRange(transcripts);
            }

            var students = Db.Student.FirstOrDefault(students => students.Id == id);
            if(students != null)
            {
                Db.Student.Remove(students);
                Db.SaveChanges();
            }
           


        }
    }
}
