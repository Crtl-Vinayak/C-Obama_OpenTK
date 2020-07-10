using System;
using obamaExperimentingV1_17.Components;

namespace obamaExperimentingV1_17
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new MainWindow().Run(60.0f);
        }
    }
}
