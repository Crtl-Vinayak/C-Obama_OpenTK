using obama_experimenting_v1._0.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obama_experimenting_v1._0
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            new MainWindow().Run(60.0);
        }
    }
}
