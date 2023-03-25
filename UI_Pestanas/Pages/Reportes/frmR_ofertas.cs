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
    public partial class frmR_ofertas : Form {
        public frmR_ofertas() {
            InitializeComponent();
            GetData();
            FormatoGrid();
        }
        private void GetData() {
            dataGridView1.DataSource = N_Reportes.Ofertas(txtBuscar.Text);
           
        }
        private void frmR_ofertas_Load(object sender, EventArgs e) {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) {
            GetData();
        }
        private void FormatoGrid() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            dataGridView1.Columns[1].HeaderText = "Carrera";
            dataGridView1.Columns[1].Width = 350;

            dataGridView1.Columns[2].HeaderText = "Programa";
            dataGridView1.Columns[2].Width = 200;

            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
        }
    }
}
