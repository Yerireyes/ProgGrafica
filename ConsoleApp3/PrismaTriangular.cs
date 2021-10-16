using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace ConsoleApp3
{
    class PrismaTriangular
    {
        private Vector3 centro;
        private float alto, ancho, profundidad;
        private Color color = Color.Black;

        public PrismaTriangular(Vector3 centro, float ancho, float alto, float profundidad)
        {
            this.centro = centro;
            this.ancho = ancho;
            this.alto = alto;
            this.profundidad = profundidad;
        }
        public void Dibujar()
        {
            PrimitiveType primitiveType = PrimitiveType.LineLoop;

            //Triangulo adelante
            GL.Color3(Color.Red);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X, centro.Y + alto * 2, centro.Z + profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y + alto, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y + alto, centro.Z + profundidad);
            GL.End();

            //Triangulo atras
            GL.Color3(Color.Red);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X, centro.Y + alto * 2, centro.Z - profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y + alto, centro.Z - profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y + alto, centro.Z - profundidad);
            GL.End();

            //Triangulo Pared izquierda
            GL.Color3(Color.BlueViolet);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X, centro.Y + alto * 2, centro.Z + profundidad);
            GL.Vertex3(centro.X, centro.Y + alto * 2, centro.Z - profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y + alto, centro.Z - profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y + alto, centro.Z + profundidad);
            GL.End();

            //Triangulo Pared Derecha
            GL.Color3(Color.BlueViolet);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X, centro.Y + alto * 2, centro.Z + profundidad);
            GL.Vertex3(centro.X, centro.Y + alto * 2, centro.Z - profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y + alto, centro.Z - profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y + alto, centro.Z + profundidad);
            GL.End();

        }
    }
}
