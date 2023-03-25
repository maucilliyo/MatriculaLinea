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
    public partial class frmMaterias : Form {
        int _idMateria  = 0;
        bool _modificar = false;
        public frmMaterias() {
            InitializeComponent();
        }

        private void frmMaterias_Load(object sender, EventArgs e) {
            GetLista();
            FormatoGrid();

            cbAulas.DataSource = N_aulas.GetAulas();
            cbAulas.DisplayMember = "idAula";
        }
        private void GetLista() {
            dataGridView1.DataSource = N_materias.GetMaterias(txtBuscar.Text);
        }
        public void FormatoGrid() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 60;

            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 250;

            dataGridView1.Columns[2].HeaderText = "Costo";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//Aliniamiento 

            dataGridView1.Columns[3].HeaderText = "Horario";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            dataGridView1.Columns[4].HeaderText = "Aula";
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn {
                UseColumnTextForButtonValue = true,
                Name = "Mod",
                Text = "Modificar",
                Width = 80
            };
            dataGridView1.Columns.Add(btnEliminar);

            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
        }
        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void btnCrear_Click(object sender, EventArgs e) {
            //VALIDACIONES  
            if (txtMateria.Text == string.Empty) {
                MessageBox.Show("Debe ingresar un nombre de materia", "Aviso", MessageBoxButtons.OK);
                return;
            }
            if (!VarGlovales.ValidarMontos(txtCosto.Text)) {
                MessageBox.Show("El formato de costo no es valido", "Aviso", MessageBoxButtons.OK);
                return;
            }
            if (!VarGlovales.ValidarFormatoHora(txtHora.Text)) {
                MessageBox.Show("El formato de hora no es valido", "Aviso", MessageBoxButtons.OK);
                return;
            };
            //
            Materias materias = new Materias {
                IdMateria = _idMateria,
                Detalle = txtMateria.Text,
                Costo = Convert.ToDecimal(txtCosto.Text),
                Aula = cbAulas.Text,
                Horario = txtHora.Text
            };
            if (_modificar)
                N_materias.Modificar(materias);
            else
                N_materias.Nueva(materias);
            //limpiar controles y variables
            txtBuscar.Clear();
            txtCosto.Clear();
            txtHora.Clear();
            txtMateria.Clear();
            cbAulas.SelectedIndex = 0;
            GetLista();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (Convert.ToString(dataGridView1.Columns[e.ColumnIndex].Name) == "Mod") {
                //obtener el valor de id persona
                try {
                    _idMateria = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idMateria"].Value);
                    txtMateria.Text = dataGridView1.CurrentRow.Cells["detalle"].Value.ToString();
                    txtCosto.Text = dataGridView1.CurrentRow.Cells["Costo"].Value.ToString();
                    txtHora.Text = dataGridView1.CurrentRow.Cells["Horario"].Value.ToString();
                    cbAulas.Text = dataGridView1.CurrentRow.Cells["aula"].Value.ToString();

                    _modificar = true;
                    btnCrear.Text = "Modificar";
                }
                catch (Exception ex) {

                    throw new Exception(ex.Message);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) {
            GetLista();
        }
    }
}
