using System;
using Microsoft.Azure.Cosmos.Table;

namespace SPMapper
{

    static class DBConnect
    {

        // loads in the read-only connection string for Cosmos DB
        private static String[] ConnStr = System.IO.File.ReadAllLines(@"./ro.cnstr");

        // getters
        public static String getConnStr()
        {
            return ConnStr[0];
        }

        public static void getMappings(String userHash)
        {
            CloudStorageAccount db = CloudStorageAccount.Parse(ConnStr[0]);
            db.CreateCloudTableClient();
        }

    }

}