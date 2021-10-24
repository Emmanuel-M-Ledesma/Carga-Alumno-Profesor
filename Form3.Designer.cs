
namespace Carga_Alumno_Profesor
{
    partial class frmDocente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMod = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.rdOtro = new System.Windows.Forms.RadioButton();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdFemD = new System.Windows.Forms.RadioButton();
            this.rdMascD = new System.Windows.Forms.RadioButton();
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.btBorrarD = new System.Windows.Forms.Button();
            this.btAddD = new System.Windows.Forms.Button();
            this.txtLegajoD = new System.Windows.Forms.TextBox();
            this.txtDniD = new System.Windows.Forms.TextBox();
            this.txtNombreD = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVdocente = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btMod);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.rdOtro);
            this.panel1.Controls.Add(this.cbMateria);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdFemD);
            this.panel1.Controls.Add(this.rdMascD);
            this.panel1.Controls.Add(this.dtpFechaD);
            this.panel1.Controls.Add(this.btBorrarD);
            this.panel1.Controls.Add(this.btAddD);
            this.panel1.Controls.Add(this.txtLegajoD);
            this.panel1.Controls.Add(this.txtDniD);
            this.panel1.Controls.Add(this.txtNombreD);
            this.panel1.Controls.Add(this.panel2);
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
            this.btMod.TabIndex = 70;
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
            this.lblError.TabIndex = 69;
            // 
            // rdOtro
            // 
            this.rdOtro.AutoSize = true;
            this.rdOtro.Location = new System.Drawing.Point(312, 67);
            this.rdOtro.Name = "rdOtro";
            this.rdOtro.Size = new System.Drawing.Size(45, 17);
            this.rdOtro.TabIndex = 68;
            this.rdOtro.TabStop = true;
            this.rdOtro.Text = "Otro";
            this.rdOtro.UseVisualStyleBackColor = true;
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(493, 20);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(121, 21);
            this.cbMateria.TabIndex = 67;
            this.cbMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMateria_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Legajo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Nombre";
            // 
            // rdFemD
            // 
            this.rdFemD.AutoSize = true;
            this.rdFemD.Location = new System.Drawing.Point(312, 44);
            this.rdFemD.Name = "rdFemD";
            this.rdFemD.Size = new System.Drawing.Size(71, 17);
            this.rdFemD.TabIndex = 60;
            this.rdFemD.TabStop = true;
            this.rdFemD.Text = "Femenino";
            this.rdFemD.UseVisualStyleBackColor = true;
            // 
            // rdMascD
            // 
            this.rdMascD.AutoSize = true;
            this.rdMascD.Location = new System.Drawing.Point(312, 21);
            this.rdMascD.Name = "rdMascD";
            this.rdMascD.Size = new System.Drawing.Size(73, 17);
            this.rdMascD.TabIndex = 59;
            this.rdMascD.TabStop = true;
            this.rdMascD.Text = "Masculino";
            this.rdMascD.UseVisualStyleBackColor = true;
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.Location = new System.Drawing.Point(123, 78);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaD.TabIndex = 58;
            // 
            // btBorrarD
            // 
            this.btBorrarD.Location = new System.Drawing.Point(645, 79);
            this.btBorrarD.Name = "btBorrarD";
            this.btBorrarD.Size = new System.Drawing.Size(75, 23);
            this.btBorrarD.TabIndex = 57;
            this.btBorrarD.Text = "Borrar";
            this.btBorrarD.UseVisualStyleBackColor = true;
            this.btBorrarD.Click += new System.EventHandler(this.btBorrarD_Click);
            // 
            // btAddD
            // 
            this.btAddD.Location = new System.Drawing.Point(645, 21);
            this.btAddD.Name = "btAddD";
            this.btAddD.Size = new System.Drawing.Size(75, 23);
            this.btAddD.TabIndex = 56;
            this.btAddD.Text = "Agregar";
            this.btAddD.UseVisualStyleBackColor = true;
            this.btAddD.Click += new System.EventHandler(this.btAddD_Click);
            // 
            // txtLegajoD
            // 
            this.txtLegajoD.Location = new System.Drawing.Point(493, 52);
            this.txtLegajoD.Name = "txtLegajoD";
            this.txtLegajoD.Size = new System.Drawing.Size(100, 20);
            this.txtLegajoD.TabIndex = 55;
            this.txtLegajoD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajoD_KeyPress);
            // 
            // txtDniD
            // 
            this.txtDniD.Location = new System.Drawing.Point(123, 46);
            this.txtDniD.MaxLength = 10;
            this.txtDniD.Name = "txtDniD";
            this.txtDniD.Size = new System.Drawing.Size(100, 20);
            this.txtDniD.TabIndex = 53;
            this.txtDniD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniD_KeyPress);
            // 
            // txtNombreD
            // 
            this.txtNombreD.Location = new System.Drawing.Point(123, 20);
            this.txtNombreD.Name = "txtNombreD";
            this.txtNombreD.Size = new System.Drawing.Size(100, 20);
            this.txtNombreD.TabIndex = 52;
            this.txtNombreD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreD_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVdocente);
            this.panel2.Location = new System.Drawing.Point(15, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 245);
            this.panel2.TabIndex = 45;
            // 
            // DGVdocente
            // 
            this.DGVdocente.AllowUserToAddRows = false;
            this.DGVdocente.AllowUserToResizeRows = false;
            this.DGVdocente.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGVdocente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVdocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVdocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVdocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVdocente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVdocente.Location = new System.Drawing.Point(0, 0);
            this.DGVdocente.Name = "DGVdocente";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVdocente.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVdocente.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVdocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVdocente.Size = new System.Drawing.Size(772, 245);
            this.DGVdocente.TabIndex = 0;
            this.DGVdocente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdocente_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 393);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDocente";
            this.Text = "frmDocete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVdocente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdFemD;
        private System.Windows.Forms.RadioButton rdMascD;
        private System.Windows.Forms.DateTimePicker dtpFechaD;
        private System.Windows.Forms.Button btBorrarD;
        private System.Windows.Forms.Button btAddD;
        private System.Windows.Forms.TextBox txtLegajoD;
        private System.Windows.Forms.TextBox txtDniD;
        private System.Windows.Forms.TextBox txtNombreD;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.RadioButton rdOtro;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}