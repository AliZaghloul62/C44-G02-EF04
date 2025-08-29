using ConsoleApp1.AppDbContext;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1.Seeding
{
    public class DataSeeding
    {
        public static bool DataSeed(ApplicationDbContext dbContext)
        {
            try
            {
                #region Departments
                if (!dbContext.Departments.Any())
                {
                    var DeptsData = File.ReadAllText("Files\\departments.json");
                    var departments = JsonSerializer.Deserialize<List<Department>>(DeptsData);

                    if (departments?.Count > 0)
                    {
                        dbContext.Departments.AddRange(departments);
                        dbContext.SaveChanges();
                    }

                }
                #endregion
                #region Students
                if (!dbContext.Students.Any())
                {
                    var StudsData = File.ReadAllText("Files\\students.json");
                    var Students = JsonSerializer.Deserialize<List<Student>>(StudsData);

                    if (Students?.Count > 0)
                    {
                        dbContext.Students.AddRange(Students);
                        dbContext.SaveChanges();
                    }

                }
                #endregion
                #region Topics
                if (!dbContext.Topics.Any())
                {
                    var TopicsData = File.ReadAllText("Files\\topics.json");
                    var Topics = JsonSerializer.Deserialize<List<Topic>>(TopicsData);

                    if (Topics?.Count > 0)
                    {
                        dbContext.Topics.AddRange(Topics);
                        dbContext.SaveChanges();
                    }

                }
                #endregion

                #region Instructors
                if (!dbContext.Instructors.Any())
                {
                    var InstructorsData = File.ReadAllText("Files\\instructors.json");
                    var Instructors = JsonSerializer.Deserialize<List<Instructor>>(InstructorsData);

                    if (Instructors?.Count > 0)
                    {
                        dbContext.Instructors.AddRange(Instructors);
                        dbContext.SaveChanges();
                    }

                }
                #endregion

                #region Courses
                if (!dbContext.Courses.Any())
                {
                    var CoursesData = File.ReadAllText("Files\\courses.json");
                    var Courses = JsonSerializer.Deserialize<List<Course>>(CoursesData);

                    if (Courses?.Count > 0)
                    {
                        dbContext.Courses.AddRange(Courses);
                        dbContext.SaveChanges();
                    }

                }
                #endregion

                #region Courses
                if (!dbContext.Courses.Any())
                {
                    var CoursesData = File.ReadAllText("Files\\courses.json");
                    var Courses = JsonSerializer.Deserialize<List<Course>>(CoursesData);

                    if (Courses?.Count > 0)
                    {
                        dbContext.Courses.AddRange(Courses);
                        dbContext.SaveChanges();
                    }

                }
                #endregion

                #region Stud_Courses
                if (!dbContext.Stud_Courses.Any())
                {
                    var Stud_CoursesData = File.ReadAllText("Files\\studentCourses.json");
                    var Stud_Courses = JsonSerializer.Deserialize<List<StudentCourse>>(Stud_CoursesData);

                    if (Stud_Courses?.Count > 0)
                    {
                        dbContext.Stud_Courses.AddRange(Stud_Courses);
                        dbContext.SaveChanges();
                    }

                }
                #endregion

                #region Course_Insts
                if (!dbContext.Course_Insts.Any())
                {
                    var Course_InstsData = File.ReadAllText("Files\\courseInstructors.json");
                    var Course_Insts = JsonSerializer.Deserialize<List<Course_Inst>>(Course_InstsData);

                    if (Course_Insts?.Count > 0)
                    {
                        dbContext.Course_Insts.AddRange(Course_Insts);
                        dbContext.SaveChanges();
                    }

                }
                #endregion

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}