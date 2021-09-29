
namespace Carga_Alumno_Profesor
{
    partial class frmAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMod = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.rdOtro = new System.Windows.Forms.RadioButton();
            this.cbCarreraA = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGValumno = new System.Windows.Forms.DataGridView();
            this.rdFem = new System.Windows.Forms.RadioButton();
            this.rdMasc = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGValumno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btMod);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.rdOtro);
            this.panel1.Controls.Add(this.cbCarreraA);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rdFem);
            this.panel1.Controls.Add(this.rdMasc);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.btBorrar);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.txtLegajo);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 393);
            this.panel1.TabIndex = 0;
            // 
            // btMod
            // 
            this.btMod.Location = new System.Drawing.Point(645, 50);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(75, 23);
            this.btMod.TabIndex = 55;
            this.btMod.Text = "Modificar";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(309, 107);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 54;
            // 
            // rdOtro
            // 
            this.rdOtro.AutoSize = true;
            this.rdOtro.Location = new System.Drawing.Point(312, 67);
            this.rdOtro.Name = "rdOtro";
            this.rdOtro.Size = new System.Drawing.Size(45, 17);
            this.rdOtro.TabIndex = 53;
            this.rdOtro.TabStop = true;
            this.rdOtro.Text = "Otro";
            this.rdOtro.UseVisualStyleBackColor = true;
            // 
            // cbCarreraA
            // 
            this.cbCarreraA.FormattingEnabled = true;
            this.cbCarreraA.Location = new System.Drawing.Point(493, 20);
            this.cbCarreraA.Name = "cbCarreraA";
            this.cbCarreraA.Size = new System.Drawing.Size(121, 21);
            this.cbCarreraA.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Legajo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Carrera ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGValumno);
            this.panel2.Location = new System.Drawing.Point(15, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 245);
            this.panel2.TabIndex = 44;
            // 
            // DGValumno
            // 
            this.DGValumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGValumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGValumno.Location = new System.Drawing.Point(0, 0);
            this.DGValumno.Name = "DGValumno";
            this.DGValumno.Size = new System.Drawing.Size(772, 245);
            this.DGValumno.TabIndex = 0;
            this.DGValumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGValumno_CellClick);
            // 
            // rdFem
            // 
            this.rdFem.AutoSize = true;
            this.rdFem.Location = new System.Drawing.Point(312, 44);
            this.rdFem.Name = "rdFem";
            this.rdFem.Size = new System.Drawing.Size(71, 17);
            this.rdFem.TabIndex = 43;
            this.rdFem.TabStop = true;
            this.rdFem.Text = "Femenino";
            this.rdFem.UseVisualStyleBackColor = true;
            // 
            // rdMasc
            // 
            this.rdMasc.AutoSize = true;
            this.rdMasc.Location = new System.Drawing.Point(312, 21);
            this.rdMasc.Name = "rdMasc";
            this.rdMasc.Size = new System.Drawing.Size(73, 17);
            this.rdMasc.TabIndex = 42;
            this.rdMasc.TabStop = true;
            this.rdMasc.Text = "Masculino";
            this.rdMasc.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(123, 78);
            this.dtpFecha.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(139, 20);
            this.dtpFecha.TabIndex = 41;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(645, 79);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 40;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(645, 23);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 39;
            this.btAdd.Text = "Agregar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(493, 52);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 38;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(123, 46);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 36;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 35;
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 393);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGValumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGValumno;
        private System.Windows.Forms.RadioButton rdFem;
        private System.Windows.Forms.RadioButton rdMasc;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbCarreraA;
        private System.Windows.Forms.RadioButton rdOtro;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btMod;
    }
}