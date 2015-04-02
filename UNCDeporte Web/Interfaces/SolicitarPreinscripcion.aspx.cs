using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Logica;
using Entidades;


public partial class Web_Carnet : System.Web.UI.Page
{
    String con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    Boolean particular = false;
    int caract_fijo = 0;
    int tel_fijo = 0;

    int caract_cel = 0;
    int tel_cel = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CargarDeportes("recreativo");
            cargarUnidadesAcademicas();
            cargarLocalidades();
            cargarCondiciones();
          
        }
    }

    

    protected void txtEnviar_Click(object sender, EventArgs e)
    {
        global.sesion = false;
        string guardado;
        char sexo;
        Boolean becado;
        GestorDeportista gd = new GestorDeportista();
        int documento = int.Parse(txtDocumento.Text);
        string apellido = txtApellido.Text;
        string nombres = txtNombres.Text;
        string email= txtEmail.Text;
        int id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
        
        int id_barrio = int.Parse(cmbBarrios.SelectedValue.ToString());
        int id_condicion = int.Parse(cmbCondiciones.SelectedValue.ToString());
        int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
        int id_escuela=0;
        int id_unidad=0;

        if (particular == false)
        {
             id_unidad = int.Parse(cmbUnidad.SelectedValue.ToString());
             if (cmbEscuela.SelectedValue.ToString() != "")
             {
                 id_escuela = int.Parse(cmbEscuela.SelectedValue.ToString());
                 
             }
        }

      

        //radio Sexo
        if (rbMasc.Checked == true)
            sexo = 'M';
        else
            sexo = 'F';


        //radio Becado
        if (rbSIBeca.Checked == true)
            becado = true;
        else
            becado = false;

        ////radio Condición
        //if (rbEstudiante.Checked == true)
        //    condicion = "Estudiante";

        if (txtCaractFijo.Text == "")
            txtCaractFijo.Text = "0";
        if (txtCaractCel.Text == "")
            txtCaractCel.Text = "0";
        if (txtCel.Text == "")
            txtCel.Text = "0";
        if (txtFijo.Text == "")
            txtFijo.Text = "0";

        try
        {
            caract_fijo = int.Parse(txtCaractFijo.Text);
            tel_fijo = int.Parse(txtFijo.Text);

            caract_cel = int.Parse(txtCaractCel.Text);
            tel_cel = int.Parse(txtCel.Text);
        }
        catch (Exception ex) { }

        DateTime fecha_Nac = Convert.ToDateTime(txtFecNac.Text);
        string direccion = txtDireccion.Text;


        //int id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
        guardado = gd.Registrar(documento, fecha_Nac, apellido, nombres, sexo,caract_fijo, tel_fijo, caract_cel, tel_cel, email, becado, direccion, id_localidad, id_barrio, id_condicion, id_deporte, id_unidad, id_escuela);
     




          if (guardado == "Guardado")
            {
               lblSolicitud.Visible = true;
               lblSolicitud.Text = "Guardado Correctamente Documento: " + txtDocumento.Text;
               Session["Documento"] = txtDocumento.Text;
               borrarTodo();

                return;
            }
           
            if(guardado=="Existe"){
                lblSolicitud.Visible = true;
                lblSolicitud.Text = "No Guardado, ya existe Documento o Email registrado";
               
                return;
            }
            
             if(guardado=="Error al Guardar")
             {
                lblSolicitud.Visible = true;
                lblSolicitud.Text = "No Guardado, error de escritura";
                
                return;
             }



        //lblSolicitud.Text = "Su solicitud ha sido enviada";

        borrarTodo();


    }


    public void borrarTodo()
    {
        txtDocumento.Text = "";
        txtEmail.Text = "";
        Response.Redirect("SolicitudEnviada.aspx");

    }


    public void CargarDeportes(string tipo)
    {
        string sql = "";
        DataSet ds = new DataSet();
        sql = "select * from deportes where tipo = '"+ tipo +"'";
        SqlConnection cx = new SqlConnection(con);
        SqlDataAdapter da = new SqlDataAdapter(sql, cx);
        da.Fill(ds, "Deportes");
        cmbDeportes.DataSource = ds;
        cmbDeportes.DataTextField = "nombre";
        cmbDeportes.DataValueField = "id_deporte";
        cmbDeportes.DataBind();

    }

    public void cargarLocalidades()
    {
        

        GestorLocalidad gl = new GestorLocalidad();
        cmbLocalidades.DataSource = gl.Consultar().Tables[0];
        cmbLocalidades.DataTextField = "Nombre";
        cmbLocalidades.DataValueField = "id_localidad";
        cmbLocalidades.DataBind();

        global.id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
        LLenarComboBarrioDeLocalidad();


    }

    public void LLenarComboBarrioDeLocalidad()
    {

        GestorBarrio gb = new GestorBarrio();
        cmbBarrios.DataSource = gb.Consultar(global.id_localidad).Tables[0]; //.tables[0] pq sino no trae el nombre
        cmbBarrios.DataValueField = "id_barrio";
        cmbBarrios.DataTextField = "nombre";
        cmbBarrios.DataBind();
      

    }

    public void cargarCondiciones()
    {

        GestorCondicion gc = new GestorCondicion();
        cmbCondiciones.DataSource = gc.Consultar().Tables[0]; //.tables[0] pq sino no trae el nombre
        cmbCondiciones.DataValueField = "id_condicion";
        cmbCondiciones.DataTextField = "nombre";
        cmbCondiciones.DataBind();


    }

    public void LLenarComboEscuelaDeUnidad()
    {

        GestorEscuela ge = new GestorEscuela();
        cmbEscuela.DataSource = ge.Consultar(global.id_unidad).Tables[0]; //.tables[0] pq sino no trae el nombre
        cmbEscuela.DataValueField = "id_unidad"; //cambiar por id_escuela
        cmbEscuela.DataTextField = "nombre";
        cmbEscuela.DataBind();

       
      
    }





    public void cargarUnidadesAcademicas()
    {
        string sql = "";
        DataSet ds = new DataSet();
        sql = "select * from unidadesAcademicas";
        SqlConnection cx = new SqlConnection(con);
        SqlDataAdapter da = new SqlDataAdapter(sql, cx);
        da.Fill(ds, "unidadesAcademicas");
        cmbUnidad.DataSource = ds;
        cmbUnidad.DataTextField = "nombre";
        cmbUnidad.DataValueField = "id_unidad";
        cmbUnidad.DataBind();


      
          
     

       
            


    }

    protected void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (Page.IsPostBack)
        //{
        global.id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
        LLenarComboBarrioDeLocalidad(); //para que ande, se pone propiedad appenddataboundsitems en true, para no perder el dato enlazado del control, ya q lo trae pero no lo guarda si hace el postback
        //
        //}
    }
    protected void cmbLocalidades_TextChanged(object sender, EventArgs e)
    {
        //if (Page.IsPostBack)
        //{
        //global.id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
        //LLenarComboBarrioDeLocalidad();

        //}
    }
    protected void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
    {
        global.id_unidad = int.Parse(cmbUnidad.SelectedValue.ToString());
        LLenarComboEscuelaDeUnidad(); //para que ande, se pone propiedad appenddataboundsitems en true, para no perder el dato enlazado del control, ya q lo trae pero no lo guarda si hace el postback
    }
    protected void cmbUnidad_TextChanged(object sender, EventArgs e)
    {
        //global.id_unidad = int.Parse(cmbUnidad.SelectedValue.ToString());
        //LLenarComboEscuelaDeUnidad(); //para que ande, se pone propiedad appenddataboundsitems en true, para no perder el dato enlazado del control, ya q lo trae pero no lo guarda si hace el postback
    }
    protected void F_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void cmbCondiciones_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id_condicion = int.Parse(cmbCondiciones.SelectedValue.ToString());
        if (id_condicion !=2 ) //2 particular
        {
            cmbUnidad.Enabled = true;
            cmbEscuela.Enabled = true;
            particular = false;
            rbNOBeca.Enabled = true;
            rbSIBeca.Enabled = true;
        }
        else
        {
            cmbUnidad.Enabled = false;
            cmbEscuela.Enabled = false;
            particular = true;
            rbNOBeca.Enabled = false;
            rbSIBeca.Enabled = false;
        }
    }
    protected void cmbCondiciones_TextChanged(object sender, EventArgs e)
    {
     
    }
    protected void btnExaminar_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        lblHorario.Text = "";
        lblHorario.Visible = true;
       

        GestorPrograma gp = new GestorPrograma();
        int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
        int cantidad_filas = gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows.Count;
        for (int i = 0; i < cantidad_filas; i++)
        {
            lblHorario.Text = lblHorario.Text + " " + gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][0].ToString() + " " + gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][1].ToString() + " " + gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][2].ToString() + "\t";
            lblSectores.Visible = true;
            lblSectores.Text = gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][3].ToString() + " " + gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][4].ToString() + " " + gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][5].ToString();
        }
    }
    protected void rbFederado_Click(object sender, EventArgs e)
    {
     
    }
    protected void rbFederado_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbTipo.Text == "Recreativo")
        {
            CargarDeportes("recreativo"); //para que ande, se pone propiedad appenddataboundsitems en true, para no perder el dato enlazado del control, ya q lo trae pero no lo guarda si hace el postback
        }
        else
        {
            CargarDeportes("federado"); 
        }
    }
    protected void txtApellido_TextChanged(object sender, EventArgs e)
    {
      
    }
}