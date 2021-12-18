using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MusicMakerProgram.Models;

using System.ComponentModel;

namespace MusicMakerProgram.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }

        [DisplayName("Number Of Student")]
        public int NumberOfStudents { get; set; }

        [ForeignKey("Teacher")]
        [DisplayName("Teacher Name")]
        public int TID { get; set; } 

    }
}
