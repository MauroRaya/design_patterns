namespace DesignPatterns {
    class Program {
        static void Main(string[] args) {
            //Creational patterns

            //1. Factories
            var app = ExpressFactory.CreateApp("Development");
            app.GET();
            app.POST();

            //2, Builders
            var request = new HttpRequest.Builder()
                .SetURL("https://api.example.com/data")
                .SetMethod("POST")
                .SetHeaders("Authorization: Bearer token")
                .SetBody("{ \"key\": \"value\" }")
                .Build();

            Console.WriteLine(request.URL);
        }
    }
}