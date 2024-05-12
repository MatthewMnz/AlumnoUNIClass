using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaNum4
{
    public partial class UNI
    {
        private List<Alumno> alumnoList;

        public UNI()
        {
            alumnoList = new List<Alumno>();
        }

        public void AgregaAlumno(Alumno alumno)
        {
            alumnoList.Add(alumno);
        }

        public List<Alumno> ObtenerListaAlumnos()
        {
            return alumnoList;
        }
    }
      
}
