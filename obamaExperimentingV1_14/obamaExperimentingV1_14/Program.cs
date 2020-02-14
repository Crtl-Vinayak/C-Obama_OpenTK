using OpenTK;
using OpenTK.Graphics;

namespace obamaExperimentingV1_14
{
    public class ObamaBattlezCSharp : GameWindow
    { 
        private static void Main(string[] args)
        {
            using (var window = new Window(1280, 720, GraphicsMode.Default, "Obama Battlez CSharp Version", GameWindowFlags.Default, DisplayDevice.Default)) {
                //window.Icon = new Icon("Resources/bruhstar (1).bmp");
                window.Run(60.0f);
            }
        }
    }
}