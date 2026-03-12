using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacroparcial1by
{
    public partial class Form1 : Form
    {
        //primer commit
        List<Estudiante> estudiantes = new List<Estudiante>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();

        public Form1()
        {
            InitializeComponent();

            CargarEstudiantes();
            CargarTalleres();
            LlenarCombos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void CargarEstudiantes()
        {
            foreach (var linea in File.ReadAllLines("estudiantes.txt"))
            {
                var datos = linea.Split(',');

                estudiantes.Add(new Estudiante
                {
                    DPI = datos[0],
                    Nombre = datos[1],
                    Direccion = datos[2]
                });
            }
        }

        void CargarTalleres()
        {
            foreach (var linea in File.ReadAllLines("talleres.txt"))
            {
                var datos = linea.Split(',');

                talleres.Add(new Taller
                {
                    Codigo = datos[0],
                    Nombre = datos[1],
                    Costo = Convert.ToDouble(datos[2])
                });
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
            Estudiante est = (Estudiante)comboEstudiante.SelectedItem;
            Taller tal = (Taller)comboTaller.SelectedItem;

            Inscripcion nueva = new Inscripcion
            {
                DPI = est.DPI,
                CodigoTaller = tal.Codigo,
                Fecha = DateTime.Now
            };

            inscripciones.Add(nueva);

            File.AppendAllText("inscripciones.txt",
                nueva.DPI + "," + nueva.CodigoTaller + "," + nueva.Fecha + Environment.NewLine);

            MessageBox.Show("Inscripción realizada");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            listBoxReporte.Items.Clear();

            foreach (var ins in inscripciones)
            {
                var est = estudiantes.Find(x => x.DPI == ins.DPI);
                var tal = talleres.Find(x => x.Codigo == ins.CodigoTaller);

                listBoxReporte.Items.Add(est.Nombre + " - " + tal.Nombre);
            }
        }
    }
}
