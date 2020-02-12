using System;
using Tao.FreeGlut;
using OpenGL;
using System.Collections.Generic;

namespace obamaExperimentingV1_12
{
    class Program
    {
        private static int width = 1280, height = 720;
        List<Volume> objects = new List<Volume>();

        static void Main(string[] args)
        {
            // create an OpenGL window
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_DEPTH | Glut.GLUT_DOUBLE | Glut.GLUT_RGBA);
            Glut.glutInitWindowSize(width, height);
            Glut.glutCreateWindow("Free Obama V1.12");

            Glut.glutIdleFunc(OnRenderFrame);
            Glut.glutReshapeFunc(OnUpdateFrame);
            Glut.glutDisplayFunc(OnDisplay);
            Glut.glutKeyboardFunc(KeyInputs);
            Glut.glutCloseFunc(OnClose);

            Glut.glutMainLoop();
        }

        private static void OnClose()
        {

        }

        private static void OnDisplay()
        {

        }

        private static void OnUpdateFrame(int width, int height)
        {

        }

        private static void OnRenderFrame()
        {

            List<Vector3> verts = new List<Vector3>();
            List<int> inds = new List<int>();
            List<Vector3> colors = new List<Vector3>();



            Glut.glutSwapBuffers();
        }

        private static void KeyInputs(byte key, int xx, int yy)
        {

        }
    }
}