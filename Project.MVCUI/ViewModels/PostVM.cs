using Project.ENTITIES.Models;
using Project.ENTITIES.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.ViewModels
{
    public class PostVM
    {
        public Post PostInstance { get; set; }
        public List<Post> Posts { get; set; }
        public List<AppUser> AppUsers { get; set; }
        
        public List<Category> Categories { get; set; }
        public List<PostTag> PostTags { get; set; }
        public List<Tag> Tags { get; set; }










    }
}