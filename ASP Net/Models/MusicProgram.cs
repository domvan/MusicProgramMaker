using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MusicMakerProgram.Models;

namespace MusicMakerProgram.Models
{
    public class MusicProgram
    {
        [Key]
        public int PID { get; set; }

        public int NumPerformers { get; set; }
    }
}
