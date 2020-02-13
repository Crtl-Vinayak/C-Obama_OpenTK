using System;
using System.Drawing;
using System.IO;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace obamaExperimentingV1_4
{
    class DisplayStuff : GameWindow
    {

        /**
         * pgmID = program's ID
         * vsID = vertexshader ID (stores address of this type shader).
         * fsID = fragmentshader ID (stores address of this type shader).
         */
        int pgmID;
        int vsID;
        int fsID;

        /**
         * geen idee wat deze 9 variabelen zijn ):
         */
        int attribute_vcol;
        int attribute_vpos;
        int uniform_mview;
        int vbo_position;
        int vbo_color;
        int vbo_mview;
        Vector3[] vertdata;
        Vector3[] coldata;
        Matrix4[] mviewdata;

        int[] indicedata;
        int ibo_elements;
        float time = 0.0f;


        public DisplayStuff() : base(1280, 720, new GraphicsMode(32, 24, 0, 4))
        {
            Title = "Obama Master OpenTK Yeeten";
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);
            //Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 1.0f, 64.0f);
            //GL.MatrixMode(MatrixMode.Projection);
            //GL.LoadMatrix(ref projection);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CursorVisible = true;

            initProgram();

            vertdata = new Vector3[] { new Vector3(-0.8f, -0.8f,  -0.8f),
                new Vector3(0.8f, -0.8f,  -0.8f),
                new Vector3(0.8f, 0.8f,  -0.8f),
                new Vector3(-0.8f, 0.8f,  -0.8f),
                new Vector3(-0.8f, -0.8f,  0.8f),
                new Vector3(0.8f, -0.8f,  0.8f),
                new Vector3(0.8f, 0.8f,  0.8f),
                new Vector3(-0.8f, 0.8f,  0.8f),
            };

            indicedata = new int[]{
                //front
                0, 7, 3,
                0, 4, 7,
                //back
                1, 2, 6,
                6, 5, 1,
                //left
                0, 2, 1,
                0, 3, 2,
                //right
                4, 5, 6,
                6, 7, 4,
                //top
                2, 3, 6,
                6, 3, 7,
                //bottom
                0, 1, 5,
                0, 5, 4
            };

            coldata = new Vector3[] { new Vector3(1f, 0f, 0f),
                      new Vector3( 0f, 0f, 1f),
                      new Vector3( 0f,  1f, 0f),new Vector3(1f, 0f, 0f),
                      new Vector3( 0f, 0f, 1f),
                      new Vector3( 0f,  1f, 0f),new Vector3(1f, 0f, 0f),
                      new Vector3( 0f, 0f, 1f)};


            mviewdata = new Matrix4[]{
                Matrix4.Identity
            };

            GL.ClearColor(Color.CornflowerBlue);
            GL.PointSize(5f);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_position);
            GL.BufferData<Vector3>(BufferTarget.ArrayBuffer, (IntPtr)(vertdata.Length * Vector3.SizeInBytes), vertdata, BufferUsageHint.StaticDraw);
            GL.VertexAttribPointer(attribute_vpos, 3, VertexAttribPointerType.Float, false, 0, 0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_position);
            GL.BufferData<Vector3>(BufferTarget.ArrayBuffer, (IntPtr)(vertdata.Length * Vector3.SizeInBytes), vertdata, BufferUsageHint.StaticDraw);
            GL.VertexAttribPointer(attribute_vpos, 3, VertexAttribPointerType.Float, false, 0, 0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_color);
            GL.BufferData<Vector3>(BufferTarget.ArrayBuffer, (IntPtr)(coldata.Length * Vector3.SizeInBytes), coldata, BufferUsageHint.StaticDraw);
            GL.VertexAttribPointer(attribute_vcol, 3, VertexAttribPointerType.Float, true, 0, 0);

            GL.UniformMatrix4(uniform_mview, false, ref mviewdata[0]);
            GL.UseProgram(pgmID);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ibo_elements);
            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(indicedata.Length * sizeof(int)), indicedata, BufferUsageHint.StaticDraw);

            mviewdata[0] = Matrix4.CreateRotationY(0.02f) * Matrix4.CreateRotationX(0.015f) * Matrix4.CreateTranslation(0.0f, 0.0f, -3.0f) * Matrix4.CreatePerspectiveFieldOfView(1.3f, ClientSize.Width / (float)ClientSize.Height, 1.0f, 40.0f);
            time += (float)e.Time;
            mviewdata[0] = Matrix4.CreateRotationY(0.55f * time) * Matrix4.CreateRotationX(0.15f * time) * Matrix4.CreateTranslation(0.0f, 0.0f, -3.0f) * Matrix4.CreatePerspectiveFieldOfView(1.3f, ClientSize.Width / (float)ClientSize.Height, 1.0f, 40.0f);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Viewport(0, 0, Width, Height);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.EnableVertexAttribArray(attribute_vpos);
            GL.EnableVertexAttribArray(attribute_vcol);
            GL.DrawElements(BeginMode.Triangles, indicedata.Length, DrawElementsType.UnsignedInt, 0);
            GL.DisableVertexAttribArray(attribute_vpos);
            GL.DisableVertexAttribArray(attribute_vcol);

            GL.Flush();
            SwapBuffers();
        }

        void initProgram()
        {
            pgmID = GL.CreateProgram();
            loadShader("Shaders/vs.glsl", ShaderType.VertexShader, pgmID, out vsID);
            loadShader("Shaders/fs.glsl", ShaderType.FragmentShader, pgmID, out fsID);
            GL.LinkProgram(pgmID);
            Console.WriteLine(GL.GetProgramInfoLog(pgmID));

            GL.GenBuffers(1, out vbo_position);
            GL.GenBuffers(1, out vbo_color);
            GL.GenBuffers(1, out vbo_mview);

            attribute_vpos = GL.GetAttribLocation(pgmID, "vPosition");
            attribute_vcol = GL.GetAttribLocation(pgmID, "vColor");
            uniform_mview = GL.GetUniformLocation(pgmID, "modelview");

            if (attribute_vpos == -1 || attribute_vcol == -1 || uniform_mview == -1) {
                Console.WriteLine("Error binding attributes");
            }

            GL.GenBuffers(1, out ibo_elements);
        }

        void loadShader(string filename, ShaderType type, int program, out int address)
        {
            address = GL.CreateShader(type);
            using (StreamReader sr = new StreamReader(filename)) {
                GL.ShaderSource(address, sr.ReadToEnd());
            }
            GL.CompileShader(address);
            GL.AttachShader(program, address);
            Console.WriteLine(GL.GetShaderInfoLog(address));
        }
    }
}