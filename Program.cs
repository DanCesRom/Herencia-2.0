namespace Herencia
{
    public class Program
    {
        static public void Main(String[] args)
        {
            for (int i = 0; i < 1;)
            {
                Variable.precio = 0;
                Console.Clear();
                Console.WriteLine("Elige tu hamburguesa: ");
                Console.WriteLine("");

                for (int x = 1; x < 4; x++) { Console.WriteLine($"{x}) {Ingredientes.hamburguesas[x - 1]} \n"); } //Muestra los tipos de Hamburguesas disponibles
                Console.WriteLine("4) Ver Precio Base de Hamburguesas e Ingredientes");     //Muestra los precios de las Hamburguesas y Adicionales
                Variable.Eleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Elecciones.Opciones();       //Corre la funcion .Opciones() en la Clase Elecciones, la cual se encarga del proceso de seleccion de Hamburguesa.

            }
        }
    }
}

