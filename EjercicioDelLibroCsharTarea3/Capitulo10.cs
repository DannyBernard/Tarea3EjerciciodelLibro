using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDelLibroCsharTarea3
{
    class Capitulo10
    {
       private int ID { get; set; }
       private string nombre { get; set; }
       private double precio { get; set; }
       private double costo { get; set; }
       private double cantidad { get; set; }

      

        public Capitulo10()
        {
            ID = 0;
            precio = 0;
            costo = 0;
            cantidad = 0;
        }
        public Capitulo10(int id, string nombre, double costo, double precio, double cantidad)
        {
            this.ID = id;
            this.nombre = nombre;
            this.costo = costo;
            this.precio =precio;
            this.cantidad = cantidad;
        }



    }

    class Estudiante
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private string apellidos { get; set; }
        private string matricula { get; set; }
        private string cedula { get; set; }
        private string direccion { get; set; }
        private string carrera { get; set; }
        private string tetlefono { get; set; }

        public Estudiante()
        {
            id = 0;
        }
        public Estudiante(int id, string nombre,string apellidos,string matricula,string cedula,string direccion,string carrera,string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.matricula = matricula;
            this.cedula = cedula;
            this.direccion = direccion;
            this.carrera = carrera;
            this.tetlefono = tetlefono;


        }

    }
    
}
