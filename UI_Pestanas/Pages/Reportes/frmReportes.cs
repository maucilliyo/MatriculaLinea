using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Pestanas.Pages.Reportes;

namespace UI_Pestanas {
    public partial class frmReportes : Form {
        public frmReportes() {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e) {
            frmR_Usuarios frmR_Usuarios = new frmR_Usuarios();  
             frmR_Usuarios.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            frmR_ofertas frmR_Ofertas = new frmR_ofertas();
            frmR_Ofertas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            frmR_Notas_estudiantes frmR_Notas_Estudiantes = new frmR_Notas_estudiantes();
            frmR_Notas_Estudiantes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            frmR_Profesores frmR_Profesores = new frmR_Profesores();    
            frmR_Profesores.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {
            frmR_aulas frmR_Aulas = new frmR_aulas();
            frmR_Aulas.ShowDialog();
        }
    }
}
