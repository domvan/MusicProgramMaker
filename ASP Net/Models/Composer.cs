using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MusicMakerProgram.Models;

namespace MusicMakerProgram.Models
{
    public class Composer
    {
        [Key]
        public int CID { get; set; }

        [DisplayName("Composer Name")]
        public string CName { get; set; }

        [DisplayName("Time Period")]
        public string Period { get; set; }

        [DisplayName("Composer Biography")]
        public string Bio { get; set; }
    }
}
