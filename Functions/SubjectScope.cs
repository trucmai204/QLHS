using Database_Connector;
using Entities;

namespace Functions
{
    public static class SubjectScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();
        public static List<Subject> Find(short? semester, string name = "")
        {
            if (semester == null)
            {
                return Db.Subject.Where(subjects => subjects.Name.Contains(name)).ToList();
            }
            return Db.Subject.Where(subjects => subjects.Name.Contains(name) && subjects.Semester == semester).ToList();

        }
        public static List<string> GetNames()
        {
            return Db.Subject.Select(subject => subject.Name).Distinct().ToList();
        }
        public static List<string> GetSemesters()
        {
            return Db.Subject.Select(subject => subject.Semester.ToString()).Distinct().ToList();
        }

        public static Subject FindById(int id) => Db.Subject.FirstOrDefault(subjects => subjects.Id == id);

        public static void Update(int id, string name, double midtermWeight, double finalWeight, short semester)
        {
            var subjects = Db.Subject.FirstOrDefault(subjects => subjects.Id == id);
            subjects.Name = name;
            subjects.MidtermWeight = midtermWeight / 100;
            subjects.FinalWeight = finalWeight / 100;
            subjects.Semester = semester;

            Db.Subject.Update(subjects);
            Db.SaveChanges();
        }

        public static void Delete(int id)
        {
            var transcripts = Db.Transcript.Where(transcript => transcript.SubjectId == id);
            if (transcripts.Any())
            {
                Db.Transcript.RemoveRange(transcripts);
            }


            var subjects = Db.Subject.FirstOrDefault(subjects => subjects.Id == id);
            Db.Subject.Remove(subjects);
            Db.SaveChanges();
        }
    }
}
