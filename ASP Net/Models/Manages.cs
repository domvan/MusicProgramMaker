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
    public class Manages
    {
        [Key]
        public int ManagesID { get; set; }

        [ForeignKey("Admin")]
        public int AdminID { get; set; }
        [Required]
        public virtual Admin Admin { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }
        [Required]
        public virtual Class Class { get; set; }
    }
}
