using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Cfg;

namespace SimpleBlog
{
    public static class Database
    {
        public static void Configure()
        {
            var config = new Configuration();

            // configure the connection string
            config.Configure();

            // add our mappings

            // create session factory
        }

        public static void OpenSession()
        {

        }

        public static void CloseSession()
        {

        }
    }
}