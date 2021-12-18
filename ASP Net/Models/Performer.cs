using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using MusicMakerProgram.Models;

namespace MusicMakerProgram.Models
{
    public class Performer
    {
        [Key]
        public int PerformerID { get; set; }

        [DisplayName("Performer Name")]
        public string Name { get; set; }

        [DisplayName("Performer Age")]
        public int Age { get; set; }

        [DisplayName("Performer Biography")]
        public string Bio { get; set; }

        [ForeignKey("Class")]
        [DisplayName("Class ID")]
        public int ClassID { get; set; }
        public virtual Class Class { get; set; }

        [ForeignKey("Level")]
        [DisplayName("Level ID")]
        public int LevelID { get; set; }
        public virtual Level Level { get; set; }
    }
}
