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
    public class GroupCanEdit
    {
        [Key]
        public int GceID { get; set; }

        [ForeignKey("Admin")]
        public int AdminID { get; set; }
        [Required]
        public virtual Admin Admin { get; set; }

        [ForeignKey("Team")]
        public int GID { get; set; }
        [Required]
        public virtual Team Team { get; set; }
    }
}
