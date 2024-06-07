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
        public static List<ClassDTO> GetClass(string name)
        {
            return Db.Class.Where(classes => classes.Name.Contains(name)).Select(classes => new ClassDTO
            {
                Id = classes.Id,
                StudentName = classes.Student.Name,
                ClassName = classes.Name,
                Grade = classes.Grade,
            }).ToList;

        }
    }
}
    