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
    public class CanView
    {
        [Key]
        public int CvID { get; set; }

        [ForeignKey("Guest")]
        public int GuestID { get; set; }
        [Required]
        public virtual Guest Guest { get; set; }

        [ForeignKey("Program")]
        public int PId { get; set; }
        [Required]
        public virtual MusicProgram Program { get; set; }
    }
}
