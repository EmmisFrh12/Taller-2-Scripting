using System;

enum TaskState
{
    INIT,
    WAIT_COMMANDS
}

public class PuntoTaller2Scripting
{
    // Declaración del delegado
    public delegate void Delegado();

    public delegate void DelegadoRespuesta(string mensaje);

    public delegate string DelegadoString(int nota);

    public delegate bool DelegadoBool(int entero);

    public delegate double DelegadoDouble(double numero1, double numero2);

    public delegate string DelegadoStringInt(int numero);



    private static TaskState taskState = TaskState.INIT;

    public static void Funcion1()
    {
        Console.WriteLine("Esta es la funcion1");
    }
    public static double Suma(double numero1, double numero2)
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

    static double Potencia(double numero1, double numero2)
    {
        return Math.Pow(numero1, numero2);
    }

    static void Respuesta(string mensaje)
    {
        Console.WriteLine("Su mensaje ha sido: " + mensaje + " ¿es correcto?");
    }

    static bool Comprobación(int opción)
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
    static string Calificación(int nota)
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

    static void Saludo()
    {
        Console.WriteLine("Buenos días");
    }
    static void Despedida()
    {
        Console.WriteLine("Hasta Luego");
    }

    public static string Convertidor(int numero)
    {
        return "El número es: " + numero.ToString();
    }


    public static void Main(string[] args)
    {
        ConsoleKeyInfo buffer = Console.ReadKey();
        

        while (true)
        {
            switch (taskState)
            {
                case TaskState.INIT:
                    taskState = TaskState.WAIT_COMMANDS;
                    Console.WriteLine("WAIT COMMANDS");
                    break;
                case TaskState.WAIT_COMMANDS:

                    if(buffer.Key == ConsoleKey.A) {
                        Delegado elQueTengoAquiColgado = Funcion1;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.B)
                    {
                        DelegadoDouble elQueTengoAquiColgado = Suma;
                        elQueTengoAquiColgado(1,2);
                    }
                    if (buffer.Key == ConsoleKey.C)
                    {
                        DelegadoDouble elQueTengoAquiColgado = Resta;
                        elQueTengoAquiColgado(1,2);
                    }
                    if (buffer.Key == ConsoleKey.D)
                    {
                        DelegadoDouble elQueTengoAquiColgado = Producto;
                        elQueTengoAquiColgado(1,2);
                    }
                    if (buffer.Key == ConsoleKey.E)
                    {
                        DelegadoDouble elQueTengoAquiColgado = Cociente;
                        elQueTengoAquiColgado(1,2);
                    }
                    if (buffer.Key == ConsoleKey.F)
                    {
                        DelegadoDouble elQueTengoAquiColgado = Potencia;
                        elQueTengoAquiColgado(1,2);
                    }
                    if (buffer.Key == ConsoleKey.G)
                    {
                        DelegadoRespuesta elQueTengoAquiColgado = Respuesta;
                        elQueTengoAquiColgado("este es el mensaje");
                    }
                    if (buffer.Key == ConsoleKey.H)
                    {
                        DelegadoBool elQueTengoAquiColgado = Comprobación;
                        elQueTengoAquiColgado(2);
                    }
                    if (buffer.Key == ConsoleKey.I)
                    {
                        DelegadoString elQueTengoAquiColgado = Calificación;
                        elQueTengoAquiColgado(5);
                    }
                    if (buffer.Key == ConsoleKey.J)
                    {
                        Delegado elQueTengoAquiColgado = Saludo;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.K)
                    {
                        Delegado elQueTengoAquiColgado = Despedida;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.L)
                    {
                        DelegadoStringInt elQueTengoAquiColgado = Convertidor;
                        elQueTengoAquiColgado(5);
                    }
                    if (buffer.Key == ConsoleKey.M)
                    {
                        Delegado elQueTengoAquiColgado = Funcion13;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.N)
                    {
                        Delegado elQueTengoAquiColgado = Funcion14;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.O)
                    {
                        Delegado elQueTengoAquiColgado = Funcion15;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.P)
                    {
                        Delegado elQueTengoAquiColgado = Funcion16;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.Q)
                    {
                        Delegado elQueTengoAquiColgado = Funcion17;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.R)
                    {
                        Delegado elQueTengoAquiColgado = Funcion18;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.S)
                    {
                        Delegado elQueTengoAquiColgado = Funcion19;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.T)
                    {
                        Delegado elQueTengoAquiColgado = Funcion20;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.U)
                    {
                        Delegado elQueTengoAquiColgado = Funcion21;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.V)
                    {
                        Delegado elQueTengoAquiColgado = Funcion22;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.W)
                    {
                        Delegado elQueTengoAquiColgado = Funcion23;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.X)
                    {
                        Delegado elQueTengoAquiColgado = Funcion24;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.Y)
                    {
                        Delegado elQueTengoAquiColgado = Funcion25;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.Z)
                    {
                        Delegado elQueTengoAquiColgado = Funcion26;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.D1)
                    {
                        Delegado elQueTengoAquiColgado = Funcion27;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.D2)
                    {
                        Delegado elQueTengoAquiColgado = Funcion28;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.D3)
                    {
                        Delegado elQueTengoAquiColgado = Funcion29;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.D4)
                    {
                        Delegado elQueTengoAquiColgado = Funcion30;
                        elQueTengoAquiColgado();
                    }

                    break;
                default:
                    Console.WriteLine("State Error");
                    break;
            }

            System.Threading.Thread.Sleep(1000);
        }
    }
}


