using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
            CargarAlumnos();
        }

        private void AgregarAlumno(object sender, EventArgs e)
        {
            RegistrarAlumno reg = new RegistrarAlumno();
            reg.Show();
        }

        private void CargarAlumnos()
        {
            List<Alumno> listaAlumnos = Central.ObtenerAlumnos();  // Obtener lista de alumnos desde Central

            // Ejemplo de cómo podrías mostrar los alumnos en una lista o tabla:
            foreach (var alumno in listaAlumnos)
            {
                ListViewItem item = new ListViewItem(alumno.Nombre);
                item.SubItems.Add(alumno.Matricula);
                item.SubItems.Add(alumno.Grupo);
                listaAlumnosView.Items.Add(item);  // listaAlumnosView es un ListView en el formulario
            }
        }
    }
}

