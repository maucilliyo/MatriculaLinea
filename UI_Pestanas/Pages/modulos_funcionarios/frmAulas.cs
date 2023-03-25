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
    public partial class frmAulas : Form {
        private bool modificar = false;
        public frmAulas() {
            InitializeComponent();
            LoadData();
            FormatoGrid();
            loadCombos();
        }
        private void LoadData() {
            dataGridView1.DataSource = N_Reportes.Aulas(null);
        }
        private void loadCombos() {
            cbEstado.DataSource = N_aulas.Estados();
            cbEstado.DisplayMember = "Estado";
        }
        private void FormatoGrid() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[0].HeaderText = "Num";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            dataGridView1.Columns[1].HeaderText = "Estado";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento

            DataGridViewButtonColumn btnMod = new DataGridViewButtonColumn {
                UseColumnTextForButtonValue = true,
                Name = "mod",
                Text = "Modificar",
                Width = 80
            };
            dataGridView1.Columns.Add(btnMod);

            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
        }
        private void button1_Click(object sender, EventArgs e) {
            Aula aula = new Aula {
                IdAula = Convert.ToInt32(lblNumero.Text),
                Estado = cbEstado.Text
            };

            if (!modificar) {
                N_aulas.Nueva(aula);
            }
            else {
                N_aulas.Modificar(aula);
            }
            cbEstado.SelectedIndex = 0;
            lblNumero.Text = "0";
            btnNuevo.Text = "Nueva";
            modificar = false;
            LoadData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (Convert.ToString(dataGridView1.Columns[e.ColumnIndex].Name) == "mod") {
                //obtener el valor de id persona
                try {
                    cbEstado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                    lblNumero.Text = dataGridView1.CurrentRow.Cells["idAula"].Value.ToString();
                    btnNuevo.Text = "Modificar";
                    modificar=true;
                }
                catch (Exception ex) {

                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
