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
    public partial class frmUsuarios : Form {
        public frmUsuarios() {
            InitializeComponent();
            GetData();
            FormatoGrid();
        }
        private void GetData() {
            dataGridView1.DataSource = N_Usuarios.Lista();
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
            dataGridView1.Columns[3].Width = 250;

            DataGridViewButtonColumn btnRol = new DataGridViewButtonColumn {
                UseColumnTextForButtonValue = true,
                Name = "rol",
                Text = " + Roles",
                Width = 80
            };
            dataGridView1.Columns.Add(btnRol);

            DataGridViewButtonColumn mod = new DataGridViewButtonColumn {
                UseColumnTextForButtonValue = true,
                Name = "mod",
                Text = "Modificar",
                Width = 80
            };
            dataGridView1.Columns.Add(mod);

            dataGridView1.RowHeadersVisible = false;//oculta la columna de selecion o columna de encabezado
            dataGridView1.ClearSelection();
        }
        private void btnCrear_Click(object sender, EventArgs e) {
      
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (Convert.ToString(dataGridView1.Columns[e.ColumnIndex].Name) == "mod") {
                //obtener el valor de id persona
                try {

                    int idUser = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idUsuario"].Value);
                    frmUsuarioNuevo frmUsuarioNuevo = new frmUsuarioNuevo(idUser);
                    frmUsuarioNuevo.ShowDialog();
                }
                catch (Exception ex) {

                    throw new Exception(ex.Message);
                }
                GetData();
            }
            if (Convert.ToString(dataGridView1.Columns[e.ColumnIndex].Name) == "rol") {
                //obtener el valor de id persona
                try {

                    int idUser = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idUsuario"].Value);
                    frmUserRol frmUserRol = new frmUserRol(idUser);
                    frmUserRol.ShowDialog();
                }
                catch (Exception ex) {

                    throw new Exception(ex.Message);
                }
                GetData();
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e) {

        }
    }
}
