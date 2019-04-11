// <copyright file="Course.cs" company="Xello">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Graduation.Models
{
    /// <summary>
    /// Course Model
    /// </summary>
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Mark { get; set; }

        public int Credits { get; }
     }
}
