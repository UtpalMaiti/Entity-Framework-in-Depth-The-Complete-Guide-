﻿
using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            PlutoContext context = new PlutoContext();

            var courses = context.Courses.ToList();

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Name} by {course.Author.Name}");
            }
            Console.Read();
        }
    }

}
