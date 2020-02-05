using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObamaV2 {
    class Program {
        static void Main(string[] args) {
            using (Game game = new Game(1280, 720, "Obama Obama Obama! OpenTK experimenting")) {
                game.Run(60.0);
            }
        }
    }
}
