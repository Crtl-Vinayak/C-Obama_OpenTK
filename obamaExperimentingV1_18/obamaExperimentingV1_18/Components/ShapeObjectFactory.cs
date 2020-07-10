using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;

namespace obamaExperimentingV1_18.Components
{
    public class ShapeObjectFactory
    {
        public static Vertex[] CreateSolidCube(float side, Color4 color)
        {
            side /= 2f;

            Vertex[] vertices =
            {
                new Vertex(new Vector4(-side, -side, -side, 1.0f),   color),
                new Vertex(new Vector4(-side, -side, side, 1.0f),    color),
                new Vertex(new Vector4(-side, side, -side, 1.0f),    color),
                new Vertex(new Vector4(-side, side, -side, 1.0f),    color),
                new Vertex(new Vector4(-side, -side, side, 1.0f),    color),
                new Vertex(new Vector4(-side, side, side, 1.0f),     color),
                
                new Vertex(new Vector4(side, -side, -side, 1.0f),    color),
                new Vertex(new Vector4(side, side, -side, 1.0f),     color),
                new Vertex(new Vector4(side, -side, side, 1.0f),     color),
                new Vertex(new Vector4(side, -side, side, 1.0f),     color),
                new Vertex(new Vector4(side, side, -side, 1.0f),     color),
                new Vertex(new Vector4(side, side, side, 1.0f),      color),
                
                new Vertex(new Vector4(-side, -side, -side, 1.0f),   color),
                new Vertex(new Vector4(side, -side, -side, 1.0f),    color),
                new Vertex(new Vector4(-side, -side, side, 1.0f),    color),
                new Vertex(new Vector4(-side, -side, side, 1.0f),    color),
                new Vertex(new Vector4(side, -side, -side, 1.0f),    color),
                new Vertex(new Vector4(side, -side, side, 1.0f),     color),

                new Vertex(new Vector4(-side, side, -side, 1.0f),    color),
                new Vertex(new Vector4(-side, side, side, 1.0f),     color),
                new Vertex(new Vector4(side, side, -side, 1.0f),     color),
                new Vertex(new Vector4(side, side, -side, 1.0f),     color),
                new Vertex(new Vector4(-side, side, side, 1.0f),     color),
                new Vertex(new Vector4(side, side, side, 1.0f),      color),

                new Vertex(new Vector4(-side, -side, -side, 1.0f),   color),
                new Vertex(new Vector4(-side, side, -side, 1.0f),    color),
                new Vertex(new Vector4(side, -side, -side, 1.0f),    color),
                new Vertex(new Vector4(side, -side, -side, 1.0f),    color),
                new Vertex(new Vector4(-side, side, -side, 1.0f),    color),
                new Vertex(new Vector4(side, side, -side, 1.0f),     color),

                new Vertex(new Vector4(-side, -side, side, 1.0f),    color),
                new Vertex(new Vector4(side, -side, side, 1.0f),     color),
                new Vertex(new Vector4(-side, side, side, 1.0f),     color),
                new Vertex(new Vector4(-side, side, side, 1.0f),     color),
                new Vertex(new Vector4(side, -side, side, 1.0f),     color),
                new Vertex(new Vector4(side, side, side, 1.0f),      color),
            };

            return vertices;
        }
    }
}
