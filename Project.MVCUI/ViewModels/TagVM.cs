using Project.ENTITIES.Models;
using Project.ENTITIES.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.ViewModels
{
    public class TagVM
    {
        public List<Post> Posts { get; set; }
        public List<Tag> Tags { get; set; }
        public Tag TagInstance { get; set; }
    }
}