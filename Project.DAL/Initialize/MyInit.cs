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
        protected override void Seed(MyContext context)
        {

            AppUser ap = new AppUser()
            {
                UserName = "YigitCanAdmin",
                Password = "KadireSormanYeter",
                UserRole = Project.ENTITIES.Models.Enums.UserRole.Admin

            };
            context.AppUsers.Add(ap);
            context.SaveChanges();
        }
    }
}
