using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_DataLayer.Models
{
    public class Module
    {
        public int Code { get; set; }
        public required string Name { get; set; }  
        public string? Description { get; set; }
        public string? URLLink { get; set; }
    }
}
