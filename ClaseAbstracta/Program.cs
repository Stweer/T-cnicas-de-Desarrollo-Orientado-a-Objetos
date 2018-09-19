using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
         //   var mounstro = new ClsMounstro("Sline",100,5);
         //   var soldado = new ClsMounstro("Ak16", 20,15);

         //   Console.WriteLine(mounstro.Ataque());
         //   Console.WriteLine(soldado.Ataque());
         //   Console.Read();

            ClsMounstro[] arreglo = new ClsMounstro[4]
            {

                new ClsMounstro("Ogre",14000,24,10),
                new ClsMounstro("Troll",24000,40,10),
                new ClsMounstro("Fantasma",36000,50,11),
                new ClsMounstro("Naga",1414,52,13)

                
            };
            Console.WriteLine("***************Arreglo Moustros*************");
            foreach (ClsMounstro c in arreglo)
            {
                Console.WriteLine("El Nombre del mosutro es {0}  tiene una vida de {1} y su daño es {2} ", c.Nombre, c.Vida, c.Daño);
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
