using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using Proyecto1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01
{
    public class Poligono
    {
        public List<Punto> puntos { get; set; }
        public Color4 color { get; set; }

        Punto p { get; set; }
        public Poligono()
        {
            puntos = new List<Punto>();
            this.color = color;
        }
        public Poligono(Color4 color)
        {
            puntos = new List<Punto>();
            this.color = color;
        }
        public Poligono(Color4 color, float x, float y, float z){
            puntos = new List<Punto>();
            this.color = color;
            this.p = new Punto(x, y, z);
        }
        public Poligono(Poligono p, Color4 color)
        {
            puntos = new List<Punto>();
            this.color = color;
            for (int i = 0; i < p.puntos.Count(); i++)
            {
                puntos.Add(new Punto(p.puntos[i]));
            }
        }

        //public Poligono(Poligono p)
        //{
        //    puntos = new List<Punto>();
        //}

        //public void CopiarPoligono(Poligono p) 
        //{
        //}

        public void Dibujar(){

            PrimitiveType primitiveType = PrimitiveType.Polygon;
            GL.Begin(primitiveType);
            GL.Color4(color);

            for (int i = 0; puntos.Count > i; i++)
            {
                GL.Vertex3(puntos.ElementAt(i).ToVector3());
            }

            GL.End();

        }

        public void Rotar(float angulo, Punto p)
        {
            GL.Rotate(20, p.ToVector3());
        }

        public void Trasladar(float x, float y, float z)
        {
        }

        public void Adicionar(float x, float y, float z)
        {
            puntos.Add(new Punto(x + p.x, y + p.y, z + p.z));
        }

        public void Adicionar(Punto punto)
        {
            puntos.Add(punto);
        }

        public void Escalar()
        {
        }

        public void Rotar()
        {
        }

        public void Eliminar(int i)
        {
            puntos.RemoveAt(i);
        }
        public void mover(Punto p)
        {
            foreach (Punto pun in puntos)
            {
                pun.acumular(p);
            }
        }
    }
    // objeto auto= new objeto(new ); 
    // objeto cuarto = new objeto();
    // cuarto.add(new parte(new poligono()));
}
