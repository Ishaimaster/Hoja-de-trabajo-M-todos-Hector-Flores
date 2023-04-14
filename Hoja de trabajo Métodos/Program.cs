using Hoja_de_trabajo_Métodos;
using System;
// HECTOR JOSE FLORES PINEDA 1199923
class Metodos
{
    //Constructor
    public double radio;
    public double lado;
    public double alto;
    public double b;
    public double areacirculo;
    public double areatriangulo;
    public double areacuadrado;

    public double Calculareacirculo()
    {
      areacirculo = (radio*radio) * Math.PI;

      return areacirculo;

    }

    public double Calculareatriang()
    {
        areatriangulo = (b * alto) / 2;

         return areatriangulo;

    }

    public double Calcularareacuadrado()
    {


        areacuadrado  = lado * lado;


        return areacuadrado;
    }



    static void Main()
    {
        Metodos metodos = new Metodos();
        electrodom electrodom = new electrodom();
        Divisor divisor = new Divisor();
        bool continuar = true;
        while (continuar)
        {
            int op = 0;
            char c,c1,c2;
            Console.WriteLine("Ingrese el numero de ejercicio que desea");
            Console.WriteLine("1. Area de las figuras geometricas");
            Console.WriteLine("2. Precio final de un electrodomestico");
            Console.WriteLine("3. Numero divisores de un determinado numero");
            Console.WriteLine("4. Cerrar prgorama");
            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (op)
            {
                case 1:
                    while (true)
                    {

                        int option = 0;
                        Console.WriteLine("Selecciona la figura que desea calcular su area");
                        Console.WriteLine("1. Circulo");
                        Console.WriteLine("2. Triangulo");
                        Console.WriteLine("3. Cuadrado");
                        option = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (option)
                        {
                            case 1:

                                Console.WriteLine("Ingrese el radio del circulo");
                                metodos.radio = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("El area es: " + metodos.Calculareacirculo());

                                break;

                            case 2:

                                Console.WriteLine("Ingrese la base del triangulo");
                                metodos.b = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Ingrese la altura del triangulo");
                                metodos.alto = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("El area es: " + metodos.Calculareatriang());

                                break;

                            case 3:

                                Console.WriteLine("Ingrese el lado del cuadrado");
                                metodos.lado = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("El area es: " + metodos.Calcularareacuadrado());

                                break;


                        }


                        Console.WriteLine("Desea continuar?       s=si, n=no");
                        c = Convert.ToChar(Console.ReadLine().ToLower());

                        if (c == 'n')
                        {
                            break;
                        }
                        else
                        {

                        }
                        Console.Clear();
                    }
                    Console.Clear() ;

                    break;

                case 2:
                    while (true)
                    {
                        Console.WriteLine("Ingrese el precio base del electrodomestico");
                        electrodom.precio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el nivel de consumo electrico A/B/C/D");
                        electrodom.consumo = Console.ReadLine();
                        Console.WriteLine("Ingrese el peso del electrodomestico (en Kg)");
                        electrodom.peso = Convert.ToDouble(Console.ReadLine());

                        electrodom.Consumoenergia();

                        Console.WriteLine("El precio final del producto es: " + electrodom.Pesoprecio());

                        Console.WriteLine("Desea continuar?       s=si, n=no");
                        c1 = Convert.ToChar(Console.ReadLine().ToLower());

                        if (c1 == 'n')
                        {
                            break;
                        }
                        else
                        {

                        }
                        Console.Clear();

                    }
                    Console.Clear();
                    break;

                case 3:
                    while (true)
                    {


                        Console.WriteLine("Ingrese el numero entero a probar");
                        divisor.numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Los divisores son: ");
                        divisor.Division();

                        Console.WriteLine("Desea continuar?       s=si, n=no");
                        c2 = Convert.ToChar(Console.ReadLine().ToLower());

                        if (c2 == 'n')
                        {
                            break;
                        }
                        else
                        {

                        }
                        Console.Clear();
                    }
                    Console.Clear();
                    break;

                case 4:

                    continuar = false;

                    break;



            }


        }

    }
































}