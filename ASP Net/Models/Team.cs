using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MusicMakerProgram.Models;

namespace MusicMakerProgram.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        [DisplayName("Group Biography")]
        public string Bio { get; set; }

        [DisplayName("Average Group Age")]
        public int Age { get; set; }
    }
}
