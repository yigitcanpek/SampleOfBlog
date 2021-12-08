using Project.ENTITIES.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.ViewModels
{
    public class PostTagVM
    {
        public Post postInstance{ get; set; }
        public List<PostTag> PostTags { get; set; }
        public List<Tag> Tags { get; set; }

    }
}