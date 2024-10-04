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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            CargarMaterias();
        }

        private void CargarMaterias()
        {
            List<Materia> listaMaterias = Central.ObtenerMaterias();

            foreach (var materia in listaMaterias)
            {
                ListViewItem item = new ListViewItem(materia.Nombre);
                item.SubItems.Add(materia.Codigo);
                listaMateriasView.Items.Add(item);  // listaMateriasView es un ListView en el formulario
            }
        }

        private void BtnAgregarMateria_Click(object sender, EventArgs e)
        {
            FormAgregarMateria agregarMateriaForm = new FormAgregarMateria();
            agregarMateriaForm.Show();
        }
    }
}

public partial class FormAgregarMateria : Form
{
    public FormAgregarMateria()
    {
        InitializeComponent();
    }

    private void BtnGuardarMateria_Click(object sender, EventArgs e)
    {
        Materia nuevaMateria = new Materia
        {
            Nombre = txtNombreMateria.Text,
            Codigo = txtCodigoMateria.Text
        };

        Central.RegistrarMateria(nuevaMateria);
        MessageBox.Show("Materia registrada con éxito.");
        this.Close();
    }
}

class Central
{
    public static List<Materia> ObtenerMaterias()
    {
        // Código para obtener la lista de materias
        return new List<Materia>
        {
            new Materia { Nombre = "Matemáticas", Codigo = "MAT101" },
            new Materia { Nombre = "Física", Codigo = "FIS201" }
        };
    }

    public static void RegistrarMateria(Materia materia)
    {
        // Código para registrar la materia
    }
}

public class Materia
{
    public string Nombre { get; set; }
    public string Codigo { get; set; }
}
