using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class Central
    {
        private static List<Alumno> listaAlumnos = new List<Alumno>();

        public static void RegistrarAlumno(Alumno alumno)
        {
            if (alumno != null && !string.IsNullOrEmpty(alumno.Nombre) && !string.IsNullOrEmpty(alumno.Matricula))
            {
                listaAlumnos.Add(alumno);  // Agrega el alumno a la lista
                MessageBox.Show("Alumno registrado con éxito.");
            }
            else
            {
                MessageBox.Show("Datos del alumno incompletos.");
            }
        }

        public static List<Alumno> ObtenerAlumnos()
        {
            return listaAlumnos;
        }
    }

    public class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Grupo { get; set; }
    }
