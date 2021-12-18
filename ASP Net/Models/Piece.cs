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
    public class Piece
    {
        [Key]
        public int PieceID { get; set; }

        public string PName { get; set; }

        [DisplayName("Piece Information")]
        public string Info { get; set; }

        [DisplayName("Year Written")]
        public int Date { get; set; }

        [DisplayName("Genre")]
        public string Genre { get; set; }

        [DisplayName("Link")]
        public string MusicSheetLink { get; set; }

        [ForeignKey("Composer")]
        [DisplayName("Composer Name")]
        public int CID { get; set; }
        public virtual Composer Composer { get; set; }
    }
}
