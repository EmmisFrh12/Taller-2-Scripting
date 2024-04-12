using System;

public class EventoEjemplo
{
    public delegate void EventHandler(object sender, EventArgs e);

    public event EventHandler MiEvento;

    public void DispararEvento()
    {
        Console.WriteLine("Disparando evento: ");

        if (MiEvento != null)
        {
            // Crear argumentos para el evento (en este caso, no se necesitan argumentos)
            EventArgs args = EventArgs.Empty;
 
            MiEvento(this, args);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        EventoEjemplo eventoEjemplo = new EventoEjemplo();

        // Suscribir un método al evento
        eventoEjemplo.MiEvento += ManejadorEvento;

        eventoEjemplo.DispararEvento();
    }

    public static void ManejadorEvento(object sender, EventArgs e)
    {
        Console.WriteLine("Eventooooooooooooooooooooo");
    }
}
