using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;

using System.Drawing;

namespace obamaExperimentingV1_16.Components
{
    /**
     * 
     * MainWindow is de kern van de programma, waar alle belangrijke functies/methode worden geroepen.
     * Program.cs Roept de GameWindow om MainWindow functies te roepen, tot dat de programma is gesloten.
     * 
     * public sealed class MainWindow : GameWindow
     * MainWindow is de child class.
     * GameWindow is de parent class.
     * MainWindow kan geen parent class meer worden, vanwege de sealed keyword.
     */
    public sealed class MainWindow : GameWindow
    {
        private readonly string title;
        private int program;
        private double time;
        private List<RenderObject> renderObjects = new List<RenderObject>();

        public MainWindow() : base (1280, 720, GraphicsMode.Default, "", GameWindowFlags.Default, DisplayDevice.Default, 4, 6, GraphicsContextFlags.ForwardCompatible)
        {
            title += "Obama Battlez C# Edition // Version A_1.0.0 // OpenGL Version " + GL.GetString(StringName.Version);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnLoad(EventArgs e)
        {
            Vertex[] vertices =
            {
                new Vertex(new Vector4(-0.25f, 0.25f, 0.5f, 1-0f), Color4.AliceBlue),
                new Vertex(new Vector4(0.0f, -0.25f, 0.5f, 1-0f), Color4.Crimson),
                new Vertex(new Vector4(0.25f, 0.25f, 0.5f, 1-0f), Color4.DarkOrange)
            };

            renderObjects.Add(new RenderObject(vertices));

            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            GL.PatchParameter(PatchParameterInt.PatchVertices, 3);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            time += e.Time;
            Title = $"{title}: (Vsync: {VSync}) FPS {1f / e.Time:0}";

            GL.ClearColor(Color.CornflowerBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            foreach (var renderStuff in renderObjects) {
                renderStuff.Render();
            }

            SwapBuffers();
        }

        protected override void OnClosed(EventArgs e)
        {

        }
    }
}
