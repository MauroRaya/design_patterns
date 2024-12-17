using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    public class File {
        private static File instance = null;

        public File GetInstance() {
            if (instance == null) {
                instance = new File();
            }
            return instance;
        }
    }
}
