// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
//Cada uno va a hacer 10 funciones en este archivo para completar las treinta que hacen falta.
static double Suma (double numero1, double numero2)
{
   return numero1 + numero2;
}
static double Resta(double numero1, double numero2)
{
    return numero1 - numero2;
}
static double Producto(double numero1, double numero2)
{
    return numero1 * numero2;
}
static double Cociente(double numero1, double numero2)
{
    if (numero2 == 0)
    {
        return 0;
    }
    else
    {
        return numero1 / numero2;
    }
    
}

static double Potencia (double numero1, double numero2)
{
    return Math.Pow(numero1, numero2);
}

static void Respuesta(string mensaje)
{
    Console.WriteLine("Su mensaje ha sido: " + mensaje + " ¿es correcto?");
}

bool Comprobación(int opción)
{
    if (opción > 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
string Calificación (int nota)
{
    
    if (nota == 100)
    {
        return "A";
    }
    if (nota >= 75 && nota < 100)
    {
        return "B";
    }
    if (nota >= 50 && nota < 75)
    {
        return "C";
    }
    if (nota >= 25 && nota < 50)
    {
        return "D";
    }
    if (nota >= 0 && nota < 25)
    {
        return "F";
    }
    else
    {
        return "nota inválida";
    }

}

void Saludo()
{
    Console.WriteLine("Buenos días");
}
void Despedida()
{
    Console.WriteLine("Hasta Luego");
}

//Funciones de Emma

void Duplicador()
{
    int base1 = 0;
    Random rnd = new Random();
    int random = rnd.Next();

    Console.WriteLine("¿mortal, cuanto dinero tienes si me lo dás te recompensaré?");
    base1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ahora que has confiado en mi haré que tu fortuna crezca");
    Console.WriteLine(base1*random);
}

void Mayuscula()
{
    Console.WriteLine("escribe una plabra y la escribiré en mayuscula");
    string palabra = Console.ReadLine();
    string mayuscula = palabra.ToUpper();
}
void Miniscula()
{
    Console.WriteLine("escribe una plabra en mayuscula y la escribiré en Minuscula");
    string palabra2 = Console.ReadLine();
    string Minuscula = palabra2.ToLower();
}
void fecha()
{
    DateTime currentTime = DateTime.Now;
}
bool Confirmar(string respuesta)
{
    if (respuesta == "Si"||respuesta == "SI")
    {
        return true;
    }
    else
    {
        return false;
    }
}
double Promedio(double num1, double num2)
{
    return (num1 + num2) / 2;
}

double AreaRectangulo(double baserec, double alturarec)
{
    return baserec * alturarec;
}
double AreaTriangulo(double basetri, double alturatri)
{
    return (basetri * alturatri)/2;
}
double AreaCirculo(double radiocir)
{
    return radiocir*radiocir * Math.PI;
}
double VolumenCilindro(double radiocil, double alturacil)
{
    return radiocil * radiocil * alturacil* Math.PI;
}
double VolumenPrisma(double basepri, double alturapris, double anchopris)
{
    return basepri * alturapris * anchopris;
}

//Andres

static string Convertidor(int numero)
{
    return "El número es: " + numero.ToString();
}

 static void Funcion1()
{
    Console.WriteLine("Esta es la funcion1");
}

 static int Contador(int numero)
{
    numero++;
    return numero;
}

 static void Arreglo(string[] arreglo)
{
    foreach (string elemento in arreglo)
    {
        Console.WriteLine(elemento);
    }
}

 static void OrdenarLista<T>(List<T> lista, Comparison<T> comparador)
{
    lista.Sort(comparador);
}
static List<T> FiltrarLista<T>(List<T> lista, Predicate<T> predicado)
{
    return lista.FindAll(predicado);
}
 static void ProcesarLista<T>(List<T> lista, Action<T> accion)
{
    foreach (var elemento in lista)
    {
        accion(elemento);
    }
}
static List<TResult> MapearLista<T, TResult>(List<T> lista, Func<T, TResult> transformador)
{
    List<TResult> resultado = new List<TResult>();
    foreach (var elemento in lista)
    {
        resultado.Add(transformador(elemento));
    }
    return resultado;
}
static TResult AgregarLista<T, TResult>(List<T> lista, TResult valorInicial, Func<TResult, T, TResult> acumulador)
{
    TResult resultado = valorInicial;
    foreach (var elemento in lista)
    {
        resultado = acumulador(resultado, elemento);
    }
    return resultado;
}
static int RealizarOperacion(OperacionMatematica operacion, int numero1, int numero2)
{
    
    return operacion(numero1, numero2);
}

