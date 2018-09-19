using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public class ClsSoldado : ClsNpc
    {

        public ClsSoldado(string nombre, int vida, int daño)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Daño = daño;
        }

        public string Atacar()
        {
            return $"{this.Nombre} esta causando {this.Daño} puntos de daño" ;
        }
    }
}
