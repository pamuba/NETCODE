﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    /// <summary>
    /// Person domain model class
    /// </summary>
    public class Person
    {
        [Key]
        public Guid PersonID { get; set; }
        //nvarchar(max)
        [StringLength(40)]
        public string? PersonName { get; set; }
        [StringLength(40)]
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [StringLength(10)]
        public string? Gender { get; set; }
        //uniqueidentifier
        public Guid? CountryID { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        //bit
        public bool ReceiveNewsLetters { get; set; }
       
        public string? TIN { get; set; }
    }
}