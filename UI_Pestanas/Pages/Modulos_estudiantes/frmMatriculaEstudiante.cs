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

namespace UI_Pestanas.WINDOWS {
    public partial class frmMatriculaEstudiante : Form {
        readonly Matricula Matricula = new Matricula();
        readonly BindingSource binding = new BindingSource();
        public frmMatriculaEstudiante() {
            InitializeComponent();
        }
        private void frmMatriculaEstudiante_Load(object sender, EventArgs e) {
            loadCombos();
            dataGridView2.DataSource = N_materias.GetMaterias(null);
            FormatoGridMaterias();

            binding.DataSource = Matricula.Materias;
            dataGridView1.DataSource = binding;
            FormatoGridMateriasMatricula();
        }
        private void CalcularTotal() {
            decimal total = 0;
            foreach (var row in Matricula.Materias) {
                total += row.Costo;
            }
            txtTotal.Text = total.ToString("N2");
        }
        public void FormatoGridMaterias() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView2.Columns[1].HeaderText = "Materia";
            dataGridView2.Columns[1].Width = 200;

            dataGridView2.Columns[2].HeaderText = "Costo";
            dataGridView2.Columns[2].Width = 90;
            dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//Aliniamiento 
            dataGridView2.Columns[2].DefaultCellStyle.Format = "N2";

            dataGridView2.Columns[3].HeaderText = "Horario";
            dataGridView2.Columns[3].Width = 90;
            dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            dataGridView2.Columns[4].HeaderText = "Aula";
            dataGridView2.Columns[4].Width = 90;
            dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn {
                UseColumnTextForButtonValue = true,
                Name = "Add",
                Text = "Agregar",
                Width = 80
            };
            dataGridView2.Columns.Add(btnEliminar);

            dataGridView2.Columns[0].Visible = false;

            dataGridView2.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView2.ClearSelection();
        }
        public void FormatoGridMateriasMatricula() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[1].HeaderText = "Materia";
            dataGridView1.Columns[1].Width = 200;

            dataGridView1.Columns[2].HeaderText = "Costo";
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//Aliniamiento 
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";

            dataGridView1.Columns[3].HeaderText = "Horario";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            dataGridView1.Columns[4].HeaderText = "Aula";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn {
                UseColumnTextForButtonValue = true,
                Name = "Del",
                Text = "Quitar",
                Width = 80
            };
            dataGridView1.Columns.Add(btnEliminar);

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
        }
        private void loadCombos() {
            
            cbCarrera.DataSource = N_carreras.GetCarreras(null);
            cbCarrera.DisplayMember = "Nombre";
            cbCarrera.ValueMember = "idCarrera";
            
            // VALIDAR LOS ROLES
            foreach (var rol in VarGlovales.Usuario.Roles) {
                if (rol.IdRol == 1) {
                    cbEstudiante.DataSource = N_estudiantes.Lista(VarGlovales.Usuario.IdUsuario.ToString());
                    cbEstudiante.Enabled = false;
                }
                else
                    cbEstudiante.DataSource = N_estudiantes.Lista(null);
                //
            }
            cbEstudiante.DisplayMember = "nombre";
            cbEstudiante.ValueMember = "idUsuario";

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (Convert.ToString(dataGridView2.Columns[e.ColumnIndex].Name) == "Add") {
                //obtener el valor de id persona
                try {

                    Materias materias = new Materias {
                        IdMateria = Convert.ToInt32(dataGridView2.CurrentRow.Cells["idMateria"].Value),
                        Costo = Convert.ToDecimal(dataGridView2.CurrentRow.Cells["Costo"].Value),
                        Aula = dataGridView2.CurrentRow.Cells["Aula"].Value.ToString(),
                        Detalle = dataGridView2.CurrentRow.Cells["detalle"].Value.ToString(),
                        Horario = dataGridView2.CurrentRow.Cells["Horario"].Value.ToString()
                    };
                    Matricula.Materias.Add(materias);
                    binding.ResetBindings(false);
                    //calcular Total
                    CalcularTotal();

                }
                catch (Exception ex) {

                    throw new Exception(ex.Message);
                }
            }
        }
        private void btnCrear_Click(object sender, EventArgs e) {
            //validaciones
            if (dataGridView1.Rows.Count == 0) { 
                MessageBox.Show("Debe agregar al menos una materia","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //
            Matricula.Monto = Convert.ToDecimal(txtTotal.Text);
            Matricula.Id_estudiante = Convert.ToInt32(cbEstudiante.SelectedValue);
            N_matriculas.Nueva(Matricula);
            dataGridView1.Rows.Clear();
            MessageBox.Show("Matricula realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (Convert.ToString(dataGridView2.Columns[e.ColumnIndex].Name) == "Add") {

                binding.RemoveAt(e.ColumnIndex);
                binding.ResetBindings(false);
                CalcularTotal();
            }
        }

        private void cbEstudiante_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
