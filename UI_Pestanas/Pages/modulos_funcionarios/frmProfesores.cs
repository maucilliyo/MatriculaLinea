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

namespace UI_Pestanas.Pages.modulos_funcionarios {
    public partial class frmProfesores : Form {
        readonly BindingSource binding = new BindingSource();
        readonly Profesor profesor = new Profesor();
        public frmProfesores() {
            InitializeComponent();
        }
        public void FormatoGridMaterias() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView2.Columns[1].HeaderText = "Materia";
            dataGridView2.Columns[1].Width = 200;

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
            dataGridView2.Columns[2].Visible = false;

            dataGridView2.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView2.ClearSelection();
        }
        public void FormatoGridMateriasAsignadas() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[1].HeaderText = "Materia";
            dataGridView1.Columns[1].Width = 200;

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
            dataGridView1.Columns[2].Visible = false;

            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
        }
        private void loadCombos() {
            cbUsuarios.DataSource = N_profesor.Lista();
            cbUsuarios.DisplayMember = "Nombre";
        }
        private void frmProfesores_Load(object sender, EventArgs e) {
            loadCombos();
            dataGridView2.DataSource = N_materias.GetMaterias(null);
            FormatoGridMaterias();
            binding.DataSource = profesor.Materias;
            dataGridView1.DataSource = binding;
            FormatoGridMateriasAsignadas();
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
                    profesor.Materias.Add(materias);
                    binding.ResetBindings(false);
                    //calcular Total
                }
                catch (Exception ex) {

                    throw new Exception(ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (Convert.ToString(dataGridView2.Columns[e.ColumnIndex].Name) == "Add") {
                binding.RemoveAt(e.ColumnIndex);
                binding.ResetBindings(false);
            }
        }
    }
}
