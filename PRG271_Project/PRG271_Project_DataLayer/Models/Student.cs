using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_DataLayer.Models
{
    public class Student
    {
        public int? Number { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public byte? Image { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public List<Module>? Modules { get; set; }   

    }
}
