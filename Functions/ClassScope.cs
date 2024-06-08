using Database_Connector;
using Entities;
using Functions.DTO;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Functions
{
    public static class ClassScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();
        public static List<Class> GetClass(string name = "")
        {
            return Db.Class.Where(classes => classes.Name.Contains(name)).ToList();

        }
        public static List<Class> GetGrade(int grade)
        {
            return Db.Class.Where(classes => classes.Grade == grade).ToList();
        }
        public static void AddClass(string name, int grade, string schoolYear)
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

        public static void EditClass(int id, string name, int grade, string schoolYear)
        {
            var classes = Db.Class.FirstOrDefault(classes => classes.Id == id);
            classes.Name = name;
            classes.Grade = grade;
            classes.SchoolYear = schoolYear;
            Db.Class.Update(classes);
            Db.SaveChanges();

        }
        public static Class GetClassById(int id) 
        { 
            return Db.Class.FirstOrDefault(classes => classes.Id == id);
            
        } 

        public static void DeleteClassById(int id)
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
    