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

        public Persona(string nombre, string apellido, DateTime nacimiento, string genero, string musica)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacimiento = Nacimiento;
            this.Genero = genero;
            this.Musica = musica;
            this.Color = color;
        }

        public string nombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public int NacimientoCalcular()
        {

        }
    }
}
