using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    public static class Database {
        //Product Interface
        public interface IDatabase {
            void CreateDB();
            void Connect();
            void Disconnect();
        }

        //Concrete implementation
        class MySQL_Operations : IDatabase {
            public void CreateDB()   => Console.WriteLine("MySQL DB created");
            public void Connect()    => Console.WriteLine("MySQL DB connected");
            public void Disconnect() => Console.WriteLine("MySQL DB disconnected");
        }

        //Concrete implementation
        class PostgresSQL_Operations : IDatabase {
            public void CreateDB()         => Console.WriteLine("PostgresSQL DB created");
            public void Connect()          => Console.WriteLine("PostgresSQL DB connected");
            public void Disconnect()       => Console.WriteLine("PostgresSQL DB disconnected");
        }

        //Abstract factory interface
        interface IDatabaseFactory {
            IDatabase CreateDB_Instance();
        }

        //Concrete factory
        public class MySQL : IDatabaseFactory {
            public IDatabase CreateDB_Instance() => new MySQL_Operations();
        }

        //Concrete factory
        public class PostgresSQL : IDatabaseFactory {
            public IDatabase CreateDB_Instance() => new PostgresSQL_Operations();
        }
    }
}
