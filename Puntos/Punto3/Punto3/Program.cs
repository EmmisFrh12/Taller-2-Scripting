using System;

public class EventoEjemplo
{
    public delegate void EventHandler(object sender, EventArgs e);

    public event EventHandler Evento;

    public void DispararEvento()
    {
        Console.WriteLine("Disparando evento: ");

        if (Evento != null)
        {
            
            EventArgs args = EventArgs.Empty;
 
            Evento(this, args);
            //No se necesitan argumentos en el ejemplo, pero sirven para dar informacion relevante sobre el evento
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        EventoEjemplo eventoEjemplo = new EventoEjemplo();

        // Suscribir un método al evento
        eventoEjemplo.Evento += ManejadorEvento;

        eventoEjemplo.DispararEvento();
    }

    public static void ManejadorEvento(object sender, EventArgs e)
    {
        Console.WriteLine("Escuche el eventooooooooooooooooooooo");
    }
}
