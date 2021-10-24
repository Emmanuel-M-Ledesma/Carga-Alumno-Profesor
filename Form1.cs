using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Carga_Alumno_Profesor
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            
            DataTable carga = new DataTable();
            paChildform.Width = 0;
            paChildform.Height = 0;
            
        }

        private Form Activo = null;
        private void FormInicio_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(287, 72);
            MaximumSize = new Size(287, 72);
            Size = new Size(287, 72);
        }

        private void AbrirFormHijo(Form ChildForm)
        {
            if (Activo != null)
            {
                Activo.Close();
            }
            Activo = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            paChildform.Controls.Add(ChildForm);
            paChildform.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Planilla de alumnos";
            MinimumSize = new Size(816, 465);
            MaximumSize = new Size(816, 465);
            Size = new Size(816, 465);
            Tamaño();
            AbrirFormHijo(new frmAlumno());
            button1.Enabled = false;
            button2.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Planilla de docentes";
            MinimumSize = new Size(816, 465);
            MaximumSize = new Size(816, 465);
            Size = new Size(816, 465);
            Tamaño();
            AbrirFormHijo(new frmDocente());
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void Tamaño()
        {
            paChildform.Width = 799;
            paChildform.Height = 393;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MinimumSize = new Size(287, 72);
            MaximumSize = new Size(287, 72);
            Size = new Size(287, 72);
            Activo.Close();
            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
