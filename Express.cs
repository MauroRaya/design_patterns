using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    public class Express {
        private string _config;

        public Express(string config) {
            _config = config;
        }

        public void GET() => Console.WriteLine("GET endpoint created.");
        public void POST() => Console.WriteLine("POST endpoint created.");
        public void PUT() => Console.WriteLine("PUT endpoint created.");
        public void DELETE() => Console.WriteLine("DELETE endpoint created.");
    }

    public static class ExpressFactory {
        public static Express CreateApp(string config) {
            return new Express(config);
        }
    }
}
