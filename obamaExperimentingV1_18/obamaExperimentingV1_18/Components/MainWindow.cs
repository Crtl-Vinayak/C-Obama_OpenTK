using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;

using System.Drawing;

namespace obamaExperimentingV1_18.Components
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
        private Matrix4 projectionMatrix;
        //private Matrix4 modelView;

        public MainWindow() : base (1280, 720, GraphicsMode.Default, "", GameWindowFlags.Default, DisplayDevice.Default, 4, 6, GraphicsContextFlags.ForwardCompatible)
        {
            title += "Obama Battlez C# Edition // Version A_1.0.0 // OpenGL Version " + GL.GetString(StringName.Version);
        }

        private void CreateProjection()
        {
            var aspectRatio = (float)Width / Height;
            projectionMatrix = Matrix4.CreatePerspectiveFieldOfView(60 * ((float) Math.PI / 180f), aspectRatio, 0.1f, 400f);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            CreateProjection();
        }

        protected override void OnLoad(EventArgs e)
        {
            VSync = VSyncMode.Off;
            CreateProjection();

            renderObjects.Add(new RenderObject(ShapeObjectFactory.CreateSolidCube(0.2f, Color.Crimson)));
            renderObjects.Add(new RenderObject(ShapeObjectFactory.CreateSolidCube(0.2f, Color.Blue)));
            renderObjects.Add(new RenderObject(ShapeObjectFactory.CreateSolidCube(0.2f, Color.Yellow)));
            renderObjects.Add(new RenderObject(ShapeObjectFactory.CreateSolidCube(0.2f, Color.DarkGoldenrod)));

            CursorVisible = true;

            //shader magic begins 1!
            shaderu = new Shaderu();
            program = shaderu.CreateProgram();
            //end shader code 1!

            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
            GL.PatchParameter(PatchParameterInt.PatchVertices, 3);
            GL.Enable(EnableCap.DepthTest);
            Closed += OnClosed;
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
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

            GL.UseProgram(program);
            GL.UniformMatrix4(20, false, ref projectionMatrix);
            float c = 0f;
            foreach (var renderStuff in renderObjects) {
                renderStuff.Bind();
                for (int i = 0; i < 5; i++) {
                    var k = i + (float)(time * (0.05f + (0.1 * c)));
                    var t2 = Matrix4.CreateTranslation(
                        (float)(Math.Sin(k * 5f) * (c + 0.5f)),
                        (float)(Math.Cos(k * 5f) * (c + 0.5f)),
                        -2.7f);
                    var r1x = Matrix4.CreateRotationX(k * 13.0f + i);
                    var r2y = Matrix4.CreateRotationY(k * 13.0f + i);
                    var r3z = Matrix4.CreateRotationZ(k * 3.0f + i);

                    var modelView = r1x * r2y * r3z * t2;
                    GL.UniformMatrix4(21, false, ref modelView);
                    renderStuff.Render();
                }
                c += 0.3f;
            }
            GL.PointSize(10);
            SwapBuffers();
        }

        protected override void OnClosed(EventArgs e)
        {
            Exit();
        }

        private void OnClosed(object sender, EventArgs eventArgs)
        {
            Exit();
        }

        public override void Exit()
        {
            Debug.WriteLine("Exit called.");
            foreach(var obj in renderObjects) {
                obj.Dispose();
            }
            GL.DeleteProgram(program);
            base.Exit();
        }
    }
}
