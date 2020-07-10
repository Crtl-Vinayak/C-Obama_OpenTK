using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;

namespace obamaExperimentingV1_16.Components
{
    public struct Vertex
    {
        public const int SIZE = (4 + 4) * 4;

        private readonly Vector4 position;
        private readonly Color4 color;

        public Vertex(Vector4 position, Color4 color)
        {
            this.position = position;
            this.color = color;
        }
    }
}
