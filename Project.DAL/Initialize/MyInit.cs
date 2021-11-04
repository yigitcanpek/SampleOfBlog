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
    public class MyInit:DropCreateDatabaseIfModelChanges<MyContext>
    {
        public override void InitializeDatabase(MyContext context)
        {
            AppUser ap = new AppUser
            {
                UserName = "Admin",
                Password = "123"
            };
            context.AppUsers.Add(ap);
            context.SaveChanges();
        }
        
    }
}
