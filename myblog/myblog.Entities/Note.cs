using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myblog.Entities
{
    class Note : MyEntityBase
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public bool IsDraft { get; set; }
        public int LikeCount { get; set; }
        public virtual User Owner { get; set; }
        public virtual Category Category { get; set; }


    }
}
