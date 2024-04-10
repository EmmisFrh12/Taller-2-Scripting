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

    private static TaskState taskState = TaskState.INIT;

    // Función que será asignada al delegado
    public static void Funcion1()
    {
        Console.WriteLine("MyFunction was called!");
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
                        Delegado elQueTengoAquiColgado = Funcion2;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.C)
                    {
                        Delegado elQueTengoAquiColgado = Funcion3;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.D)
                    {
                        Delegado elQueTengoAquiColgado = Funcion4;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.E)
                    {
                        Delegado elQueTengoAquiColgado = Funcion5;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.F)
                    {
                        Delegado elQueTengoAquiColgado = Funcion6;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.G)
                    {
                        Delegado elQueTengoAquiColgado = Funcion7;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.H)
                    {
                        Delegado elQueTengoAquiColgado = Funcion8;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.I)
                    {
                        Delegado elQueTengoAquiColgado = Funcion9;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.J)
                    {
                        Delegado elQueTengoAquiColgado = Funcion10;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.K)
                    {
                        Delegado elQueTengoAquiColgado = Funcion11;
                        elQueTengoAquiColgado();
                    }
                    if (buffer.Key == ConsoleKey.L)
                    {
                        Delegado elQueTengoAquiColgado = Funcion12;
                        elQueTengoAquiColgado();
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


