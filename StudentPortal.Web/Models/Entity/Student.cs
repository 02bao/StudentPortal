﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPortal.Web.Models.Entity;

[Table("Student")]
public class Student
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Subscribe { get; set; }
}
