using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NosesApi.App_Data;
namespace NosesApi
{
    public class Repository
    {

        private readonly DbOperationsEntities _context;

        public Repository()
        {
            _context = new DbOperationsEntities();
        }
        public void kek()
        {
           
        }
    }
}