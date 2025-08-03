using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());
        // Implementar la lógica de menú
        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese el primer número: ");
                double sumaNum1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                double sumaNum2 = double.Parse(Console.ReadLine());
                double sumaResultado = Sumar(sumaNum1, sumaNum2);
                Console.WriteLine($"El resultado de la suma es: {sumaResultado}");
                break;
            case 2:
                Console.Write("Ingrese el primer número: ");
                double restaNum1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                double restaNum2 = double.Parse(Console.ReadLine());
                double restaResultado = Restar(restaNum1, restaNum2);
                Console.WriteLine($"El resultado de la resta es: {restaResultado}");
                break;
            case 3:
                Console.Write("Ingrese el primer número: ");
                double multiNum1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                double multiNum2 = double.Parse(Console.ReadLine());
                double multiResultado = Multiplicar(multiNum1, multiNum2);
                Console.WriteLine($"El resultado de la multiplicación es: {multiResultado}");
                break;
            case 4:
                Console.Write("Ingrese el primer número: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                double num2 = double.Parse(Console.ReadLine());
                double resultado = Dividir(num1, num2);
                Console.WriteLine($"El resultado de la división es: {resultado}");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    // Implementar funciones de suma, resta, multiplicación, división
    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static double Restar(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("No se puede dividir por cero.");
            return double.NaN;
        }
        return a / b;
    }
}