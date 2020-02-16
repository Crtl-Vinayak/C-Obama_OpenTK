using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Input;
using System;
using System.Drawing;

namespace obamaExperimentingV1_14
{
    class Window : GameWindow
    {

        Texture2D texture;

        public Window(int width, int height, string title, DisplayDevice displayDevice)
            : base(width, height, GraphicsMode.Default, title, GameWindowFlags.Default, displayDevice)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color.CornflowerBlue);

            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);

            //texture stuff beneath...
            GL.Enable(EnableCap.Texture2D);
            texture = ContentPipe.LoadTexture("Textures/smile.png");

        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            var input = Keyboard.GetState();

            if (input.IsKeyDown(Key.Escape)) {
                Exit();
            }

            base.OnUpdateFrame(e);

        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            //GL.Color4(0.4, 0.6, 0.1, 1.0);
            //GL.Begin(PrimitiveType.Triangles);
            //GL.Vertex2(0, 0);
            //GL.Vertex2(1, 0);
            //GL.Vertex2(0, 1);
            //GL.End();

            //GL.Color4(0.4, 0.2, 0.1, 1.0);
            //GL.Begin(PrimitiveType.Triangles);
            //GL.Vertex2(0, 0);
            //GL.Vertex2(-1, 0);
            //GL.Vertex2(0, -1);
            //GL.End();

            SwapBuffers();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);
        }
    }
}