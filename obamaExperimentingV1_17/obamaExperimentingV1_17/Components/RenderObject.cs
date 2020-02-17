using System;
using OpenTK.Graphics.OpenGL4;

namespace obamaExperimentingV1_17.Components
{
    public class RenderObject : IDisposable
    {

        private bool isInitialized;
        private readonly int vertexArray;
        private readonly int buffer;
        private readonly int verticeCount;

        public RenderObject(Vertex[] vertices)
        {
            verticeCount = vertices.Length;
            vertexArray = GL.GenVertexArray();
            buffer = GL.GenBuffer();

            GL.BindVertexArray(vertexArray);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vertexArray);
            GL.NamedBufferStorage(buffer, Vertex.SIZE * vertices.Length, vertices, BufferStorageFlags.MapWriteBit);

            GL.VertexArrayAttribBinding(vertexArray, 0, 0);
            GL.EnableVertexArrayAttrib(vertexArray, 0);
            GL.VertexArrayAttribFormat(vertexArray, 0, 4, VertexAttribType.Float, false, 0);
            GL.VertexArrayAttribBinding(vertexArray, 1, 0);
            GL.EnableVertexArrayAttrib(vertexArray, 1);
            GL.VertexArrayAttribFormat(vertexArray, 1, 4, VertexAttribType.Float, false, 16);

            GL.VertexArrayVertexBuffer(vertexArray, 0, buffer, IntPtr.Zero, Vertex.SIZE);
            isInitialized = true;
        }

        public void Bind()
        {
            GL.BindVertexArray(vertexArray);
        }

        public void Render()
        {
            GL.DrawArrays(PrimitiveType.Triangles, 0, verticeCount);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && isInitialized) {
                GL.DeleteVertexArray(vertexArray);
                GL.DeleteBuffer(buffer);
                isInitialized = false;
            }
        }
    }
}