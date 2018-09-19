using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public class ClsMounstro : ClsNpc, DañoAdicional

    {
        
        
        

        public ClsMounstro(string nombre,int vida ,int daño ,int dañoaurita)
        {
            Nombre = nombre;
            Vida = vida;
            Daño = daño;
            dañoaura = dañoaurita;
        }

        public int dañoaura { get ; set ; }
        




        public string Ataque()
        {
            return $"{this.Nombre} esta causando {this.Daño} puntos de daño";

        }

        public void dañoarma()
        {
            Console.WriteLine("Generando daño extra de arma");
        }

        public void dañoextra()
        {
            Console.WriteLine("Generando daño extra de extra");
        }
    }
}
