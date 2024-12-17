using static DesignPatterns.Database;

namespace DesignPatterns {
    class Program {
        static void Main(string[] args) {
            //1. Creational patterns

            //1.1. Factory method
            var app = ExpressFactory.CreateApp("Development");
            app.GET();
            app.POST();

            Console.WriteLine();

            //1.2. Abstract factory
            MySQL mysql = new MySQL();
            var db1 = mysql.CreateDB_Instance();

            PostgresSQL postgres = new PostgresSQL();
            var db2 = postgres.CreateDB_Instance();

            db1.CreateDB();
            db1.Connect();
            db1.Disconnect();

            db2.CreateDB();
            db2.Connect();
            db2.Disconnect();

            Console.WriteLine();

            //1.3. Builders
            var request = new HttpRequest.Builder()
                .SetURL("https://api.example.com/data")
                .SetMethod("POST")
                .SetHeaders("Authorization: Bearer token")
                .SetBody("{ \"key\": \"value\" }")
                .Build();

            Console.WriteLine(request.URL);
            Console.WriteLine();

            //1.4. Singletons
            File file = new File();
            var file1 = file.GetInstance();
            var file2 = file.GetInstance();

            Console.WriteLine("Instancias file são iguais?: " + (file1 == file2));
            Console.WriteLine();

            //1.5. Prototypes
            Square square    = new Square(10, 20, 5);
            Square newSquare = (Square)square.Clone();

            Console.WriteLine($"Square original: {square.X} - {square.Y}");
            Console.WriteLine($"Square clonado:  {newSquare.X} - {newSquare.Y}");

            newSquare.X = 100;
            newSquare.Y = 200;

            Console.WriteLine($"Square clonado após alteração: {newSquare.X} - {newSquare.Y}");
            Console.WriteLine($"Square original: {square.X} - {square.Y}");
            Console.WriteLine();
        }
    }
}