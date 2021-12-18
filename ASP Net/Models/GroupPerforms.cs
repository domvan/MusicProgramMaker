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
    public class GroupPerforms
    {
        [Key]
        public int GpID { get; set; }

        [ForeignKey("Team")]
        public int GID { get; set; }
        [Required]
        public virtual Team Team { get; set; }

        [ForeignKey("Performance")]
        public int PerfID { get; set; }
        [Required]
        public virtual Performance Performance { get; set; }
    }
}
