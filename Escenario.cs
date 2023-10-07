using Proyecto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01
{
    public class Escenario
    {
        public Dictionary<string, Objeto> objetos { get; set; }
        
        public Escenario()
        {
            objetos = new Dictionary<string, Objeto>();
        }
        public Escenario(Escenario esc){
            objetos = new Dictionary<string, Objeto>();
            foreach (KeyValuePair<string, Objeto> k in esc.objetos){
                objetos.Add((k.Key), new Objeto(k.Value));
            }
        }
        public void AdicionarObjeto(String s, Objeto p)
        {

            objetos.Add(s, p);
        }
        public void Dibujar()
        {
            foreach (Objeto valor in objetos.Values)
            {
                valor.Dibujar();
            }
        }
        public void Rotar()
        {

        }
        public void mover(Punto p)
        {
            foreach(Objeto valor in objetos.Values)
            {
                valor.mover(p);
            }
        }
        /*
        public void mover(Punto p)
        {
            foreach (Objeto valor in objetos.Values)
            {
                foreach (Parte par in valor.partes.Values) 
                { 
                    foreach(Poligono pol in par.Lista)
                    {
                        foreach(Punto pun in pol.puntos)
                        {
                            pun.acumular(p);
                        }
                    }
                }
            }
        }
        */
    }
}
