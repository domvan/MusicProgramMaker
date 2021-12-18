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
    public class composerCanEdit
    {
        [Key]
        public int CceID { get; set; }

        [ForeignKey("Admin")]
        public int AdminID { get; set; }
        [Required]
        public virtual Admin Admin {get; set;}

        [ForeignKey("Composer")]
        public int CID { get; set; }
        [Required]
        public virtual Composer Composer { get; set; }
    }
}
