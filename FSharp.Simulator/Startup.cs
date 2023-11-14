using OpenSilver.Simulator;
using System;

namespace FSharp.Simulator
{
    static class Startup
    {
        [STAThread]
        static int Main(string[] args)
        {
            return SimulatorLauncher.Start(typeof(AppC.App));
            //return SimulatorLauncher.Start(typeof(AppF.App));
            //return SimulatorLauncher.Start(typeof(AppVB.App));
        }
    }
}
