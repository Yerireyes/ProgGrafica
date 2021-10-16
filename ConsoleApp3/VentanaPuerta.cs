using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace ConsoleApp3
{
    class VentanaPuerta
    {
        PrimitiveType primitiveType = PrimitiveType.LineLoop;

        public void Dibujar()
        {
            GL.Color3(Color.Cyan);
            GL.Begin(primitiveType);
            GL.Vertex3(0, 0.15, -0.2);
            GL.Vertex3(0, 0.35, -0.2);
            GL.Vertex3(0, 0.35, -0.7);
            GL.Vertex3(0, 0.15, -0.7);
            GL.End();

            GL.Color3(Color.Aqua);
            GL.Begin(primitiveType);
            GL.Vertex3(0.133, 0, -0.9);
            GL.Vertex3(0.13, 0.35, -0.9);
            GL.Vertex3(0.26, 0.35, -0.9);
            GL.Vertex3(0.266, 0, -0.9);
            GL.End();
        }
    }
}
