using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    public class Database {
        private static Database instance = null;

        public Database GetInstance() {
            if (instance == null) {
                instance = new Database();
            }
            return instance;
        }
    }
}
