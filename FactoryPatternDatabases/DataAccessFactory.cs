using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDatabases
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();

                case "sql":
                    return new SQLDataAccess();

                case "mongo":
                    return new MongoDataAccess();

                default:
                    return new ListDataAccess();

            }

        }

    }
}
