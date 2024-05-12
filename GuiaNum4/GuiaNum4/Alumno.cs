using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaNum4
{
    public enum Carreras
    {
        Ingenieria_Sistemas,
        Ingenieria_Computacion,
        Ingenieria_Electronica,
        Telecomunicaciones
    }
    public partial class Alumno
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public string Carnet { get; set; }
        public Carreras Carrera { get; set; }
        public List<double> Calificaciones { get; set; } 

        public Alumno(string nombre, int edad, string carnet, Carreras carrera)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Carrera = carrera;
            this.Carnet = carnet;
            Calificaciones = new List<double>();
        }

        public double CalcularPromedio()
        {
            if (Calificaciones.Count == 0) 
            {
                return 0;
            }

            double sumaCalificaciones = 0;
            foreach (var calificacion in Calificaciones)
            {
                sumaCalificaciones += calificacion;
            }

            return sumaCalificaciones / Calificaciones.Count;
        }

        public string EstadoAprobado()
        {
            double promedio = CalcularPromedio();
            if (promedio >=60)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }
    
                                                                    


    
}
