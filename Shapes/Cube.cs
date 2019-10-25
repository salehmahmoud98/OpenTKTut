﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
namespace OpenTKTut.Shapes
{
    class Cube : OGLShape
    {
        public Cube(Vector3 center, double length,bool enableRotation = false)
        {
            Center = center;
            Length = length;
            EnableAutoRotate = enableRotation;
        }

        public Vector3 Center { get; set; }
        public double Length { get; set; }

        public override void Draw()
        {
            base.Draw();
            GL.PushMatrix();
            GL.Translate(Center.X,Center.Y,-Center.Z);
            if(EnableAutoRotate)
            {
                
                GL.Rotate(_rotateAngle, Vector3.UnitX);
                GL.Rotate(_rotateAngle, Vector3.UnitZ);
                _rotateAngle = _rotateAngle < 360 ? _rotateAngle + 1 : _rotateAngle - 360;
            }

            GL.Begin(BeginMode.Quads);

            //Front Face
           
            GL.Color3(1.0f, 0.0f, 0.0f);
            GL.Vertex3(-Length / 2, -Length / 2, Length / 2);
            GL.Vertex3(Length / 2, -Length / 2, Length / 2);
            GL.Vertex3(Length / 2, Length / 2, Length / 2);
            GL.Vertex3(-Length / 2, Length / 2, Length / 2);
            //Rear Face
            
            GL.Color3(1.0f, 1.0f, 0.0f);
            GL.Vertex3(-Length / 2, -Length / 2, -Length / 2);
            GL.Vertex3(Length / 2, -Length / 2, -Length / 2);
            GL.Vertex3(Length / 2, Length / 2, -Length / 2);
            GL.Vertex3(-Length / 2, Length / 2, -Length / 2);

            //Rear Left

            GL.Color3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(-Length / 2, -Length / 2, -Length / 2);
            GL.Vertex3(-Length / 2, -Length / 2, Length / 2);
            GL.Vertex3(-Length / 2, Length / 2, Length / 2);
            GL.Vertex3(-Length / 2, Length / 2, -Length / 2);

            //Rear Right

            GL.Color3(0.0f, 1.0f, 0.0f);
            GL.Vertex3(Length / 2, -Length / 2, -Length / 2);
            GL.Vertex3(Length / 2, -Length / 2, Length / 2);
            GL.Vertex3(Length / 2, Length / 2, Length / 2);
            GL.Vertex3(Length / 2, Length / 2, -Length / 2);

            //Rear bottom

            GL.Color3(0.0f, 1.0f, 1.0f);
            GL.Vertex3(-Length / 2, -Length / 2, -Length / 2);
            GL.Vertex3(-Length / 2, -Length / 2, Length / 2);
            GL.Vertex3(Length / 2, -Length / 2, Length / 2);
            GL.Vertex3(Length / 2, -Length / 2, -Length / 2);

            //Rear Up

            GL.Color3(0.0f, 0.0f, 1.0f);
            GL.Vertex3(-Length / 2, Length / 2, -Length / 2);
            GL.Vertex3(-Length / 2, Length / 2, Length / 2);
            GL.Vertex3(Length / 2, Length / 2, Length / 2);
            GL.Vertex3(Length / 2, Length / 2, -Length / 2);


            GL.End();



            GL.PopMatrix();
        }

    }
}
