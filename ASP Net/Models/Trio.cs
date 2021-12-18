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
    public class Trio
    {
        [Key]
        [ForeignKey("Team")]
        public int GID { get; set; }
        [Required]
        public virtual Team Team { get; set; }

        [ForeignKey("Violinist")]
        [DisplayName("Violinist Name")]
        public int Violinist { get; set; }
        [Required]
        public virtual Violinist ViolinistObj { get; set; }

        [ForeignKey("Cellist")]
        [DisplayName("Cellist Name")]
        public int Cellist { get; set; }
        [Required]
        public virtual Cellist CellistObj { get; set; }

        [ForeignKey("Pianist")]
        [DisplayName("Pianist Name")]
        public int Pianist { get; set; }
        [Required]
        public virtual Pianist PianistObj { get; set; }
    }
}


