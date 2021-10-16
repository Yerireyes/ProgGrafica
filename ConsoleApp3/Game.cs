using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace ConsoleApp3
{
    public class Game : GameWindow
    {
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.White);
            GL.MatrixMode(MatrixMode.Projection);
            //GL.LoadIdentity();
            GL.Ortho(-300, 300, -300, 300, -300, 300);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Rotate(0.5, 0.0, 1.0, 0.0);
            base.OnUpdateFrame(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadIdentity();

            //GL.Rotate(20, 1, 1, 0);
            Home p = new Home(new Vector3(0, 0, 0), 10, 10, 20);
            p.Dibujar();
            Home m = new Home(new Vector3(20, 20, 20), 10, 10, 20);
            m.Dibujar();
            Home l = new Home(new Vector3(-50, 100, 50), 30, 40, 60);
            l.Dibujar();


            SwapBuffers();
            base.OnRenderFrame(e);
        }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }

    }
}
