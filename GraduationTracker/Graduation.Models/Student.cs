// <copyright file="Student.cs" company="Xello">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Graduation.Models
{
    using Graduation.Utilities;

    /// <summary>
    /// Student Model
    /// </summary>
    public class Student
    {
        public int Id { get; set; }

        public Course[] Courses { get; set; }

        public STANDING Standing { get; set; } = STANDING.None;
    }
}
