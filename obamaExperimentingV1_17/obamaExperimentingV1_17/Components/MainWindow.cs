using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;

using System.Drawing;

namespace obamaExperimentingV1_17.Components
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
        public int program;

        private readonly string title;
        private Shaderu shaderu;
        private double time;
        private List<RenderObject> renderObjects = new List<RenderObject>();
        private Matrix4 modelView;

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
            CursorVisible = true;

            Vertex[] vertices = ShapeObjectFactory.CreateSolidCube(0.2f, Color.Crimson);
            renderObjects.Add(new RenderObject(vertices));

            //shader magic begins 1!
            shaderu = new Shaderu();
            program = shaderu.CreateProgram();
            //end shader code 1!

            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
            GL.PatchParameter(PatchParameterInt.PatchVertices, 3);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {

            time += e.Time;
            var k = (float)time * 0.05f;
            var r1x = Matrix4.CreateRotationX(k * 13.0f);
            var r2y = Matrix4.CreateRotationY(k * 13.0f);
            var r3z = Matrix4.CreateRotationZ(k * 3.0f);

            var t1 = Matrix4.CreateTranslation((float) (Math.Sin(k * 5f) * 0.5f), (float) (Math.Cos(k * 5f) * 0.5f), 0f);

            modelView = r1x * r2y * r3z * t1;

            HandleKeyBoard();
        }

        public void HandleKeyBoard()
        {
            var keyState = Keyboard.GetState();

            if (keyState.IsKeyDown(Key.Escape)) {
                Exit();
            }
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            time += e.Time;
            Title = $"{title}: (Vsync: {VSync}) FPS {1f / e.Time:0}";

            GL.ClearColor(Color.CornflowerBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            //shader trickery Begin 2!
            GL.UseProgram(program);
            //shader trickery End 2!

            GL.UniformMatrix4(20, false, ref modelView);

            foreach (var renderStuff in renderObjects) {
                renderStuff.Render();
            }

            SwapBuffers();
        }

        protected override void OnClosed(EventArgs e)
        {
            Exit();
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Exit is being called.");
        }
    }
}
