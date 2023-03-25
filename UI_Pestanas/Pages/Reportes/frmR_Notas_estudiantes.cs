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

namespace UI_Pestanas.Pages.Reportes {
    public partial class frmR_Notas_estudiantes : Form {
        public frmR_Notas_estudiantes() {
            InitializeComponent();
            loadCombos();
        }
        private void loadCombos() {
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
        private void FormatoGrid() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[0].HeaderText = "Materia";
            dataGridView1.Columns[0].Width = 250;   

            dataGridView1.Columns[1].HeaderText = "Horario";
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            dataGridView1.Columns[2].HeaderText = "Aula";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            dataGridView1.Columns[3].HeaderText = "Nota";
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            dataGridView1.Columns[4].HeaderText = "Estado";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 


            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
        }
        private void GetData() {
            dataGridView1.DataSource = N_Reportes.NotasEstudiantes(cbEstudiante.SelectedValue.ToString());
            FormatoGrid();
        }
        private void btnCrear_Click(object sender, EventArgs e) {
            GetData();
        }
    }
}
