using CloudXFerDBLayer.Utils;
using Microsoft.Data.Sqlite;
using Dapper;
using System;

namespace CloudXFerDBLayer.DBUtils.ConfigDbMaintenance
{
    public class DBMaintenance
    {


        public static bool InstantiatedDB(SqliteConnection conn)
        {
            try
            {
                var configureTime = conn.ExecuteScalar("SELECT ConfigureTime from CXFConfig");
                return (configureTime != null);
            }
            catch
            {
                return false;
            }
        }


        public static void InstantiateDB(SqliteConnection conn)
        {
            conn.Open();
            if (!InstantiatedDB(conn))
            {
                conn.Execute(@"CREATE TABLE CXFConfig (
                            ConfigKey TEXT UNIQUE, 
                            ConfigValue TEXT UNIQUE
                            )"
                );
                conn.Execute(@"CREATE TABLE CXFProjects ( 
                            ProjectId INTEGER PRIMARY KEY,
                            ProjectName TEXT UNIQUE, 
                            ProjectCreationTime INTEGER, 
                            ProjectComments TEXT,
                            ProjectCode TEXT
                            )"
                );
                conn.Execute(@"CREATE TABLE CXFProjectCommands (
                            CommandId INTEGER PRIMARY KEY,
                            ProjectId INTEGER,
                            CommandText TEXT
                            )"
                );
                conn.Execute("INSERT INTO CXFConfig (ConfigKey, ConfigValue) VALUES ('ConfigureTime', @ConfigureTime) ",
                    new { ConfigureTime = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString() }
                );
            }
        }

        public static void InstantiateDB()
        {

            using (var conn = new SqliteConnection(Statics.ConfigDBConnString))
            {
                try
                {
                    InstantiateDB(conn);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }

            }
        }

    }
}