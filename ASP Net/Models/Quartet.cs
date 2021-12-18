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
    public class Quartet
    {
        [Key]
        [ForeignKey("Team")]
        public int GID { get; set; }
        [Required]
        public virtual Team Team { get; set; }

        [ForeignKey("Violinist")]
        [DisplayName("First Violinist Name")]
        public int FirstViolin { get; set; }
        [Required]
        public virtual Violinist FViolinist { get; set; }

        [ForeignKey("Violinist")]
        [DisplayName("Second Violinist Name")]
        public int SecondViolin { get; set; }
        [Required]
        public virtual Violinist SViolinist { get; set; }

        [ForeignKey("Violist")]
        [DisplayName("Violist Name")]
        public int Violist { get; set; }
        [Required]
        public virtual Violist ViolistObj { get; set; }

        [ForeignKey("Cellist")]
        [DisplayName("Cellist Name")]
        public int Cellist { get; set; }
        [Required]
        public virtual Cellist CellistObj { get; set; }
    }
}


