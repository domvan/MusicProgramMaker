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
    public class Cellist
    {
        [Key]
        [ForeignKey("Performer")]
        [DisplayName("Cellist Name")]
        public int PerformerID { get; set; }
        [Required]
        public virtual Performer Performer { get; set; }

    }
}

