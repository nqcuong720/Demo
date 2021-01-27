// <copyright file="Class.cs" company="PlaceholderCompany">
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
    /// Class.
    /// </summary>
    [Table("Class")]
    public class Class
    {
        /// <summary>
        /// Gets or sets classId.
        /// </summary>
        [Key]
        public int ClassId { get; set; }

        /// <summary>
        /// Gets or sets className.
        /// </summary>
        public string ClassName { get; set; }
    }
}
