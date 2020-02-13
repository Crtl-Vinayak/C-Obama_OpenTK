using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Input;

namespace OpenTK_speeltuin
{
    public sealed class MainWindow : GameWindow
    {
        private static int _program;
        private int _vertexArray;
        private double _time;

        public MainWindow() : base(1280, // initial width
        720, // initial height
        GraphicsMode.Default,
        "OpenTK Speeltuin",  // initial title
        GameWindowFlags.Default,
        DisplayDevice.Default,
        4, // OpenGL major version
        0, // OpenGL minor version
        GraphicsContextFlags.ForwardCompatible)
        {
            Title += ": OpenGL Version: " + GL.GetString(StringName.Version);
        }
        //laat de user de window re-sizen
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }
        //wanner het programma geladen wordt
        protected override void OnLoad(EventArgs e)
        {
            CursorVisible = true;
            _program = CompileShaders();
            GL.GenVertexArrays(1, out _vertexArray);
            GL.BindVertexArray(_vertexArray);
            Closed += OnClosed;
        }
        //afsluiten programma
        private void OnClosed(object sender, EventArgs eventArgs)
        {
            Exit();
        }
        //dit wordt elk frame aangeroepen
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            HandleKeyboard();
        }
        private void HandleKeyboard()
        {
            var keyState = Keyboard.GetState();

            if (keyState.IsKeyDown(Key.Escape))
            {
                Exit();
            }
        }

        //wordt ook elk frame geroepen en kan kleuren laten zien
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            _time += e.Time;
            Title = $"(Vsync: {VSync}) FPS: {1f / e.Time:0}";

            Color4 backColor;
            backColor.A = 1.0f;
            backColor.R = 0.1f;
            backColor.G = 0.1f;
            backColor.B = 0.3f;
            GL.ClearColor(backColor);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.UseProgram(_program);

            // add shader attributes here
            Vector4 position;
            position.X = (float)Math.Sin(_time) * 0.5f;
            position.Y = (float)Math.Cos(_time) * 0.5f;
            position.Z = 0.0f;
            position.W = 1.0f;
            GL.VertexAttrib4(1, position);
            GL.VertexAttrib1(0, _time);
            GL.DrawArrays(PrimitiveType.Points, 0, 1);
            GL.PointSize(10);
            SwapBuffers();
        }

        //shaders aanroepen
        private int CompileShaders()
        {
            var vertexShader = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(vertexShader, File.ReadAllText(@"Shaders\vertexShader.vert"));
            GL.CompileShader(vertexShader);

            var fragmentShader = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(fragmentShader, File.ReadAllText(@"Shaders\fragmentShader.frag"));
            GL.CompileShader(fragmentShader);

            var program = GL.CreateProgram();
            GL.AttachShader(program, vertexShader);
            GL.AttachShader(program, fragmentShader);
            GL.LinkProgram(program);

            GL.DetachShader(program, vertexShader);
            GL.DetachShader(program, fragmentShader);
            GL.DeleteShader(vertexShader);
            GL.DeleteShader(fragmentShader);
            return program;
        }
        public override void Exit()
        {
            GL.DeleteVertexArrays(1, ref _vertexArray);
            GL.DeleteProgram(_program);
            base.Exit();
        }
    }
}