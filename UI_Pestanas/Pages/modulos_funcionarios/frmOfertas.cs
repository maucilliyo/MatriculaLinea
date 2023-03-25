using CapaEntidades;
using CapaNegocios;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI_Pestanas.Pages.modulos_funcionarios {
    public partial class frmOfertas : Form {
        public frmOfertas() {
            InitializeComponent();
        }

        private void cbTipoUser_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void frmOfertas_Load(object sender, EventArgs e) {
            LoadCombos();

            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn {
                UseColumnTextForButtonValue = true,
                Name = "del",
                Text = "Eliminar",
                Width = 80
            };
            dataGridView1.Columns.Add(btnEliminar);
        }
        private void LoadCombos() {

            cbMaterias.DataSource = N_materias.GetMaterias(null);
            cbMaterias.DisplayMember = "Detalle";
            cbMaterias.ValueMember = "idMateria";

            cbProgramas.DataSource = N_Programa.Lista();
            cbProgramas.DisplayMember = "Detalle";
            cbProgramas.ValueMember = "idPrograma";

            cbCarrera.DataSource = N_carreras.GetCarreras(null);
            cbCarrera.DisplayMember = "Nombre";
            cbCarrera.ValueMember = "idCarrera";
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Add(cbMaterias.SelectedValue, cbMaterias.Text);
        }

        private void btnCrear_Click(object sender, EventArgs e) {
            if (dataGridView1.Rows.Count <= 0) {
                MessageBox.Show("Debe agregar por al menos una materia","Aviso",MessageBoxButtons.OK);
            }
            Ofertas ofertas = new Ofertas { 
                 Id_Carrera = Convert.ToInt32(cbCarrera.SelectedValue),
                 Id_programa = Convert.ToInt32(cbProgramas.SelectedValue),
            };
            foreach (DataGridViewRow row in  dataGridView1.Rows) {
                Ofertas_materias ofertas_Materias = new Ofertas_materias { 
                    Id_materia = Convert.ToInt32(row.Cells["idMateria"].Value),
                };
                ofertas.Materias.Add(ofertas_Materias);
            }
            N_Ofertas.Nueva(ofertas);
            MessageBox.Show("Oferta creada", "Aviso", MessageBoxButtons.OK);
            dataGridView1.Rows.Clear();
        }
        //private void 
    }
}
