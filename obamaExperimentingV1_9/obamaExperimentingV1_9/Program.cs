using System;
using Tao.FreeGlut;
using OpenGL;

namespace obamaExperimentingV1_9
{
    static class Program
    {
        private static int width = 1280, height = 720;
        static void Main()
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Glut.glutInitWindowSize(width, height);
            Glut.glutCreateWindow("FREE OBAMA PRISM (:");

            Glut.glutIdleFunc(OnRenderFrame);
            Glut.glutDisplayFunc(OnDisplay);

            Glut.glutMainLoop();
        }

        private static void OnDisplay()
        {
            
        }

        private static void OnRenderFrame()
        {
            Gl.Viewport(0, 0, 1280, 720);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Glut.glutSwapBuffers();
        }
    }
}