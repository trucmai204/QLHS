﻿using Database_Connector;
using Entities;

namespace Functions
{
    public static class StudentScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();

        public static List<Student> GetStudentBy(string name)
        {
            return null;            

        }
    }
}
