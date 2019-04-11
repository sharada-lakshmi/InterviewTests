// <copyright file="Diploma.cs" company="Xello">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Graduation.Models
{
    /// <summary>
    /// Diploma Model
    /// </summary>
    public class Diploma
    {
        public int Id { get; set; }

        public int Credits { get; set; }

        public int[] Requirements { get; set; }
    }
}
