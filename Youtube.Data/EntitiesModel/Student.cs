// <copyright file="Student.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Youtube.Data.EntitiesModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// Student.
    /// </summary>
    [Table("Student")]
    public class Student
    {
        /// <summary>
        /// Gets or sets studentId.
        /// </summary>
        [Key]
        public int StudentId { get; set; }

        /// <summary>
        /// Gets or sets studentName.
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        public string Address { get; set; }
    }
}
