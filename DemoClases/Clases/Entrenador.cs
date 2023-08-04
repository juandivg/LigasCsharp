using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoClases.Clases;
class Entrenador : Persona {
    public int codFederacion { get; set; }
    public string especialidad { get; set; }

    public Entrenador (string nombre, int id, int edad, string ciudadOrigen, int codFederacion,string especialidad): base (nombre,id,edad,ciudadOrigen){
        this.codFederacion = codFederacion;
        this.especialidad = especialidad;
    }
}