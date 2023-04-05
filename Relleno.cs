using System.Diagnostics;

namespace Herencia
{
    public class Relleno
    {
        public static void Agregar() 
        {
            Console.WriteLine("\n");
            if (Variable.Eleccion == 1) { Variable.limite = 4; } else if (Variable.Eleccion == 2) { Variable.limite = 2; } else if (Variable.Eleccion == 3){ Variable.limite = 0; }

            for (int z = 0; z < Variable.limite; z++) //Define el Limite de Ingredientes Adicionales dependiendo el Tipo de Hamburguesa
            {
                Console.WriteLine($"Que mas quisieras agregarle a la Hamburguesa? Puedes agregarle {Variable.limite} adicionales. Presione 0 Para finalizar de agregar \n");
                
                for (int x = 1; x < 7; x++) {Console.WriteLine($"{x}) {Ingredientes.adicionales[x-1]}");} //Muestra los Igredientes Adicionales que puedes elegir
                int eleccion = Convert.ToInt32(Console.ReadLine()); Console.Clear();
                if (eleccion >= 1 && eleccion <= 6)
                {
                    Registro.factura_ingredientes.Add(Ingredientes.adicionales[eleccion-1]); //Agrega el Ingrediente a la factura
                }
                else { break; }
            }

            Console.WriteLine("Su factura incluye: \n");
            Console.WriteLine(Ingredientes.hamburguesas[Variable.Eleccion - 1] + "\n"); //Muestra el tipo de Hamburguesa que elegiste
            foreach (string x in Registro.factura_ingredientes)
            {
                Console.WriteLine(x + " son " + Precios.adicionales[Registro.factura_ingredientes.IndexOf(x)] + " pesos");  //Muestra cada Ingrediente Adicional con su respectivo Precio que elegiste
                Variable.precio += Precios.adicionales[Registro.factura_ingredientes.IndexOf(x)];                             //Agrega el Precio de cada Ingrediente Adicional
            }
            Console.WriteLine($"\nLa factura hace {Variable.precio} pesos." + "\n\nPresione Cualquier Tecla para volver al Menu");
            Registro.factura_ingredientes.Clear();
            Console.ReadKey();
        }
    }
}

