using Project.ENTITIES.Models;
using Project.ENTITIES.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.ViewModels
{
    public class CategoryVM
    {
        public List<Post> Posts { get; set; }
        public List<Category> Categories { get; set; }
        public Category CategoryInstance { get; set; }

    }
}