namespace DesignPatterns {
    class Program {
        static void Main(string[] args) {
            //Creational patterns

            //1. Factories
            var app = ExpressFactory.CreateApp("Development");
            app.GET();
            app.POST();

            //2. Builders
            var request = new HttpRequest.Builder()
                .SetURL("https://api.example.com/data")
                .SetMethod("POST")
                .SetHeaders("Authorization: Bearer token")
                .SetBody("{ \"key\": \"value\" }")
                .Build();

            Console.WriteLine(request.URL);

            //3. Singletons
            Database database = new Database();
            var db1 = database.GetInstance();
            var db2 = database.GetInstance();

            Console.WriteLine("Instancias db são iguais?: " + (db1 == db2));

            //4. Prototypes
            Square square    = new Square(10, 20, 5);
            Square newSquare = (Square)square.Clone();

            Console.WriteLine($"Square original: {square.X} - {square.Y}");
            Console.WriteLine($"Square clonado:  {newSquare.X} - {newSquare.Y}");

            newSquare.X = 100;
            newSquare.Y = 200;

            Console.WriteLine($"Square clonado após alteração: {newSquare.X} - {newSquare.Y}");
            Console.WriteLine($"Square original: {square.X} - {square.Y}");
        }
    }
}