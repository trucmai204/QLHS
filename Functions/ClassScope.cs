using Database_Connector;
using Entities;


namespace Functions
{
    public static class ClassScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();
        public static List<Class> FindByName(string name = "")
        {
            return Db.Class.Where(classes => classes.Name.Contains(name)).ToList();
        }

        public static List<string> GetNames()
        {
            return Db.Class.Select(classes => classes.Name).Distinct().ToList();
        }

        public static List<int> GetGrades()
        {
            return Db.Class.Select(classes => classes.Grade).Distinct().ToList();
        }

        public static List<string> GetSchoolYears()
        {
            return Db.Class.Select(classes => classes.SchoolYear).Distinct().ToList();
        }

        public static List<Class> FindBySchoolYear(string schoolYear)
        {
            return Db.Class.Where(classes => classes.SchoolYear.Contains(schoolYear)).ToList();
        }
        public static List<Class> FindByGrade(int? grade)
        {
            if (grade == null)
            {
                return Db.Class.ToList();
            }
            return Db.Class.Where(classes => classes.Grade == grade).ToList();
        }
        public static Class FindById(int id)
        {
            return Db.Class.FirstOrDefault(classes => classes.Id == id);
        }

        public static void Create(string name, int grade, string schoolYear)
        {
            var classes = new Class
            {
                Name = name,
                Grade = grade,
                SchoolYear = schoolYear
            };
            Db.Class.Add(classes);
            Db.SaveChanges();
        }
        public static void Update(int id, string name, int grade, string schoolYear)
        {
            var classes = Db.Class.FirstOrDefault(classes => classes.Id == id);
            classes.Name = name;
            classes.Grade = grade;
            classes.SchoolYear = schoolYear;
            Db.Class.Update(classes);
            Db.SaveChanges();

        }
        public static void Delete(int id)
        {
            var transcripts = Db.Transcript.Where(transcript => transcript.Student.ClassId == id).ToList();
            foreach (var transcript in transcripts)
            {
                Db.Transcript.Remove(transcript);
            }

            var students = Db.Student.Where(student => student.ClassId == id).ToList();
            foreach (var student in students)
            {
                Db.Student.Remove(student);
            }

            var grade = Db.Class.FirstOrDefault(grade => grade.Id == id);
            if (grade != null)
            {
                Db.Class.Remove(grade);
                Db.SaveChanges();
            }

        }
    }
}
