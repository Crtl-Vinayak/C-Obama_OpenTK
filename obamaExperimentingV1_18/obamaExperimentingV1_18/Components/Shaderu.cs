using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;

namespace obamaExperimentingV1_18.Components
{
    public class Shaderu
    {
        public int CreateProgram()
        {
            try {
                var program = GL.CreateProgram();
                var shaders = new List<int>();
                shaders.Add(CompileShader(ShaderType.VertexShader, @"Shaders/simplePipeVert.c"));
                shaders.Add(CompileShader(ShaderType.FragmentShader, @"Shaders/simplePipeFrag.c"));

                foreach (var shader in shaders) {
                    GL.AttachShader(program, shader);
                }

                GL.LinkProgram(program);
                var info = GL.GetProgramInfoLog(program);
                if (!string.IsNullOrWhiteSpace(info)) {
                    throw new Exception($"CompileShaders ProgramLinking had errors: {info}");
                }

                foreach (var shader in shaders) {
                    GL.DetachShader(program, shader);
                    GL.DeleteShader(shader);
                }

                return program;
            } catch (Exception e) {
                Debug.WriteLine(e);
                throw;
            }
        }

        public int CompileShader(ShaderType shaderType, string filepath)
        {
            var shader = GL.CreateShader(shaderType);
            var src = File.ReadAllText(filepath);
            GL.ShaderSource(shader, src);
            GL.CompileShader(shader);
            var info = GL.GetShaderInfoLog(shader);
            if (!string.IsNullOrWhiteSpace(info))
                throw new Exception($"CompileShader {shaderType} had errors: {info}");
            return shader;
        }
    }
}
