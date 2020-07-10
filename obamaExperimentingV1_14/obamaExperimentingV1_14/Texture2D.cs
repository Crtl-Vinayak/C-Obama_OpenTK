using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL4;
using System.Drawing;
using System.Drawing.Imaging;

namespace obamaExperimentingV1_14
{
    class Texture2D
    {
        private readonly int id;
        private readonly int width;
        private readonly int height;

        public Texture2D(int id, int width, int height)
        {
            this.id = id;
            this.width = width;
            this.height = height;
        }

        public int ID { get { return id; } }
        public int Width { get { return width; } }
        public int Height { get { return height; } }

    }
}
