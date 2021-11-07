using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.Singleton
{
    public class DBTool
    {


        DBTool() { }

        static MyContext _dbInsantance;

        public static MyContext DBInsantance
        {
            get
            {

                if (_dbInsantance == null)
                {

                    _dbInsantance = new MyContext();
                }

                return _dbInsantance;
            }



        }


    }
}
