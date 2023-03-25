namespace UI_Pestanas {
    partial class frmReportes {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnR_Aulas = new System.Windows.Forms.Button();
            this.btnR_profesores = new System.Windows.Forms.Button();
            this.btnR_materiasEstudiante = new System.Windows.Forms.Button();
            this.btnR_ofertas = new System.Windows.Forms.Button();
            this.btnR_Usuarios = new System.Windows.Forms.Button();
            this.btnR_Matricula_estu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Pestanas.Properties.Resources.imagenReportes;
            this.pictureBox1.Location = new System.Drawing.Point(412, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 306);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnR_Aulas
            // 
            this.btnR_Aulas.BackColor = System.Drawing.Color.Tan;
            this.btnR_Aulas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.btnR_Aulas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.btnR_Aulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR_Aulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR_Aulas.ForeColor = System.Drawing.Color.Black;
            this.btnR_Aulas.Image = global::UI_Pestanas.Properties.Resources.aulas;
            this.btnR_Aulas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_Aulas.Location = new System.Drawing.Point(556, 21);
            this.btnR_Aulas.Name = "btnR_Aulas";
            this.btnR_Aulas.Size = new System.Drawing.Size(133, 72);
            this.btnR_Aulas.TabIndex = 16;
            this.btnR_Aulas.Text = "AULAS";
            this.btnR_Aulas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_Aulas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnR_Aulas.UseVisualStyleBackColor = false;
            this.btnR_Aulas.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnR_profesores
            // 
            this.btnR_profesores.BackColor = System.Drawing.Color.Tan;
            this.btnR_profesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.btnR_profesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.btnR_profesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR_profesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR_profesores.ForeColor = System.Drawing.Color.Black;
            this.btnR_profesores.Image = global::UI_Pestanas.Properties.Resources.Profesor;
            this.btnR_profesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_profesores.Location = new System.Drawing.Point(417, 21);
            this.btnR_profesores.Name = "btnR_profesores";
            this.btnR_profesores.Size = new System.Drawing.Size(133, 72);
            this.btnR_profesores.TabIndex = 15;
            this.btnR_profesores.Text = "PROFESORES";
            this.btnR_profesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_profesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnR_profesores.UseVisualStyleBackColor = false;
            this.btnR_profesores.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnR_materiasEstudiante
            // 
            this.btnR_materiasEstudiante.BackColor = System.Drawing.Color.Tan;
            this.btnR_materiasEstudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.btnR_materiasEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.btnR_materiasEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR_materiasEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR_materiasEstudiante.ForeColor = System.Drawing.Color.Black;
            this.btnR_materiasEstudiante.Image = global::UI_Pestanas.Properties.Resources.Materias;
            this.btnR_materiasEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_materiasEstudiante.Location = new System.Drawing.Point(275, 21);
            this.btnR_materiasEstudiante.Name = "btnR_materiasEstudiante";
            this.btnR_materiasEstudiante.Size = new System.Drawing.Size(136, 72);
            this.btnR_materiasEstudiante.TabIndex = 14;
            this.btnR_materiasEstudiante.Text = "MATERIAS POR ESTUDIANTES";
            this.btnR_materiasEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnR_materiasEstudiante.UseVisualStyleBackColor = false;
            this.btnR_materiasEstudiante.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnR_ofertas
            // 
            this.btnR_ofertas.BackColor = System.Drawing.Color.Tan;
            this.btnR_ofertas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.btnR_ofertas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.btnR_ofertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR_ofertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR_ofertas.ForeColor = System.Drawing.Color.Black;
            this.btnR_ofertas.Image = global::UI_Pestanas.Properties.Resources.Ofertas;
            this.btnR_ofertas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_ofertas.Location = new System.Drawing.Point(141, 21);
            this.btnR_ofertas.Name = "btnR_ofertas";
            this.btnR_ofertas.Size = new System.Drawing.Size(128, 72);
            this.btnR_ofertas.TabIndex = 13;
            this.btnR_ofertas.Text = "OFERTAS";
            this.btnR_ofertas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_ofertas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnR_ofertas.UseVisualStyleBackColor = false;
            this.btnR_ofertas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnR_Usuarios
            // 
            this.btnR_Usuarios.BackColor = System.Drawing.Color.Tan;
            this.btnR_Usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.btnR_Usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.btnR_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR_Usuarios.ForeColor = System.Drawing.Color.Black;
            this.btnR_Usuarios.Image = global::UI_Pestanas.Properties.Resources.user;
            this.btnR_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_Usuarios.Location = new System.Drawing.Point(7, 21);
            this.btnR_Usuarios.Name = "btnR_Usuarios";
            this.btnR_Usuarios.Size = new System.Drawing.Size(128, 72);
            this.btnR_Usuarios.TabIndex = 12;
            this.btnR_Usuarios.Text = "USUARIOS";
            this.btnR_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnR_Usuarios.UseVisualStyleBackColor = false;
            this.btnR_Usuarios.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnR_Matricula_estu
            // 
            this.btnR_Matricula_estu.BackColor = System.Drawing.Color.Tan;
            this.btnR_Matricula_estu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(173)))), ((int)(((byte)(207)))));
            this.btnR_Matricula_estu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(138)))));
            this.btnR_Matricula_estu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR_Matricula_estu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR_Matricula_estu.ForeColor = System.Drawing.Color.Black;
            this.btnR_Matricula_estu.Image = global::UI_Pestanas.Properties.Resources.Matricula;
            this.btnR_Matricula_estu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_Matricula_estu.Location = new System.Drawing.Point(696, 21);
            this.btnR_Matricula_estu.Name = "btnR_Matricula_estu";
            this.btnR_Matricula_estu.Size = new System.Drawing.Size(133, 72);
            this.btnR_Matricula_estu.TabIndex = 18;
            this.btnR_Matricula_estu.Text = "MATRICULA POR ESTUDIANTE";
            this.btnR_Matricula_estu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnR_Matricula_estu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnR_Matricula_estu.UseVisualStyleBackColor = false;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 381);
            this.Controls.Add(this.btnR_Matricula_estu);
            this.Controls.Add(this.btnR_Aulas);
            this.Controls.Add(this.btnR_profesores);
            this.Controls.Add(this.btnR_materiasEstudiante);
            this.Controls.Add(this.btnR_ofertas);
            this.Controls.Add(this.btnR_Usuarios);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnR_Usuarios;
        private System.Windows.Forms.Button btnR_ofertas;
        private System.Windows.Forms.Button btnR_materiasEstudiante;
        private System.Windows.Forms.Button btnR_profesores;
        private System.Windows.Forms.Button btnR_Aulas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnR_Matricula_estu;
    }
}