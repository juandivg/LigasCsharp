using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoClases.Clases;
class Jugador : Persona {
    public string dorsal { get; set; }
    public string posicion { get; set; }
    public int nivelHabilidad { get; set; }

    public Jugador (string nombre, int id, int edad, string ciudadOrigen, string dorsal,string posicion, int nivelHabilidad): base (nombre,id,edad,ciudadOrigen){
        this.dorsal = dorsal;
        this.posicion = posicion;
        this.nivelHabilidad = nivelHabilidad;
        
    }
    public Jugador(){}
    public Jugador agregarJugador(){
        System.Console.WriteLine("Nombre del jugador:");
        string name=Console.ReadLine();
        System.Console.WriteLine("Id jugador");
        int id=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Edad");
        int age=int.Parse(Console.ReadLine());
        System.Console.WriteLine("CIudad de origen:");
        string city=Console.ReadLine();
        System.Console.WriteLine("Dorsal");
        string dorsal=Console.ReadLine();
        System.Console.WriteLine("Posicion");
        string posicion=Console.ReadLine();
        System.Console.WriteLine("Nivel habilidad");
        int nivel=int.Parse(Console.ReadLine());
        Jugador jugador=new Jugador(name, id, age, city, dorsal, posicion, nivel);
        return jugador;
    }
    public void listarJugadores(List<Jugador> Jugadores, Equipo equipo){
        System.Console.WriteLine($"JUgadores del equipo {equipo.nombre}");
        foreach(Jugador Jugador in Jugadores){
            System.Console.WriteLine($"{Jugador.nombre}");
        }
        Console.ReadKey();
    }

}