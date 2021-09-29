using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidad;
using Negocios;


namespace Carga_Alumno_Profesor
{
    public partial class frmDocente : Form
    {
        #region Atributos


        public Docente ObjEntDocente = new Docente();
        public NegDocentes ObjNegDocentes = new NegDocentes();

        #endregion

        #region Constructor

        public frmDocente()
        {
            InitializeComponent();
            DGVdocente.ColumnCount = 7;
            DGVdocente.Columns[0].HeaderText = "Nombre";
            DGVdocente.Columns[1].HeaderText = "Dni";
            DGVdocente.Columns[2].HeaderText = "Fecha de nacimiento";
            DGVdocente.Columns[3].HeaderText = "Edad";
            DGVdocente.Columns[4].HeaderText = "Sexo";
            DGVdocente.Columns[5].HeaderText = "Legajo";
            DGVdocente.Columns[6].HeaderText = "Materia";


            DGVdocente.Columns[0].Width = 200;
            DGVdocente.Columns[1].Width = 60;
            DGVdocente.Columns[2].Width = 100;
            DGVdocente.Columns[3].Width = 30;
            DGVdocente.Columns[4].Width = 50;
            DGVdocente.Columns[5].Width = 80;
            DGVdocente.Columns[6].Width = 200;

            cbMateria.Items.Add("Programacion");
            cbMateria.Items.Add("Practica");
            cbMateria.Items.Add("Modelado de sistemas");
            cbMateria.Items.Add("Matematica");
            cbMateria.Items.Add("Base de datos");

            FillDGV();
            btBorrarD.Enabled = false;
            btMod.Enabled = false;
        }

        #endregion

        #region Eventos

        private void btAddD_Click(object sender, EventArgs e)
        {
            if (txtDniD.Text == "" || txtLegajoD.Text == "" || txtNombreD.Text == "" || cbMateria.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un docente", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = ObjNegDocentes.abmDocentes("Alta", ObjEntDocente);
                if (nAdd == -1)
                {
                    MessageBox.Show("No pudo grabar alumnos en el sistema");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }


                Limpiar();
            }

        }

        private void btBorrarD_Click(object sender, EventArgs e)
        {
            if (DGVdocente.Rows.Count.Equals(1))
            {
                MessageBox.Show("No se pueden borrar mas filas", "Error en la tabla");
            }
            else
            {
                int nDel = -1;
                DGVaObj();
                nDel = ObjNegDocentes.abmDocentes("Baja", ObjEntDocente);
                if (nDel == -1)
                {
                    MessageBox.Show("No se pudo borrar", "Error");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }
            }
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            if (ObjEntDocente.Dni == null)
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un alumno", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = ObjNegDocentes.abmDocentes("Modificar", ObjEntDocente);
                if (nAdd == -1)
                {
                    MessageBox.Show("No pudo grabar alumnos en el sistema");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }

            }
            btMod.Enabled = false;
            btAddD.Enabled = true;
            btBorrarD.Enabled = false;
        }

        private void DGVdocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = DGVdocente.CurrentRow.Index;
            if (lblError.Text != "")
            {
                MessageBox.Show("", "Error");
            }
            else
            { 
                btAddD.Enabled = false;
                btMod.Enabled = true;
                btBorrarD.Enabled = true;

                txtDniD.Text = DGVdocente[1, pos].Value.ToString();
                txtNombreD.Text = DGVdocente[0, pos].Value.ToString();
                dtpFechaD.Value = System.Convert.ToDateTime(DGVdocente[2, pos].Value);
                cbMateria.Text = DGVdocente[6, pos].Value.ToString();
                txtLegajoD.Text = DGVdocente[5, pos].Value.ToString();
                if (DGVdocente[4, pos].Value.ToString() == "M")
                {
                    rdMascD.Checked = true;
                }
                else if (DGVdocente[4, pos].Value.ToString() == "F")
                {
                    rdFemD.Checked = true;
                }
                else
                {
                    rdHelicoptero.Checked = true;
                }
                ObjEntDocente.DNI2 = long.Parse(DGVdocente[1, pos].Value.ToString());
            }
        }
        #endregion

        #region Metodos

        private string SexoA()
        {
            string SexoA = "No selecciono sexo";
            if (rdFemD.Checked)
            {
                SexoA = "F";
            }
            if (rdMascD.Checked)
            {
                SexoA = "M";
            }
            if (rdHelicoptero.Checked)
            {
                SexoA = "X";
            }
            return SexoA;
        }
        private void Limpiar()
        {
            txtDniD.Clear();
            txtLegajoD.Clear();
            txtNombreD.Clear();
            cbMateria.Text = "";
            dtpFechaD.Text = "";

        }
        private void txtDniD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FillDGV()
        {
            DGVdocente.Rows.Clear();
            DataSet ds = new DataSet();
            ds = ObjNegDocentes.listadoDocentes("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    DGVdocente.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDateTime(dr[2]).ToShortDateString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());


                }
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "No hay docentes cargados en el sistema";
            }
        }

        private void TxtObj()
        {
            ObjEntDocente.Nombre = txtNombreD.Text;
            ObjEntDocente.Dni = long.Parse(txtDniD.Text);
            ObjEntDocente.FechNac = dtpFechaD.Value;
            ObjEntDocente.Sexo = char.Parse(SexoA());
            ObjEntDocente.Legajo = txtLegajoD.Text;
            ObjEntDocente.Materia = cbMateria.Text;
            ObjEntDocente.Edad(dtpFechaD.Value.Year);
        }

        private void DGVaObj()
        {
            int pos = DGVdocente.CurrentRow.Index;
            ObjEntDocente.Dni = long.Parse(DGVdocente[1, pos].Value.ToString());

        }

        #endregion
    }
}
