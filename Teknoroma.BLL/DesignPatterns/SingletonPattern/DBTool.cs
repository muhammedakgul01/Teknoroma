using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teknoroma.DataAccess.Context;

namespace Teknoroma.BLL.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }

        static TeknoromaDbContext _dbInstance;

        public static TeknoromaDbContext DbInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new TeknoromaDbContext();
                return _dbInstance;
            }
        }
    }
}