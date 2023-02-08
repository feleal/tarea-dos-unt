internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio N° 2");

        double precio = 0;
        double valorIVA;
        double Final;

        Console.WriteLine("Ingrese el precio...");
        precio= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" el precio del producto es...."+precio);
        Console.WriteLine("");
        // llamado a la funcion pasar el precio 
        valorIVA= obtenerIva(precio);
        Console.WriteLine();
        // muestra el resultado de la operacion---
        Console.WriteLine("el precio del producto es..."+precio);
        Final = valorIVA + precio;
        Console.WriteLine("el precip final con el IVA es...."+ Final);

        Console.ReadKey();  
       
    }
     public static double obtenerIva(double p)
     {
        double valorIva;// este es el precio por el importe
        valorIva = p * 0.21;
        return valorIva;   
     }
}