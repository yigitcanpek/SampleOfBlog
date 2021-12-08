using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.Entities
{
    public class PostTag:BaseEntity
    {
        public int? PostID { get; set; }
        public int? TagID { get; set; }
        public virtual Post Post { get; set; }
        public virtual Tag Tag { get; set; }

    }
}
