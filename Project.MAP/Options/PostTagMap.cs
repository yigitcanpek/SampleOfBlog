using Project.ENTITIES.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class PostTagMap:BaseMap<PostTag>
    {
        public PostTagMap()
        {
            Ignore(x => x.ID).HasKey(x => new { x.PostID, x.TagID });
        }
    }
}
