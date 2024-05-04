// See https://aka.ms/new-console-template for more information

// Ejercicio 01: Operaciones Básicas
Console.WriteLine("Ingrese dos números:");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Suma: {num1 + num2}");
Console.WriteLine($"Resta: {num1 - num2}");
Console.WriteLine($"Multiplicación: {num1 * num2}");
if (num2 != 0)
    Console.WriteLine($"División: {num1 / num2}");
else
    Console.WriteLine("No se puede dividir entre cero.");

// Ejercicio 02: Verificación de Número Par o Impar
Console.WriteLine("Ingrese un número:");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero % 2 == 0)
    Console.WriteLine("El número es par.");
else
    Console.WriteLine("El número es impar.");

// Ejercicio 03: Área de un Triángulo
Console.WriteLine("Ingrese la base del triángulo:");
double baseTriangulo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triángulo:");
double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
Console.WriteLine($"El área del triángulo es: {areaTriangulo}");

// Ejercicio 04: Calculadora de Factorial
Console.WriteLine("Ingrese un número para calcular su factorial:");
int numFactorial = Convert.ToInt32(Console.ReadLine());
long factorial = CalcularFactorial(numFactorial);
Console.WriteLine($"El factorial de {numFactorial} es: {factorial}");

static long CalcularFactorial(int num)
{
    if (num == 0)
        return 1;
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}

// Ejercicio 05: Número Primo
Console.WriteLine("Ingrese un número para verificar si es primo:");
int numPrimo = Convert.ToInt32(Console.ReadLine());
if (EsPrimo(numPrimo))
    Console.WriteLine($"{numPrimo} es un número primo.");
else
    Console.WriteLine($"{numPrimo} no es un número primo.");

static bool EsPrimo(int num)
{
    if (num <= 1)
        return false;
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}

// Ejercicio 06: Inversión de Cadena
Console.WriteLine("Ingrese una cadena de texto:");
string cadena = Console.ReadLine();
string cadenaInvertida = InvertirCadena(cadena);
Console.WriteLine($"La cadena invertida es: {cadenaInvertida}");

static string InvertirCadena(string cadena)
{
    char[] charArray = cadena.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

// Ejercicio 07: Suma de Números Pares en un Rango Especificado
Console.WriteLine("Ingrese el límite inferior del rango:");
int limiteInferior = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el límite superior del rango:");
int limiteSuperior = Convert.ToInt32(Console.ReadLine());
int sumaPares = SumaNumerosPares(limiteInferior, limiteSuperior);
Console.WriteLine($"La suma de los números pares en el rango [{limiteInferior}, {limiteSuperior}] es: {sumaPares}");

static int SumaNumerosPares(int inicio, int fin)
{
    int suma = 0;
    for (int i = inicio; i <= fin; i++)
    {
        if (i % 2 == 0)
            suma += i;
    }
    return suma;
}

// Ejercicio 08: Lista de Cuadrados de los Primeros 10 Números Naturales
Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
ListarCuadradosPrimerosNaturales();
static void ListarCuadradosPrimerosNaturales()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i}^2 = {i * i}");
    }
}

// Ejercicio 09: Contador de Vocales en una Cadena de Texto
Console.WriteLine("Ingrese una cadena de texto:");
string texto = Console.ReadLine();
int contadorVocales = ContarVocales(texto);
Console.WriteLine($"El número de vocales en la cadena es: {contadorVocales}");
static int ContarVocales(string texto)
{
    int contador = 0;
    foreach (char c in texto)
    {
        if ("aeiouAEIOU".Contains(c))
            contador++;
    }
    return contador;
}

// Ejercicio 10: Números de la Serie Fibonacci
Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
for (int i = 0; i < 10; i++)
{
    Console.Write(Fibonacci(i) + " ");
}
Console.WriteLine();
static int Fibonacci(int n)
{
    if (n <= 1)
        return n;
    int a = 0, b = 1;
    for (int i = 2; i <= n; i++)
    {
        int temp = a + b;
        a = b;
        b = temp;
    }
    return b;
}

// Ejercicio 11: Ordenamiento de Lista de Números
Console.WriteLine("Ingrese una lista de números separados por comas:");
string[] numerosStr = Console.ReadLine().Split(',');
int[] numeros = Array.ConvertAll(numerosStr, int.Parse);
Array.Sort(numeros);
Console.WriteLine("Lista ordenada de menor a mayor:");
Console.WriteLine(string.Join(", ", numeros));

// Ejercicio 12: Palíndromo
Console.WriteLine("Ingrese una palabra para verificar si es un palíndromo:");
string palabra = Console.ReadLine().ToLower();
bool esPalindromo = EsPalindromo(palabra);
if (esPalindromo)
    Console.WriteLine("La palabra es un palíndromo.");
else
    Console.WriteLine("La palabra no es un palíndromo.");
static bool EsPalindromo(string palabra)
{
    int inicio = 0;
    int fin = palabra.Length - 1;
    while (inicio < fin)
    {
        if (palabra[inicio] != palabra[fin])
            return false;
        inicio++;
        fin--;
    }
    return true;
}

// Ejercicio 13: Generador de Tablas de Multiplicar
Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
int numeroTabla = Convert.ToInt32(Console.ReadLine());
GenerarTablaMultiplicar(numeroTabla);
static void GenerarTablaMultiplicar(int numero)
{
    Console.WriteLine($"Tabla de multiplicar del {numero}:");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}

// Ejercicio 14: Cálculo del Área de un Círculo
Console.WriteLine("Ingrese el radio del círculo:");
double radio = Convert.ToDouble(Console.ReadLine());
double area = CalcularAreaCirculo(radio);
Console.WriteLine($"El área del círculo es: {area}");
static double CalcularAreaCirculo(double radio)
{
    return Math.PI * Math.Pow(radio, 2);
}

// Ejercicio 15: Suma de Dígitos de un Número Entero
Console.WriteLine("Ingrese un número entero para calcular la suma de sus dígitos:");
int numeroEntero = Convert.ToInt32(Console.ReadLine());
int sumaDigitos = SumaDigitos(numeroEntero);
Console.WriteLine($"La suma de los dígitos del número es: {sumaDigitos}");
static int SumaDigitos(int numero)
{
    int suma = 0;
    while (numero != 0)
    {
        suma += numero % 10;
        numero /= 10;
    }
    return suma;
}

Console.ReadLine();
