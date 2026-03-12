using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace simulacroparcial1by
{
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
            CargarTalleres();
            LlenarCombos();
        }

        void CargarEstudiantes()
        {
            string ruta = Application.StartupPath + "\\estudiantes.txt";

            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encontró estudiantes.txt");
                return;
            }

            string[] lineas = File.ReadAllLines(ruta);

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                Estudiante est = new Estudiante
                {
                    DPI = datos[0],
                    Nombre = datos[1],
                    Direccion = datos[2]
                };

                estudiantes.Add(est);
            }
        }

        void CargarTalleres()
        {
            string ruta = Application.StartupPath + "\\talleres.txt";

            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encontró talleres.txt");
                return;
            }

            string[] lineas = File.ReadAllLines(ruta);

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                Taller t = new Taller
                {
                    Codigo = datos[0],
                    Nombre = datos[1],
                    Costo = double.Parse(datos[2])
                };

                talleres.Add(t);
            }
        }

        void LlenarCombos()
        {
            comboEstudiante.DataSource = estudiantes;
            comboEstudiante.DisplayMember = "Nombre";

            comboTaller.DataSource = talleres;
            comboTaller.DisplayMember = "Nombre";
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (comboEstudiante.SelectedItem == null || comboTaller.SelectedItem == null)
            {
                MessageBox.Show("Seleccione estudiante y taller");
                return;
            }

            Estudiante est = (Estudiante)comboEstudiante.SelectedItem;
            Taller tal = (Taller)comboTaller.SelectedItem;

            Inscripcion nueva = new Inscripcion
            {
                DPI = est.DPI,
                CodigoTaller = tal.Codigo,
                Fecha = DateTime.Now
            };

            inscripciones.Add(nueva);

            string ruta = Application.StartupPath + "\\inscripciones.txt";

            File.AppendAllText(ruta,
                nueva.DPI + "," +
                nueva.CodigoTaller + "," +
                nueva.Fecha.ToShortDateString() +
                Environment.NewLine);

            MessageBox.Show("Inscripción realizada");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            listBoxReporte.Items.Clear();

            foreach (var i in inscripciones)
            {
                Estudiante est = estudiantes.Find(x => x.DPI == i.DPI);
                Taller tal = talleres.Find(t => t.Codigo == i.CodigoTaller);

                listBoxReporte.Items.Add(est.Nombre + " - " + tal.Nombre);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listBoxReporte.Items.Clear();

            var ordenado = inscripciones.OrderBy(i =>
                talleres.Find(t => t.Codigo == i.CodigoTaller).Nombre);

            foreach (var i in ordenado)
            {
                Estudiante est = estudiantes.Find(x => x.DPI == i.DPI);
                Taller tal = talleres.Find(t => t.Codigo == i.CodigoTaller);

                listBoxReporte.Items.Add(est.Nombre + " - " + tal.Nombre);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total de estudiantes inscritos: " + inscripciones.Count);
        }

        private void listBoxReporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Estudiante
    {
        public string DPI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
    }

    public class Taller
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
    }

    public class Inscripcion
    {
        public string DPI { get; set; }
        public string CodigoTaller { get; set; }
        public DateTime Fecha { get; set; }
    }
}

