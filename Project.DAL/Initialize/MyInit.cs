using Project.DAL.Context;
using Project.ENTITIES.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Initialize
{
    public class MyInit: CreateDatabaseIfNotExists<MyContext>
    {
        public override void InitializeDatabase(MyContext context)
        {
            AppUser kadir = new AppUser
            {
                UserName = "Legolas",
                Name = "Kadir",
                Surname = "Şöför",
                Password = "Arwen34",
                UserRole = Project.ENTITIES.Models.Enums.UserRole.Admin
            };

            AppUser yigit = new AppUser
            {
                UserName = "Gimli",
                Name = "Yiğit Can",
                Surname = "Pekgüzel",
                Password = "Arwen44",
                UserRole = Project.ENTITIES.Models.Enums.UserRole.Admin
            };
            context.AppUsers.Add(kadir);
            context.AppUsers.Add(yigit);
            context.SaveChanges();
        }
        
    }
}
