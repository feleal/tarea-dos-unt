// See https://aka.ms/new-console-template for more information

//Crea un programa que calcule el IVA de un producto.
//El valor de este producto se pasará por teclado y nos mostrará por pantalla el
//valor del IVA y su valor final. El IVA es el 21 %. Por ejemplo,
//si introducimos 100 como valor de producto, el IVA es 21 y el valor
//final es 121.


string producto = "";
double iva = 0.21;
double precio = 0;
double precioConIva = 0;
double total = 0;


Console.WriteLine("Ingrese el producto que desea registrar..");
producto = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("ingrese el precio del producto..");
precio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("el precio del producto es .." + precio);

Console.WriteLine("");
Console.WriteLine(" el importe del IVA es..." + iva);
Console.WriteLine("");
precioConIva = precio * iva;
Console.WriteLine();
Console.WriteLine(" el importe del producto mas el precio iva es:...." + precioConIva);
Console.WriteLine();
total = precio + precioConIva;
Console.WriteLine(" el precio total, incluyendo al iva es.." + total);
Console.WriteLine();

Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

// Crea un programa muestre los números entre el 0 y el 100,
// que no sean divisibles por 2. Usa un ciclo While.


// profe espero estes bien, tenes que descomentar el ejercicio de arriba para poder correrlo



//int n = 1;

//while (n >= 100)
//{

//    if (n % 2 != 0)
//    {
//        Console.WriteLine("los numeros son..." + n);

//    }
//    n++;
//}




Console.ReadKey();
//Console.ReadKey();