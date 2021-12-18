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
    public class Knows
    {
        [Key]
        public int KnowsID { get; set; }

        [ForeignKey("Performer")]
        public int PerformerID { get; set; }
        [Required]
        public virtual Performer Performer { get; set; }

        [ForeignKey("Piece")]
        public int PieceID { get; set; }
        [Required]
        public virtual Piece Piece { get; set; }
    }
}
