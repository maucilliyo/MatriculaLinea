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
    public partial class frmR_aulas : Form {
        public frmR_aulas() {
            InitializeComponent();
            loadCombos();
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

            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
        }
        private void frmR_aulas_Load(object sender, EventArgs e) {
            dataGridView1.DataSource = N_Reportes.Aulas(null);
            FormatoGrid();
        }
        private void btnCrear_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = N_Reportes.Aulas(cbEstado.Text);
        }
        private void button1_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = N_Reportes.Aulas(null);
        }
    }
}
