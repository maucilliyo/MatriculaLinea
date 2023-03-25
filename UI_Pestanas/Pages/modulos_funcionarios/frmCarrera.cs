using CapaEntidades;
using CapaNegocios;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI_Pestanas.Pages.modulos_funcionarios {
    public partial class frmCarrera : Form {
        bool _modificar = false;
        int _idCarrera = 0;
        public frmCarrera() {
            InitializeComponent();
        }
        private void btnCrear_Click(object sender, EventArgs e) {
            //validaciones
            if (txtCarrera.Text.Trim() == string.Empty) {
                MessageBox.Show("Dabe ingresar un nombre de carrera","Aviso",MessageBoxButtons.OK);
                return;
            }
            //objeto
            Carrera carrera = new Carrera { 
                Nombre = txtCarrera.Text.ToUpper(),
                IdCarrera = _idCarrera
            };
            //
            if(_modificar)
                N_carreras.Modificar(carrera);
            else
                N_carreras.Nueva(carrera);

            //refrescar lista
            GetLista();
            //limpiar y normalize
            txtCarrera.Clear();
            btnCrear.Text = "Crear";
            _modificar = false;
            _idCarrera = 0;
        }
        public void GetLista() {

            dataGridView1.DataSource = N_carreras.GetCarreras(txtCarreraBuscar.Text);
        }
        public void FormatoGrid() {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle {
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[0].HeaderText = "Numero";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Aliniamiento 

            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 450;

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
        private void frmCarrera_Load(object sender, EventArgs e) {
            GetLista();
            FormatoGrid();
        }
        private void txtCarreraBuscar_TextChanged(object sender, EventArgs e) {
            GetLista();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (Convert.ToString(dataGridView1.Columns[e.ColumnIndex].Name) == "Mod") {
                //obtener el valor de id persona
                try {
                    _idCarrera = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idCarrera"].Value);
                    txtCarrera.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                    _modificar = true;
                    btnCrear.Text = "Modificar";
                }
                catch (Exception ex) {

                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
