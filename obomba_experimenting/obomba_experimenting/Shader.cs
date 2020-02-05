using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObamaV2 {
    class Shader {

        int Handle;

        public Shader(string vertexPath, string fragmentPath) {
            string VertexShaderSource;
            string FragmentShaderSource;

            using (StreamReader reader = new StreamReader(vertexPath, Encoding.UTF8)) {
                VertexShaderSource = reader.ReadToEnd();
            }

            using (StreamReader reader = new StreamReader(fragmentPath, Encoding.UTF8)) {
                FragmentShaderSource = reader.ReadToEnd();
            }
        }
    }
}
