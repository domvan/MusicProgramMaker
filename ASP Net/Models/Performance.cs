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
    public class Performance
    {
        [Key]
        public int PerfID { get; set; }

        public string Perf_name { get; set; }

        [ForeignKey("Program")]
        [DisplayName("Program ID")]
        public int PID { get; set; }
        public virtual MusicProgram MusicProgram { get; set; }

        [ForeignKey("Piece")]
        [DisplayName("Piece Name")]
        public int PieceID { get; set; }
        public virtual Piece Piece { get; set; }

    }
}
