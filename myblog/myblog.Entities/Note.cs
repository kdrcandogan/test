using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myblog.Entities
{   [Table("Notes")]
     public class Note : MyEntityBase
    {
        [Required,StringLength(60)]
        public string Title { get; set; }
        [Required,StringLength(25)]
        public string Text { get; set; }
        public bool IsDraft { get; set; }       
       
        public virtual User Owner { get; set; }
        public virtual Category Category { get; set; }


    }
}
