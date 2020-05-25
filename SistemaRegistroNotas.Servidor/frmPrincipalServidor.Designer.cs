namespace SistemaRegistroNotas.Servidor
{
    partial class frmPrincipalServidor
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
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.btnRegistrarCurso = new System.Windows.Forms.Button();
            this.btnRegistrarNotas = new System.Windows.Forms.Button();
            this.btnValidarPendientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(33, 38);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(269, 42);
            this.btnRegistrarAlumno.TabIndex = 0;
            this.btnRegistrarAlumno.Text = "Registrar Alumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // btnRegistrarCurso
            // 
            this.btnRegistrarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCurso.Location = new System.Drawing.Point(33, 106);
            this.btnRegistrarCurso.Name = "btnRegistrarCurso";
            this.btnRegistrarCurso.Size = new System.Drawing.Size(269, 42);
            this.btnRegistrarCurso.TabIndex = 1;
            this.btnRegistrarCurso.Text = "Registrar Curso";
            this.btnRegistrarCurso.UseVisualStyleBackColor = true;
            this.btnRegistrarCurso.Click += new System.EventHandler(this.btnRegistrarCurso_Click);
            // 
            // btnRegistrarNotas
            // 
            this.btnRegistrarNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNotas.Location = new System.Drawing.Point(33, 172);
            this.btnRegistrarNotas.Name = "btnRegistrarNotas";
            this.btnRegistrarNotas.Size = new System.Drawing.Size(269, 42);
            this.btnRegistrarNotas.TabIndex = 2;
            this.btnRegistrarNotas.Text = "Registrar Notas";
            this.btnRegistrarNotas.UseVisualStyleBackColor = true;
            this.btnRegistrarNotas.Click += new System.EventHandler(this.btnRegistrarNotas_Click);
            // 
            // btnValidarPendientes
            // 
            this.btnValidarPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarPendientes.Location = new System.Drawing.Point(33, 240);
            this.btnValidarPendientes.Name = "btnValidarPendientes";
            this.btnValidarPendientes.Size = new System.Drawing.Size(269, 42);
            this.btnValidarPendientes.TabIndex = 3;
            this.btnValidarPendientes.Text = "Validar Alumnos Pendientes";
            this.btnValidarPendientes.UseVisualStyleBackColor = true;
            // 
            // frmPrincipalServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 317);
            this.Controls.Add(this.btnValidarPendientes);
            this.Controls.Add(this.btnRegistrarNotas);
            this.Controls.Add(this.btnRegistrarCurso);
            this.Controls.Add(this.btnRegistrarAlumno);
            this.Name = "frmPrincipalServidor";
            this.Text = "Sistema de Registro de Estudiantes y Notas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.Button btnRegistrarCurso;
        private System.Windows.Forms.Button btnRegistrarNotas;
        private System.Windows.Forms.Button btnValidarPendientes;
    }
}

