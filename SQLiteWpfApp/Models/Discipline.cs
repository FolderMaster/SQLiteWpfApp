﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLiteWpfApp.Models
{
    [Table("Disciplines")]
    [PrimaryKey(nameof(ID))]
    public class Discipline
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int HoursCount { get; set; }

        public Specialty Specialty { get; set; }

        public StudyForm StudyForm { get; set; }
    }
}