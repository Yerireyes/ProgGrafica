using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;

namespace ConsoleApp3
{
    class Home
    {
        private PrismaTriangular t;
        private Paralelepipedo p;
        public Home(Vector3 centro, float ancho, float alto, float profundidad)
        {
            t = new PrismaTriangular(centro, ancho, alto, profundidad);
            p = new Paralelepipedo(centro, ancho, alto, profundidad);
            
        }
        
        public void Dibujar()
        {
            t.Dibujar();
            p.Dibujar();
        }

    }
}
