using Project.ENTITIES.Models;
using Project.ENTITIES.Models.Entities;
using Project.ENTITIES.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.ViewModels
{
    public class AppUserVM:BaseEntity
    {
        public AppUser AppUser { get; set; }
        public List<AppUser> AppUsers { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public UserRole UserRole { get; set; }
        
        public List<Post> Posts { get; set; }


    }
}