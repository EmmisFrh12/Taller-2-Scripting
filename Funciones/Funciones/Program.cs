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