using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Logica;

namespace UNCDeporte.Interfaz.Admin
{
    public partial class AltaDeportista : Form
    {
        string sql = "";
        string nombre = "";
        string nombre2 = "";
        string apellido = "";
        string fec_nac = "";
        string email = "";
        int id_deporte=0;

        public AltaDeportista()
        {
            InitializeComponent();
        }

        public void LLenarComboLocalidad()
        {

            GestorLocalidad gl = new GestorLocalidad();
            cmbLocalidades.DataSource = gl.Consultar().Tables[0];
            cmbLocalidades.DisplayMember = "Nombre";
            cmbLocalidades.ValueMember = "id_localidad";
            cmbLocalidades.SelectedIndex = 0;
        }

        public void LLenarDeportes()
        {
            /*
            sql = "Select * from deportes";
            DataSet ds = new DataSet();
            SqlConnection cx = new SqlConnection();

            conexion c = new conexion();

            cx.ConnectionString = c.getCadena();

            SqlDataAdapter da = new SqlDataAdapter(sql, cx);

            da.Fill(ds, "deportes");

            cmbDeporte.DataSource = ds.Tables[0].DefaultView;
            cmbDeporte.DisplayMember = "nombre";
            cmbDeporte.ValueMember = "id_deporte";
             */ 
        }


        private void AltaDeportista_Load(object sender, EventArgs e)
        {
            /*
            
            LLenarDeportes();
             */
            LLenarComboLocalidad();
            llenarComboUnidadAcademica();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            nombre = txtNombre.Text;
            nombre2 = txtNombre2.Text;
            apellido = txtApellido.Text;
            fec_nac = txtFechaNacimiento.Text;
            email = txtEmail.Text;
            sql = "INSERT INTO Deportistas (nombre, nombre2, apellido, fec_nac, email) VALUES ('" + nombre + "','" + nombre2 + "','" + apellido + "','"+fec_nac+"','"+email+"'  )";
            DataSet ds = new DataSet();
            SqlConnection cx = new SqlConnection();

            conexion c = new conexion();

            cx.ConnectionString = c.getCadena();

            SqlDataAdapter da = new SqlDataAdapter(sql, cx);       

            da.Fill(ds, "deportistas");

            lblGuardado.Visible = true;
             */ 
        }

        private void btnNuevaLocalidad_Click(object sender, EventArgs e)
        {
            /*
            NuevaLocalidad form = new NuevaLocalidad();
            form.Show();
             */ 
        }

        public void llenarComboUnidadAcademica()
        {
            GestorUnidadAcademica gu = new GestorUnidadAcademica();
            cmbUnidadAcademica.DataSource = gu.Consultar().Tables[0];
            cmbUnidadAcademica.DisplayMember = "nombre";
            cmbUnidadAcademica.ValueMember = "id_unidad";
            cmbUnidadAcademica.SelectedIndex = 0;

        }

        private void cmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (cmbDeporte.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                //MessageBox.Show(cmbDeporte.SelectedValue.ToString());
                id_deporte = Int32.Parse(cmbDeporte.SelectedValue.ToString());

                sql = "Select * from CategoriasDeporte where id_deporte=" + id_deporte + "";
                DataSet ds4 = new DataSet();

                SqlConnection cx = new SqlConnection();
                conexion c = new conexion();

                cx.ConnectionString = c.getCadena();
                SqlDataAdapter da4 = new SqlDataAdapter(sql, cx);

                da4.Fill(ds4, "CategoriasDeporte");

                cmbCategoriaDeporte.DataSource = ds4.Tables[0].DefaultView;
                cmbCategoriaDeporte.DisplayMember = "nombre";
                cmbCategoriaDeporte.ValueMember = "id_categoriaDeporte";            
            }
             */
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
