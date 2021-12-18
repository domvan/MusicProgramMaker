﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using MusicMakerProgram.Models;

namespace MusicMakerProgram.Models
{
    public class Pianist
    {
        [Key]
        [ForeignKey("Performer")]
        [DisplayName("Pianist Name")]
        public int PerformerID { get; set; }
        [Required]
        public virtual Performer Performer { get; set; }

    }
}

