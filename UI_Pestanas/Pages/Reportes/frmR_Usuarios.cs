using CapaNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI_Pestanas.Pages.Reportes {
    public partial class frmR_Usuarios : Form {
        public frmR_Usuarios() {
            InitializeComponent();
            GetData();
        }
        private void GetData() {
            dataGridView1.DataSource = N_Reportes.Usuarios(chkActivos.Checked,txtBuscar.Text);
            FormatoGrid();
        }
        private void FormatoGrid() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 250;

            dataGridView1.Columns[2].HeaderText = "Direccion";
            dataGridView1.Columns[2].Width = 250;

            dataGridView1.Columns[3].HeaderText = "Roles";
            dataGridView1.Columns[3].Width = 200;
       

            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
        }
        private void chkActivos_CheckedChanged(object sender, EventArgs e) {
            GetData();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e) {
            GetData();
        }
    }
}
