
using System;

class Program
{
    // 1. Suma recursiva: O(n)
    static long SumaRecursiva(int n)
    {
        if (n <= 0)
            return 0;

        long resultado = n + SumaRecursiva(n - 1);

        Console.WriteLine(
            $"Sumando {n}: resultado parcial = {resultado}");

        return resultado;
    }

    // 2. Factorial: O(n)
    static long Factorial(int n)
    {
        if (n <= 1)
            return 1;

        return n * Factorial(n - 1);
    }

    // 3. Potencia: O(n)
    static long Potencia(int baseNum, int exponente)
    {
        if (exponente == 0)
            return 1;

        return baseNum * Potencia(baseNum, exponente - 1);
    }

    // 4. Fibonacci: O(2^n)
    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // 5. Suma de digitos: O(log n)
    static int SumaDigitos(int n)
    {
        if (n < 10)
            return n;

        return n % 10 + SumaDigitos(n / 10);
    }

    // 6. Maximo comun divisor: O(log n)
    static int MCD(int a, int b)
    {
        if (b == 0)
            return a;

        return MCD(b, a % b);
    }

    //7. Resta de digitos: O(log n)
    static int RestaDigitos(int n)
    {
        if (n < 10)
            return n;

        return n % 10 - RestaDigitos(n / 10);
    }

    // Leer numeros enteros

    static int LeerEntero(string mensaje)
    {
        int numero;

        Console.Write(mensaje);

        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Entrada invalida. Intenta de nuevo: ");
        }

        return numero;
    }


    // Mostrar complejidades
    static void MostrarComplejidades()
    {
        Console.WriteLine("\n--- COMPLEJIDAD ALGORITMICA ---");
        Console.WriteLine("1. Suma recursiva: O(n)");
        Console.WriteLine("2. Factorial: O(n)");
        Console.WriteLine("3. Potencia: O(n)");
        Console.WriteLine("4. Fibonacci: O(2^n)");
        Console.WriteLine("5. Suma de digitos: O(log n)");
        Console.WriteLine("6. MCD: O(log n)");

        Console.WriteLine("\nComplejidad espacial:");
        Console.WriteLine("1. Suma recursiva: O(n)");
        Console.WriteLine("2. Factorial: O(n)");
        Console.WriteLine("3. Potencia: O(n)");
        Console.WriteLine("4. Fibonacci: O(n)");
        Console.WriteLine("5. Suma de digitos: O(log n)");
        Console.WriteLine("6. MCD: O(log n)");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n==============================");
        Console.WriteLine("   CALCULADORA RECURSIVA");
        Console.WriteLine("==============================");
        Console.WriteLine("1. Suma recursiva");
        Console.WriteLine("2. Factorial");
        Console.WriteLine("3. Potencia");
        Console.WriteLine("4. Fibonacci");
        Console.WriteLine("5. Suma de digitos");
        Console.WriteLine("6. Maximo comun divisor");
        Console.WriteLine("7. Resta de digitos");
        Console.WriteLine("8. Ver complejidades");
        Console.WriteLine("0. Salir");
        Console.WriteLine("==============================");
    }

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            MostrarMenu();
            opcion = LeerEntero("Selecciona una opcion: ");

            switch (opcion)
            {
                case 1:
                    {
                        int n = LeerEntero(
                            "Ingresa un numero entre 1 y 100: ");

                        if (n >= 1 && n <= 100)
                        {
                            long resultado = SumaRecursiva(n);
                            Console.WriteLine(
                                $"La suma total de 1 hasta {n} es: {resultado}");
                        }
                        else
                            Console.WriteLine("Numero fuera de rango.");

                        break;
                    }

                case 2:
                    {
                        int n = LeerEntero(
                            "Ingresa un numero entre 0 y 20: ");

                        if (n >= 0 && n <= 20)
                            Console.WriteLine($"Factorial: {Factorial(n)}");
                        else
                            Console.WriteLine("Numero fuera de rango.");

                        break;
                    }

                case 3:
                    {
                        int b = LeerEntero("Ingresa la base (-100 a 100): ");
                        int e = LeerEntero("Ingresa el exponente (0 a 20): ");

                        if (b >= -100 && b <= 100 && e >= 0 && e <= 20)
                            Console.WriteLine($"Resultado: {Potencia(b, e)}");
                        else
                            Console.WriteLine("Valores fuera de rango.");

                        break;
                    }

                case 4:
                    {
                        int n = LeerEntero("Posicion Fibonacci (0 a 40): ");

                        if (n >= 0 && n <= 40)
                            Console.WriteLine($"Fibonacci: {Fibonacci(n)}");
                        else
                            Console.WriteLine("Numero fuera de rango.");

                        break;
                    }

                case 5:
                    {
                        int n = LeerEntero("Ingresa un numero entre 0 y 2000000000: ");

                        if (n >= 0)
                            Console.WriteLine($"Suma de digitos: {SumaDigitos(n)}");
                        else
                            Console.WriteLine("Ingresa un numero no negativo.");

                        break;
                    }

                case 6:
                    {
                        int a = LeerEntero("Ingresa el primer numero: ");
                        int b = LeerEntero("Ingresa el segundo numero: ");

                        if (a >= 0 && b >= 0 && (a != 0 || b != 0))
                            Console.WriteLine($"MCD: {MCD(a, b)}");
                        else
                            Console.WriteLine("Numeros invalidos.");

                        break;
                    }

                case 7:
                    {
                        int n = LeerEntero("Ingresa un numero entre 0 y 2000000000: ");

                        if (n >= 0)
                            Console.WriteLine($"Resta de digitos: {RestaDigitos(n)}");
                        else
                            Console.WriteLine("Ingresa un numero no negativo.");

                        break;
                    }

                case 8:
                    MostrarComplejidades();
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }

        } while (opcion != 0);
    }
}