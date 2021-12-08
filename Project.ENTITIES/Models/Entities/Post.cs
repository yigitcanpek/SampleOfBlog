using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.Entities
{
    public class Post:BaseEntity
    {
        public string Title { get; set; }
        public string TitleDescription { get; set; }
        public string Description { get; set; }
        public int ReviewCount { get; set; }
        public string ImagePath { get; set; }
        //Relational Properties
        public int? AppUserID { get; set; }
        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual List<PostTag> PostTags { get; set; }
    }
}
