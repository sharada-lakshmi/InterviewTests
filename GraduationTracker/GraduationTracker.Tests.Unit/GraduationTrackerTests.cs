// <copyright file="GraduationTrackerTests.cs" company="Xello">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GraduationTracker.Tests.Unit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Graduation.BAL;
    using Graduation.Models;
    using Graduation.Utilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GraduationTrackerTests
    {
        /// <summary>
        /// test if the student is graduated
        /// </summary>
        [TestMethod]
        public void TestStudentHasGraduated()
        {
            var tracker = new GraduationTracker();

            var diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new int[] { 100, 102, 103, 104 }
            };

            var students = new[]
            {
               new Student
               {
                   Id = 1,
                   Courses = new Course[]
                   {
                        new Course{Id = 1, Name = "Math", Mark = 95 },
                        new Course{Id = 2, Name = "Science", Mark = 95 },
                        new Course{Id = 3, Name = "Literature", Mark = 95 },
                        new Course{Id = 4, Name = "Physichal Education", Mark = 95 }
                   }
               }
            };

            var graduated = new List<Tuple<bool, STANDING>>();

            foreach (var student in students)
            {
                // item 1 is the boolean value if the student is graduated or not based on the business logic
                Assert.IsTrue(tracker.HasGraduated(student, diploma).Item1 == true);
            }
        }

        /// <summary>
        /// test if the student is not graduated
        /// </summary>
        [TestMethod]
        public void TestStudentHasNotGraduated()
        {
            var tracker = new GraduationTracker();

            var diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new int[] { 100, 102, 103, 104 }
            };

            var students = new[]
            {
               new Student
               {
                   Id = 1,
                   Courses = new Course[]
                   {
                        new Course{Id = 1, Name = "Math", Mark = 0 },
                        new Course{Id = 2, Name = "Science", Mark = 0 },
                        new Course{Id = 3, Name = "Literature", Mark = 0 },
                        new Course{Id = 4, Name = "Physichal Education", Mark = 0 }
                   }
               }
            };

            foreach (var student in students)
            {
                // item 1 is the boolean value if the student is graduated or not based on the business logic
                Assert.IsTrue(tracker.HasGraduated(student, diploma).Item1 == false);
            }
        }

        /// <summary>
        /// test any student is graduated from the list
        /// </summary>
        [TestMethod]
        public void TestAnyStudentHasGraduated()
        {
            var tracker = new GraduationTracker();

            var diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new int[] { 100, 102, 103, 104 }
            };

            var students = new[]
            {
               new Student
               {
                   Id = 1,
                   Courses = new Course[]
                   {
                        new Course{Id = 1, Name = "Math", Mark = 95 },
                        new Course{Id = 2, Name = "Science", Mark = 95 },
                        new Course{Id = 3, Name = "Literature", Mark = 95 },
                        new Course{Id = 4, Name = "Physichal Education", Mark = 95 }
                   }
               },
               new Student
               {
                   Id = 2,
                   Courses = new Course[]
                   {
                        new Course{Id = 1, Name = "Math", Mark = 80 },
                        new Course{Id = 2, Name = "Science", Mark = 80 },
                        new Course{Id = 3, Name = "Literature", Mark = 80 },
                        new Course{Id = 4, Name = "Physichal Education", Mark = 80 }
                   }
               },
            new Student
            {
                Id = 3,
                Courses = new Course[]
                {
                    new Course{Id = 1, Name = "Math", Mark = 50 },
                    new Course{Id = 2, Name = "Science", Mark = 50 },
                    new Course{Id = 3, Name = "Literature", Mark = 50 },
                    new Course{Id = 4, Name = "Physichal Education", Mark = 50 }
                }
            },
            new Student
            {
                Id = 4,
                Courses = new Course[]
                {
                    new Course{Id = 1, Name = "Math", Mark = 40 },
                    new Course{Id = 2, Name = "Science", Mark = 40 },
                    new Course{Id = 3, Name = "Literature", Mark = 40 },
                    new Course{Id = 4, Name = "Physichal Education", Mark = 40 }
                }
            }
        };

            var graduated = new List<Tuple<bool, STANDING>>();
            bool isGraduated = false;
            foreach (var student in students)
            {
                // item 1 is the boolean value if the student is graduated or not based on the business logic
                if (tracker.HasGraduated(student, diploma).Item1 == true)
                {
                    isGraduated = true;
                    break;
                }
            }

            Assert.IsTrue(isGraduated);
        }

        /// <summary>
        /// test no one from the list is graduated
        /// </summary>
        [TestMethod]
        public void TestNoneStudentHasGraduated()
        {
            var tracker = new GraduationTracker();

            var diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new int[] { 100, 102, 103, 104 }
            };

            var students = new[]
            {
               new Student
               {
                   Id = 1,
                   Courses = new Course[]
                   {
                        new Course{Id = 1, Name = "Math", Mark = 0 },
                        new Course{Id = 2, Name = "Science", Mark = 0 },
                        new Course{Id = 3, Name = "Literature", Mark = 0 },
                        new Course{Id = 4, Name = "Physichal Education", Mark = 0 }
                   }
               },
               new Student
               {
                   Id = 2,
                   Courses = new Course[]
                   {
                        new Course{Id = 1, Name = "Math", Mark = 0 },
                        new Course{Id = 2, Name = "Science", Mark = 0 },
                        new Course{Id = 3, Name = "Literature", Mark = 0 },
                        new Course{Id = 4, Name = "Physichal Education", Mark = 0 }
                   }
               },
            new Student
            {
                Id = 3,
                Courses = new Course[]
                {
                    new Course{Id = 1, Name = "Math", Mark = 0 },
                    new Course{Id = 2, Name = "Science", Mark = 0 },
                    new Course{Id = 3, Name = "Literature", Mark = 0 },
                    new Course{Id = 4, Name = "Physichal Education", Mark = 0 }
                }
            },
            new Student
            {
                Id = 4,
                Courses = new Course[]
                {
                    new Course{Id = 1, Name = "Math", Mark = 0 },
                    new Course{Id = 2, Name = "Science", Mark = 0 },
                    new Course{Id = 3, Name = "Literature", Mark = 0 },
                    new Course{Id = 4, Name = "Physichal Education", Mark = 0 }
                }
            }
        };

            var graduated = new List<Tuple<bool, STANDING>>();

            bool isGraduated = false;
            foreach (var student in students)
            {
                // item 1 is the boolean value if the student is graduated or not based on the business logic
                if (tracker.HasGraduated(student, diploma).Item1 == true)
                {
                    isGraduated = true;
                    break;
                }
            }

            Assert.IsFalse(isGraduated);
        }

        /// <summary>
        /// test all students are graduated from the list
        /// </summary>
        [TestMethod]
        public void TestAllStudentsHasGraduated()
        {
            var tracker = new GraduationTracker();

            var diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new int[] { 100, 102, 103, 104 }
            };

            var students = new[]
            {
               new Student
               {
                   Id = 1,
                   Courses = new Course[]
                   {
                        new Course{Id = 1, Name = "Math", Mark = 95 },
                        new Course{Id = 2, Name = "Science", Mark = 95 },
                        new Course{Id = 3, Name = "Literature", Mark = 95 },
                        new Course{Id = 4, Name = "Physichal Education", Mark = 95 }
                   }
               },
               new Student
               {
                   Id = 2,
                   Courses = new Course[]
                   {
                        new Course{Id = 1, Name = "Math", Mark = 80 },
                        new Course{Id = 2, Name = "Science", Mark = 80 },
                        new Course{Id = 3, Name = "Literature", Mark = 80 },
                        new Course{Id = 4, Name = "Physichal Education", Mark = 80 }
                   }
               },
            new Student
            {
                Id = 3,
                Courses = new Course[]
                {
                    new Course{Id = 1, Name = "Math", Mark = 50 },
                    new Course{Id = 2, Name = "Science", Mark = 50 },
                    new Course{Id = 3, Name = "Literature", Mark = 50 },
                    new Course{Id = 4, Name = "Physichal Education", Mark = 50 }
                }
            },
            new Student
            {
                Id = 4,
                Courses = new Course[]
                {
                    new Course{Id = 1, Name = "Math", Mark = 40 },
                    new Course{Id = 2, Name = "Science", Mark = 40 },
                    new Course{Id = 3, Name = "Literature", Mark = 40 },
                    new Course{Id = 4, Name = "Physichal Education", Mark = 40 }
                }
            }
        };

            var graduated = new List<Tuple<bool, STANDING>>();
            bool isGraduated = true;
            foreach (var student in students)
            {
                // item 1 is the boolean value if the student is graduated or not based on the business logic
                if (tracker.HasGraduated(student, diploma).Item1 == false)
                {
                    isGraduated = false;
                    break;
                }
            }

            Assert.IsTrue(isGraduated);
        }
    }
}
