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
    public class SoloPerforms
    {
        [Key]
        public int SpID { get; set; }

        [ForeignKey("Performer")]
        public int PerformerID { get; set; }
        [Required]
        public virtual Performer Performer { get; set; }

        [ForeignKey("Performance")]
        public int PerfID { get; set; }
        [Required]
        public virtual Performance Performance { get; set; }
    }
}
