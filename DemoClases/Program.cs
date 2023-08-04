using DemoClases.View;
using DemoClases.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Liga> Ligas = new List<Liga>();
        MainMenu menu = new MainMenu();
        int opcion = 0;
        do
        {
            opcion = menu.menu();
            switch (opcion)
            {
                case 1:
                    int opcionPlantel = 0;
                    MenuPlantel menuPlantel = new MenuPlantel();
                    do
                    {
                        opcionPlantel = menuPlantel.menuPlantel();
                        Liga ligabuscar = new Liga();
                        Liga opcionliga;
                        Equipo opcionequipo;
                        Equipo equipo = new Equipo();
                        Jugador jugador=new Jugador();
                        Jugador player;
                        switch (opcionPlantel)
                        {
                            case 1:

                                opcionliga = ligabuscar.buscarLiga(Ligas);
                                opcionequipo = equipo.agregarEquipo();
                                opcionliga.EquiposDeLiga.Add(opcionequipo);
                                equipo.listarEquipos(opcionliga.EquiposDeLiga);
                                break;
                            case 2:
                                opcionliga = ligabuscar.buscarLiga(Ligas);
                                opcionequipo=equipo.buscarEquipo(opcionliga.EquiposDeLiga);
                                player=jugador.agregarJugador();
                                opcionequipo.jugadores.Add(player);
                                jugador.listarJugadores(opcionequipo.jugadores, opcionequipo);
                                break;
                            default:
                                break;
                        }
                    } while (opcionPlantel != 6);
                    break;
                case 2:
                    int opcionBuscar = 0;
                    MenuBusqueda menuBusqueda = new MenuBusqueda();
                    do
                    {
                        opcionPlantel = menuBusqueda.menuBuscar();
                    } while (opcionBuscar != 5);
                    break;
                case 3:
                    Liga liga = new Liga();
                    Ligas.Add(liga.agregarLiga());
                    liga.mostrarLigas(Ligas);
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        } while (opcion != 4);
    }



}



