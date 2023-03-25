using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Pestanas.Pages.modulos_funcionarios;
using UI_Pestanas.Pages.Modulos_profesores;
using UI_Pestanas.Pages.Reportes;
using UI_Pestanas.WINDOWS;

namespace UI_Pestanas {
    public partial class frmMenu : Form {
        private Point _imgHitArea = new Point(15, 5);
        public frmMenu() {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        private void frmMenu_Load(object sender, EventArgs e) {
            //
            lblUser.Text = VarGlovales.Usuario.Nombre;
            if (VarGlovales.Usuario.Roles.Count > 1) {
                frmTipoUsuarioInicio frmTipoUsuarioInicio = new frmTipoUsuarioInicio();
                frmTipoUsuarioInicio.ShowDialog();
            }
            Permisos();
        }
        private void Permisos() {

            switch (VarGlovales.Usuario.TipoIniciado) {
                case "Funcionario":
                    btnTsMatricula.Visible = true;
                    btnTSAulas.Visible = true;
                    btnTSMaterias.Visible = true;
                    btnTSNotas.Visible = true;
                    btnTSOfertas.Visible = true;
                    btnTSProfesor.Visible = true;
                    btnTSReportes.Visible = true;
                    btnTSUsuarios.Visible = true;
                    btnTsSubLista.Visible = true;
                    btnTsSubNuevo.Visible = true;
                    break;
                case "Profesor":
                    btnTSNotas.Visible = true;
                    btnTSUsuarios.Visible = true;
                    break;
                default:
                    btnTsMatricula.Visible = true;
                    btnTSMaterias.Visible = true;
                    break;
            }
        }
        private void tabControl1_MouseClick(object sender, MouseEventArgs e) {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl1.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControl1.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 50;
            r.Height = 50;
            if (tabControl1.SelectedIndex >= 1) {
                if (r.Contains(p)) {
                    //CERRAMOS EL TAB
                    TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];

                    Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == TabP.Name).SingleOrDefault<Form>();
                    if (existe != null) {
                        existe.Close();
                        //SI SE CERRO DEVERDAD SE ELIMINA EL TAB
                        Form sigueAbierto = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == TabP.Name).SingleOrDefault<Form>();
                        if (sigueAbierto == null) {
                            //PARA SELECIONAR EL TAB ANTERIOR
                            tabControl1.SelectedIndex = tc.SelectedIndex - 1;
                            //CERRAR EL TAB
                            tc.TabPages.Remove(TabP);
                        }
                    }
                }
            }
        }
        private void CrearTabs<MiForm>(string Name) where MiForm : Form, new() {
            //Buscar si esta cargado
            foreach (TabPage tp in tabControl1.TabPages) {
                if (tp.Text == Name + "     X" && tp.Text != "INICIO   ") {
                    tabControl1.SelectedTab = tp;
                    return;
                }
            }
            //Sino esta cargado se habre de nuevo

            TabPage Prueba1 = new TabPage {
                Text = Name + "     X",
                Height = 100
            };

            //Abrir formulario
            Form formulario;
            formulario = Prueba1.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null) {
                formulario = new MiForm {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                Prueba1.Name = formulario.Name;
                tabControl1.TabPages.Add(Prueba1);
                tabControl1.SelectedTab = Prueba1;

                Prueba1.Controls.Add(formulario);
                formulario.Show();
            }
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnTsMatricula_Click(object sender, EventArgs e) {
            foreach (var item in VarGlovales.Usuario.permisos) {
                if (item.IdModulo == 1) {
                    CrearTabs<frmMatriculaEstudiante>("MATRICULA");
                }
                else
                    CrearTabs<frmMatricula>("MATRICULA");
            }
        }
        private void btnTSMaterias_Click(object sender, EventArgs e) {
            CrearTabs<frmMaterias>("MATERIAS");
        }
        private void btnTSAulas_Click(object sender, EventArgs e) {
            CrearTabs<frmAulas>("AULAS");
        }

        private void btnTSOfertas_Click(object sender, EventArgs e) {
            CrearTabs<frmOfertas>("OFERTAS");
        }

        private void btnTSProfesor_Click(object sender, EventArgs e) {
            CrearTabs<frmProfesores>("PROFESORES");
        }

        private void btnTSNotas_Click(object sender, EventArgs e) {
            CrearTabs<frmNotas_profesor>("ASIGNAR NOTAS");
        }

        private void btnTsSubLista_Click(object sender, EventArgs e) {
            CrearTabs<frmUsuarios>("USUARIOS");
        }

        private void btnTsSubNuevo_Click(object sender, EventArgs e) {
            frmUsuarioNuevo frmAsignarRol = new frmUsuarioNuevo();
            frmAsignarRol.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            CrearTabs<frmR_Usuarios>("REPORTE USUARIOS");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {
            CrearTabs<frmR_ofertas>("REPORTE OFERTAS");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) {
            CrearTabs<frmR_Notas_estudiantes>("REPORTE NOTAS");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e) {
            CrearTabs<frmR_Profesores>("REPORTE PROFESORES");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e) {
            
            CrearTabs<frmR_Notas_estudiantes>("REPORTE NOTAS");
        }

        private void btnTSUsuarios_Click(object sender, EventArgs e) {
            if (VarGlovales.Usuario.TipoIniciado != "Funcionario") {
                int idUser = VarGlovales.Usuario.IdUsuario;
                frmUsuarioNuevo frmUsuarioNuevo = new frmUsuarioNuevo(idUser);
                frmUsuarioNuevo.ShowDialog();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e) {
            CrearTabs<frmR_aulas>("REPORTE AULAS");
        }
    }
}
