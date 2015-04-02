using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UNCDeporte.Interfaz.Admin
{
    public partial class AltaProfesor : Form
    {

        String sql = "";
        String nombre = "";
        String nombre2 = "";
        String apellido = "";
        String fec_nac = "";
        String email = "";
        int id_localidad;

     
        int id_deporte;

        int dni;
        int tel;


        public AltaProfesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            nombre2 = txtNombre2.Text;
            apellido = txtApellido.Text;
            fec_nac = txtFechaNacimiento.Text;
            email = txtEmail.Text;
            id_localidad = Int32.Parse(cmbLocalidades.SelectedValue.ToString());
            id_deporte = Int32.Parse(cmbDeporte.SelectedValue.ToString());
            
            
            if(txtDNI.Text != "") 
            dni = Int32.Parse(txtDNI.Text);

            if(txtTel.Text != "") 
            tel = Int32.Parse(txtTel.Text); ;
  



            sql = "INSERT INTO Profesores (dni, tel, nombre, nombre2, apellido, fec_nac, email, id_localidad, id_deporte) VALUES ('"+ dni + "','"+ tel +"','" + nombre + "','" + nombre2 + "','" + apellido + "','" + fec_nac + "','" + email + "','"+ id_localidad + "','" + id_deporte + "' )";
            DataSet ds = new DataSet();
            SqlConnection cx = new SqlConnection();

            conexion c = new conexion();

            //cx.ConnectionString = c.getCadena();

            SqlDataAdapter da = new SqlDataAdapter(sql, cx);

            da.Fill(ds, "profesores");

            lblGuardado.Visible = true;
        }

        private void AltaProfesor_Load(object sender, EventArgs e)
        {

            sql = "Select * from localidades";
            DataSet ds = new DataSet();
            SqlConnection cx = new SqlConnection();

            conexion c = new conexion();

            //cx.ConnectionString = c.getCadena();

            SqlDataAdapter da = new SqlDataAdapter(sql, cx);

            da.Fill(ds, "localidades");

            cmbLocalidades.DataSource = ds.Tables[0].DefaultView;
            cmbLocalidades.DisplayMember ="nombre";
            cmbLocalidades.ValueMember = "id_localidad";

           // -----------------------------------------

            sql = "Select * from deportes";
            DataSet ds2 = new DataSet();

            SqlDataAdapter da2 = new SqlDataAdapter(sql, cx);

            da2.Fill(ds2, "deportes");

            cmbDeporte.DataSource = ds2.Tables[0].DefaultView;
            cmbDeporte.DisplayMember = "nombre";
            cmbDeporte.ValueMember = "id_deporte";

      

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            return;
        }

      

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            id_deporte = Int32.Parse(cmbDeporte.SelectedValue.ToString());

            sql = "Select * from CategoriasDeporte where id_deporte="+ id_deporte+"";
            DataSet ds4 = new DataSet();
      
            SqlConnection cx = new SqlConnection();
            conexion c = new conexion();

            //cx.ConnectionString = c.getCadena();
            SqlDataAdapter da4 = new SqlDataAdapter(sql, cx);

            da4.Fill(ds4, "CategoriasDeporte");

            cmbCategoriaDeporte.DataSource = ds4.Tables[0].DefaultView;
            cmbCategoriaDeporte.DisplayMember = "nombre";
            cmbCategoriaDeporte.ValueMember = "id_categoriaDeporte";


        }

        private void cmbDeporte_SelectedValueChanged(object sender, EventArgs e)
        {
            //if(cmbDeporte.SelectedValue.ToString()!=
            //MessageBox.Show(cmbDeporte.SelectedValue.ToString());


        }

        private void cmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeporte.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                //MessageBox.Show(cmbDeporte.SelectedValue.ToString());
                id_deporte = Int32.Parse(cmbDeporte.SelectedValue.ToString());

                sql = "Select * from CategoriasDeporte where id_deporte=" + id_deporte + "";
                DataSet ds4 = new DataSet();

                SqlConnection cx = new SqlConnection();
                conexion c = new conexion();

                //cx.ConnectionString = c.getCadena();
                SqlDataAdapter da4 = new SqlDataAdapter(sql, cx);

                da4.Fill(ds4, "CategoriasDeporte");

                cmbCategoriaDeporte.DataSource = ds4.Tables[0].DefaultView;
                cmbCategoriaDeporte.DisplayMember = "nombre";
                cmbCategoriaDeporte.ValueMember = "id_categoriaDeporte";

            }
        }

   

       
    }
}
