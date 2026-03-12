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
        List<Estudiante> estudiantes = new List<Estudiante>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
