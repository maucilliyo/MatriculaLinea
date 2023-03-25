namespace UI_Pestanas
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pbxLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tstMenu = new System.Windows.Forms.ToolStrip();
            this.btnTsMatricula = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTSMaterias = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTSAulas = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTSOfertas = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTSProfesor = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTSNotas = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTSUsuarios = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTsSubLista = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTsSubNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTSReportes = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFactura1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFactura2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListaFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.adadadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoEmpresa)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.tstMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(150, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 681);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.tabPage4.Controls.Add(this.pbxLogoEmpresa);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1152, 655);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "INICIO   ";
            // 
            // pbxLogoEmpresa
            // 
            this.pbxLogoEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbxLogoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoEmpresa.Image")));
            this.pbxLogoEmpresa.Location = new System.Drawing.Point(347, 172);
            this.pbxLogoEmpresa.Name = "pbxLogoEmpresa";
            this.pbxLogoEmpresa.Size = new System.Drawing.Size(486, 480);
            this.pbxLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoEmpresa.TabIndex = 1;
            this.pbxLogoEmpresa.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.Label2);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 45);
            this.panel2.TabIndex = 4;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "MATRICULA EN LINEA";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(1082, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(31, 20);
            this.lblUser.TabIndex = 41;
            this.lblUser.Text = "n/d";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(1009, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 20);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "Usuario:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1278, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.tstMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 681);
            this.panel1.TabIndex = 5;
            // 
            // tstMenu
            // 
            this.tstMenu.AutoSize = false;
            this.tstMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.tstMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tstMenu.GripMargin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.tstMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTsMatricula,
            this.btnTSMaterias,
            this.btnTSAulas,
            this.btnTSOfertas,
            this.btnTSProfesor,
            this.btnTSNotas,
            this.btnTSUsuarios,
            this.btnTSReportes});
            this.tstMenu.Location = new System.Drawing.Point(0, 0);
            this.tstMenu.Name = "tstMenu";
            this.tstMenu.Size = new System.Drawing.Size(147, 681);
            this.tstMenu.TabIndex = 27;
            this.tstMenu.Text = "toolStrip1";
            // 
            // btnTsMatricula
            // 
            this.btnTsMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTsMatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTsMatricula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTsMatricula.ForeColor = System.Drawing.Color.White;
            this.btnTsMatricula.Image = global::UI_Pestanas.Properties.Resources.Matricula;
            this.btnTsMatricula.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTsMatricula.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTsMatricula.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTsMatricula.Name = "btnTsMatricula";
            this.btnTsMatricula.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.btnTsMatricula.Size = new System.Drawing.Size(145, 41);
            this.btnTsMatricula.Text = "   MATRICULA";
            this.btnTsMatricula.ToolTipText = "   Facturas";
            this.btnTsMatricula.Visible = false;
            this.btnTsMatricula.Click += new System.EventHandler(this.btnTsMatricula_Click);
            // 
            // btnTSMaterias
            // 
            this.btnTSMaterias.AutoSize = false;
            this.btnTSMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTSMaterias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTSMaterias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSMaterias.ForeColor = System.Drawing.Color.White;
            this.btnTSMaterias.Image = global::UI_Pestanas.Properties.Resources.Materias;
            this.btnTSMaterias.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTSMaterias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTSMaterias.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTSMaterias.Name = "btnTSMaterias";
            this.btnTSMaterias.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.btnTSMaterias.Size = new System.Drawing.Size(145, 38);
            this.btnTSMaterias.Text = "  MATERIAS";
            this.btnTSMaterias.Visible = false;
            this.btnTSMaterias.Click += new System.EventHandler(this.btnTSMaterias_Click);
            // 
            // btnTSAulas
            // 
            this.btnTSAulas.AutoSize = false;
            this.btnTSAulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTSAulas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTSAulas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSAulas.ForeColor = System.Drawing.Color.White;
            this.btnTSAulas.Image = global::UI_Pestanas.Properties.Resources.aulas;
            this.btnTSAulas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTSAulas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTSAulas.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTSAulas.Name = "btnTSAulas";
            this.btnTSAulas.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.btnTSAulas.Size = new System.Drawing.Size(145, 38);
            this.btnTSAulas.Text = "   AULAS";
            this.btnTSAulas.Visible = false;
            this.btnTSAulas.Click += new System.EventHandler(this.btnTSAulas_Click);
            // 
            // btnTSOfertas
            // 
            this.btnTSOfertas.AutoSize = false;
            this.btnTSOfertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTSOfertas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTSOfertas.DoubleClickEnabled = true;
            this.btnTSOfertas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSOfertas.ForeColor = System.Drawing.Color.White;
            this.btnTSOfertas.Image = global::UI_Pestanas.Properties.Resources.Ofertas;
            this.btnTSOfertas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTSOfertas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTSOfertas.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTSOfertas.Name = "btnTSOfertas";
            this.btnTSOfertas.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.btnTSOfertas.Size = new System.Drawing.Size(145, 38);
            this.btnTSOfertas.Text = "   OFERTAS";
            this.btnTSOfertas.Visible = false;
            this.btnTSOfertas.Click += new System.EventHandler(this.btnTSOfertas_Click);
            // 
            // btnTSProfesor
            // 
            this.btnTSProfesor.AutoSize = false;
            this.btnTSProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTSProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTSProfesor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSProfesor.ForeColor = System.Drawing.Color.White;
            this.btnTSProfesor.Image = global::UI_Pestanas.Properties.Resources.Profesor1;
            this.btnTSProfesor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTSProfesor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTSProfesor.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTSProfesor.Name = "btnTSProfesor";
            this.btnTSProfesor.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.btnTSProfesor.Size = new System.Drawing.Size(145, 38);
            this.btnTSProfesor.Text = "   PROFESOR";
            this.btnTSProfesor.Visible = false;
            this.btnTSProfesor.Click += new System.EventHandler(this.btnTSProfesor_Click);
            // 
            // btnTSNotas
            // 
            this.btnTSNotas.AutoSize = false;
            this.btnTSNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTSNotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTSNotas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSNotas.ForeColor = System.Drawing.Color.White;
            this.btnTSNotas.Image = global::UI_Pestanas.Properties.Resources.Notas;
            this.btnTSNotas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTSNotas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTSNotas.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTSNotas.Name = "btnTSNotas";
            this.btnTSNotas.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.btnTSNotas.Size = new System.Drawing.Size(145, 38);
            this.btnTSNotas.Text = "   NOTAS";
            this.btnTSNotas.Visible = false;
            this.btnTSNotas.Click += new System.EventHandler(this.btnTSNotas_Click);
            // 
            // btnTSUsuarios
            // 
            this.btnTSUsuarios.AutoSize = false;
            this.btnTSUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTSUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTSUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTsSubLista,
            this.btnTsSubNuevo});
            this.btnTSUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnTSUsuarios.Image = global::UI_Pestanas.Properties.Resources.user;
            this.btnTSUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTSUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTSUsuarios.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTSUsuarios.Name = "btnTSUsuarios";
            this.btnTSUsuarios.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.btnTSUsuarios.Size = new System.Drawing.Size(145, 38);
            this.btnTSUsuarios.Text = "   USUARIOS";
            this.btnTSUsuarios.Visible = false;
            this.btnTSUsuarios.Click += new System.EventHandler(this.btnTSUsuarios_Click);
            // 
            // btnTsSubLista
            // 
            this.btnTsSubLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTsSubLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTsSubLista.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnTsSubLista.ForeColor = System.Drawing.Color.White;
            this.btnTsSubLista.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTsSubLista.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTsSubLista.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTsSubLista.Name = "btnTsSubLista";
            this.btnTsSubLista.Size = new System.Drawing.Size(148, 24);
            this.btnTsSubLista.Text = "&1 - Lista";
            this.btnTsSubLista.Visible = false;
            this.btnTsSubLista.Click += new System.EventHandler(this.btnTsSubLista_Click);
            // 
            // btnTsSubNuevo
            // 
            this.btnTsSubNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTsSubNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTsSubNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnTsSubNuevo.ForeColor = System.Drawing.Color.White;
            this.btnTsSubNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTsSubNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTsSubNuevo.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTsSubNuevo.Name = "btnTsSubNuevo";
            this.btnTsSubNuevo.Size = new System.Drawing.Size(148, 24);
            this.btnTsSubNuevo.Text = "&2 - Nuevo";
            this.btnTsSubNuevo.Visible = false;
            this.btnTsSubNuevo.Click += new System.EventHandler(this.btnTsSubNuevo_Click);
            // 
            // btnTSReportes
            // 
            this.btnTSReportes.AutoSize = false;
            this.btnTSReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTSReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTSReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem6,
            this.toolStripMenuItem5});
            this.btnTSReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSReportes.ForeColor = System.Drawing.Color.White;
            this.btnTSReportes.Image = global::UI_Pestanas.Properties.Resources.reportes;
            this.btnTSReportes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTSReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTSReportes.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTSReportes.Name = "btnTSReportes";
            this.btnTSReportes.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.btnTSReportes.Size = new System.Drawing.Size(145, 38);
            this.btnTSReportes.Text = "   REPORTES";
            this.btnTSReportes.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(262, 24);
            this.toolStripMenuItem1.Text = "&1 - USUARIOS";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(262, 24);
            this.toolStripMenuItem2.Text = "&2 - OFERTAS";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.toolStripMenuItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(262, 24);
            this.toolStripMenuItem3.Text = "&3 - NOTAS ESTUDIANTES";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.toolStripMenuItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(262, 24);
            this.toolStripMenuItem4.Text = "&4 - PROFESORES";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.toolStripMenuItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(262, 24);
            this.toolStripMenuItem6.Text = "&5 - AULAS";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.toolStripMenuItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(262, 24);
            this.toolStripMenuItem5.Text = "&6 - MATERIAS ESTUDIANTES";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // btnFactura1
            // 
            this.btnFactura1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adToolStripMenuItem});
            this.btnFactura1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura1.ForeColor = System.Drawing.Color.White;
            this.btnFactura1.Name = "btnFactura1";
            this.btnFactura1.Size = new System.Drawing.Size(155, 22);
            this.btnFactura1.Text = "FACTURA 1 (F2)";
            // 
            // adToolStripMenuItem
            // 
            this.adToolStripMenuItem.Name = "adToolStripMenuItem";
            this.adToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.adToolStripMenuItem.Text = "ad";
            // 
            // btnFactura2
            // 
            this.btnFactura2.ForeColor = System.Drawing.Color.DarkGray;
            this.btnFactura2.Name = "btnFactura2";
            this.btnFactura2.Size = new System.Drawing.Size(155, 22);
            this.btnFactura2.Text = "FACTURA 2 (F3)";
            // 
            // btnListaFacturas
            // 
            this.btnListaFacturas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adadadToolStripMenuItem});
            this.btnListaFacturas.Name = "btnListaFacturas";
            this.btnListaFacturas.Size = new System.Drawing.Size(155, 22);
            this.btnListaFacturas.Text = "ad";
            // 
            // adadadToolStripMenuItem
            // 
            this.adadadToolStripMenuItem.Name = "adadadToolStripMenuItem";
            this.adadadToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.adadadToolStripMenuItem.Text = "adadad";
            // 
            // btnFactura
            // 
            this.btnFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Padding = new System.Windows.Forms.Padding(1, 0, 0, 5);
            this.btnFactura.Size = new System.Drawing.Size(156, 25);
            this.btnFactura.Text = "Factura 1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1310, 726);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoEmpresa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tstMenu.ResumeLayout(false);
            this.tstMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ToolStripMenuItem btnFactura1;
        private System.Windows.Forms.ToolStripMenuItem adToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnFactura2;
        private System.Windows.Forms.ToolStripMenuItem btnListaFacturas;
        private System.Windows.Forms.ToolStripMenuItem adadadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnFactura;
        private System.Windows.Forms.PictureBox pbxLogoEmpresa;
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStrip tstMenu;
        public System.Windows.Forms.ToolStripDropDownButton btnTsMatricula;
        public System.Windows.Forms.ToolStripDropDownButton btnTSMaterias;
        public System.Windows.Forms.ToolStripDropDownButton btnTSAulas;
        public System.Windows.Forms.ToolStripDropDownButton btnTSOfertas;
        public System.Windows.Forms.ToolStripDropDownButton btnTSProfesor;
        public System.Windows.Forms.ToolStripDropDownButton btnTSNotas;
        public System.Windows.Forms.ToolStripDropDownButton btnTSUsuarios;
        public System.Windows.Forms.ToolStripDropDownButton btnTSReportes;
        private System.Windows.Forms.ToolStripMenuItem btnTsSubLista;
        private System.Windows.Forms.ToolStripMenuItem btnTsSubNuevo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

