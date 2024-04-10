// See https://aka.ms/new-console-template for more information
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