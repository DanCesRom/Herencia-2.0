namespace Herencia
{
    public class Ingredientes
    {
        public static readonly string[] adicionales = { "Lechuga", "Tomates", "Bacon", "Pepinillos", "Queso", "Cebolla" };           //Arreglo de elementos de los Ingredientes
        public static readonly string[] hamburguesas = { "Hamburguesa Clasica", "Hamburguesa Saludable", "Hamburguesa Premium", };    //Arreglo de tipos de Hamburguesas
    }
    public class Precios
    {
        public static readonly int[] adicionales = { 12, 17, 20, 14, 16, 10};   //Arreglo que contiene los precios de los Ingredientes
        public static readonly int[] hamburguesas = { 60, 45, 95 };              //Arreglo que contiene los precios de los tipos de Hamburguesas
    }

    public class Registro
    {
        public static List<string> factura_ingredientes = new List<string>();       //Lista que contiene los elementos a facturar
    }

    public class Tipos
    {
        public static readonly string[] clasica = { "Pan Brioche", "Carne" };                      //Arreglo que contiene elementos de Hamburguesa Clasica
        public static readonly string[] saludable = { "Pan Integral", "Carne" };                   //Arreglo que contiene elementos de Hamburguesa Saludable
        public static readonly string[] premium = { "Pan Relleno", "Carne", "Papitas", "Bebida" }; //Arreglo que contiene elementos de Hamburguesa Premium
    }

    public class Variable
    {
        public static int precio;
        public static int Eleccion;
        public static int limite;

    }


}

