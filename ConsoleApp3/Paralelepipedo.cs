using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using OpenTK.Graphics;

namespace ConsoleApp3
{
    class Paralelepipedo
    {
        private Vector3 centro;
        private float alto, ancho, profundidad;
        private Color color = Color.Black;

        public Paralelepipedo(Vector3 centro, float ancho, float alto, float profundidad)
        {
            this.centro = centro;
            this.ancho = ancho;
            this.alto = alto;
            this.profundidad = profundidad;
        }
        public void Dibujar()
        {
            

            PrimitiveType primitiveType = PrimitiveType.LineLoop;

            //Pared Adelante
            GL.Color3(color);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X - ancho, centro.Y + alto, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y + alto, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y - alto, centro.Z + profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y - alto, centro.Z + profundidad);
            GL.End();


            //Pared Atras
            GL.Color3(Color.Green);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X - ancho, centro.Y + alto, centro.Z - profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y + alto, centro.Z - profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y - alto, centro.Z - profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y - alto, centro.Z - profundidad);
            GL.End();

            //Pared Izquierda
            GL.Color3(Color.Blue);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X - ancho, centro.Y + alto, centro.Z - profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y + alto, centro.Z + profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y - alto, centro.Z + profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y - alto, centro.Z - profundidad);
            GL.End();

            //Pared Derecha
            GL.Color3(Color.Gold);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X + ancho, centro.Y + alto, centro.Z - profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y + alto, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y - alto, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y - alto, centro.Z - profundidad);
            GL.End();

            //Pared Arriba
            GL.Color3(Color.Gold);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X - ancho, centro.Y + alto, centro.Z - profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y + alto, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y + alto, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y + alto, centro.Z - profundidad);
            GL.End();

            //Pared Abajo
            GL.Color3(Color.Gold);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X - ancho, centro.Y - alto, centro.Z - profundidad);
            GL.Vertex3(centro.X - ancho, centro.Y - alto, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y - alto, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho, centro.Y - alto, centro.Z - profundidad);
            GL.End();


            //Puerta
            GL.Color3(Color.Violet);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X - ancho/3, centro.Y + alto/2, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho/3, centro.Y + alto/2, centro.Z + profundidad);
            GL.Vertex3(centro.X + ancho/3, centro.Y - alto, centro.Z + profundidad);
            GL.Vertex3(centro.X - ancho/3, centro.Y - alto, centro.Z + profundidad);
            GL.End();

            //Ventana
            GL.Color3(Color.Violet);
            GL.Begin(primitiveType);
            GL.Vertex3(centro.X - ancho, centro.Y + alto / 3, centro.Z + profundidad/2);
            GL.Vertex3(centro.X - ancho, centro.Y + alto / 3, centro.Z - profundidad/2);
            GL.Vertex3(centro.X - ancho, centro.Y - alto / 3, centro.Z - profundidad/2);
            GL.Vertex3(centro.X - ancho, centro.Y - alto / 3, centro.Z + profundidad/2);
            GL.End();

        }
    }
}
