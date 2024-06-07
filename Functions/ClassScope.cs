using Database_Connector;
using Entities;
using Functions.DTO;
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
        public static List<Class> GetClass(string name)
        {
            return Db.Class.Where(classes => classes.Name.Contains(name)).ToList();

        }
        public static List<Class> GetGrade(int grade)
        {
            return Db.Class.Where(classes => classes.Grade == grade).ToList();
        }
      
        public static void DeleteClassById(int Id)
        {
            var grade = Db.Class.FirstOrDefault(grade => grade.Id == Id);
            if (grade != null)
            {
                Db.Class.Remove(grade);
                Db.SaveChanges();
            }
          
        }
    }
}
    