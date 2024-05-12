namespace GuiaNum4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UNI uni = new UNI();

            Alumno alumno1 = new Alumno("Juan Espinoza", 20, "2022-0808U", Carreras.Ingenieria_Sistemas);
            alumno1.Calificaciones.AddRange(new List<double> { 60, 60, 60, 64, 71 });
            uni.AgregaAlumno(alumno1);

            Alumno alumno2 = new Alumno("Ismael Asensio", 20, "2022-0777U", Carreras.Ingenieria_Computacion);
            alumno2.Calificaciones.AddRange(new List<double> { 80, 80, 80, 77, 91 });
            uni.AgregaAlumno(alumno2);

            Alumno alumno3 = new Alumno("Nestor Soto", 19, "2022-0003U", Carreras.Ingenieria_Electronica);
            alumno3.Calificaciones.AddRange(new List<double> { 60, 70, 70, 80, 90 });
            uni.AgregaAlumno(alumno3);

            List<Alumno> listaAlumnos = uni.ObtenerListaAlumnos();
            Console.WriteLine("Lista de Alumnos:");
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine($"Nombre: {alumno.Nombre}");
                Console.WriteLine($"Edad: {alumno.Edad}");
                Console.WriteLine($"Carnet: {alumno.Carnet}");
                Console.WriteLine($"Carrera: {alumno.Carrera}");
                Console.WriteLine($"Calificaciones: {string.Join(", ", alumno.Calificaciones)}");
                Console.WriteLine($"Promedio: {alumno.CalcularPromedio()}");
                Console.WriteLine($"Estado: {alumno.EstadoAprobado()}");
                Console.WriteLine();
            }
        }
    }
}
