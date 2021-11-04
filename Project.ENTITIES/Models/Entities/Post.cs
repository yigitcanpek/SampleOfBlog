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

        //Relational Properties
        public int? AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
