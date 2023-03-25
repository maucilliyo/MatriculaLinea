using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Pestanas.Pages.Modulos_profesores {
    public partial class frmNotas_profesor : Form {
        BindingSource source = new BindingSource();
        public frmNotas_profesor() {
            InitializeComponent();
            LoadCombos();
        }
        private void btnCrear_Click(object sender, EventArgs e) {

            source.DataSource = N_estudiantes.Lista_materias(Convert.ToInt32(cbMaterias.SelectedValue));
            dataGridView1.DataSource = source;
            source.ResetBindings(false);
            formatoGrid();
        }
        private void formatoGrid() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[1].HeaderText = "ESTUDIANTE";
            dataGridView1.Columns[1].Width = 400;

            dataGridView1.Columns[2].HeaderText = "NOTA";
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//Aliniamiento 
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
        }
        private void frmNotas_profesor_Load(object sender, EventArgs e) {

        }
        private void LoadCombos() {
            cbMaterias.DataSource = N_profesor.Lista_materias(VarGlovales.Usuario.IdUsuario.ToString());
            cbMaterias.DisplayMember = "detalle";
            cbMaterias.ValueMember = "id_materia";
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

            if (Convert.ToString(dataGridView1.Columns[e.ColumnIndex].Name) == "nota") {
                dataGridView1.BeginEdit(true);
            }
        }
        private void button1_Click(object sender, EventArgs e) {
            if (dataGridView1.Rows.Count == 0) {
                MessageBox.Show("Debe cargar lista de estudiantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewRow nota in dataGridView1.Rows) {
                AlumnosMaterias alumnosMaterias = new AlumnosMaterias {
                    Id_alumno = Convert.ToInt32(nota.Cells["id_alumno"].Value),
                    Id_materia = Convert.ToInt32(cbMaterias.SelectedValue),
                    Nota = nota.Cells["nota"].Value.ToString()
                };
                N_estudiantes.Actualizar_nota(alumnosMaterias);
            }
            MessageBox.Show("Notas Actualizadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
