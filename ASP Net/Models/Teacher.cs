using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MusicMakerProgram.Models;

namespace MusicMakerProgram.Models
{
    public class Teacher
    {
        [Key]
        public int TID { get; set; }

        [DisplayName("Teacher School")]
        public string School { get; set; }

        [DisplayName("Teacher Biography")]
        public string Bio { get; set; }

        [DisplayName("Teacher Name")]
        public string Name { get; set; }
    }
}
