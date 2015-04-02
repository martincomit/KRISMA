using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace UNCDeporte.Admin
{
    public partial class NuevoPerfil : Form
    {
        public NuevoPerfil()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NuevoPerfil_Load(object sender, EventArgs e)
        {
            GestorPermiso gp = new GestorPermiso();
            dgPermisos.DataSource = gp.Consultar();
            dgPermisos.DataMember = "Permisos";
            dgPermisos.Columns[1].Visible = false;
            dgAgregados.Columns[1].Visible = false;
        }

        private void dgPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int filas = dgPermisos.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                dgPermisos.Rows[i].DefaultCellStyle.BackColor = Color.White;

            }
            dgPermisos.CurrentRow.DefaultCellStyle.BackColor = Color.Aqua;

            //reviso todas las filas y las pinto de blanco para resetear, pq si solo pongo el color no se borran
            //luego al final pinto la seleccionada.

            btnAgregar.Enabled = true;
            int id_permiso = 1;
            int nombre = 2;
            int descripcion = 3;
            global.id_permiso = int.Parse(dgPermisos.Rows[e.RowIndex].Cells[id_permiso].Value.ToString());
            global.nombre = dgPermisos.Rows[e.RowIndex].Cells[nombre].Value.ToString();
            global.descripcion = dgPermisos.Rows[e.RowIndex].Cells[descripcion].Value.ToString();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                dgAgregados.Rows.Add("", global.id_permiso, global.nombre, global.descripcion);

                dgPermisos.Rows.RemoveAt(dgPermisos.CurrentRow.Index);
            }
            catch (Exception ex) { }
        }

        private void dgAgregados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int filas = dgAgregados.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                dgAgregados.Rows[i].DefaultCellStyle.BackColor = Color.White;

            }
            dgAgregados.CurrentRow.DefaultCellStyle.BackColor = Color.Aqua;

            //reviso todas las filas y las pinto de blanco para resetear, pq si solo pongo el color no se borran
            //luego al final pinto la seleccionada.

            //int id_permiso = 1;
            //int nombre = 2;
            //int descripcion = 3;
            //global.id_permiso = int.Parse(dgPermisos.Rows[e.RowIndex].Cells[id_permiso].Value.ToString());
            //global.nombre = dgPermisos.Rows[e.RowIndex].Cells[nombre].Value.ToString();
            //global.descripcion = dgPermisos.Rows[e.RowIndex].Cells[descripcion].Value.ToString();


            btnAgregar.Enabled = false;
            btnQuitar.Enabled = true;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            dgAgregados.Rows.RemoveAt(dgAgregados.CurrentRow.Index);
            GestorPermiso gp = new GestorPermiso();
            dgPermisos.DataSource = gp.Consultar();
            dgPermisos.DataMember = "Permisos";
            dgPermisos.Columns[1].Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string guardado;




            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
                return;
            }



            int filas = dgAgregados.Rows.Count;
            int id;
            int[] id_permisos = new int[20]; //ver como hacer vector dinamico de permisos
            for (int i = 0; i < filas; i++)
            {
                id = int.Parse(dgAgregados.Rows[i].Cells[1].Value.ToString());
                id_permisos[i] = id;
            }



            GestorPerfil gp = new GestorPerfil();

            guardado = gp.Registrar(txtNombre.Text, txtDescripcion.Text);



            if (guardado == "Guardado")
            {
                lblGuardado.Visible = true;

                int id_perfil = gp.ObtenerUltimoID(txtNombre.Text);

                for (int i = 0; i < filas; i++)
                {
                    gp.RegistrarIds(id_perfil, id_permisos[i]);
                }

                lblGuardado.Text = "Guardado Correctamente: " + txtNombre.Text;

                limpiar();



                return;
            }

            if (guardado == "Existe")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, ya existe: " + txtNombre.Text;
                limpiar();
                return;
            }

            if (guardado == "Error al Guardar")
            {
                lblGuardado.Visible = true;
                lblGuardado.Text = "No Guardado, error de escritura";
                limpiar();
                return;
            }

            



        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        private void limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            int filas = dgAgregados.Rows.Count;

            dgAgregados.Rows.Clear();


            GestorPermiso gp = new GestorPermiso();
            dgPermisos.DataSource = gp.Consultar();
            dgPermisos.DataMember = "Permisos";
            dgPermisos.Columns[1].Visible = false;
            dgAgregados.Columns[1].Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();

        }



    }
}