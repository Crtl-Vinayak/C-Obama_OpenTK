﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTK_speeltuin
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            new MainWindow().Run(60);
        }
    }
}