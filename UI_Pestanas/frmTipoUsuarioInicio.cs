using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Pestanas {
    public partial class frmTipoUsuarioInicio : Form {
        public frmTipoUsuarioInicio() {
            InitializeComponent();
        }

        private void frmTipoUsuarioInicio_Load(object sender, EventArgs e) {
            cbTipoUser.DataSource = VarGlovales.Usuario.Roles;
            cbTipoUser.DisplayMember = "dRol";
            cbTipoUser.ValueMember = "nombre";
        }

        private void button2_Click(object sender, EventArgs e) {
            //todo
            VarGlovales.Usuario.TipoIniciado = cbTipoUser.Text;
            //
            this.Close();
        }
    }
}
