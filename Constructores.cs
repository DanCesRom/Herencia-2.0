using System.Diagnostics;

namespace Herencia
{
    public class Elecciones
    {
        public static void Opciones() 
        {
            if (Variable.Eleccion == 1)
            {
                Variable.precio += Precios.hamburguesas[Variable.Eleccion-1];
                Console.WriteLine("La Hamburguesa Clasica Contiene: \n");
                foreach (string x in Tipos.clasica) { Console.WriteLine(x); }     //Muestra el contenido de la Hamburguesa Clasica
                Relleno.Agregar();                                               //Corre la funcion .Agregar() en la Clase Relleno la cual se encarga de agregar los Ingredientes Adicionales a la Hamburguesa.
            }

            else if (Variable.Eleccion == 2)
            {
                Variable.precio += Precios.hamburguesas[Variable.Eleccion-1];
                Console.WriteLine("La Hamburguesa Saludable Contiene: \n");     //Muestra el contenido de la Hamburguesa Saludable
                foreach (string x in Tipos.saludable) { Console.WriteLine(x); }
                Relleno.Agregar();                                             //Corre la funcion .Agregar() en la Clase Relleno la cual se encarga de agregar los Ingredientes Adicionales a la Hamburguesa.
            }

            else if (Variable.Eleccion == 3)
            {
                Variable.precio += Precios.hamburguesas[Variable.Eleccion-1];
                Console.WriteLine("La Hamburguesa Premium Contiene: \n");       //Muestra el contenido de la Hamburguesa Premium
                foreach (string x in Tipos.premium) { Console.WriteLine(x); }
                Relleno.Agregar();                                             //Corre la funcion .Agregar() en la Clase Relleno la cual se encarga de agregar los Ingredientes Adicionales a la Hamburguesa.
            }

            else if (Variable.Eleccion == 4)
            {
                Console.WriteLine("El Precio Base de Cada Hamburguesa e Ingredientes son: \n");
                for (int x = 0; x < 3; x++) { Console.WriteLine(Ingredientes.hamburguesas[x] + " son " + Precios.hamburguesas[x] + " pesos."); }         //Muestra cada tipo de Hamburguesa con su Precio
                Console.WriteLine("\n" + "Adicionales" + "\n");
                for (int x = 0; x < 6; x++) { Console.WriteLine(Ingredientes.adicionales[x] + " Cuesta: " + Precios.adicionales[x] + " Pesos"); }       //Muestra cada tipo de Adicional con su Precio
                Console.WriteLine("\nPresione Cualquier Tecla para volver al Menu"); Console.ReadKey();
            }

            else { Console.WriteLine("No Eligio ninguna de las opciones..."); Thread.Sleep(4000); }
        }
    
    }
}

