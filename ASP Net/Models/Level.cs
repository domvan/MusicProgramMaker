using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MusicMakerProgram.Models;

namespace MusicMakerProgram.Models
{
    public class Level
    {
        [Key]
        public int LevelID { get; set; }

        [DisplayName("Years of Expirience")]
        public string YearsOfExpirience { get; set; }
    }
}
