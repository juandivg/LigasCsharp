namespace DemoClases.View;

public class MenuPlantel
{
    public MenuPlantel()
    {
    }

    public int menuPlantel()
    {
            Console.Clear();
            Console.WriteLine("1.Registro de equipo");
            Console.WriteLine("2.Registro Jugador");
            Console.WriteLine("3.Registro Entrenador");
            Console.WriteLine("4.Registro Masajista");
            Console.WriteLine("5.Venta jugador");
            Console.WriteLine("6.Salir");
            return int.Parse(Console.ReadLine());
    }      
}
