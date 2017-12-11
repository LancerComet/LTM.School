using LTM.School.Core.Models;
using LTM.School.Application.enumsType;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.EntityFramework.Data {
    /// <summary>
    /// 数据库初始化器 DbInitializer.
    /// </summary>
    public class DbInitializer {
        /// <summary>
        /// 数据库初始化静态方法.
        /// </summary>
        /// <param name="context"></param>
        public static void Initialize(SchoolDbContext context) {
            // 确保数据库已经创建.
            context.Database.EnsureCreated();

            // 添加种子数据.
            if (!context.Students.Any()) {
                var students = new Student[] {
                    new Student() {
                        Name = "LancerComet", EnrollmentDate = DateTime.Parse("2017-12-11")
                    },

                    new Student() {
                        Name = "Wch", EnrollmentDate = DateTime.Parse("2017-12-11")
                    }
                };

                foreach (Student item in students) {
                    context.Students.Add(item);
                }

                context.SaveChanges();
            }

            if (!context.Courses.Any()) {
                var courses = new Course[] {
                    new Course() {
                        Id = 1, Title = "Chinese", Credits = 2
                    },
                    new Course() {
                        Id = 2, Title = "English", Credits = 2
                    },
                    new Course() {
                        Id = 3, Title = "Math", Credits = 2
                    },
                    new Course() {
                        Id = 4, Title = "Physics", Credits = 1
                    },
                    new Course() {
                        Id = 5, Title = "Chemical", Credits = 1
                    }
                };

                foreach (Course item in courses) {
                    context.Courses.Add(item);
                }

                context.SaveChanges();
            }

            if (!context.Enrollments.Any()) {
                var enrollments = new Enrollment[] {
                    // For 学生 0.
                    new Enrollment() {
                        StudentId = 0, CourseId = 1, Grade = CourseGrade.B
                    },

                    new Enrollment() {
                       StudentId = 0, CourseId = 2, Grade = CourseGrade.A
                    },

                    new Enrollment() {
                        StudentId = 0, CourseId = 3, Grade = CourseGrade.C
                    },

                    // For 学生 1.
                    new Enrollment() {
                        StudentId = 1, CourseId = 1, Grade = CourseGrade.D
                    },

                    new Enrollment() {
                        StudentId = 1, CourseId = 4, Grade = CourseGrade.E
                    },

                    new Enrollment() {
                        StudentId = 1, CourseId = 5, Grade = CourseGrade.F
                    }
                };

                foreach (Enrollment item in enrollments) {
                    context.Enrollments.Add(item);
                }

                context.SaveChanges();
            }
        }
    }
}
