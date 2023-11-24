using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_JADM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listas lista = new Listas();
            int menu = 0;
            do 
            {
                Console.WriteLine("1.Insertar persona");
                Console.WriteLine("2.Mostrar lista de personas");
                Console.WriteLine("3. Buscar persona por nombre y edad");
                Console.WriteLine("4. Ordenar");
                Console.WriteLine("Selecciona una opcion");
                menu = Convert.ToInt32(Console.ReadLine()); 
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Ingresa nombre de la persona");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa edad de la persona");
                        int Edad = Convert.ToInt32(Console.ReadLine());
                        Persona persona = new Persona {nombre = Nombre, edad = Edad };
                        lista.InsertarPersona(persona);
                        break;
                        case 2:
                        lista.MostrarPersona();
                        break;
                        case 3:
                        Console.WriteLine("Ingresa el nombre para buscar");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ingresa edad para buscar");
                        int age = Convert.ToInt32(Console.ReadLine());
                        lista.EncontrarPersona(name,age);
                        break;
                    case 4:
                            lista.ordenar();
                        break;

                }
            }
            while (menu != 6);
            
        }
    }
}
