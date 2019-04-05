using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Genero { get; set; }
        public string Musica { get; set; }
        public string Color { get; set; }

        //constructores

        public Persona() { }

        public Persona(string Nombre, string Apellido, DateTime Nacimiento, string Genero, string Musica)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Color = Color;
            this.Genero = Genero;
            this.Musica = Musica;
            this.Color = Color;
        }

        public string nombreCompleto()
        {
            return Nombre + " " + Apellido;
        }
    }
}
