using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;
using MapeoDeDatos;



namespace UNCDeporte
{
    public partial class Login : Form
    {
        String sql = "";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            sql="Select * from usuarios where usuario='" + txtUsuario.Text +"' and pass='"+ txtPass.Text+"'" ;
            DataSet ds = new DataSet();
            StringConexion c = new StringConexion();
                    
            SqlConnection cx = new SqlConnection();
            cx.ConnectionString = c.getCadena();
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "Usuarios");
            try
            {
                string test = ds.Tables[0].Rows[0][0].ToString();
                lblIncorrecto.Visible = false;
                global.usuario = txtUsuario.Text;
                global.id_usuario = int.Parse(test);
                MenuAdmin f2 = new MenuAdmin();
                f2.Show();
                txtUsuario.Text = "";
                txtPass.Text = "";

            }

            catch (Exception ex)
            {
                txtUsuario.Text = "";        
                txtPass.Text = "";
                lblIncorrecto.Visible = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
