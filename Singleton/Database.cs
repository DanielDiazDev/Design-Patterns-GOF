using System;

namespace Singleton
{
    class Database
    {
        private static Database instance;
        private static object threadLock = new object();
        private Database()
        {
            
        }
        public static Database getInstance()
        {
            if (Database.instance == null)
            {
                if (instance == null)
                {
                    lock (threadLock)
                    {
                        if (instance == null)
                            instance = new Database();
                    }
                }
            }
            return instance;
        }
        public void query(string sql)
        {
            
        }
    }
}