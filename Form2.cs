using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocios;
using Entidad;



namespace Carga_Alumno_Profesor
{
    public partial class frmAlumno : Form
    {

        public Alumno objEntAlumno = new Alumno();
        public NegAlumnos objNegAlumno = new NegAlumnos();
      
        #region Constructor

        public frmAlumno()
        {
            InitializeComponent();
            DGValumno.ColumnCount = 7;
            DGValumno.Columns[0].HeaderText = "Nombre";
            DGValumno.Columns[1].HeaderText = "Dni";
            DGValumno.Columns[2].HeaderText = "Fecha de nacimiento";
            DGValumno.Columns[3].HeaderText = "Edad";
            DGValumno.Columns[4].HeaderText = "Sexo";
            DGValumno.Columns[5].HeaderText = "Legajo";
            DGValumno.Columns[6].HeaderText = "Carrera";

            DGValumno.Columns[0].Width = 200;
            DGValumno.Columns[1].Width = 60;
            DGValumno.Columns[2].Width = 75;
            DGValumno.Columns[3].Width = 40;
            DGValumno.Columns[4].Width = 65;
            DGValumno.Columns[5].Width = 80;
            DGValumno.Columns[6].Width = 200;

            cbCarreraA.Items.Add("Desarrollo de software");
            cbCarreraA.Items.Add("Enfermeria");
            cbCarreraA.Items.Add("Optica");
            cbCarreraA.Items.Add("Higiene y seguridad");
            FillDGV();
            btMod.Enabled = false;
            btBorrar.Enabled = false;
            //cargarDGV();
        }

        #endregion

        #region eventos

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "" || txtNombre.Text == "" || txtLegajo.Text == "" || cbCarreraA.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un alumno", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = objNegAlumno.abmAlumnos("Alta", objEntAlumno);
                if (nAdd == -1)
                {
                    MessageBox.Show("No pudo grabar el alumno en el sistema");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }

            }
        }
        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (DGValumno.Rows.Count.Equals(0))
            {
                MessageBox.Show("No se pueden borrar mas filas", "Error en la tabla");
            }
            else
            {

                int nDel = -1;
                DGVaObj();
                nDel = objNegAlumno.abmAlumnos("Baja", objEntAlumno);
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
            btAdd.Enabled = true;
            btMod.Enabled = false;
            btBorrar.Enabled = false;
            txtDni.Enabled = true;
        }

        private void btMod_Click(object sender, EventArgs e)
        {

            if (objEntAlumno.Nombre== "" )
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un alumno", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = objNegAlumno.abmAlumnos("Modificar", objEntAlumno);
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
            btAdd.Enabled = true;
            btBorrar.Enabled = false;
            txtDni.Enabled = true;
        }

        private void DGValumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDni.Enabled = false;
            int pos = DGValumno.CurrentRow.Index;
            if (DGValumno[1, pos].Value == null)
            {
                MessageBox.Show("La fila debe contener datos");
            }
            else
            {
                btAdd.Enabled = false;
                btMod.Enabled = true;
                btBorrar.Enabled = true;

                txtDni.Text = DGValumno[1, pos].Value.ToString();
                txtNombre.Text = DGValumno[0, pos].Value.ToString();
                dtpFecha.Value = System.Convert.ToDateTime(DGValumno[2, pos].Value);
                cbCarreraA.Text = DGValumno[6, pos].Value.ToString();
                txtLegajo.Text = DGValumno[5, pos].Value.ToString();
                if (DGValumno[4, pos].Value.ToString() == "Masculino")
                {
                    rdMasc.Checked = true;
                }
                else if (DGValumno[4, pos].Value.ToString() == "Femenino")
                {
                    rdFem.Checked = true;
                }
                else
                {
                    rdOtro.Checked = true;
                }

            }
        }
        #endregion

        #region Metodos
        private char SexoA()
        {
            char SexoA = 'x';
            if (rdFem.Checked)
            {
                SexoA = 'F';
            }
            if (rdMasc.Checked)
            {
                SexoA = 'M';
            }
            if (rdOtro.Checked)
            {
                SexoA = 'O';
            }
            return SexoA;
        }
        private void FillDGV()
        {
            DGValumno.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegAlumno.listadoAlumnos("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr[4].ToString() == "M" )
                    {
                        dr[4] = "Masculino";
                    }
                    if (dr[4].ToString() == "F")
                    {
                        dr[4] = "Femenino";
                    }
                    if (dr[4].ToString() == "O")
                    {
                        dr[4] = "Otro";
                    }
                    DGValumno.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDateTime(dr[2]).ToShortDateString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),dr[6].ToString());
                    
                    
                }
                lblError.Text = "";
            }
            else
            {
                lblError.Text="No hay alumnos cargados en el sistema";
            }
        }

        private void TxtObj()
        {
            objEntAlumno.Nombre = txtNombre.Text;
            objEntAlumno.Dni = long.Parse(txtDni.Text);
            objEntAlumno.FechNac = dtpFecha.Value;
            objEntAlumno.Sexo = SexoA();
            objEntAlumno.Legajo = txtLegajo.Text;
            objEntAlumno.Carrera = cbCarreraA.Text;
            objEntAlumno.Edad(dtpFecha.Value.Year);
        }

        private void DGVaObj()
        {
            int pos = DGValumno.CurrentRow.Index;
            objEntAlumno.Dni =long.Parse( DGValumno[1,pos].Value.ToString());
            
        }
        
        private void Limpiar()
        {
            txtDni.Clear();
            txtLegajo.Clear();
            txtNombre.Clear();
            cbCarreraA.Text = "";
            dtpFecha.Text = "";

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                errorLeg.SetError(txtDni, "Solo se admiten numeros");
            }
            else
            {
                errorLeg.Clear();
            }
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorLeg.SetError(txtLegajo, "Solo se admiten numeros");
            }
            else
            {
                errorLeg.Clear();
            }
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorLeg.SetError(txtNombre, "No se admiten numeros");
            }
            else
            {
                errorLeg.Clear();
            }

        }

        private void cbCarreraA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorLeg.SetError(cbCarreraA, "No se admiten numeros");
            }
            else
            {
                errorLeg.Clear();
            }
        }

        #endregion


    }
}
